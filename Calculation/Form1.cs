using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Хранят значения цифр
        private static double firstNumber;
        private static double SecondNumber;

        //Значение знака
        private static string znakChar = " ";

        //Проверка на наичие
        private static bool flagZnak = false;
        private static bool flagZapataya = false;
        private static bool flagNumber = false;

        private double calc()
        {
            switch (znakChar)
            {
                case "+":
                    return firstNumber + SecondNumber;

                case "-":
                    return firstNumber - SecondNumber;


                case "*":
                    return firstNumber * SecondNumber;

                case "/":
                    return firstNumber / SecondNumber;

            }

            return 0;
        }


        //Методы для ввода чисел начало ---------------------------------------------------------
        private void oneBnt_Click(object sender, EventArgs e)
        {
            calculation.Text += "1";
            flagNumber = true;

        }

        private void twoBtn_Click(object sender, EventArgs e)
        {

            calculation.Text += "2";
            flagNumber = true;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {

            calculation.Text += "3";
            flagNumber = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            calculation.Text += "4";
            flagNumber = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            calculation.Text += "5";
            flagNumber = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            calculation.Text += "6";
            flagNumber = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            calculation.Text += "7";
            flagNumber = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            calculation.Text += "8";
            flagNumber = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            calculation.Text += "9";
            flagNumber = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            calculation.Text += "0";
            flagNumber = true;
        }

        //Методы для ввода чисел Конец ---------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(calculation.Text == ""))
                {
                    if (!flagZnak)
                    {
                        firstNumber = Convert.ToDouble(calculation.Text);
                        znakChar = "+";
                        calculation.Text += '+';
                        flagZnak = true;
                        flagNumber = false;
                    }
                    else
                    {
                        string[] elementsStr = calculation.Text.Split(znakChar);

                        if (elementsStr.Length > 1 && flagNumber)
                        {
                            SecondNumber = Convert.ToDouble(elementsStr[1]);
                            flagNumber = false;

                            firstNumber = calc();
                            znakChar = "+";

                            calculation.Text = firstNumber.ToString() + '+';


                        }


                    }
                }


                flagZapataya = false;
            }
            catch
            {
                Console.WriteLine("Произошла ошибка");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(calculation.Text == ""))
            {
                try
                {
                    if (!flagZnak)
                    {
                        firstNumber = Convert.ToDouble(calculation.Text);
                        znakChar = "-";
                        calculation.Text += '-';
                        flagZnak = true;
                        flagNumber = false;
                    }
                    else
                    {
                        string[] elementsStr = calculation.Text.Split(znakChar);

                        if (elementsStr.Length > 1 && flagNumber)
                        {
                            SecondNumber = Convert.ToDouble(elementsStr[1]);
                            flagNumber = false;

                            firstNumber = calc();

                            znakChar = "-";

                            calculation.Text = firstNumber.ToString() + '-';


                        }


                    }


                    flagZapataya = false;
                }
                catch
                {
                    Console.WriteLine("Произошла ошибка");
                }
                
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!(calculation.Text == ""))
            {
                if (flagZnak)
                {
                    string[] elementsStr = calculation.Text.Split(znakChar);

                    if (elementsStr.Length > 1 && flagNumber)
                    {
                        SecondNumber = Convert.ToDouble(elementsStr[1]);

                        flagNumber = false;
                        flagZnak = false;
                        flagZapataya = false;

                        firstNumber = calc();

                        znakChar = " ";

                        calculation.Text = firstNumber.ToString();


                    }

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(calculation.Text != "" && !flagZapataya)
            {
                calculation.Text += ',';
                flagZapataya = true;
            }
        }
    }
}
