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
using CalculatorNS;
namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Double.Parse(fstValue.Text);
            double num2 = Double.Parse(sndValue.Text);
            if (CombBox.SelectedItem == add)
            {
                Result.Content = (Calculator.Add(num1, num2));
            }else if(CombBox.SelectedItem == minus)
            {
                Result.Content = (Calculator.Minus(num1, num2));
            }
            else if(CombBox.SelectedItem == times)
            {
                Result.Content = (Calculator.Multiply(num1, num2));
            }
            else if (CombBox.SelectedItem == divide)
            {
                Result.Content = (Calculator.Divide(num1, num2));
            }
            
                
        }
    }
}
