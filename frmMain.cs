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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInputWohnenW frmInputWohnen = new FrmInputWohnenW();
            frmInputWohnen.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInputGewerbe frmInputGewerbe = new FrmInputGewerbe();
            frmInputGewerbe.ShowDialog();
        }
    }
}
