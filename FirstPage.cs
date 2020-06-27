using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_Man
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            tbnPlay.Enabled = false;
        }
        /// <summary>
        /// seting play button to open the 2nd form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPLay_Click(object sender, EventArgs e)
        {
            if (RDEazy.Checked)
            {
                this.Hide();
                Form2  sp = new Form2(30);
                sp.ShowDialog();
            }
            else if (RDNormal.Checked)
            {
                this.Hide();
                Form2 sp = new Form2(20);
                sp.ShowDialog();
            }
            else if (RDHard.Checked)
            {
                this.Hide();
                Form2 sp = new Form2(10);
                sp.ShowDialog();
            }
        }
        /// <summary>
        /// seting the play button on when the user choose the difficult he\she want
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbnPlay.Enabled = true;
        }

    }
}
