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
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesAddPage : Page
    {
        FoodShopContext context;

        public EmployeesAddPage(FoodShopContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void firstNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void firstNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
