
namespace MP3
{
    partial class ConvertForm
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
            this.formatPicker = new System.Windows.Forms.ComboBox();
            this.convertApplyButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // formatPicker
            // 
            this.formatPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatPicker.FormattingEnabled = true;
            this.formatPicker.Items.AddRange(new object[] {
            "MP3",
            "WAV",
            "WAVPCM",
            "AIFF"});
            this.formatPicker.Location = new System.Drawing.Point(49, 51);
            this.formatPicker.Name = "formatPicker";
            this.formatPicker.Size = new System.Drawing.Size(121, 21);
            this.formatPicker.TabIndex = 0;
            this.formatPicker.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // convertApplyButton
            // 
            this.convertApplyButton.Location = new System.Drawing.Point(194, 198);
            this.convertApplyButton.Name = "convertApplyButton";
            this.convertApplyButton.Size = new System.Drawing.Size(75, 23);
            this.convertApplyButton.TabIndex = 1;
            this.convertApplyButton.Text = "Apply";
            this.convertApplyButton.UseVisualStyleBackColor = true;
            this.convertApplyButton.Click += new System.EventHandler(this.convertApplyButton_Click);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 233);
            this.Controls.Add(this.convertApplyButton);
            this.Controls.Add(this.formatPicker);
            this.Name = "ConvertForm";
            this.Text = "ConvertForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox formatPicker;
        private System.Windows.Forms.Button convertApplyButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}