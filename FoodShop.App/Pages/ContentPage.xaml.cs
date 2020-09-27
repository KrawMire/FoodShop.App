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
    /// Interaction logic for ContentPage.xaml
    /// </summary>
    public partial class ContentPage : Page
    {
        private NavigationContoller menuController;
        private List<object> pagesList;
        private List<Button> buttonsList;
        private FoodShopContext dbContext;

        public ContentPage(FoodShopContext context)
        {
            InitializeComponent();

            this.dbContext = context;

            this.pagesList = new List<object>
            {
                new object(), // Заменяет заголовок категории
                new ShopsAddPage(dbContext),
                new ShopsTablePage(dbContext),
                new object(), // Заменяет заголовок категории
                new EmployeesAddPage(dbContext),
                new EmployeesTablePage(dbContext),
                new object(), // Заменяет заголовок категории
                new ProductsInShopsAddPage(dbContext),
                new ProductsInShopsTablePage(dbContext)
            };
            this.buttonsList = new List<Button>
            {
                shopsButton,
                shopsAddButton,
                shopsTableButton,
                employeesButton,
                employeesAddButton,
                employeesTableButton,
                productsInShopsButton,
                productsInShopsAddButton,
                productsInShopsTableButton
            };
            this.menuController = new NavigationContoller(3, 2, pagesList, buttonsList, MainFrame);
            menuController.PageNavigate(buttonsList[1]);
        }

        private void categoryButton_Click(object sender, RoutedEventArgs e)
        {
            var clickedButton = (Button)sender;
            menuController.OpenOrCloseCategory(Int32.Parse(clickedButton.Tag.ToString()));
        }

        private void pageOpenButton_Click(object sender, RoutedEventArgs e)
        {
            menuController.PageNavigate(sender);
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
