using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SoxSharp;
using System.Media;
using System.Windows.Controls;
using System.Windows.Forms.Integration;

//needs SoX executable to run this program
//download SoX @ sox.sourceforge.net

namespace MP3
{
    public partial class Form1 : Form
    {
        readonly static Sox sox = new Sox("C:\\Program Files (x86)\\sox-14-4-1\\sox.exe");  //replace file location for wherever your SoX executable is
        string fileName;
        
        public Form1()
        {
            InitializeComponent();
        }

        //displays information on audio file
        //sample rate, # of channels, bit rate, size
        private void SetAudioInfo(string f)            
        {
            AudioInfo info = sox.GetInfo(f);
            audioInfoLabel.Text = info.ToString();
        }

        //when "Select File..." is pressed
        private void GetFileFromUser(object sender, EventArgs e)
        {
            fileName = SelectFileButton();
            if(string.IsNullOrEmpty(fileName))
            {
                notificationLabel.Text = "Please choose a file!";
                return;
            }
            axWindowsMediaPlayer1.URL = fileName;
            SetAudioInfo(fileName);
            
        }
        
        //user chooses file to play
        private string SelectFileButton()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            fileNameLabel.Text = fileName;
            notificationLabel.Text = "";

            return fileName;
        }

        private void SetEffectForm()
        {
            EffectForm effectForm = new EffectForm(fileName);
            effectForm.Show();

        }

        private void ApplyEffect(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                notificationLabel.Text = "Please choose a file!";
                return;
            }
            SetEffectForm();
        }

        private void SetConvertForm()
        {
            ConvertForm convertForm = new ConvertForm(fileName);
            convertForm.Show();
        }

        private void ApplyConversion(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(fileName))
            {
                notificationLabel.Text = "Please choose a file!";
                return;
            }
            SetConvertForm();
        }

    }
}
