   M S B A M L   `   `   `  ����F  BStoreWithEF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StoreWithEF.ViewStoreWithEF.View  5   	   =#clr-namespace:StoreWithEF.ViewModelStoreWithEF.ViewModel  5   	   $    StoreWithEF.View.ClientsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StoreWithEF.View     5   	   9	viewModel#clr-namespace:StoreWithEF.ViewModel     5   	   -   5          � Title$  ClientsWindow��5	   	   $	��450��5
   	   $	��800��5   	   $	��800��5   	   $	��800��5   	   
����p�� � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      2   ,StoreWithEF.ViewModel.ClientsWindowViewModel   ClientsWindowViewModel  HeaderGridViewColumn �� 
TargetType �� Property �� Value  ClientsButton��%d  &	        &	      &	 �       5   
   5      �� 5   
   " ��6-   .�5      ��  � ��
 ��� �6+   �� 5       � ��
 �   �6,   �� 5       � ��$ 2q�60   �� 5       � ��$ 0q�6'   �� 5       � ��$ 0q�6(   5      �� 5    
   " ��6&   .�5!      ��  � ��$ 15(�6)   �� 5"       � ��$ 34��6'   �� 5#       � ��$ 85��6&   �� 5$       � ��$ 	10 15 0 0q�6'   �� 5%       � ��$	 Top=�62   �� 5&       � ��
 ����6+   �� 5'       �@�Cursor$
 Hand��6'   �� 5(       � ��$ 0q�6(   5)      5,      .��5.      �  � RowDefinitions 5/   
   �� 50      $��* �6    � ColumnDefinitions 52   
   �� 53      $��4* �6   �� 54      $��* �6   .+�58   
   �� -   5         ��Name$ 	lvClients��58      $
��Left=�5;      $	��400��5<      $��
10,10,0,10q�5=      $	��Top=�5>      $	��625��5?      $��0q�5@      ��59      �� *ObservableClients+	 �� Source#	 [  
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5A      �� 5B      .P�5C      �� $��Id��6%    �� HeaderContainerStyle# [ 5E   %    �� Width$ 40��5F   %    �� DisplayMemberBinding 5D   %   �� *
ClientId+$ PropertyChanged=�$
 TwoWay=�5F   %   �� 5G      $��LastName��6%   # [ 5I   %   $	 115��5J   %    5H   %   �� *
LastName+$ PropertyChanged=�$
 TwoWay=�5J   %   �� 5K      $��	FirstName��6%   # [ 5M   %   $	 115��5N   %    5L   %   �� *	FirstName+$ PropertyChanged=�$
 TwoWay=�5N   %   �� 5O      $��FathersName��6%   # [ 5Q   %   $	 115��5R   %    5P   %   �� *FathersName+$ PropertyChanged=�$
 TwoWay=�5R   %   �� 5S      $��PhoneNumber��6%   # [ 5U   %   $	 115��5V   %    5T   %   �� *PhoneNumber+$ PropertyChanged=�$
 TwoWay=�5V   %   �� 5W      $��Email��6%   # [ 5Y   %   $	 115��5Z   %    5X   %   �� *Email+$ PropertyChanged=�$
 TwoWay=�5Z   %   5[      5]      �� 5^   
   $��1��6    �� Orientation$ Vertical=�5_      .+�5`      �� $��Добавить��5a      #��[ 5b      ��5c      �� *OpenFormAddClientCommand+#	 [  5d      �� 5e      $��Удалить��5f      #��[ 5g      ��5h      �� *DeleteClientCommand+#	 [  ��5i      ��  �� ElementName$ 	lvClients��$
 OneWay=�5j      �� 5k      #��[ 5l      $��45��5m      ��5n      �� 5o      $#��Покупки клиента��6    $
��Wrap=�5p      5q      5s      �� 5t      #��[ 5u      $��45��5v      ��5w      �� 5x      $��Все покупки��6    $
��Wrap=�5y      5z      5|      5}      5      5�      