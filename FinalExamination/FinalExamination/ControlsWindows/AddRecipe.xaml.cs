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
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Window
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            RecipesSuggestion x = new RecipesSuggestion();
            x.IngredientsTextblock.Text = Ingred1.Text + "       " + Ingred2.Text + "       " + Ingred3.Text + "       " + Ingred4.Text + "       ";
            x.QuantityTextblock.Text = Qnt1.Text + "       " + Qnt2.Text + "       " + Qnt3.Text + "       " + Qnt4.Text + "       ";
            Button newButton = new Button();
            newButton.Content = RecipeName.Text;
            newButton.Height = 25;
            newButton.Width = 177;
            x.RecipesListView.Items.Add(newButton);
            x.Show();
        }
    }
}
