   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF.Views	WPF.Views  5      -clr-namespace:WPF.ViewModelWPF.ViewModel  5          WPF.Views.Artist   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WPF.Views     5      )tclr-namespace:WPF.ViewModel     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� ��6   �� *Artist+��5      �� 5      .R�5      �� 
�������$��1q�65   $��5q�6I   ._�5      �   5      �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   �� 5   "   $
��Auto �63   .+�5      �� $��5q�6<   $��0��6G   $
��Bold"�6W   ��6(   �� *ID+6W   �� 5      $��5q�6>   $��1��6I   ��6(   �� *Name+6I   �� 5       $��5q�6C   $��2��6N   ��6(   �� *	Followers+6N   �� 5!      $��5q�6D   $��3��6O   ��6(   �� *
Popularity+6O   �� 5"      $��5q�6D   $��4��6O   ��6(   �� *
Name_Genre+6O   �� 5#      $��Delete��6%   $��5q�66   $��5��6A   ��6Q   �� *!DataContext.DeleteArtistCommand+ �� RelativeSource ��  �� AncestorType UserControl��5$   %   �� 5%      5&      5'      5)      � 5+   
   $��1��6    � RowDefinitions 5,      �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    .+�54      �� $��0��6    �� Orientation$ 
Horizontal=�6&   $��0 0 0 10q�6?   .+�55      �� $��Name:��6   $��Center=�6)   $��0 0 10 0q�6D   $
��Bold"�6V   $��16(�6h   �� 56      $	��200��60   $��Center=�6<   $��16(�6W   ��6   �� *Name+6W   57      �� 59      $��1��6   $ 
Horizontal=�6&   $��0 0 0 10q�6?   .+�5:      �� $��Popularity:��6   $��Center=�6/   $��0 0 10 0q�6J   $
��Bold"�6\   $��16(�6n   �� 5;      $	��200��66   $��Center=�6B   $��16(�6]   ��6   �� *
Popularity+6]   5<      �� 5>      $��2��6   $ 
Horizontal=�6&   $��0 0 0 10q�6?   .+�5?      �� $��	Follower:��6   $��Center=�6-   $��0 0 10 0q�6H   $
��Bold"�6Z   $��16(�6l   �� 5@      $	��200��65   $��Center=�6A   $��16(�6\   ��6   �� *	Followers+6\   5A      �� 5C      $��3��6   $ 
Horizontal=�6&   $��0 0 0 10q�6?   .+�5D      �� $��Name_Genre:��6   $��Center=�6/   $��0 0 10 0q�6J   $
��Bold"�6\   $��16(�6n   �� 5E      $	��200��65   $��Center=�6A   $��16(�6\   ��6   �� *	NameGenre+6\   5F      �� 5H      $	��Add��6   $��5q�6#   $��4��6.   ��6;   �� *AddArtistCommand+5I      5J      5K      