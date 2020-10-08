using System;
using System.Collections.Generic;
using System.Data;
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
using FoodShop.App.Pages.Shops;

namespace FoodShop.App.Pages
{
    /// <summary>
    /// Interaction logic for ShopsTablePage.xaml
    /// </summary>
    public partial class ShopsTablePage : Page
    {
        FoodShopContext context;

        public ShopsTablePage(FoodShopContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mainTable.ItemsSource = context.Shop.ToList();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var shopForDelete = mainTable.SelectedItems.Cast<Shop>().ToList();
                context.RemoveRange(shopForDelete);
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
            var shopForUpdate = (Shop)mainTable.SelectedItem;
            NavigationService.Navigate(new ShopsUpdatePage(context, shopForUpdate.Id));
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                mainTable.ItemsSource = context.Shop.Where(e => e.Address.Contains(searchTextBox.Text)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
