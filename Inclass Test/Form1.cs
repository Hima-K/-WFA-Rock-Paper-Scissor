using Inclass_Test.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass_Test
{
    public partial class Form1 : Form
    {
      
    
        public Form1()
        {
          
       
            InitializeComponent();
        }

        public string answer1,answer2;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
           
            
          
            int num=random.Next();

            if (num % 3 == 1)
            {
                label3.Text = "Rock";
                answer1 = label3.Text;
              pictureBox1.Image = Resources.Rock;
                

                timer.Start();
            }
            else if (num % 3 == 2)
            {
                label3.Text = "Paper";
                answer1 = label3.Text;
                pictureBox1.Image = Resources.Paper;
            }
            else if(num % 3 == 0)
            {
                label3.Text = "Scissor";
                answer1 = label3.Text;
                pictureBox1.Image = Resources.scissor;
            }
          
           

            if (answer1 == "Rock" && answer2 == "Paper")
            {
                label5.Text = "Player 1 is won";
            }

            else if (answer1 == "Rock" && answer2 == "Scissor")
            {

                label5.Text = "Player 1 is won";
            }

            else if (answer1 == "Paper" && answer2 == "Rock")
            {

                label5.Text = "Player 2 is won";
            }

            else if (answer1 == "Paper" && answer2 == "Scissor")
            {
                label5.Text = "Player 2 is won";
            }

            else if (answer1 == "Scissor" && answer2 == "Rock")
            {

                label5.Text = "Player 2 is won";
            }

            else if (answer1 == "Scissor" && answer2 == "Paper")
            {
                label5.Text = "Player 1 is won";
            }

            else if (answer1 == "Rock" && answer2 == "Rock")
            {
                label5.Text = "Game is draw";
            }

            else if (answer1 == "Paper" && answer2 == "Paper")
            {
                label5.Text = "Game is draw";
            }

            else if (answer1 == "Scissor" && answer2 == "Scissor")
            {
                label5.Text = "Game is draw";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
         


            int num = random.Next();

            if (num % 3 == 1)
            {
                label4.Text = "Rock";
                answer2 = label4.Text;
                pictureBox2.Image = Resources.Rock;
                pictureBox1.Visible = true;

                timer.Start();
            }
            else if (num % 3 == 2)
            {
                label4.Text = "Paper";
                answer2 = label4.Text;
                pictureBox2.Image = Resources.Paper;
            }
            else if (num % 3 == 0)
            {
                label4.Text = "Scissor";
                answer2 = label4.Text;
                pictureBox2.Image = Resources.scissor;
            }


            if (answer1 == "Rock" && answer2 == "Paper")
            {
                label5.Text = "Player 1 is won";
            }

            else if (answer1 == "Rock" && answer2 == "Scissor")
            {

                label5.Text = "Player 1 is won";
            }

            else if (answer1 == "Paper" && answer2 == "Rock")
            {

                label5.Text = "Player 2 is won";
            }

            else if (answer1 == "Paper" && answer2 == "Scissor")
            {
                label5.Text = "Player 2 is won";
            }

            else if (answer1 == "Scissor" && answer2 == "Rock")
            {

                label5.Text = "Player 2 is won";
            }

            else if (answer1 == "Scissor" && answer2 == "Paper")
            {
                label5.Text = "Player 1 is won";
            }

            else if (answer1 == "Rock" && answer2=="Rock")
            {
                label5.Text = "Game is draw";
            }

            else if (answer1 == "Paper" && answer2 == "Paper")
            {
                label5.Text = "Game is draw";
            }

            else if (answer1 == "Scissor" && answer2 == "Scissor")
            {
                label5.Text = "Game is draw";
            }





        }








    }

    
   
  
}
