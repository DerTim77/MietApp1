using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MietApp1
{
    public partial class FrmInputGewerbe : Form
    {
        public FrmInputGewerbe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonHinzufügenG_Click(object sender, EventArgs e)
        {
            GewerbeImmobilie gewerbe = new GewerbeImmobilie();
            gewerbe.Strasse = textBoxStrasseG.Text;

        }
    }
}
