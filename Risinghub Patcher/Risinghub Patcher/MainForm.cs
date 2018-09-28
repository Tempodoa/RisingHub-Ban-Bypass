using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;


namespace Risinghub_Patcher
{
    public partial class MainForm : Form
    {
        private string DownloadsPath;
        private string DesktopPath;
        private Random random;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            DownloadsPath = KnownFolders.GetPath(KnownFolder.Downloads);
            DesktopPath = KnownFolders.GetPath(KnownFolder.Desktop);
            var DLFiles = Directory.GetFiles(DownloadsPath, "DarkLauncher.exe", SearchOption.AllDirectories);
            var DesktopFiles = Directory.GetFiles(DesktopPath, "DarkLauncher.exe", SearchOption.AllDirectories);
            string[] allFiles = DLFiles.Concat(DesktopFiles).ToArray();
            if (allFiles.Length == 0)
                DLPathBox.Text = "Browse and select DarkLauncher.exe";
            else
                DLPathBox.Text = allFiles[0];

            DestinationBox.Text = Path.Combine(DesktopPath, "DarkLauncher (Modified)");
        }

        private void browseDLPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = DownloadsPath;
                openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DLPathBox.Text = openFileDialog1.FileName;
                }
            }
        }

        private void chooseDestButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if(result== DialogResult.OK)
                {
                    DestinationBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(DestinationBox.Text))
                Directory.CreateDirectory(DestinationBox.Text);
            if (!File.Exists(DLPathBox.Text))
            {
                MessageBox.Show("Couldn't find specified DarkLauncher.exe");
                return;
            }
                
            var assembly = AssemblyDefinition.ReadAssembly(DLPathBox.Text);
            var programType = assembly.MainModule.Types.First(x => x.Name == "HWID");
            var mainMethod = programType.Methods.First(x => x.Name == "getHard");
            var FileReadMethod = typeof(File).GetMethod("ReadAllText", new Type[] { typeof(string) });
            var FileReadRef = assembly.MainModule.ImportReference(FileReadMethod);
            mainMethod.Body.Instructions.Insert(74, Instruction.Create(OpCodes.Ldstr, "hwid.txt"));
            mainMethod.Body.Instructions.Insert(75, Instruction.Create(OpCodes.Call, FileReadRef));
            mainMethod.Body.Instructions.RemoveAt(73);

            var FormClass = assembly.MainModule.Types.First(x => x.Name == "Form1");
            var StartMethod = FormClass.Methods.First(x => x.Name == "button1_Click");
            StartMethod.Body.Instructions.RemoveAt(126);
            StartMethod.Body.Instructions.RemoveAt(126);
            assembly.Write(Path.Combine(DestinationBox.Text, "DarkLauncher (Modified).exe"));
            File.WriteAllText(Path.Combine(DestinationBox.Text, "hwid.txt"),RandomString(30));

            MessageBox.Show("Sucessfully modified your DarkLauncher.\n\nIMPORTANT:\n1: Change the text inside hwid.txt after getting banned again.\n2: USE A MAC ADDRESS CHANGER (i.e. TMAC/MyMAC)");
        }

        private string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
