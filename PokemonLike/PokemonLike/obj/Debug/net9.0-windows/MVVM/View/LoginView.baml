   M S B A M L   `   `   `  ����F  BPokemonLike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PokemonLike.MVVM.ViewPokemonLike.MVVM.View  5      G(clr-namespace:PokemonLike.MVVM.ViewModelPokemonLike.MVVM.ViewModel  5      %    PokemonLike.MVVM.View.LoginView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PokemonLike.MVVM.View     5      >	viewmodel(clr-namespace:PokemonLike.MVVM.ViewModel     5        � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius J� SnapsToDevicePixels �� Triggers P� Property	 P� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$	 150��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 10q�6'   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 5q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 20��5   !   $
 True��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5       5!      5#       5%      P� 5&       �@J�IsMouseOver$
	 True��61   . �5'      ��  � �� �#FFDE0063   5)      P� 5*       � ��$
	 True��6/   . �5+      ��  � �� �#CC000063   5-      5/      50      .��53      � ��54   
   �� 55      
 �� 
StartPoint$	
 0,0&�6"    �� EndPoint$	 1,1&�63   .��56      �  � Color$ #3B4CCA��6    � Offset$	 0.0Q�6/   � 58      $ #77afb6��6   $	 0.5Q�6/   � 5:      $ #A5C6D9��6   $	 1.0Q�6/   5<       � RowDefinitions 5@   
   �� 5A      $��* �6   �� 5B      $
��Auto �6   �� 5C      $
��Auto �6   �� 5D      $
��Auto �6   �� 5E      $��* �6    � ColumnDefinitions 5H   
   �� 5I      $��* �6   �� 5J      $
��Auto �6   �� 5K      $
��Auto �6   �� 5L      $��* �6   .+�5P   
   �� $��Retour��6   $
��Left=�5R      $	��Top=�5S      $��20q�5T      $��70��5U      ���#FF0000
���������5Q      �� *NavigateToMenuCommand+5W      �� 5Z      $��	Username:��6   $��Center=�6)   $��16(�6D   $��10q�6R   $��1��5[      $��1��6!   $��Right=�61   �� 5\      -   5         ��Name$ UsernameTextBox��5\      $	��200��6/   $��30��6;   $��10q�6G   $��1��5]   Q   $��2��6^   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6^   �� 5`      $��	Password:��6   $��Center=�6)   $��16(�6D   $��10q�6R   $��2��5a      $��1��6!   $��Right=�61   G� 5b      -   5         G�Name$ PasswordBox��5b   >   $	��200��6   $��30��6&   $��10q�62   $��2��5c      $��2��6#   63   �� 5f      $��Login��6   $	��100��6%   $��30��61   $��10q�6=   $��3��5h      $��2��6   $��1��62   $��Center=�5i      ���#FFDE00
���   ���5g      �� *LoginCommand+5i   C   5j      5k      