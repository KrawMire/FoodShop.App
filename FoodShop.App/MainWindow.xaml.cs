using FoodShop.App.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodShop.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            NavigationService.Navigate(new ServerConnectionPage());
        }

        private void NavigationWindow_Loaded(object sender, RoutedEventArgs e)
        {
            /*string messageString =  "Авторизация сейчас не работает, просто нажмите кнопку \"Войти\". \n" +
                                    "Также пока не работают вкладки меню с добавлением данных в базу (страницы не готовы),\n" +
                                    "работают только вкладки со списками, то есть выгрузка и отображение";
            MessageBox.Show(messageString);*/
        }
    }
}
