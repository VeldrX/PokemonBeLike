   M S B A M L   `   `   `  ����F  BPokemonLike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PokemonLike.MVVM.ViewPokemonLike.MVVM.View  5      G(clr-namespace:PokemonLike.MVVM.ViewModelPokemonLike.MVVM.ViewModel  5      $    PokemonLike.MVVM.View.GameView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PokemonLike.MVVM.View     5      >	viewmodel(clr-namespace:PokemonLike.MVVM.ViewModel     5      .��5      � ���#2C3E50.+�5   
   �� $
��Left=�6   $	��Top=�60   $��10q�6H     �� Orientation$  Vertical=�6T   .+�5      �� $��PokeDex��6   $	��120��6'   $��5q�63   ���#1ABC9C
�������
������ $��1q�5   W   ��5   >   �� *NavigatePokemonListCommand+5   W   �� 5      $��
AbilityDex��6   $	��120��6*   $��5q�66   ���#1ABC9C
�������
������ $��1q�5   W   ��5   A   �� *NavigateAbilityListCommand+5   W   �� 5      $
��Menu��6   $	��120��6$   $��5q�60   ���#1ABC9C
�������
������ $��1q�5   W   ��5   ;   �� *NavigateMenuCommand+5   W   5      � 5   
   $��Center=�6   $��Center=�6,   $��10,10,10,80q�6G    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5       �� $��0��6   $��Center=�6)   $��Center=�6F   $��10q�6a   .+�5!      �� $��Votre Pokémon:��6   $��16(�62   
�������$��Center=�6S   �� 5"      $��18(�6B   $
��Bold"�6P   
�������$��Center=�6u   ��6   �� *MonsterOfPlayer.Name+6u   �� 5#      $��HP Restants:��6   $��16(�60   
�������$��Center=�6Q   �� 5$      $��16(�6   
�������$��Center=�6=   �� 5%      �6   �� *MonsterOfPlayerCurrentHP+ �� 5&      $	� / ��6    �� 5'      �6   �� *MonsterOfPlayerHP+5(      5)      �� 5,      $��VS��6   $��40(�6"   $
��Bold"�60   ���#E74C3C$��Center=�6W   $��Center=�6t   $��1��6�   $��10q�6�   �� 5/      $��2��6   $��Center=�6)   $��Center=�6F   $��10q�6a   .+�50      �� $��Ennemi Pokémon:��6   $��16(�63   
�������$��Center=�6T   �� 51      $��18(�6B   $
��Bold"�6P   
�������$��Center=�6u   ��6   �� *MonsterOfEnnemy.Name+6u   �� 52      $��HP Restants:��6   $��16(�60   
�������$��Center=�6Q   �� 53      $��16(�6   
�������$��Center=�6=   �� 54      �6   �� *MonsterOfEnnemyCurrentHP+ �� 55      $	� / ��6    �� 56      �6   �� *MonsterOfEnnemyHP+57      58      59      �� 5<   
   $��Center=�6   $��Bottom=�62   $��
10,0,10,40q�6M   $  Vertical=�6a   .+�5=      �� $��Relancer un Combat��6   $	��200��62   $��5q�6>   ���#3498DB
�������
������ $��1q�5>   K   ��5=   I   �� *RestartBattleCommand+5>   K   5@      �� 5B   
   $��Right=�6   $��Center=�61   $��10q�6L   .+�5C      �� $��Journal de Combat :��6   $��16(�63   
�������6A   �� 5D      $��14(�63   
�������$
��Wrap=�6T   $	��150��6h   ��6   �� *	BattleLog+6h   5E      � 5J   
   $��Center=�6   $��Bottom=�6,   $��
10,0,10,80q�6G    � RowDefinitions 5K      �� 5L      $��* �6    �� 5M      $��* �6     5O      �� 5P      $��* �6#   �� 5Q      $��* �6#   .+�5U      �� $	��120��5V      $��25��6   $��5q�6%   $��0��5W      $��0��6   ���#9B59B6
�������
������ $��1q�5Z   O   ��5U      �� *MonsterOfPlayerSpells[0].Name+��5X      �� *UseSkillCommand+��5Y      �� *MonsterOfPlayerSpells[0]+5Z   O   �� 5]      $	��120��5^      $��25��6   $��5q�6%   $��0��5_      $��1��6   ���#9B59B6
�������
������ $��1q�5b   O   ��5]      �� *MonsterOfPlayerSpells[1].Name+��5`      �� *UseSkillCommand+��5a      �� *MonsterOfPlayerSpells[1]+5b   O   �� 5e      $	��120��5f      $��25��6   $��5q�6%   $��1��5g      $��0��6   ���#9B59B6
�������
������ $��1q�5j   O   ��5e      �� *MonsterOfPlayerSpells[2].Name+��5h      �� *UseSkillCommand+��5i      �� *MonsterOfPlayerSpells[2]+5j   O   �� 5m      $	��120��5n      $��25��6   $��5q�6%   $��1��5o      $��1��6   ���#9B59B6
�������
������ $��1q�5r   O   ��5m      �� *MonsterOfPlayerSpells[3].Name+��5p      �� *UseSkillCommand+��5q      �� *MonsterOfPlayerSpells[3]+5r   O   5s      �� 5v   
   $��Right=�6   $	��Top=�61   $��10q�6I   .+�5w      �� $��Score: ��6   $��16(�6'   
�������$��Right=�6H   �� 5x      $��16(�6/   $
��Bold"�6=   
�������$��Right=�6b   $��10q�6~   ��6   �� *Score+6~   5y      5{      5|      