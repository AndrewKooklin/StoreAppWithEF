   M S B A M L   `   `   `  ����F  BStoreWithEF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:StoreWithEFStoreWithEF  5   	   3clr-namespace:StoreWithEF.ViewStoreWithEF.View  5   	   =#clr-namespace:StoreWithEF.ViewModelStoreWithEF.ViewModel  5   	   A%clr-namespace:StoreWithEF.HelpMethodsStoreWithEF.HelpMethods  5	   	   )    #StoreWithEF.View.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:StoreWithEF     5   	   /viewclr-namespace:StoreWithEF.View     5   	   9	viewModel#clr-namespace:StoreWithEF.ViewModel     5   	   6help%clr-namespace:StoreWithEF.HelpMethods     5	   	     � Title$  Registration��5   	   $	��450��5   	   $	��450��5   	   $	��450��5   	   $	��600��5   	   $	��600��5   	   $	��600��5   	   
����p�� � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      7   1StoreWithEF.ViewModel.RegistrationWindowViewModel   RegistrationWindowViewModel3   -StoreWithEF.HelpMethods.MyMultiValueConverter  MyMultiValueConverter  RegistrationLabel �� 
TargetType �� Property �� Value  RegistrationTextBox  RegistrationPasswordBox  RegistrationButton��%�  &	        &	      &	 .     &	 �     &	     &	 9      5   
   5        5   
   5      �� 5   
   " ��6*   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Center=�62   �� 5       � ��$ Right=�64   5      �� 5    
   " ��6,   .�5!      ��  � ��$ 20(�6)   �� 5"       � ��$ 37��6'   �� 5#       � ��$ Center=�62   �� 5$       � ��$
 Left=�64   5%      �� 5&   
   " G�60   .�5'      ��  � ��$ 20(�6)   �� 5(       � ��$ 37��6'   �� 5)       � ��$ Center=�62   �� 5*       � ��$
 Left=�64   5+      �� 5,   
   " ��6+   .�5-      ��  � ��$ 20(�6)   �� 5.       � ��$ 34��6'   �� 5/       � ��$ Center=�62   �� 50       � ��
 ����6+   �� 51       �@�Cursor$
 Hand��6'   �� 52       � ��$ 0 0 0 5q�6(   53      56      .��58      �  � RowDefinitions 5:   
   �� 5;      $��* �6   �� 5<      $
��0.3* �6   �� 5=      $
��0.7* �6   �� 5>      $
��0.7* �6   �� 5?      $
��0.7* �6   �� 5@      $
��0.3* �6   �� 5A      $
��0.5* �6   �� 5B      $��* �6    � ColumnDefinitions 5D   
   �� 5E      $��* �6   �� 5F      $
��1.5* �6   .+�5I   
   �� $��2��6   $��Registration form��5J      $��Center=�5K      $��25(�5L      $
��Bold"�5M      $��150,12,171.6,0q�5N      $	��Top=�5O      $	��272��5P      �� 5Q   
   -   5         ��Name$ lErrorInput��5Q      $��1��5S      $��1��5T      $��30��5U      $	��260��5V      $
��Left=�5W      $	��Top=�5X      $��15(�5Y      $��0q�5Z      $��0q�5[      
����  ���5R      �� *InputLabelContent+	 �� Source#	 [  5^      �� 5_   
   $��UserName��6   $��2��5`      #��[ 5a      $	��118��5b      �� 5c   
   $��Password��6   $��3��5d      #��[ 5e      $	��107��5f      �� 5g   
   $��Confirm password��6   $��4��5h      #��[ 5i      $	��185��5j      �� 5k   
   -   5        
 ��Name$
 
tbUserName��5k      $��2��5l      $��1��5m      #��[ 5n      $	��230��5o      G� 5p   
   -   5         G�Name$ 
tbPassword��5p      $��3��5q      $��1��5r      #��[ 5s      $	��230��5t      G� 5v   
   -   5        $ tbConfirmPassword��5v      $��4��5w      $��1��5x      #��[ 5y      $	��230��5z      �� 5{   
   -   5        $ lErrorRegistration��5{      $��5��5}      $��1��5~      $��30��5      $	��230��5�      $
��Left=�5�      $��15(�5�      
���  ����5|      �� *!CkeckMatchPasswordsLabelContent+#	 [  5�      �� 5�   
   -   5         ��Name$ chbRememberMe��5�      $��6��5�      $��1��5�      $
��Left=�5�      $��Center=�5�      $��2q�5�      
���   �$��	20,10,0,0q�5�      $��25��5�      $��25��5�       d� 	IsChecked 5�      �� *CkeckRememberMe+#	 [  �� 5�   
   $��Remember me��6   $��6��5�      $��1��5�      $��20(�5�      $��50,0,0,0q�5�      $
��Left=�5�      $��Center=�5�      $	��151��5�      �� 5�   
   $��7��5�      $��2��5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� $��Log in��6   $��	240,0,0,0q�5�      #��[ 5�      $��80��5�      ��5�      �� *RedirectToLogInCommand+#	 [  ��5�      ��  �� ElementName$ window�� �� Mode$ OneWay=��� 5�      $��Register��6   $��28,0,0,0q�5�      #��[ 5�      $	��118��5�      ��5�      �� *RegisterCommand+#	 [  $ TwoWay=���5�      `� 5�       `� 	Converter# [ 6#   .1�5�      ��  �� Path$
 Text�6"   $ 
tbUserName��6.   6I   �� 5�      $ 
tbPassword��6"   6=   �� 5�      $ tbConfirmPassword��6"   6D   5�      5�      5�      5�      5�      