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
using System.IO;

namespace FoodShop.App.Pages
{
    /// <summary>
    /// Interaction logic for UserAuthPage.xaml
    /// </summary>
    public partial class ServerConnectionPage : Page
    {
        FoodShopContext context;
        string loadingImageSourse;

        public ServerConnectionPage()
        {
            InitializeComponent();

            loadingImageSourse = Path.GetFullPath("graphics/loading.gif");
            MessageBox.Show(loadingImageSourse);
        }

        async void CheckConnection(string ConnectionString)
        {
            try
            {
                context = new FoodShopContext(ConnectionString);
                LoadingAnimation.Visibility = Visibility.Visible;
                authButton.IsEnabled = false;
                await context.Database.EnsureCreatedAsync();
                NavigationService.Navigate(new UserAuthPage(context));
            }
            catch
            {
                LoadingAnimation.Visibility = Visibility.Collapsed;
                authButton.IsEnabled = false;
                MessageBox.Show("Не удалось подключиться к базе данных");
            }
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            // "Data Source=desktop-avignuq;Initial Catalog=FoodShop;User ID=sa;Password=12345"
            string connectionString = $"Data Source={serverNameTextBox.Text};Initial Catalog=FoodShop;User ID={dbLoginTextBox.Text};Password={dbPasswordTextBox.Password}";

            CheckConnection(connectionString);
        }

        private void serverNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (serverNameTextBox.Text == "Введите имя сервера...")
            {
                serverNameTextBox.Text = "";
                serverNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void serverNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(serverNameTextBox.Text))
            {
                serverNameTextBox.Text = "Введите имя сервера...";
                serverNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }

        private void dbLoginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (dbLoginTextBox.Text == "Введите имя пользователя базы...")
            {
                dbLoginTextBox.Text = "";
                dbLoginTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void dbLoginTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dbLoginTextBox.Text))
            {
                dbLoginTextBox.Text = "Введите имя пользователя базы...";
                dbLoginTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }
    }
}
