   M S B A M L   `   `   `  ����F  BStoreWithEF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:StoreWithEFStoreWithEF  5   	   =#clr-namespace:StoreWithEF.ViewModelStoreWithEF.ViewModel  5   	   A%clr-namespace:StoreWithEF.HelpMethodsStoreWithEF.HelpMethods  5   	   ;"clr-namespace:StoreWithEF.CommandsStoreWithEF.Commands  5	   	       StoreWithEF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:StoreWithEF     5   	   9	viewModel#clr-namespace:StoreWithEF.ViewModel     5   	   6help%clr-namespace:StoreWithEF.HelpMethods     5   	   7commands"clr-namespace:StoreWithEF.Commands     5	   	   -   5          �Name$  window��5   	    � Title$ 	LogInForm��5   	   $	��360��5   	   $	��360��5   	   $	��360��5   	   $	��500��5   	   $	��500��5   	   $	��500��5   	   
����p�� � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      /   )StoreWithEF.ViewModel.MainWindowViewModel   MainWindowViewModel3   -StoreWithEF.HelpMethods.MyMultiValueConverter  MyMultiValueConverter  
LogInLabel �� 
TargetType �� Property �� Value  LogInTextBox  LogInPasswordBox  LogInButton  ValidationTemplate �� Padding  TextBoxInError  PasswordBox��%!  &	        &	      &	 .     &	 �     &	 W    &	 �    &	 �    &	 �    &	 5      5   
   5        5   
   5      �� 5   
   " ��6#   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Center=�62   �� 5       � ��$ Right=�64   5       �� 5!   
   " ��6%   .�5"      ��  � ��$ 20(�6)   �� 5#       � ��$ 37��6'   �� 5$       � ��$
 Left=�64   5%      �� 5&   
   " G�6)   .�5'      ��  � ��$ 20(�6)   �� 5(       � ��$ 37��6'   �� 5)       � ��$
 Left=�64   5*      �� 5+   
   " ��6$   .�5,      ��  � ��$ 20(�6)   �� 5-       � ��$ 33��6'   �� 5.       � ��$ Center=�62   �� 5/       � ��
 ����6+   �� 50       �@�Cursor$
 Hand��6'   �� 51       � ��$ 0 0 0 5q�6(   52      �� 54   
   .R�55      ]� .+�56      �� 
���  ��$��22(�57      $
��Bold"�58      $ 	220,0,0,0q�59      $��Right=�5:      !6;   5<      5=      �� 5?   
   " ��6'   .�5@      ��  � ��$ 20(�6)   �� 5A       � ��$ 37��6'   �� 5B       � ��$
 Left=�64   5K      �� 5L   
   " G�6$   .�5M      ��  � ��$ 20(�6)   �� 5N       � ��$ 37��6'   �� 5O       � ��$
 Left=�64   5P      5Q      .��5S      � -   5         �Name$ gLogIn��5S      	 � RowDefinitions	 5T   
   �� 5U      $
��0.8* �6   �� 5V      $
��0.8* �6   �� 5W      $��0.25* �6   �� 5X      $
��0.8* �6   �� 5Y      $
��0.5* �6   �� 5Z      $
��0.7* �6   
 � ColumnDefinitions
 5\   
   �� 5]      $��* �6   �� 5^      $��2* �6   6,   .+�5a   
   �� $��
LogIn form��6   $��2��5b      $��Center=�5c      $��25(�5d      $
��Bold"�5e      $��0,20,0,0q�5f      $��3q�5g      $	��Top=�5h      $	��178��5i      �� 5j   
   $��UserName��6   $��1��5k      #��[ 5l      $	��120��5m      �� 5n   
   $��Password��6   $��3��5o      #��[ 5p      $	��110��5q      �� 5r   
   -   5         ��Name$ 
tbUserName��5r      $��1��5s      $��1��5t      #��[ 5v      $��0q�5w      $	��230��5x      ��5u      �� *
UserName+ �� Source# [  .��5x      .��5�   #   5�      �� 5�   
   -   5         ��Name$ lErrorInput��5�      $��2��5�      $��1��5�      $	��Top=�5�      $
��Left=�5�      $	��255��5�      $��25��5�      $��15(�5�      
����  �$��0,0,0,5q�5�      $��0q�5�       � BindingGroup 5�      ��  �� BindingGroupName$ 
Parameters����5�      �� *InputLabelContent+# [  5�      G� 5�   
   -   5         G�Name$ 
tbPassword��5�      $��3��5�      $��1��5�      $��20(�5�      $��37��5�      $
��Left=�5�      $��0q�5�      $	��230��5�      5�      �� 5�   
   -   5        $ lErrorLogIn��5�      $��4��5�      $��1��5�      $	��Top=�5�      $
��Left=�5�      $	��265��5�      $��45��5�      $��15(�5�      
���  ��$��0,0,0,0q�5�      $��0q�5�       5�      �� $ 
Parameters����5�      �� *CheckUserLabelContent+# [  5�      �� 5�   
   $��2��5�      $��5��5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� $��Log in��6   #��[ 5�      $��80��5�      $��
160,0,0,12q�5�      ��5�      �� *LogInCommand+# [   �� Mode$ TwoWay=���5�      `� 5�       `� 	Converter# [ 6#   .1�5�      ��  �� Path$
 Text�6"    �� ElementName$ 
tbUserName��6.   6I   �� 5�      $ 
tbPassword��6"   6=   �� 5�      $ Content�6"   $ tbErrorLogIn��61   6N   5�      5�      �� 5�      $��Registration��6   $��	25,0,0,12q�5�      $	��128��5�      #��[ 5�      ��5�      �� *RedirectRegistrationCommand+# [  ��5�      �� $ window��$ OneWay=�5�      5�      5�      