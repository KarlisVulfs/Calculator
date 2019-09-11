using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string number1 = "";
        string operation = "";
        bool IsOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void numberClicked(int num)
        {
            if(IsOperationClicked == true)
            {
                textBox1.Text = "";
                IsOperationClicked = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + num;
            // textBox1.Text += num;

        }
        private void operationClicked(string op)
        {
            if(IsOperationClicked == true)
            {
                operation = op;
                //partrauc talako funkciju
                return;
            }
            //if (number1 == "")
            if(string.IsNullOrEmpty(number1))
            {
                number1 = textBox1.Text;
                operation = op;
            }
            else
            {
                equalsClicked();
            }
            IsOperationClicked = true;

        }
        private void clearClicked()
        {
            textBox1.Text = "0";
            number1 = "";
            operation = "";
            IsOperationClicked = false;
        }
        private void equalsClicked()
        {
            if(IsOperationClicked)
            {
                return;
            }
            int rezultats = 0;
            int sk1 = int.Parse(number1);
            int sk2 = int.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    rezultats = sk1 + sk2;
                    break;
                case "-":
                    rezultats = sk1 - sk2;
                    break;
                case "/":
                    rezultats = sk1 / sk2;
                    break;
                case "*":
                    rezultats = sk1 * sk2;
                    break;
            }
            textBox1.Text = rezultats.ToString();
            number1 = textBox1.Text;// saglaba atmina ka pirmo skailti
            IsOperationClicked = true;
        }        
            

        private void button1_Click(object sender, EventArgs e)//1
        {
            numberClicked(1);
            
        }

        private void button2_Click(object sender, EventArgs e)//2
        {
            numberClicked(2);
        }

        private void button3_Click(object sender, EventArgs e)//3
        {
            numberClicked(3);
        }

        private void button4_Click(object sender, EventArgs e)//4
        {
            numberClicked(4);
        }

        private void button5_Click(object sender, EventArgs e)//5
        {
            numberClicked(5);
        }

        private void button6_Click(object sender, EventArgs e)//6
        {
            numberClicked(6);
        }

        private void button7_Click(object sender, EventArgs e)//7
        {
            numberClicked(7);
        }

        private void button8_Click(object sender, EventArgs e)//8
        {
            numberClicked(8);
        }

        private void button9_Click(object sender, EventArgs e)//9
        {
            numberClicked(9);
        }

        private void buttonirvienads_Click(object sender, EventArgs e)//=
        {
            equalsClicked();
        }

        private void buttonsaskaiti_Click(object sender, EventArgs e)//+
        {
            operationClicked("+");
        }

        private void buttonatnem_Click(object sender, EventArgs e)//-
        {
            operationClicked("-");
        }

        private void buttonx_Click(object sender, EventArgs e)//x
        {
            operationClicked("*");
        }

        private void buttondali_Click(object sender, EventArgs e)// /
        {
            operationClicked("/");
        }

        private void buttonC_Click(object sender, EventArgs e)// C
        {
            clearClicked();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)//0
        {
            numberClicked(0);
        }
    }
}
