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
            var employees = from emi in context.EmployeeMainInfo
                            join ewi in context.EmployeeWorkInfo on emi.Id equals ewi.EmployeeId
                            select new
                            {
                                ID = emi.Id,
                                FirstName = emi.FirstName,
                                MiddleName = emi.MiddleName,
                                LastName = emi.LastName,
                                BirthDate = emi.BirthDate,
                                Position = ewi.Position,
                                DateFrom = ewi.WorkDateFrom,
                                DateTo = ewi.WorkDateTo
                            };
            mainTable.ItemsSource = employees.ToList();
        }
    }
}
