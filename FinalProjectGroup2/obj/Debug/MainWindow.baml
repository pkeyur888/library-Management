   M S B A M L   `   `   `  ����M  IFinalProjectGroup2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalProjectGroup2FinalProjectGroup2  5   	   #    FinalProjectGroup2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FinalProjectGroup2     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��950��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$? 9Resources\book-frame-seamless-looping-vector-26577287.jpg��6    j� Stretch$ UniformToFill=�6a    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5       $��2* �6   �� 5!      $��2* �6   �� 5"      $��2* �6   �� 5#      $��2* �6   �� 5$      $��2* �6   �� 5%      $��1* �6   .+�5(   
   �� $��Library Management��6   $��1��6-   $��0��6:   $��9��6J   $	��Top=�6_   $��Center=�6w   
���**��$	��500��6�   $��35(�6�   
���   �$��6q�6�   
�������6�   &   System.Windows.Controls.DataGrid  5*   
   -   5        $��	mediaData��5*      $��2��6$   $��3��61   $��4��6A   $��4��6U      AutoGenerateColumns .  $��6q�6�   
���   �   AlternatingRowBackground
 �����$��14(�6�      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6Z   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *Title+ �� Mode$ OneWay=�6Z     5-      $ 
Media Type��6%   $	 1* 6c   
 69   �� *	MediaType+$ OneWay=�6c   4  .System.Windows.Controls.DataGridCheckBoxColumn  5.      $ Lent ?��6)   $	 1* 6h   
 69   �� *CurrentStatus+$ OneWay=�6h     5/      $ 	Borrowed ��6%   $	 1* 6l   
 68   �� *CurrentBorrowMember+$ OneWay=�6l   51        53   
   -   5        $��
memberData��53      $��3��6%   $��2��62   $��2��6B   $��1��6S    .  $��5q�6�   
 �����$��17(�6�   
���   � 54        55      $ Member��6%   $	 1* 6Z   
 65   �� *Name+$ OneWay=�6Z   57      �� 58   
   -   5        $��
lentButton��58      $
��Lent��6#   $��2��63   $��2��6D   $��4q�6j   
���   �$��15(�6�   $
��Bold"�6�   �� 59   
   -   5        $��returnButton��59      $��Return��6%   $��2��66   $��5��6F   $��4q�6n   
���   �$��15(�6�   $
��Bold"�6�   5;      5<      