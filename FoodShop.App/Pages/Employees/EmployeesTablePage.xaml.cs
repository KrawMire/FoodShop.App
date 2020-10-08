using FoodShop.App.DBWorker;
using FoodShop.App.Pages.Employees;
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
    /// Interaction logic for EmployeesTablePage.xaml
    /// </summary>
    public partial class EmployeesTablePage : Page
    {
        FoodShopContext context;

        public EmployeesTablePage(FoodShopContext context)
        {
            InitializeComponent();

            this.context = context;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mainTable.ItemsSource = context.EmployeeMainInfo.ToList();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            var employeeForUpdate = (EmployeeMainInfo)mainTable.SelectedItem;
            NavigationService.Navigate(new EmployeesUpdatePage(context, employeeForUpdate.Id));
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainTable.SelectedItems.Count > 0)
            {
                var res = MessageBox.Show("Вы уверены, что хотите удалить " + mainTable.SelectedItems.Count + " работников?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                
                if (res == MessageBoxResult.Yes)
                {
                    try
                    {
                        var employeesList = mainTable.SelectedItems.Cast<EmployeeMainInfo>().ToList();

                        context.EmployeeMainInfo.RemoveRange(employeesList);

                        context.SaveChanges();
                        MessageBox.Show(mainTable.SelectedItems.Count + " работников удалено!");

                        mainTable.ItemsSource = context.EmployeeMainInfo.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                mainTable.ItemsSource = context.EmployeeMainInfo.Where(e => e.FirstName.Contains(searchTextBox.Text)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
