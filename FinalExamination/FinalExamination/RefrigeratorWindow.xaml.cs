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
using System.Windows.Shapes;
using System.Windows.Threading;
using FinalExamination.ControlsWindows;

namespace FinalExamination
{
    /// <summary>
    /// Interaction logic for RefrigeratorWindow.xaml
    /// </summary>
    public partial class RefrigeratorWindow : Window
    {
        public RefrigeratorWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;

            TimeText.Text = dt.ToString("dd/MM HH:mm:ss");

        }

        private void CameraButton_Click(object sender, RoutedEventArgs e)
        {
            CameraView x = new CameraView();
            x.Show();
        }

        private void CalendarImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CalendarPopup.Visibility = Visibility.Visible;
        }

        private void RadioImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RadioControls x = new RadioControls();
            x.Show();
        }

        private void RecipesImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RecipesSuggestion x = new RecipesSuggestion();
            x.Show();
        }

        private void WebImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WebBrowserWindow x = new WebBrowserWindow();  
            x.Show();
        }

        private void WeatherImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GoogleWeather.Visibility = Visibility.Visible;
        }

        private void CalendarPopup_MouseLeave(object sender, RoutedEventArgs e)
        {
            CalendarPopup.Visibility = Visibility.Hidden;
        }

        private void GoogleWeather_MouseLeave(object sender, MouseEventArgs e)
        {
            GoogleWeather.Visibility = Visibility.Hidden;
        }

        private void ShowNowImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OnlineShopControl x = new OnlineShopControl();
            x.Show();
        }

        private void HelpImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("UI.chm");
        }
    }
}
