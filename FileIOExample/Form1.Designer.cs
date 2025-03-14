namespace FileIOExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            txbOriginal = new TextBox();
            txbEncrypt = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            labOriginal = new Label();
            labEncrypt = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(549, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(134, 22);
            openFileToolStripMenuItem.Text = "Open File...";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(134, 22);
            saveFileToolStripMenuItem.Text = "Save File...";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // txbOriginal
            // 
            txbOriginal.Location = new Point(83, 72);
            txbOriginal.Multiline = true;
            txbOriginal.Name = "txbOriginal";
            txbOriginal.ReadOnly = true;
            txbOriginal.Size = new Size(131, 83);
            txbOriginal.TabIndex = 1;
            // 
            // txbEncrypt
            // 
            txbEncrypt.Location = new Point(327, 72);
            txbEncrypt.Multiline = true;
            txbEncrypt.Name = "txbEncrypt";
            txbEncrypt.ReadOnly = true;
            txbEncrypt.Size = new Size(131, 83);
            txbEncrypt.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(108, 200);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 23);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt ";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(355, 200);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 23);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // labOriginal
            // 
            labOriginal.AutoSize = true;
            labOriginal.Location = new Point(108, 41);
            labOriginal.Name = "labOriginal";
            labOriginal.Size = new Size(96, 15);
            labOriginal.TabIndex = 5;
            labOriginal.Text = "Original/Decrypt";
            // 
            // labEncrypt
            // 
            labEncrypt.AutoSize = true;
            labEncrypt.Location = new Point(367, 41);
            labEncrypt.Name = "labEncrypt";
            labEncrypt.Size = new Size(47, 15);
            labEncrypt.TabIndex = 6;
            labEncrypt.Text = "Encrypt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 266);
            Controls.Add(labEncrypt);
            Controls.Add(labOriginal);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txbEncrypt);
            Controls.Add(txbOriginal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private TextBox txbOriginal;
        private TextBox txbEncrypt;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label labOriginal;
        private Label labEncrypt;
    }
}
