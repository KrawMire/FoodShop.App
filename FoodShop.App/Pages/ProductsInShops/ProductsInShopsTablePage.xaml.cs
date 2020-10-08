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
using FoodShop.App.DBWorker;
using FoodShop.App.Pages.ProductsInShops;

namespace FoodShop.App.Pages
{
    public partial class ProductsInShopsTablePage : Page
    {
        FoodShopContext context;

        public ProductsInShopsTablePage(FoodShopContext context)
        {
            InitializeComponent();

            this.context = context;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mainTable.ItemsSource = context.ProductInShop.ToList();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var productsInShopsForDelete = mainTable.SelectedItems.Cast<ProductInShop>().ToList();
                context.ProductInShop.RemoveRange(productsInShopsForDelete);
                context.SaveChanges();
                MessageBox.Show("Удаление прошло успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            var elementForUpdate = (ProductInShop)mainTable.SelectedItem;
            NavigationService.Navigate(new ProductsInShopsUpdatePage(context, elementForUpdate.ShopId, elementForUpdate.ProductId));
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
