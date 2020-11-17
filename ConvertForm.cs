using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoxSharp;

namespace MP3
{
    public partial class ConvertForm : Form
    {
        readonly static Sox sox = new Sox("C:\\Program Files (x86)\\sox-14-4-1\\sox.exe");
        string fileName;
        string outputFile;

        public ConvertForm(string f)
        {
            InitializeComponent();
            fileName = f;   //carried over from Form1
        }

        private void SetConversion()
        {
            int caseSwitch = formatPicker.SelectedIndex;

            switch (caseSwitch)
            {
                case 0:
                    sox.Output.Type = FileType.MP3;
                    saveFileDialog1.Filter = "MP3|*.mp3";
                    saveFileDialog1.FilterIndex = 1;
                    break;
                case 1:
                    sox.Output.Type = FileType.WAV;
                    saveFileDialog1.Filter = "WAV|*.wav";
                    saveFileDialog1.FilterIndex = 1;
                    break;
                case 2:
                    sox.Output.Type = FileType.WAVPCM;
                    saveFileDialog1.Filter = "WAVPCM|*.wavpcm";
                    saveFileDialog1.FilterIndex = 1;
                    break;
                case 3:
                    sox.Output.Type = FileType.AIFF;
                    saveFileDialog1.Filter = "AIFF|*.aiff";
                    saveFileDialog1.FilterIndex = 1;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConversion();
        }

        private void convertApplyButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            outputFile = saveFileDialog1.FileName;
            sox.Process(fileName, outputFile);
            Close();
        }
    }
}
