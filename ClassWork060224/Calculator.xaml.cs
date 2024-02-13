using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassWork060224
{
    public partial class Calculator : Page
    {
        private bool isOperatorClicked = false;
        private bool isCommaClicked = false;
        private bool isCalculated = false;
        private double num1 = 0;
        private double num2 = 0;
        private string dzialanie = " ";

        public Calculator()
        {
            InitializeComponent();
        }

        private void EqualsBTN_Click(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            else
            {
                if (isOperatorClicked == true)
                {
                    this.Input.Text = Convert.ToString(num1);
                }
                else
                {
                    try
                    {
                        num2 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num2;
                        this.Dzialanie.Text += "=";
                    }
                    catch
                    {
                        num2 = 0;
                    }

                    if (dzialanie == "+")
                    {
                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }
                    else if (dzialanie == "-")
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }
                    else if (dzialanie == "*")
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }
                    else if (dzialanie == "/")
                    {
                        if (num2 != 0)
                        {
                            num1 = num1 / num2;
                            this.Input.Text = Convert.ToString(num1);
                            num2 = 0;
                            dzialanie = " ";
                        }
                        //else
                        //{
                        //    this.Input.Text = "Не делите на нуль!";
                        //    num1 = 0;
                        //    num2 = 0;
                        //    dzialanie = " ";
                        //}
                    }

                    else if (dzialanie == "x^y")
                    {
                        num1 = Math.Pow(num1, num2);
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }

                    else if (dzialanie == "y√x")
                    {
                        num1 = Math.Pow(num1, 1/num2);
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }
                }
                isOperatorClicked = false;
                isCalculated = true;
                num1 = 0;
            }
        }
        private void ButOffClicked(object s, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void ACBTN_Click(object s, RoutedEventArgs e)
        {
            this.Dzialanie.Text = "";
            this.Input.Text = "";
            num1 = 0;
            num2 = 0;
            dzialanie = " ";
            isOperatorClicked = false;
            isCalculated = false;
            isCommaClicked = false;
        }

        private void PlusMinusBTN_Click(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            if (isOperatorClicked == true)
            {
                try
                {
                    num1 = Convert.ToDouble(this.Input.Text);
                    num2 = num1 * (-1);
                }
                catch { }
                if (dzialanie == "+")
                {
                    num1 = num1 + num2;
                    this.Input.Text = Convert.ToString(num1);
                }
                else if (dzialanie == "-")
                {
                    num1 = num1 - num2;
                    this.Input.Text = Convert.ToString(num1);
                }
                else if (dzialanie == "*")
                {
                    num1 = num1 * num2;
                    this.Input.Text = Convert.ToString(num1);
                }
                else if (dzialanie == "/")
                {
                    if (num2 != 0)
                    {
                        num1 = num1 / num2;
                        this.Input.Text = Convert.ToString(num1);
                    }
                    //else
                    //{
                    //    this.Input.Text = "Не делите на нуль!";
                    //    num1 = 0;
                    //    num2 = 0;
                    //    dzialanie = " ";
                    //    isCalculated = true;
                    //}
                }

                else if (dzialanie == "x^y")
                {
                    num1 = Math.Pow(num1, num2);
                    this.Input.Text = Convert.ToString(num1);
                    num2 = 0;
                    dzialanie = " ";
                }

                else if (dzialanie == "y√x")
                {
                    num1 = Math.Pow(num1, 1 / num2);
                    this.Input.Text = Convert.ToString(num1);
                    num2 = 0;
                    dzialanie = " ";
                }

                this.Dzialanie.Text += dzialanie;
                this.Dzialanie.Text += num2;
                dzialanie = " ";
                isOperatorClicked = false;
                isCalculated = true;
            }
            else
            {
                try
                {
                    this.Input.Text = Convert.ToString(Convert.ToDouble(this.Input.Text) * (-1));
                    if (Convert.ToDouble(this.Input.Text) == 0.0)
                    {
                        this.Input.Text = "0";

                        isCommaClicked = false;
                    }
                }
                catch
                {
                }
            }
        }
        private void OperatorBTN_Click(object s, RoutedEventArgs e)
        {
            Button b = (Button)s;
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            try
            {
                double oryginal = Convert.ToDouble(this.Input.Text);
                int doCalkowitej = (int)Convert.ToDouble(this.Input.Text);
                if (oryginal == doCalkowitej)
                {
                    this.Input.Text = Convert.ToString(oryginal);
                }
                else if (Convert.ToString(oryginal) != this.Input.Text)
                {
                    this.Input.Text = Convert.ToString(oryginal);
                }
            }
            catch { }
            isCommaClicked = false;
            if (isOperatorClicked == true)
            {
                dzialanie = b.Content.ToString();
            }
            else
            {

                if (num1 == 0 && num2 == 0 && dzialanie != "/")
                {
                    dzialanie = b.Content.ToString();
                    try
                    {
                        num1 = Convert.ToDouble(this.Input.Text);
                        this.Dzialanie.Text += num1;
                        isOperatorClicked = true;
                    }
                    catch
                    {
                        dzialanie = " ";
                        num1 = 0;
                    }
                }
                else
                {
                    isOperatorClicked = true;
                    try
                    {
                        num2 = Convert.ToDouble(this.Input.Text);
                    }
                    catch { num2 = 0; }
                    this.Dzialanie.Text += num2;
                    if (dzialanie == "+")
                    {
                        num1 = num1 + num2;
                        this.Input.Text = Convert.ToString(num1);
                    }
                    else if (dzialanie == "-")
                    {
                        num1 = num1 - num2;
                        this.Input.Text = Convert.ToString(num1);
                    }
                    else if (dzialanie == "*")
                    {
                        num1 = num1 * num2;
                        this.Input.Text = Convert.ToString(num1);
                    }
                    else if (dzialanie == "/")
                    {
                        if (num2 != 0)
                        {
                            num1 = num1 / num2;
                            this.Input.Text = Convert.ToString(num1);
                        }
                        //else
                        //{
                        //    this.Input.Text = "Не делить на 0!";
                        //    num1 = 0;
                        //    num2 = 0;
                        //    dzialanie = " ";
                        //    isCalculated = true;
                        //}
                    }

                    else if (dzialanie == "x^y")
                    {
                        num1 = Math.Pow(num1, num2);
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }

                    else if (dzialanie == "y√x")
                    {
                        num1 = Math.Pow(num1, 1 / num2);
                        this.Input.Text = Convert.ToString(num1);
                        num2 = 0;
                        dzialanie = " ";
                    }

                    if (this.Dzialanie.Text.Length >= 60)
                    {
                        this.Dzialanie.Text = Convert.ToString(num1);
                    }
                    dzialanie = b.Content.ToString();
                    num2 = 0;
                }
            }
        }

        private void NumberBTN_Click(object s, RoutedEventArgs e)
        {
            Button b = (Button)s;
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            if (isOperatorClicked == true)
            {
                if (this.Dzialanie.Text != "")
                    this.Dzialanie.Text += dzialanie;
                this.Input.Text = "";
                isOperatorClicked = false;
                try
                {
                    if (Convert.ToDouble(this.Input.Text) == 0 && isCommaClicked == false)
                    {
                        this.Input.Text = b.Content.ToString();
                    }
                    else
                    {
                        this.Input.Text += b.Content.ToString();
                    }
                }
                catch
                {
                    this.Input.Text = b.Content.ToString();
                }
            }
            else
            {
                isOperatorClicked = false;
                try
                {
                    if (Convert.ToDouble(this.Input.Text) == 0.0 && isCommaClicked == false)
                    {
                        this.Input.Text = b.Content.ToString();
                    }
                    else
                    {
                        this.Input.Text += b.Content.ToString();
                    }
                }
                catch
                {
                    this.Input.Text = b.Content.ToString();
                }
            }
        }

        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Sin(number);
                if (RadiansBTN.IsChecked == true && DegreeBTN.IsChecked == false)
                {
                    Input.Text = result.ToString();
                }
                if(DegreeBTN.IsChecked == true && RadiansBTN.IsChecked == false)
                {
                    double result1 = Math.Sin((number / 180D) * Math.PI);
                   
                    Input.Text = result1.ToString();
                }
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                if (RadiansBTN.IsChecked == true && DegreeBTN.IsChecked == false)
                {
                    double result = Math.Cos(number);
                    Input.Text = result.ToString();
                }
                if (DegreeBTN.IsChecked == true && RadiansBTN.IsChecked == false)
                {
                    double result1 = Math.Cos((number / 180D) * Math.PI);

                    Input.Text = result1.ToString();
                }
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void TgButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                if (RadiansBTN.IsChecked == true && DegreeBTN.IsChecked == false)
                {
                    double result = Math.Tan(number);
                    Input.Text = result.ToString();
                }
                if (DegreeBTN.IsChecked == true && RadiansBTN.IsChecked == false)
                {
                    double result1 = Math.Tan((number / 180D) * Math.PI);

                    Input.Text = result1.ToString();
                }
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void CtgButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                if (RadiansBTN.IsChecked == true && DegreeBTN.IsChecked == false)
                {
                    double result = Math.Cos(number)/Math.Sin(number);
                    Input.Text = result.ToString();
                }
                if (DegreeBTN.IsChecked == true && RadiansBTN.IsChecked == false)
                {
                    double result1 = Math.Cos((number / 180D) * Math.PI) / Math.Sin((number / 180D) * Math.PI);

                    Input.Text = result1.ToString();
                }
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void SecondSDegreeBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Pow(number, 2);
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }
        private void ThirdSDegreeBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Pow(number, 3);
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }
        private void exBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Pow(Math.E, number);
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }
        private void SqrtBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Sqrt(number);
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void ThirdSqrtBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Pow(number, (1/3));
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }
        private void OneXBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = 1/number;
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void NaturalLogXBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Log(number);
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void LgBTN_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Input.Text, out double number))
            {
                double result = Math.Log10(number);
                Input.Text = result.ToString();
            }
            else
            {
                Input.Text = "Error";
            }
        }

        private void CommaBTN_Click(object s, RoutedEventArgs e)
        {
            if (isCalculated == true)
            {
                isCalculated = false;
                this.Dzialanie.Text = "";
            }
            try
            {
                double oryginal = Convert.ToDouble(this.Input.Text);
                int doCalkowitej = (int)Convert.ToDouble(this.Input.Text);

                if (doCalkowitej != oryginal)
                {

                    isCommaClicked = true;
                }
                else
                {
                    isCommaClicked = false;
                    this.Input.Text = Convert.ToString(oryginal);
                }

            }
            catch
            {
                if (this.Input.Text == "NIE DZIEL PRZEZ 0!")
                {
                    isCommaClicked = true;
                }
            }

            if (isOperatorClicked == true)
            {
                this.Dzialanie.Text += dzialanie;
                this.Input.Text = "";
                isOperatorClicked = false;
                this.Input.Text = "0,";
                isCommaClicked = true;

            }
            else if (isCommaClicked == false)
            {
                if (this.Input.Text != "")
                {
                    this.Input.Text += ",";
                }
                else
                {
                    this.Input.Text = "0,";
                }
                isCommaClicked = true;
            }
        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
