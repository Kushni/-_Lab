
namespace DesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLast = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaceFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToWord = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.allViewer1 = new UserInteface.AllViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnOptions,
            this.FileOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OnOptions
            // 
            this.OnOptions.Name = "OnOptions";
            this.OnOptions.Size = new System.Drawing.Size(75, 24);
            this.OnOptions.Text = "Options";
            this.OnOptions.Click += new System.EventHandler(this.OnOptions_Click);
            // 
            // FileOptions
            // 
            this.FileOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenLast,
            this.OpenFile,
            this.SaveFile,
            this.SaceFileAs,
            this.конвертуватиToolStripMenuItem});
            this.FileOptions.Name = "FileOptions";
            this.FileOptions.Size = new System.Drawing.Size(46, 24);
            this.FileOptions.Text = "File";
            // 
            // OpenLast
            // 
            this.OpenLast.Name = "OpenLast";
            this.OpenLast.Size = new System.Drawing.Size(193, 26);
            this.OpenLast.Text = "Open Last Save";
            this.OpenLast.Click += new System.EventHandler(this.OpenLast_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(193, 26);
            this.OpenFile.Text = "Open";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(193, 26);
            this.SaveFile.Text = "Save";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SaceFileAs
            // 
            this.SaceFileAs.Name = "SaceFileAs";
            this.SaceFileAs.Size = new System.Drawing.Size(193, 26);
            this.SaceFileAs.Text = "Save As";
            this.SaceFileAs.Click += new System.EventHandler(this.SaceFileAs_Click);
            // 
            // конвертуватиToolStripMenuItem
            // 
            this.конвертуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertToWord,
            this.ConvertToExcel});
            this.конвертуватиToolStripMenuItem.Name = "конвертуватиToolStripMenuItem";
            this.конвертуватиToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.конвертуватиToolStripMenuItem.Text = "Конвертувати";
            // 
            // ConvertToWord
            // 
            this.ConvertToWord.Name = "ConvertToWord";
            this.ConvertToWord.Size = new System.Drawing.Size(151, 26);
            this.ConvertToWord.Text = "До Word";
            this.ConvertToWord.Click += new System.EventHandler(this.ConvertToWord_Click);
            // 
            // ConvertToExcel
            // 
            this.ConvertToExcel.Name = "ConvertToExcel";
            this.ConvertToExcel.Size = new System.Drawing.Size(151, 26);
            this.ConvertToExcel.Text = "До Excel";
            this.ConvertToExcel.Click += new System.EventHandler(this.ConvertToExcel_Click);
            // 
            // allViewer1
            // 
            this.allViewer1.Location = new System.Drawing.Point(0, 38);
            this.allViewer1.Name = "allViewer1";
            this.allViewer1.Size = new System.Drawing.Size(1061, 500);
            this.allViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 546);
            this.Controls.Add(this.allViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserInteface.AllViewer allViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OnOptions;
        private System.Windows.Forms.ToolStripMenuItem FileOptions;
        private System.Windows.Forms.ToolStripMenuItem OpenLast;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem SaceFileAs;
        private System.Windows.Forms.ToolStripMenuItem конвертуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToWord;
        private System.Windows.Forms.ToolStripMenuItem ConvertToExcel;
    }
}

