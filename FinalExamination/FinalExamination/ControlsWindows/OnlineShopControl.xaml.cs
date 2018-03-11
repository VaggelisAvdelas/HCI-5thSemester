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
using System.Windows.Shapes;

namespace FinalExamination.ControlsWindows
{
    /// <summary>
    /// Interaction logic for OnlineShopControl.xaml
    /// </summary>
    public partial class OnlineShopControl : Window
    {
        public OnlineShopControl()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Your order has been placed.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Quantity1.Text = "0";
            Quantity2.Text = "0";
            Quantity3.Text = "0";
            Quantity4.Text = "0";
            Quantity5.Text = "0";
        }

        private void Button1plus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity1.Text, out int num);
            num += 1;
            Quantity1.Text = num.ToString();
        }

        private void Button1minus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity1.Text, out int num);
            num -= 1;
            Quantity1.Text = num.ToString();
        }

        private void Button2plus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity2.Text, out int num);
            num += 1;
            Quantity2.Text = num.ToString();
        }

        private void Button2minus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity2.Text, out int num);
            num -= 1;
            Quantity2.Text = num.ToString();
        }

        private void Button3plus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity3.Text, out int num);
            num += 1;
            Quantity3.Text = num.ToString();
        }

        private void Button3minus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity3.Text, out int num);
            num -= 1;
            Quantity3.Text = num.ToString();
        }

        private void Button4plus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity4.Text, out int num);
            num += 1;
            Quantity4.Text = num.ToString();
        }

        private void Button4minus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity4.Text, out int num);
            num -= 1;
            Quantity4.Text = num.ToString();
        }

        private void Button5plus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity5.Text, out int num);
            num += 1;
            Quantity5.Text = num.ToString();
        }

        private void Button5minus_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Quantity5.Text, out int num);
            num -= 1;
            Quantity5.Text = num.ToString();
        }
    }
}
