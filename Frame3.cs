using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_Man
{
    public partial class Frame3 : Form
    {

        private int Score;

        private int totalSec;

        public Frame3()
        {
            InitializeComponent();
        }
        public Frame3(int Score, int diff)
        {
            InitializeComponent();
            this.Score = Score;
                if (diff==30)
            {
                RDEazy.Checked = true;
                totalSec = 30;
            }
            else if (diff==20)
            {
                RDNormal.Checked = true;
                totalSec = 20;
            }

            else
            {
                RDHard.Checked = true;
                totalSec = 10;
            }
        }
        public void winlose(string end , string con)
        {
            if (con.Equals("try again"))
            {
                DifficultL.Visible = false;
                RDNormal.Visible = false;
                RDHard.Visible = false;
                RDEazy.Visible = false;
            }
            WinLoseL.Text = end;
            btnContinue.Text = con;
            
        } 

    


        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btnContinue.Text.Equals("Continue"))
            {
                if (RDEazy.Checked)
                {
                    this.Hide();
                    Form2 frm = new Form2(30);
                    frm.setScore(Score);
                    frm.ShowDialog();
                }
                else if (RDNormal.Checked)
                {
                    this.Hide();
                    Form2 frm = new Form2(20);
                    frm.setScore(Score);
                    frm.ShowDialog();
                }
                else if (RDHard.Checked)
                {
                    this.Hide();
                    Form2 frm = new Form2(10);
                    frm.setScore(Score);
                    frm.ShowDialog();
                }
            }
            else
            {
                FirstPage frm = new FirstPage();
                frm.ShowDialog();
            }
            
        }

        private void WinLoseL_Click(object sender, EventArgs e)
        {

        }
    }
}
