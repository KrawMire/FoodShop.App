   M S B A M L   `   `   `  ����G  CFoodShop.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FoodShop.App.PagesFoodShop.App.Pages  5      %    FoodShop.App.Pages.UserAuthPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:FoodShop.App.Pages     5        N� Title$  UserAuthPage��5	      .��5      � ���#edeff1 � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6   .+�5   
   �� $��1��6   $��1��6      ContentBorder#��[  6.   ._�5      �  5      �� 5      $
��50px �6'   �� 5      �� 5      $
��50px �6'   .+�5      �� $��1��6   .+�5      ��   	PageLabel#��[ 6   $ ��Введите логин:��6?   �� 5       -   5         ��Name$ loginTextBox��5"        PageTextBox#��[ 5       $"��Введите логин...��5!      5$      �� 5%      #��[ 6   $"��Введите пароль:��6?   G� 5&      -   5         G�Name$ passwordTextBox��5(        PagePasswordBox#��[ 5&   "    G� Password$  ��5'      5(      5)      �� 5*      -   5         ��Name$ 
authButton��5+        
PageButton#��[ 5*      $��1��5,      $��1��5-      $��
Войти��5.      5/      50      51      52      53      