   M S B A M L   `   `   `  ����G  CAvtorization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AvtorizationAvtorization  5   	   !    Avtorization.RegisterWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Avtorization     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � AllowsTransparency .  � WindowStyle$
 None=�6e   ��65   Z� .��5      � .+�5   
   �� -   5        $	��400��5   .   $��15q�6=   ���#fff �� Padding$ 30q�6[   $��Center=�6h   $��Center=�6�    �� CornerRadius$ 20��6�   $	��550��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LawnGreen��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� -   5        $
��Wrap=�5      $��Right=�60   $��30(�6L   	 � Cursor$
	 Hand��6Z   $��X��6�   �� 5      $��Регистрация��6   $
��Bold"�6/   $��25(�6A   $��0,0,0,20q�6O   � 5      $��0,0,0,10q�6   .+�5      �� -   5        $
��Left=�5      $��Решистрация��6M      MaterialDesignFlatButton#��[  6c   �� 5      -   5        $��Right=�5      $��
Войти��69   6I   5      �� 5      -   5        $��	EnterName��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$$
 Введите Ваше имя��6+     MaterialDesignTextBox#��[ 6]   �� 5      -   5        $��
EnterLogin��5      $
 Введите логин��6,   #��[ 6[   G� 5      -   5        $��EnterPassword��5      $!
 Введите пароль��63     MaterialDesignPasswordBox#��[ 6c   G� 5      -   5        $��EnterPassword2��5      $%
 Повторите пароль��64   #��[ 6f   �� 5      -	   5        $��
EnterEmail��5      $
 Введите Email��6,   #��[ 6[   5      5      5       5!      