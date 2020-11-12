namespace MP3
{
    partial class EffectForm
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
            this.effectPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // effectPicker
            // 
            this.effectPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.effectPicker.FormattingEnabled = true;
            this.effectPicker.Items.AddRange(new object[] {
            "Bass Boost",
            "Treble Boost"});
            this.effectPicker.Location = new System.Drawing.Point(70, 72);
            this.effectPicker.Name = "effectPicker";
            this.effectPicker.Size = new System.Drawing.Size(121, 21);
            this.effectPicker.TabIndex = 0;
            this.effectPicker.SelectedIndexChanged += new System.EventHandler(this.effectPicker_SelectedIndexChanged);
            // 
            // EffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 336);
            this.Controls.Add(this.effectPicker);
            this.Name = "EffectForm";
            this.Text = "EffectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox effectPicker;
    }
}