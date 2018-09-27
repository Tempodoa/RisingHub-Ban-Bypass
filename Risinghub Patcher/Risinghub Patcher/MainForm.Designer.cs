namespace Risinghub_Patcher
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DLPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseDLPath = new System.Windows.Forms.Button();
            this.chooseDestButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.patchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DLPathBox
            // 
            this.DLPathBox.Location = new System.Drawing.Point(121, 12);
            this.DLPathBox.Name = "DLPathBox";
            this.DLPathBox.Size = new System.Drawing.Size(437, 20);
            this.DLPathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DarkLauncher Path:";
            // 
            // browseDLPath
            // 
            this.browseDLPath.Location = new System.Drawing.Point(564, 10);
            this.browseDLPath.Name = "browseDLPath";
            this.browseDLPath.Size = new System.Drawing.Size(75, 23);
            this.browseDLPath.TabIndex = 2;
            this.browseDLPath.Text = "Browse";
            this.browseDLPath.UseVisualStyleBackColor = true;
            this.browseDLPath.Click += new System.EventHandler(this.browseDLPath_Click);
            // 
            // chooseDestButton
            // 
            this.chooseDestButton.Location = new System.Drawing.Point(564, 36);
            this.chooseDestButton.Name = "chooseDestButton";
            this.chooseDestButton.Size = new System.Drawing.Size(75, 23);
            this.chooseDestButton.TabIndex = 5;
            this.chooseDestButton.Text = "Browse";
            this.chooseDestButton.UseVisualStyleBackColor = true;
            this.chooseDestButton.Click += new System.EventHandler(this.chooseDestButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Path:";
            // 
            // DestinationBox
            // 
            this.DestinationBox.Location = new System.Drawing.Point(121, 38);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(437, 20);
            this.DestinationBox.TabIndex = 3;
            // 
            // patchButton
            // 
            this.patchButton.Location = new System.Drawing.Point(215, 64);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(223, 42);
            this.patchButton.TabIndex = 6;
            this.patchButton.Text = "Patch";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 117);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.chooseDestButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestinationBox);
            this.Controls.Add(this.browseDLPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DLPathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RisingHub Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DLPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseDLPath;
        private System.Windows.Forms.Button chooseDestButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Button patchButton;
    }
}

