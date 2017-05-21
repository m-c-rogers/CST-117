using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOneExerciseA
{
    public partial class Form1 : Form
    {
        Double userInput = 0;
        String operatorInput = "";
        bool operatorInputClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" | operatorInputClicked == true)
            {
                inputBox.Clear();
                operatorInputClicked = false;
            }
            inputBox.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputBox.Text += "0";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            inputBox.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputBox.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userInput = Double.Parse(inputBox.Text);
            inputBox.Clear();
            inputBox.Text = "+";
            operatorInput = "+";
            operatorInputClicked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userInput = Double.Parse(inputBox.Text);
            inputBox.Clear();
            inputBox.Text = "-";
            operatorInput = "-";
            operatorInputClicked = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            userInput = Double.Parse(inputBox.Text);
            inputBox.Clear();
            inputBox.Text = "*";
            operatorInput = "*";
            operatorInputClicked = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            userInput = Double.Parse(inputBox.Text);
            inputBox.Clear();
            inputBox.Text = "/";
            operatorInput = "/";
            operatorInputClicked = true;
        }


        private void button16_Click(object sender, EventArgs e)
        {
            switch (operatorInput)
            {
                case "+":
                    inputBox.Text = (userInput + Double.Parse(inputBox.Text)).ToString();
                    break;
                case "-":
                    inputBox.Text = (userInput - Double.Parse(inputBox.Text)).ToString();
                    break;
                case "*":
                    inputBox.Text = (userInput * Double.Parse(inputBox.Text)).ToString();
                    break;
                case "/":
                    inputBox.Text = (userInput / Double.Parse(inputBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
