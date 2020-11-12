using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using SoxSharp;
using System.Media;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.IO;
using Accord.Controls;
using Accord.Audio;
using Accord.DirectSound;
using Accord.Audio.Formats;

namespace MP3
{
    public partial class Form1 : Form
    {
        readonly static Sox sox = new Sox("C:\\Program Files (x86)\\sox-14-4-1\\sox.exe");
        EffectForm effectForm = new EffectForm();
        Signal signal;
        
        
        public Form1()
        {
            InitializeComponent();
            //var bassEffect = new SoxSharp.Effects.BassEffect(50);
            //var trebleEffect = new SoxSharp.Effects.TrebleEffect(50);
            //var contrastEffect = new SoxSharp.Effects.ContrastEffect(50);
            //var reverseEffect = new SoxSharp.Effects.ReverseEffect();
            //sox.Effects.Add(bassEffect);
            //sox.Effects.Add(trebleEffect);
            //sox.Effects.Add(contrastEffect);
            //sox.Effects.Add(reverseEffect);
            //sox.Process("C:\\Users\\alozi\\Desktop\\CSCI 225\\MP3\\Gypsy.mp3", "C:\\Users\\alozi\\Desktop\\GYPSYBASS.mp3");
        }

        private void SetAudioInfo(string f)
        {
            AudioInfo info = sox.GetInfo(f);
            audioInfoLabel.Text = info.ToString();
        }

        private void GetFileFromUser(object sender, EventArgs e)
        {
            string file = SelectFileButton();
            axWindowsMediaPlayer1.URL = file;
            SetAudioInfo(file);
            //wavechart1.UpdateWaveform("Wave", signal.ToFloat());
            
        }

        private string SelectFileButton()
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            fileNameLabel.Text = fileName;
            //sox.Process(fileName, "awesomesauce.wav");
            //WaveDecoder waveDecoder = new WaveDecoder("awesomesauce.wav");
            //signal = waveDecoder.Decode();

            return fileName;
        }

        private void SetEffectForm()
        {
            effectForm.Show();
            


        }

        private void ApplyEffect(object sender, EventArgs e)
        {
            SetEffectForm();

            using (Sox sox = new Sox("C:\\Program Files (x86)\\sox-14-4-1\\sox.exe"))
            {
                SoxSharp.Effects.BassEffect bass;
                sox.Effects.Add(new SoxSharp.Effects.BassEffect(5));
            }

        }

    }
}
