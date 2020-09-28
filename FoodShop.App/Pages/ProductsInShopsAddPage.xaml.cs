using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodShop.App.Pages
{
    /// <summary>
    /// Interaction logic for ProductsInShops.xaml
    /// </summary>
    public partial class ProductsInShopsAddPage : Page
    {
        FoodShopContext context;
        List<string> units;
        List<string> products;
        List<string> shops;

        public ProductsInShopsAddPage(FoodShopContext context)
        {
            InitializeComponent();

            List<Unit> unitsList = context.Unit.ToList();
            List<Product> productList = context.Product.ToList();
            List<Shop> shopList = context.Shop.ToList();

            this.context = context;
            
            foreach (var element in unitsList) { units.Add(element.Name); }
            foreach (var element in productList) { products.Add(element.Name); }
            foreach (var element in shopList) { shops.Add(element.Address); }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void amountTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (amountTextBox.Text == "Введите адрес магазина...")
            {
                amountTextBox.Text = "";
                amountTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void amountTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTextBox.Text))
            {
                amountTextBox.Text = "Введите адрес магазина...";
                amountTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }
    }
}
