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
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    public partial class Calculator : Page
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void OneBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "1";
        }

        private void TwoBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "2";
        }

        private void ThreeBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "3";
        }

        private void FourBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "4";
        }

        private void FiveBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "5";
        }

        private void SixBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "6";
        }

        private void SevenBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "7";
        }

        private void EightBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "8";
        }

        private void NineBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "9";
        }

        private void ZeroBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "0";
        }

        private void ACBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }

        private void CommaBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + ",";
        }

        private void EqualsBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text;
        }

        private void PlusBTN_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "+";
            var a = Result.Text;

        }

        private void MinusBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MultiplicationBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DivisionBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
