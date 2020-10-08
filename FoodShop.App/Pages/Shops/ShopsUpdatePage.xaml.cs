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

namespace FoodShop.App.Pages.Shops
{
    /// <summary>
    /// Interaction logic for ShopsUpdatePage.xaml
    /// </summary>
    public partial class ShopsUpdatePage : Page
    {
        Shop shopForUpdate;
        FoodShopContext context;

        public ShopsUpdatePage(FoodShopContext context, int shopID)
        {
            InitializeComponent();
            this.context = context;
            headerLabel.Content = $"Обновление данных сотрудника с ID = {shopID}";
            shopForUpdate = context.Shop.Where(s => s.Id == shopID).FirstOrDefault();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                shopForUpdate.Address = addressTextBox.Text;
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
