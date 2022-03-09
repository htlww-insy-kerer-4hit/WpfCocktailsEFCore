using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;

namespace CocktailsWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lbCocktails.ItemsSource = new string[] { "Cocktail 1", "Cocktail 2" };
            lbCocktails.SelectedIndex = 0;
            DataContext = this;
        }

        private void tbCocktailFilter_KeyUp(object sender, KeyEventArgs e)
        {
            string searchterm = tbCocktailFilter.Text.Trim().ToLower();
            MessageBox.Show("Filtering is not implemented yet.");
        }

        private void btnEditCocktail_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Editing is not implemented yet.");
        }
    }
}
