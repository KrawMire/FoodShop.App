using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FoodShop.App
{
    // Сам по себе класс нужен для нормальной работы
    // бокового меню
    // Было слишком много лишнего дикого кода в странице,
    // поэтому я решил вынести всё это в отдельный класс

    class NavigationContoller
    {
        private int subcategoriesAmount;    // Количество подкатегорий в категории (предполагается, что их будет одингаковое количество)
        private Frame navigationFrame;      // Фрейм навигации по страницам
        private List<object> pagesList;     // Список страниц, по которым перемещается пользователь
        private List<Button> buttonsList;   // Список кнопок для навигации (кнопок на боковом меню)
        private bool[] openedCategories;    // Открытые категории

        public NavigationContoller(int CategoriesAmount,int SubCategoriesInCategoryAmount, List<object> PagesList, List<Button> ButtonsList, Frame NavigatingFrame)
        {   
            this.subcategoriesAmount = SubCategoriesInCategoryAmount;
            this.navigationFrame = NavigatingFrame;
            this.pagesList = PagesList;
            this.buttonsList = ButtonsList;
            this.openedCategories = new bool[CategoriesAmount * SubCategoriesInCategoryAmount + SubCategoriesInCategoryAmount];

            for (int i = 0; i < CategoriesAmount; i++) { openedCategories[i] = false; }
        }

        public void PageNavigate(object sender)
        {
            var clickedButton = (Button)sender;
            navigationFrame.Navigate(pagesList[Int32.Parse(clickedButton.Tag.ToString())]);
        }

        public void OpenOrCloseCategory(int Number)
        {
            string openedHeader = "- " + buttonsList[Number].Content.ToString().Substring(2);
            string closedHeader = "+ " + buttonsList[Number].Content.ToString().Substring(2);

            if (openedCategories[Number])
            {
                for (int i = 1; i <= subcategoriesAmount; i++)
                {
                    buttonsList[Number + i].Visibility = Visibility.Collapsed;
                    buttonsList[Number + i].Visibility = Visibility.Collapsed;
                }

                openedCategories[Number] = false;
                buttonsList[Number].Content = closedHeader;
            }
            else
            {
                for (int i = 1; i <= subcategoriesAmount; i++)
                {
                    buttonsList[Number + i].Visibility = Visibility.Visible;
                    buttonsList[Number + i].Visibility = Visibility.Visible;
                }

                openedCategories[Number] = true;
                buttonsList[Number].Content = openedHeader;
            }
        }
    }
}
