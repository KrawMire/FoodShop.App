using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for UserAuthPage.xaml
    /// </summary>
    public partial class UserAuthPage : Page
    {
        FoodShopContext context;

        public UserAuthPage(FoodShopContext context)
        {
            InitializeComponent();
            this.context = context;   
        }

        private void loginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text == "Введите логин...")
            {
                loginTextBox.Text = "";
                loginTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void loginTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                loginTextBox.Text = "Введите логин...";
                loginTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            //context.Shop.Where(s => s.Address == shopComboBox.SelectedItem.ToString()).Select(s => s.Id).FirstOrDefault()
            if (context.User.Where(u => u.Login == loginTextBox.Text && u.Password == passwordTextBox.Password).FirstOrDefault() != null)
                NavigationService.Navigate(new ContentPage(this.context));

            else
                MessageBox.Show("Не удалось найти пользователя с такими логином и паролем!");
        }
    }
}
