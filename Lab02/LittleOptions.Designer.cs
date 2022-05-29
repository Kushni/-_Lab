
using System.Windows.Forms;

namespace DesktopApp
{
    partial class LittleOptions 
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButtonBinary = new System.Windows.Forms.RadioButton();
            this.radioButtonXml = new System.Windows.Forms.RadioButton();
            this.radioButtonJson = new System.Windows.Forms.RadioButton();
            this.LableFileType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Каскадне видалення";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButtonBinary
            // 
            this.radioButtonBinary.AutoSize = true;
            this.radioButtonBinary.Location = new System.Drawing.Point(32, 118);
            this.radioButtonBinary.Name = "radioButtonBinary";
            this.radioButtonBinary.Size = new System.Drawing.Size(128, 21);
            this.radioButtonBinary.TabIndex = 1;
            this.radioButtonBinary.TabStop = true;
            this.radioButtonBinary.Text = "Бінарний файл";
            this.radioButtonBinary.UseVisualStyleBackColor = true;
            this.radioButtonBinary.CheckedChanged += new System.EventHandler(this.radioButtonBinary_CheckedChanged);
            // 
            // radioButtonXml
            // 
            this.radioButtonXml.AutoSize = true;
            this.radioButtonXml.Location = new System.Drawing.Point(32, 145);
            this.radioButtonXml.Name = "radioButtonXml";
            this.radioButtonXml.Size = new System.Drawing.Size(57, 21);
            this.radioButtonXml.TabIndex = 2;
            this.radioButtonXml.TabStop = true;
            this.radioButtonXml.Text = "XML";
            this.radioButtonXml.UseVisualStyleBackColor = true;
            this.radioButtonXml.CheckedChanged += new System.EventHandler(this.radioButtonXml_CheckedChanged);
            // 
            // radioButtonJson
            // 
            this.radioButtonJson.AutoSize = true;
            this.radioButtonJson.Location = new System.Drawing.Point(32, 172);
            this.radioButtonJson.Name = "radioButtonJson";
            this.radioButtonJson.Size = new System.Drawing.Size(66, 21);
            this.radioButtonJson.TabIndex = 3;
            this.radioButtonJson.TabStop = true;
            this.radioButtonJson.Text = "JSON";
            this.radioButtonJson.UseVisualStyleBackColor = true;
            this.radioButtonJson.CheckedChanged += new System.EventHandler(this.radioButtonJson_CheckedChanged);
            // 
            // LableFileType
            // 
            this.LableFileType.AutoSize = true;
            this.LableFileType.Location = new System.Drawing.Point(29, 86);
            this.LableFileType.Name = "LableFileType";
            this.LableFileType.Size = new System.Drawing.Size(79, 17);
            this.LableFileType.TabIndex = 4;
            this.LableFileType.Text = "Тип файлу";
            // 
            // LittleOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 260);
            this.Controls.Add(this.LableFileType);
            this.Controls.Add(this.radioButtonJson);
            this.Controls.Add(this.radioButtonXml);
            this.Controls.Add(this.radioButtonBinary);
            this.Controls.Add(this.checkBox1);
            this.Name = "LittleOptions";
            this.Text = "LittleOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private RadioButton radioButtonBinary;
        private RadioButton radioButtonXml;
        private RadioButton radioButtonJson;
        private Label LableFileType;
    }
}