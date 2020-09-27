using System;
using System.Collections.Generic;
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
            this.context = context;
        }
    }
}
