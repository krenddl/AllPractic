   M S B A M L   `   `   `  ����@  <Users, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UsersUsers  5          Users.Page1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Users     5      -   5          N� Title$  Page1��5
      .��5      � 
�������.+�5   
   � 
������� � RowDefinitions 5      �� 5      $��30 �6    �� 5      .+�5      ]� $��0��6   $��Stretch=�6%   $
��Left=�6A   .+�5      �� -   5        $��0��5      $	��Add��6&   $
��Left=�64   $��Stretch=�6O   $��35��6k   6�   �� 5      -   5        $��0��5      $
��Edit��6&   $
��Left=�65   $��Stretch=�6P   $��35��6l   6�   �� 5      -   5        $��0��5      $��Remove��6&   $
��Left=�67   $��Stretch=�6R   $��50��6n   6�   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	UsersGrid��5      $��1��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *ID+  5      $
 Name��6)   $ * 67    6A   �� *Name+  5      $ RoleID��6)   $ * 69    6C   �� *RoleID+  5      $
 Role��6)   $ * 67    6A   �� *
Role.Role1+5!      5"      5$      5%      