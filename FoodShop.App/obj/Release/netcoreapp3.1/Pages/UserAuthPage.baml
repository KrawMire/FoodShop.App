   M S B A M L   `   `   `  ���� G  CFoodShop.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FoodShop.App.PagesFoodShop.App.Pages  %    FoodShop.App.Pages.UserAuthPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:FoodShop.App.Pages       N� Title$  UserAuthPage��.��� ���#edeff1 � ColumnDefinitions �� $
��0.5* ��� �� $
��0.5* � � RowDefinitions �� $
��0.5* ��� �� $
��0.5* �.+��� $��1��$��1��   ContentBorder#��[  ._��  �� $
��50px ��� �� $
��50px �.+��� $��1��.+���   	PageLabel#��[ $ ��Введите логин:���� -    ��Name$ loginTextBox��  PageTextBox#��[ $"��Введите логин...���� #��[ $"��Введите пароль:��G� -    G�Name$ passwordTextBox��  PagePasswordBox#��[  G� Password$  ���� -    ��Name$ 
authButton��  
PageButton#��[ $��1��$��1��$��
Войти��