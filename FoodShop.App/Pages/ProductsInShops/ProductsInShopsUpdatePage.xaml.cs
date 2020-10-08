using FoodShop.App.DBWorker;
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

namespace FoodShop.App.Pages.ProductsInShops
{
    /// <summary>
    /// Interaction logic for ProductsInShopsUpdatePage.xaml
    /// </summary>
    public partial class ProductsInShopsUpdatePage : Page
    {
        FoodShopContext context;
        ProductInShop elementForDelete;

        public ProductsInShopsUpdatePage(FoodShopContext context, int shopID, int productID)
        {
            InitializeComponent();

            this.context = context;
            headerLabel.Content = $"Обновление данных сотрудника с ID магазина = {shopID} и ID товара = {productID}";
            this.elementForDelete = context.ProductInShop.Where(e => e.ShopId == shopID && e.ProductId == productID).FirstOrDefault();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> unitsNames = new List<string>(),
                            shopsNames = new List<string>(),
                            productsNames = new List<string>();

            foreach (var element in context.Unit.ToList()) { unitsNames.Add(element.Name); }
            foreach (var element in context.Product.ToList()) { productsNames.Add(element.Name); }
            foreach (var element in context.Shop.ToList()) { shopsNames.Add(element.Address); }

            unitComboBox.ItemsSource = unitsNames;
            productComboBox.ItemsSource = productsNames;
            shopComboBox.ItemsSource = shopsNames;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                elementForDelete.ProductId = context.Product.Where(p => p.Name == productComboBox.SelectedItem.ToString()).Select(p => p.Id).FirstOrDefault();
                elementForDelete.ShopId = context.Shop.Where(s => s.Address == shopComboBox.SelectedItem.ToString()).Select(s => s.Id).FirstOrDefault();
                elementForDelete.Amount = Int32.Parse(amountTextBox.Text);
                elementForDelete.UnitId = context.Unit.Where(u => u.Name == unitComboBox.SelectedItem.ToString()).Select(u => u.Id).FirstOrDefault();

                context.SaveChanges();
                MessageBox.Show("Данные успешно обновлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
