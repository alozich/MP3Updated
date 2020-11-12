using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3
{
    public partial class EffectForm : Form
    {
        public EffectForm()
        {
            InitializeComponent();
        }

        //private void SetEffectForm()
        //{
        //    var effect ;
        //    int index;
        //}



        private void effectPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var effect = effectPicker.SelectedItem;
        }
    }
}
