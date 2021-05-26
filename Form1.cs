using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void functieOperatie(String op, TextBox rezultat)
        {
            String[] rezultatArray = rezultat.Text.Trim().Split(" ");
            op = op.Trim();
            if (rezultatArray.Length == 1)
            {
                rezultat.Text += " " + op + " ";
            }
            else if (rezultatArray.Length == 3)
            {
                String operatie = rezultatArray[1];
                double firstNumber = double.Parse(rezultatArray[0]);
                double secondNumber = double.Parse(rezultatArray[2]);
                rezultat.Text = operatie switch
                {
                    "+" => Convert.ToString(firstNumber + secondNumber) + " " + op + " ",
                    "-" => Convert.ToString(firstNumber - secondNumber) + " " + op + " ",
                    "/" => Convert.ToString(firstNumber / secondNumber) + " " + op + " ",
                    "*" => Convert.ToString(firstNumber * secondNumber) + " " + op + " ",
                    _ => "eroare"
                };
            }
        }

        private void tastaCifra(TextBox rezultat, String cifra)
        {
            rezultat.Text = (rezultat.Text.StartsWith('0') && !rezultat.Text.Contains('.')) ? cifra.Trim() : rezultat.Text + cifra.Trim();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tastaCifra(rezultat, "9");
        }                    

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            rezultat.Text = rezultat.Text.Trim();
            String[] rezultatArray = rezultat.Text.Split(" ");            
            if (string.IsNullOrEmpty(rezultat.Text))
            {
                rezultat.Text = "0";
            }
            else
            if (rezultatArray.Length < 3)
            {
                rezultat.Text = rezultatArray[0];
            }
            else
            {
                double firstNumber = double.Parse(rezultatArray[0]);
                double secondNumber = double.Parse(rezultatArray[2]);
                String operatie = rezultatArray[1];
                rezultat.Text = operatie switch
                {
                    "+" => Convert.ToString(firstNumber + secondNumber),
                    "-" => Convert.ToString(firstNumber - secondNumber),
                    "/" => Convert.ToString(firstNumber / secondNumber),
                    "*" => Convert.ToString(firstNumber * secondNumber),
                    _ => "eroare"
                };
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {

            functieOperatie(" + ", rezultat);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            functieOperatie("-", rezultat);
        }

        private void buttonInmultit_Click(object sender, EventArgs e)
        {
            functieOperatie("*", rezultat);
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            functieOperatie("/", rezultat);
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            String[] rezultatArray = rezultat.Text.Split(" ");
            if (rezultatArray.Length == 1 && !rezultatArray[0].Contains("."))
            {
                rezultat.Text = rezultat.Text + ".";
            } else if (rezultatArray.Length == 3 && !rezultatArray[2].Contains("."))
            {
                rezultat.Text = rezultat.Text + ".";
            }
        }

        private void buttonDeleteLast_Click(object sender, EventArgs e)
        {

            int length = rezultat.Text.Length;
            if (length == 1)
            {
                rezultat.Text = "0";
            }
            else if (!rezultat.Text.EndsWith(' '))
            {
                rezultat.Text = rezultat.Text.Remove(length - 1);
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            rezultat.Text = "0";
        }
    }
}
