   M S B A M L   `   `   `  ����G  CFoodShop.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FoodShop.App.PagesFoodShop.App.Pages  5      -    'FoodShop.App.Pages.ServerConnectionPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:FoodShop.App.Pages     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5        N� Title$  UserAuthPage��5
      .��5      � ���#edeff1 � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6   .+�5   
   �� $��1��6   $��1��6      ContentBorder#��[  6.   ._�5      �  5      �� 5      $
��50px �6'   �� 5      �� 5      $
��50px �6'   .+�5      �� $��1��6   .+�5       ��   	PageLabel#��[ 6   $O��IВведите имя сервера (Например: desktop-avignuq):��6?   �� 5!      -   5         ��Name$ serverNameTextBox��5#        PageTextBox#��[ 5!      $-��'Введите имя сервера...��5"      5%      �� 5&      #��[ 6   $I��CВведите пользователя базы данных (sa):��6?   �� 5'      -   5        $ dbLoginTextBox��5)      #��[ 5'      $@��:Введите имя пользователя базы...��5(      5+      �� 5,      #��[ 6   $Y��SВведите пароль пользователя базы данных (12345):��6?   G� 5-      -   5         G�Name$ dbPasswordTextBox��5.        PagePasswordBox#��[ 5-   "   5.      5/      �� 50      -   5         ��Name$ 
authButton��51        
PageButton#��[ 50      $��1��52      $��1��53      $��
Войти��54      55      56      57      � 5;   
   -   5         �Name$ LoadingAnimation��5@      $��1��5;      $��1��6   ���#FFFFFF$	��400��5=      $	��300��5>      $y�	Collapsed=�5?       J� Effect 5A      3  -System.Windows.Media.Effects.DropShadowEffect  5B         
BlurRadius$ 15Q�6#   	   	Direction$		 -90Q�63   
   RenderingBias$
 Quality=�6C      ShadowDepth$ 2Q�6[    5D      �� 5E      $��50 �6#   �� 5F      �� 5G      $��50 �6#    5I      �� 5J      $	��100 �6    �� 5K      �� 5L      $��50 �6    .+�5O      �� $��1��6   $��30(�5P      $��Загрузка...��5Q      $��Center=�5R      $��Center=�5S      $
��Bold"�5T      �� 5U      $��1��5V      $��1��5W      "  WpfAnimatedGif.ImageBehavior   AnimatedSource 5U      �� *loadingImageSource+5W      5X      5Y      5Z      