   M S B A M L   `   `   `  ����F  BPokemonLike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PokemonLike.MVVM.ViewPokemonLike.MVVM.View  5      G(clr-namespace:PokemonLike.MVVM.ViewModelPokemonLike.MVVM.ViewModel  5      $    PokemonLike.MVVM.View.MenuView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PokemonLike.MVVM.View     5      >	viewmodel(clr-namespace:PokemonLike.MVVM.ViewModel     5        � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius J� SnapsToDevicePixels �� Triggers P� Property	 P� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$	 150��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 10q�6'   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 5q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 20��5   !   $
 True��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5       5!      5#       5%      P� 5&       �@J�IsMouseOver$
	 True��61   . �5'      ��  � �� �#B3A12563   5)      P� 5*       � ��$
	 True��6/   . �5+      ��  � �� �#CC000063   5-      5/      50      .��52      � ��53   
   �� 54      
 �� 
StartPoint$	
 0,0&�6"    �� EndPoint$	 1,1&�63   .��56      �  � Color$ #3B4CCA��6    � Offset$	 0.0Q�6/   � 58      $ #7B98D7��6   $	 0.5Q�6/   � 5:      $ #A5C6D9��6   $	 1.0Q�6/   5<       � RowDefinitions 5?   
   �� 5@      $��2* �6   �� 5A      $��1* �6   �� 5B      $��3* �6    � ColumnDefinitions 5E   
   �� 5F      $��1* �6   �� 5G      $��1* �6   �� 5H      $��1* �6   .+�5L   
   �� $��Pokemon��6   $��60(�5M      $
��Bold"�5N      $��Segoe Print)�5O      $��Center=�5P      $��Center=�5Q      $��0��5R      $��3��5S       J� Effect 5T      3  -System.Windows.Media.Effects.DropShadowEffect  5U         ShadowDepth$ 1Q�6#      Color$ #FF0000��5V   #      Opacity$ 1Q�5W   #      
BlurRadius$ 20Q�5X   #   ��5Z      �� 5[       �� Color$ #FFDE00��6"   5^      �� 5a   
   $��36(�5b      $
��Bold"�5c      $��Segoe Print)�5d      $��Center=�5e      $��Center=�5f      $��1��5g      $��3��5h      $��	0,10,0,10q�5i      ��5a      �� *
PlayerName+ 5l        5m      $ 0Q�6#   $ #3B4CCA��5n      $	 0.8Q�5o      $ 8Q�5p      ��5t      �� 5u      $	
 0,0&�6&   $	 1,1&�67   .��5v      � $ #FFDE00��6#   $	 0.0Q�63   � 5x      $ #B3A125��6#   $	 1.0Q�63   5z      5|      � 5�   
   $��2��6   $��3��6   $��Center=�60   $��Center=�6M    5�      �� 5�      $��1* �6    �� 5�      $��1* �6     5�      �� 5�      $��1* �6#   �� 5�      $��1* �6#   .+�5�      �� $��Register��6   ���#FF0000$��0��6i   $��0��6v   ��6=   �� *NavigateRegisterCommand+6v   �� 5�      $��Login��6   ���#CC0000$��0��6c   $��1��6p   ��6:   �� *NavigateLoginCommand+6p   �� 5�      $
��Play��6   ���#B3A125$��1��6a   $��0��6n   ��69   �� *NavigateGameCommand+6n   �� 5�      $��Settings��6   ���#B5D153$��1��6h   $��1��6u   ��6=   �� *NavigateSettingCommand+6u   5�      5�      5�      