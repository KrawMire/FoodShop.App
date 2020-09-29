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
            try
            {
                this.context.EmployeeMainInfo.Add(new EmployeeMainInfo()
                {
                    FirstName = firstNameTextBox.Text,
                    MiddleName = middleNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    BirthDate = (DateTime)birthDatePicker.SelectedDate
                });

                context.SaveChanges();

                MessageBox.Show("Данные успешно добавлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить данные в базу.\nПроверьте правильность ввода данных и повторите попытку.");
            }
        }

        private void firstNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstNameTextBox.Text == "Введите фамилию работника...")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void firstNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                firstNameTextBox.Text = "Введите фамилию работника...";
                firstNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }

        private void middleNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (middleNameTextBox.Text == "Введите имя работника...")
            {
                middleNameTextBox.Text = "";
                middleNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void middleNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(middleNameTextBox.Text))
            {
                middleNameTextBox.Text = "Введите имя работника...";
                middleNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }

        private void lastNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastNameTextBox.Text == "Введите отчество работника...")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void lastNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameTextBox.Text = "Введите отчество работника...";
                lastNameTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }
    }
}
