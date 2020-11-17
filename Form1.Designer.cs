namespace MP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.audioInfoLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.applyEffectsButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // audioInfoLabel
            // 
            this.audioInfoLabel.AutoSize = true;
            this.audioInfoLabel.Location = new System.Drawing.Point(160, 274);
            this.audioInfoLabel.Name = "audioInfoLabel";
            this.audioInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.audioInfoLabel.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(163, 87);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(466, 171);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(685, 388);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 10;
            this.selectFileButton.Text = "Select File...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.GetFileFromUser);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(160, 9);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.fileNameLabel.TabIndex = 11;
            this.fileNameLabel.Text = "File Name";
            // 
            // applyEffectsButton
            // 
            this.applyEffectsButton.Location = new System.Drawing.Point(590, 388);
            this.applyEffectsButton.Name = "applyEffectsButton";
            this.applyEffectsButton.Size = new System.Drawing.Size(89, 23);
            this.applyEffectsButton.TabIndex = 12;
            this.applyEffectsButton.Text = "Apply Effects...";
            this.applyEffectsButton.UseVisualStyleBackColor = true;
            this.applyEffectsButton.Click += new System.EventHandler(this.ApplyEffect);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(509, 388);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 13;
            this.convertButton.Text = "Convert...";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ApplyConversion);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(506, 428);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(0, 13);
            this.notificationLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.applyEffectsButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.audioInfoLabel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "MP3";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label audioInfoLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button applyEffectsButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label notificationLabel;
    }
}

