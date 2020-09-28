﻿using System;
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
    /// Interaction logic for ShopsPage.xaml
    /// </summary>
    public partial class ShopsAddPage : Page
    {
        FoodShopContext context;

        public ShopsAddPage(FoodShopContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void addressTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addressTextBox.Text = "Введите количество товара...";
                addressTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#b4b5ba"));
            }
        }

        private void addressTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (addressTextBox.Text == "Введите количество товара...")
            {
                addressTextBox.Text = "";
                addressTextBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            }
        }

        private void shopAddButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
