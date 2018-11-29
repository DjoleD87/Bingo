using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    public partial class Form1 : Form
    {
        int counter = 212;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            newGameBtn.Visible = false;
            startPicture.Visible = false;
            timer2.Start();
            gameNumber.Visible = true;



        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
        }

        private void textBoxNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            bigNumberText.Text = "";
            textBoxNumber.Text = "";
            NewGameVisible();
            counter++;
            gameNumber.Text = counter.ToString();
            startBtn.Visible = true;
            button1.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Random myRnd = new Random();
            int rndNumber = myRnd.Next(1, 3);
            bigNumberText.Text = rndNumber.ToString();
            textBoxNumber.Text = textBoxNumber.Text + rndNumber.ToString() + "  ";

            if (rndNumber == 1)
            {
                pictureBox1.Visible = false;
            }
            else if (rndNumber == 2)
            {
                pictureBox2.Visible = false;
            }
            else if (rndNumber == 3)
            {
                pictureBox3.Visible = false;
            }
            else if (rndNumber == 4)
            {
                pictureBox4.Visible = false;
            }
            else if (rndNumber == 5)
            {
                pictureBox5.Visible = false;
            }
            else if (rndNumber == 6)
            {
                pictureBox6.Visible = false;
            }
            else if (rndNumber == 7)
            {
                pictureBox7.Visible = false;
            }
            else if (rndNumber == 8)
            {
                pictureBox8.Visible = false;
            }
            else if (rndNumber == 9)
            {
                pictureBox9.Visible = false;
            }
            else if (rndNumber == 10)
            {
                pictureBox10.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newGameBtn.Visible = true;
            bingoBtn.Visible = true;
            timer2.Stop();
            


        }
        private void NewGameVisible()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            startPicture.Visible = true;
            newGameBtn.Visible = false;
            bingoP.Visible = false;
            bingoBtn.Visible = false;
        }

        private void bingoBtn_Click(object sender, EventArgs e)
        {
            bingoP.Visible = true;
        }
    }
}
