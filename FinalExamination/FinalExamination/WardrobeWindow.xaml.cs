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
using FinalExamination.ControlsWindows;

namespace FinalExamination
{
    /// <summary>
    /// Interaction logic for WardrobeWindow.xaml
    /// </summary>
    public partial class WardrobeWindow : Window
    {
        public WardrobeWindow()
        {
            InitializeComponent();
        }

        private void CasualDressCodeButton_Click(object sender, RoutedEventArgs e)
        {
            CasualDressCode x = new CasualDressCode();
            x.Show();
        }

        private void BussinessDressCodeButton_Click(object sender, RoutedEventArgs e)
        {
            CasualDressCode x = new CasualDressCode();
            x.ShirtImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Wardrobe/business_shirt.png", UriKind.Relative));
            x.PantsImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Wardrobe/business_pants.png", UriKind.Relative));
            x.ShoesImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Wardrobe/business_shoes.jpg", UriKind.Relative));

            x.Show();
        }

        private void FormalDressCodeButton_Click(object sender, RoutedEventArgs e)
        {
            CasualDressCode x = new CasualDressCode();
            x.ShirtImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Wardrobe/formal_shirt.jpg", UriKind.Relative));
            x.PantsImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Wardrobe/tuxedo_pants.jpg", UriKind.Relative));
            x.ShoesImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Wardrobe/tuxedo_shoes.jpg", UriKind.Relative));

            x.Show();
        }

        private void HelpImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("UI.chm");
        }
    }
}
