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

namespace FoodShop.App.Pages.Employees
{
    /// <summary>
    /// Interaction logic for EmployeesUpdatePage.xaml
    /// </summary>
    public partial class EmployeesUpdatePage : Page
    {
        EmployeeMainInfo employeeForUpdate;
        FoodShopContext context;

        public EmployeesUpdatePage(FoodShopContext ArgContext, int employeeID)
        {
            InitializeComponent();

            this.context = ArgContext;
            headerLabel.Content = $"Обновление данных сотрудника с ID = {employeeID}";
            this.employeeForUpdate = context.EmployeeMainInfo.Where(e => e.Id == employeeID).FirstOrDefault();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                employeeForUpdate.FirstName = firstNameTextBox.Text;
                employeeForUpdate.MiddleName = middleNameTextBox.Text;
                employeeForUpdate.LastName = lastNameTextBox.Text;
                employeeForUpdate.BirthDate = (DateTime)birthDatePicker.SelectedDate;

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
