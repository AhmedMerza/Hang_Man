using System;
//using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;

namespace Hang_Man
{
    public partial class Form2 : Form
    {
        private int score = 0; private int totalSec;

        private int difficult;

        private string word = "";

        private string[] words = { "Ahmed" , "Ali" , "Ebrahim", "Red", "Yellow", "Green", "Blue", "School", "University", "Bahrain", "Saudi", "Kuwait" };
        private string[] ind = { "Name", "Name", "Name", "Color", "Color", "Color", "Color", "Building", "Building", "Country" , "Country", "Country"};

        private Bitmap[] HgPic = {Hang_Man.Properties.Resources._4 ,
            Hang_Man.Properties.Resources._5 , Hang_Man.Properties.Resources._6 ,
            Hang_Man.Properties.Resources._7 ,
            Hang_Man.Properties.Resources._8 , Hang_Man.Properties.Resources._9 ,
            Hang_Man.Properties.Resources._10};

        private int WrongGuesses = 0;

        private bool won = false;

        public Form2()
        {
            InitializeComponent();
            play();
        }
        /// <summary>
        /// a method to open the form and 
        /// and set the timer
        /// </summary>
        /// <param name="diff"></param>
        public Form2(int diff)
        {
            InitializeComponent();
            play();
            TimeL.Text = diff.ToString();
            difficult = diff;
            if (diff==30)
            {
                totalSec = 30;
            }
            else if (diff==20){
                totalSec = 20;
            }
            else
            {
                totalSec = 10;
            }
        }

        private void play()
        {
            letused.Text = "";
            RandomWord();
        }
        private string copy;

        /// <summary>
        /// choose random word 
        /// </summary>
        private void RandomWord()
        {
            WrongGuesses = 0;
            //the txtbox
            theWord.ResetText();
            Random rnd = new Random();
            int index = rnd.Next(words.Length);
            word = words[index];
            typeL.Text = ind [index];
            for (int i = 0; i < word.Length; i++)
            {
                theWord.Text += "- ";
            }
            for (int i = 0; i < word.Length; i++)
            {
                copy += word.ElementAt(i) + " ";
            }
        }
        /// <summary>
        /// set the score
        /// </summary>
        /// <param name="Score"></param>
        public void setScore(int Score)
        {
            score = Score;
            score++;
            ScoreL.Text = "Score:" +score.ToString();
        }
        /// <summary>
        /// check the win
        /// </summary>
        /// <param name="win"></param>
        public void winCheck(bool win)
        {
            if (win)
            {
                timer1.Dispose();
                this.Hide();
                Frame3 frm3 = new Frame3(score, difficult);
                frm3.winlose("You have Won", "Continue");
                frm3.ShowDialog();
            }
            else
            {
                //timer1.Stop();
                timer1.Dispose();
                this.Hide();
                Frame3 frm3 = new Frame3();
                frm3.winlose("You have Lost", "try again" );
                frm3.ShowDialog();
            }
        }
        //private string copyWord = "";

        public void button_Click(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            choice.Visible = false;
            if (word.Contains(choice.Text)|| word.Contains(choice.Text.ToLower()))
            {
                char[] temp = copy.ToCharArray();
                char[] find = theWord.Text.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);

                for (int i = 0; i<theWord.Text.Length; i++)
                {
                    if (char.ToUpper(temp[i]) == guessChar)
                    {
                        if (i == 0)
                        {
                            find[i] = guessChar;
                        }
                        else
                        {
                            find[i] = char.ToLower(guessChar);
                        }
                        //copyWord = new string(find);
                        theWord.Text = new string(find);
                        if (copy.Equals(theWord.Text))//copyWord
                        {
                            won = true;
                            winCheck(won);
                        }
                    }
                }
            }
            else
            {
                WrongGuesses++;
            if (WrongGuesses < 6)
            {
                    HmP.Image = HgPic[WrongGuesses];
            }
            else 
            {
             HmP.Image = HgPic[WrongGuesses];
                MessageBox.Show("The man died", "Hang Man");
                winCheck(won);
            }
            }

            letused.Text += choice.Text+ " ";
        }

        private void theWord_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// set the timer in the label
        /// open frm3 when the time's up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (totalSec > 0)
            {
                totalSec--;
                TimeL.Text = totalSec.ToString();
            }
            else 
            {
                timer1.Stop();
                this.Hide();
                Frame3 frm3 = new Frame3();
                frm3.winlose("You have Lost", "try again");
                frm3.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
