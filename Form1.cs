using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Game
{
    public partial class Form1 : Form
    {
        public int num;
        public int randomNum;
        public int clickCount = 0;
        public int Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9=9;
        public bool haveWon = false;
        public bool startPressed = false;
        public bool clearPressed = false;
        public int label1Pressed = 0;
        public int label2Pressed = 0;
        public int label3Pressed = 0;
        public int label4Pressed = 0;
        public int label5Pressed = 0;
        public int label6Pressed = 0;
        public int label7Pressed = 0;
        public int label8Pressed = 0;
        public int label9Pressed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Label1);
            label1Pressed++;
            clearPressed = false;

            if (label1Pressed == 1)
            {
                clickCount++;
            }
            if (Label1 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label1.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;
            }
            else if (Label1 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label1.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else if (startPressed != true)
            {
                label1.Text = "*";
                label11.Text = "Press CLEAR and START";
                label1.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label1.BackColor = Color.Red;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Label2);
            label2Pressed++;
            clearPressed = false;

            if (label2Pressed == 1)
            {
                clickCount++;
            }

            if (Label2 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label2.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label2 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label2.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else if (startPressed != true)
            {
                label2.Text = "*";
                label11.Text = "Press CLEAR and START";
                label2.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(Label3);
            label3Pressed++;
            clearPressed = false;

            if (label3Pressed == 1)
            {
                clickCount++;
            }

            if (Label3 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label3.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label3 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label3.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else if (startPressed != true)
            {
                label3.Text = "*";
                label11.Text = "Press CLEAR and START";
                label3.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label3.BackColor = Color.Red;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Label4);
            label4Pressed++;
            clearPressed = false;

            if (label4Pressed == 1)
            {
                clickCount++;
            }

            if (Label4 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label4.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label4 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label4.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else if (startPressed != true)
            {
                label4.Text = "*";
                label11.Text = "Press CLEAR and START";
                label4.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else
            {
                label4.BackColor = Color.Red;
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(Label5);
            label5Pressed++;
            clearPressed = false;

            if (label5Pressed == 1)
            {
                clickCount++;
            }

            if (Label5 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label5.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label5 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label5.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else if (startPressed != true)
            {
                label5.Text = "*";
                label11.Text = "Press CLEAR and START";
                label5.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label5.BackColor = Color.Red;
            }
        }

       
        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(Label6);
            label6Pressed++;
            clearPressed = false;

            if (label6Pressed == 1)
            {
                clickCount++;
            }

            if (Label6 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label6.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label6 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label6.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else if (startPressed != true)
            {
                label6.Text = "*";
                label11.Text = "Press CLEAR and START";
                label6.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label6.BackColor = Color.Red;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(Label7);
            label7Pressed++;
            clearPressed = false;

            if (label7Pressed == 1)
            {
                clickCount++;
            }

            if (Label7 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label7.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label7 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label7.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else if (startPressed != true)
            {
                label7.Text = "*";
                label11.Text = "Press CLEAR and START";
                label7.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else
            {
                label7.BackColor = Color.Red;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(Label8);
            label8Pressed++;
            clearPressed = false;

            if (label8Pressed == 1)
            {
                clickCount++;
            }

            if (Label8 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label8.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label8 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label8.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else if (startPressed != true)
            {
                label8.Text = "*";
                label11.Text = "Press CLEAR and START";
                label8.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else
            {
                label8.BackColor = Color.Red;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(Label9);
            label9Pressed++;
            clearPressed = false;

            if (label9Pressed == 1)
            {
                clickCount++;
            }
            if (Label9 == randomNum && clickCount <= 5 && startPressed == true)
            {
                label9.BackColor = Color.Green;
                label11.Text = "YOU WON!!";
                label11.ForeColor = Color.Green;
                haveWon = true;

            }
            else if (Label9 != randomNum && clickCount >= 5 && haveWon == false && startPressed == true)
            {
                label11.Text = "GAME OVER!!";
                label9.BackColor = Color.Red;
                label11.ForeColor = Color.Red;

            }
            else if (startPressed != true)
            {
                label9.Text = "*";
                label11.Text = "Press CLEAR and START";
                label9.BackColor = Color.Red;
                label11.ForeColor = Color.Red;
            }
            else
            {
                label9.BackColor = Color.Red;
            }
        }

        private void label10_Click(object sender, EventArgs e)//i guess this is unwanted...
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//start button
        {
            Work();
            haveWon = false;
           
            if(clearPressed == true)
            {
                startPressed = true;
                label10.Text = "Find the Box which has " + randomNum + " in it, in 5 attempts...You will Win!!";
            }
            else
            {
                startPressed=false;
                label11.Text = "Press CLEAR and START";
                label11.ForeColor = Color.Red;
            }

            label1Pressed = 0;
            label2Pressed = 0;
            label3Pressed = 0;
            label4Pressed = 0;
            label5Pressed = 0;
            label6Pressed = 0;
            label7Pressed = 0;
            label8Pressed = 0;
            label9Pressed = 0;

        }

        private void button2_Click(object sender, EventArgs e)//clear button
        {
            label11.Text = String.Empty;

            label1.BackColor = Color.White;
            label1.Text = String.Empty;

            label2.BackColor = Color.White;
            label2.Text = String.Empty;

            label3.BackColor = Color.White;
            label3.Text = String.Empty;

            label4.BackColor = Color.White;
            label4.Text = String.Empty;

            label5.BackColor = Color.White;
            label5.Text = String.Empty;

            label6.BackColor = Color.White;
            label6.Text = String.Empty;

            label7.BackColor = Color.White;
            label7.Text = String.Empty;

            label8.BackColor = Color.White;
            label8.Text = String.Empty;

            label9.BackColor = Color.White;
            label9.Text = String.Empty;

            label10.Text = String.Empty;

            clickCount = 0;

            haveWon = false;

            startPressed = false;

            clearPressed = true;

            label1Pressed = 0;
            label2Pressed = 0;
            label3Pressed = 0;
            label4Pressed = 0;
            label5Pressed = 0;
            label6Pressed = 0;
            label7Pressed = 0;
            label8Pressed = 0;
            label9Pressed = 0;
        }
        public void Work()
        {
            int j,k;
            int temp1,temp2;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random =new Random();
            Random random1 = new Random();

            for (int i = 8; i > 0; i--)
            {
                j = random.Next(0, 9);
                temp1 = array[i];
                array[i] = array[j];
                array[j]= temp1;
            }

            for (int l = 8; l > 0; l--)
            {
                k = random.Next(0, 9);
                temp2 = array[l];
                array[l] = array[k];
                array[k] = temp2;
            }

            Label1 = array[0];
            Label2 = array[1];
            Label3 = array[2];
            Label4 = array[3];
            Label5 = array[4];
            Label6 = array[5];
            Label7 = array[6];
            Label8 = array[7];
            Label9 = array[8];
            randomNum = random1.Next(1, 10);

        }
    }   
}
