   M S B A M L   `   `   `  ����F  BPokemonLike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PokemonLike.MVVM.ViewPokemonLike.MVVM.View  5      G(clr-namespace:PokemonLike.MVVM.ViewModelPokemonLike.MVVM.ViewModel  5      '    !PokemonLike.MVVM.View.SettingView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PokemonLike.MVVM.View     5      >	viewmodel(clr-namespace:PokemonLike.MVVM.ViewModel     5        � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius J� SnapsToDevicePixels �� Triggers P� Property	 P� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$	 150��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 10q�6'   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 5q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 20��5   !   $
 True��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5      5       5"       5$      P� 5%       �@J�IsMouseOver$
	 True��61   . �5&      ��  � �� �#FF572263   5(      P� 5)       � ��$
	 True��6/   . �5*      ��  � �� �#D32F2F63   5,      5.      5/      .��51      � ��52   
   �� 53      
 �� 
StartPoint$	
 0,0&�6"    �� EndPoint$	 1,1&�63   .��54      �  � Color$ #2196F3��6    � Offset$	 0.0Q�6/   � 56      $ #BBDEFB��6   $	 0.5Q�6/   � 58      $ #64B5F6��6   $	 1.0Q�6/   5:       � RowDefinitions 5=   
   �� 5>      $
��Auto �6   �� 5@      $
��Auto �6   �� 5B      $
��Auto �6   �� 5D      $
��Auto �6   �� 5F      $��* �6    � ColumnDefinitions 5J   
   �� 5K      $��* �6   �� 5L      $
��Auto �6   �� 5M      $
��Auto �6   �� 5N      $��* �6   .+�5R   
   �� $
��Menu��6   $��0��5T      $��1��5U      $��2��5V      $��Center=�5W      ���#FF5722
���������5S      �� *NavigateMenuCommand+5Y      �� 5\   
   $��
Current : ��6   $��Center=�5]      $��12(�5^      $��10q�5_      $��1��5`      $��1��5a      $��Right=�5b      
���   �5c      �� 5e   
   $��Center=�5f      $��12(�5g      $��10q�5h      $��1��5i      $��2��5j      $
��Left=�5k      
���   ���5e      �� *CurrentConnectionDisplay+5l      �� 5o   
   -   5         ��Name$ URLBox��5o      $	��250��5p      $��30��5q      $��10q�5r      $��2��5s      $��1��5t      $��2��5u      ���#FFFFFF���#2196F3��5v      �� *DatabaseConnection+ �� UpdateSourceTrigger$ PropertyChanged=�5x      �� 5{   
   $
��Save��6   $	��150��5|      $��50��5}      $��10q�5~      $��3��5�      $��2��5�      $��1��5�      $��Center=�5�      ���#4CAF50
���������5      �� *SaveCommand+5�      5�      5�      