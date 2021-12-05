using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_3_19_MalkovNV
{
    public partial class Menu : Form
    {
        Form1 frm1;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            DialogResult dr = frm1.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm1.Close();
            }
            else if (dr == DialogResult.OK)
            { 
                frm1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
