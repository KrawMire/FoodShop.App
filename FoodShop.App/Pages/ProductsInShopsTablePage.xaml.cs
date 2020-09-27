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
    /// Interaction logic for ProductsInShopsTablePage.xaml
    /// </summary>
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
            var productsInShops = from pis in context.ProductInShop
                                  join p in context.Product on pis.ProductId equals p.Id
                                  join s in context.Shop on pis.ShopId equals s.Id
                                  join u in context.Unit on pis.UnitId equals u.Id
                                  select new { Product = p.Name, ShopAddress = s.Address, Amount = pis.Amount, Units = u.Name };

            mainTable.ItemsSource = productsInShops.ToList();
        }
    }
}
