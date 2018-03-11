using FinalExamination.ControlsWindows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FinalExamination
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

        private void KitchenLightsButton_Click(object sender, RoutedEventArgs e)
        {
            if (KitchenLightsButton.Background == Brushes.Gray)
            {
                KitchenLightsButton.Background = Brushes.LightSkyBlue;
                KitchenLightsButton.Foreground = Brushes.White;
                System.Windows.MessageBox.Show("Kitchen lights are on.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else if (KitchenLightsButton.Background == Brushes.LightSkyBlue)
            {
                KitchenLightsButton.Background = Brushes.Gray;
                KitchenLightsButton.Foreground = Brushes.Black;
                System.Windows.MessageBox.Show("Kitchen lights are off.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void HallLightsButton_Click(object sender, RoutedEventArgs e)
        {
            if (HallLightsButton.Background == Brushes.Gray)
            {
                HallLightsButton.Background = Brushes.LightSkyBlue;
                HallLightsButton.Foreground = Brushes.White;
                System.Windows.MessageBox.Show("Hall lights are on.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else if (HallLightsButton.Background == Brushes.LightSkyBlue)
            {
                HallLightsButton.Background = Brushes.Gray;
                HallLightsButton.Foreground = Brushes.Black;
                System.Windows.MessageBox.Show("Hall lights are off.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void BedroomLightsButton_Click(object sender, RoutedEventArgs e)
        {
            if (BedroomLightsButton.Background == Brushes.Gray)
            {
                BedroomLightsButton.Background = Brushes.LightSkyBlue;
                BedroomLightsButton.Foreground = Brushes.White;
                System.Windows.MessageBox.Show("Bedroom lights are on.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else if (BedroomLightsButton.Background == Brushes.LightSkyBlue)
            {
                BedroomLightsButton.Background = Brushes.Gray;
                BedroomLightsButton.Foreground = Brushes.Black;
                System.Windows.MessageBox.Show("Bedroom lights are off.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void HeatButton_Click(object sender, RoutedEventArgs e)
        {
            if (HeatButton.Background == Brushes.Gray)
            {
                HeatButton.Background = Brushes.LightSkyBlue;
                HeatButton.Foreground = Brushes.White;
                System.Windows.MessageBox.Show("Heat is now on.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else if (HeatButton.Background == Brushes.LightSkyBlue)
            {
                HeatButton.Background = Brushes.Gray;
                HeatButton.Foreground = Brushes.Black;
                System.Windows.MessageBox.Show("Heat is now off.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordText.Text == "admin")
            {
                LockButton.IsEnabled = true;
                UnlockButton.IsEnabled = true;
                UnlockButton.IsChecked = true;
                System.Windows.MessageBox.Show("Correct Password, House is unlocked.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                PasswordText.Text = "";
            }
        }

        private void LockButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("House is locked.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            LockButton.IsEnabled = false;
            UnlockButton.IsEnabled = false;
        }

        private void UnlockButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("House is unlocked.","Info",MessageBoxButton.OK, MessageBoxImage.Information);
            LockButton.IsEnabled = false;
            UnlockButton.IsEnabled = false;
        }

        private void RefrigeratorOptions_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RefrigeratorWindow x = new RefrigeratorWindow();
            x.Show();
        }

        private void WardrobeOptions_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WardrobeWindow x = new WardrobeWindow();
            x.Show();
        }

        private void TvButton_Click(object sender, RoutedEventArgs e)
        {

            TvControls x = new TvControls();
            x.Show();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioControls x = new RadioControls();
            x.Show();
        }

        private void CoffeButton_Click(object sender, RoutedEventArgs e)
        {
            if (CoffeButton.Background == Brushes.Gray)
            {
                CoffeButton.Background = Brushes.LightSkyBlue;
                CoffeButton.Foreground = Brushes.White;
                System.Windows.MessageBox.Show("Coffee Maker is on.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (CoffeButton.Background == Brushes.LightSkyBlue)
            {
                CoffeButton.Background = Brushes.Gray;
                CoffeButton.Foreground = Brushes.Black;
                System.Windows.MessageBox.Show("Coffee Maker is off.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BoilerButton_Click(object sender, RoutedEventArgs e)
        {
            if (BoilerButton.Background == Brushes.Gray)
            {
                BoilerButton.Background = Brushes.LightSkyBlue;
                BoilerButton.Foreground = Brushes.White;
                System.Windows.MessageBox.Show("Boiler is on.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (BoilerButton.Background == Brushes.LightSkyBlue)
            {
                BoilerButton.Background = Brushes.Gray;
                BoilerButton.Foreground = Brushes.Black;
                System.Windows.MessageBox.Show("Boiler is off.","Info",MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void OvenButton_Click(object sender, RoutedEventArgs e)
        {
            OvenControls x = new OvenControls();
            x.Show();
        }

        private void WashmachineButton_Click(object sender, RoutedEventArgs e)
        {
            WashMachineControls x = new WashMachineControls();
            x.Show();
        }

        private void HelpImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("UI.chm");
        }
    }
}
