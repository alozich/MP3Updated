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

//user is able to choose from a list of effects to apply to file

namespace MP3
{
    public partial class EffectForm : Form
    {
        readonly static Sox sox = new Sox("C:\\Program Files (x86)\\sox-14-4-1\\sox.exe");
        string fileName;
       
        public EffectForm(string f)
        {
            InitializeComponent();
            fileName = f;       //carried over from Form1
        }

        //effect options for user
        private void SetEffectForm()
        {
            int caseSwitch = effectPicker.SelectedIndex;

            switch(caseSwitch)
            {
                case 0:
                    sox.Effects.Add(new SoxSharp.Effects.BassEffect(50));
                    break;
                case 1:
                    sox.Effects.Add(new SoxSharp.Effects.TrebleEffect(50));
                    break;
                case 2:
                    sox.Effects.Add(new SoxSharp.Effects.ReverseEffect());
                    break;
                case 3:
                    sox.Effects.Add(new SoxSharp.Effects.SpeedEffect(1.5));
                    break;
                case 4:
                    sox.Effects.Add(new SoxSharp.Effects.TempoEffect(2));
                    break;
            }
        }

        private void effectPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEffectForm();
            
        }

        private void applyConfirmButt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string outputFile = saveFileDialog1.FileName;
            saveFileDialog1.Filter = "MP3|*.mp3";
            saveFileDialog1.FilterIndex = 1;
            sox.Process(fileName, outputFile);
            Close();
        }
    }
}
