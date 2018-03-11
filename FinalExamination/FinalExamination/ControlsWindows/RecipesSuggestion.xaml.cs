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
    /// Interaction logic for RecipesSuggestion.xaml
    /// </summary>
    public partial class RecipesSuggestion : Window
    {
        public RecipesSuggestion()
        {
            InitializeComponent();
        }

        private void OnlineRecipes_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserWindow x = new WebBrowserWindow();
            x.Show();
        }

        private void BologneseRec_Click(object sender, RoutedEventArgs e)
        {
            RecipeImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Recipes/bolognese.png", UriKind.Relative));
            IngredientsTextblock.Text = "Pasta no7     Minced Meat     Tomatoes    Onions";
            QuantityTextblock.Text = "500gr     750gr       1       2";
            StockTextbox.Text = "500gr      750gr       0/1     2/2";
        }

        private void PastitsioRec_Click(object sender, RoutedEventArgs e)
        {
            RecipeImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Recipes/pastitsio.png", UriKind.Relative));
            IngredientsTextblock.Text = "Pasta no3      Minced Meat     Tomatoes    Onions    Bechamel";
            QuantityTextblock.Text = "300gr     750gr       2       2       1";
            StockTextbox.Text = "0gr      750gr       0/2     2/2       1/1";
        }

        private void ChickenRec_Click(object sender, RoutedEventArgs e)
        {
            RecipeImage.Source = new BitmapImage(new Uri("/FinalExamination;component/Assets/Recipes/chickenalacream.png", UriKind.Relative));
            IngredientsTextblock.Text = "Chicken Breast      Rice     Mushrooms    Onions    Creme Fraiche";
            QuantityTextblock.Text = "2     200gr       400gr       1       1";
            StockTextbox.Text = "2/2      200gr     250gr     1/1       1/1";
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe x = new AddRecipe();
            x.Show();
            this.Close();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            OnlineShopControl x = new OnlineShopControl();
            x.Show();
        }
    }
}
