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
    }
}
