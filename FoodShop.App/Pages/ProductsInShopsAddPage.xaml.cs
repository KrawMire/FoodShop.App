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

        public ProductsInShopsAddPage(FoodShopContext context)
        {
            InitializeComponent();

            this.context    = context;
            List<string>    unitsNames      = new List<string>(),
                            shopsNames      = new List<string>(),
                            productsNames   = new List<string>();

            foreach(var element in context.Unit.ToList()) { unitsNames.Add(element.Name); }
            foreach(var element in context.Product.ToList()) { productsNames.Add(element.Name); }
            foreach(var element in context.Shop.ToList()) { shopsNames.Add(element.Address); }

            unitComboBox.ItemsSource = unitsNames;
            productComboBox.ItemsSource = productsNames;
            shopComboBox.ItemsSource = shopsNames;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
                context.ProductInShop.Add(new ProductInShop()
                {
                    ProductId = context.Product.Where(p => p.Name == productComboBox.SelectedItem.ToString()).Select(p => p.Id).FirstOrDefault(),
                    ShopId = context.Shop.Where(s => s.Address == shopComboBox.SelectedItem.ToString()).Select(s => s.Id).FirstOrDefault(),
                    Amount = Int32.Parse(amountTextBox.Text),
                    UnitId = context.Unit.Where(u => u.Name == unitComboBox.SelectedItem.ToString()).Select(u => u.Id).FirstOrDefault()
                });
                context.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!");
            
        }

        private void amountTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (amountTextBox.Text == "Введите количество товара...")
            {
                amountTextBox.Text = "";
                amountTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void amountTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountTextBox.Text))
            {
                amountTextBox.Text = "Введите количество товара...";
                amountTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }
    }
}
