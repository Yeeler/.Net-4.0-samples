   M S B A M L   `   `   `  ����D  @BooksDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Wrox.ProCSharp.WPF.DataWrox.ProCSharp.WPF.Data  5      #    Wrox.ProCSharp.WPF.DataGridUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Wrox.ProCSharp.WPF.Data     5        � 	Resources  5	       	  books S� 
ObjectType)   #Wrox.ProCSharp.WPF.Data.BookFactory S� 
MethodName  	booksView �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%�   &	        &	 ,     7   S� 5
   
   "  6+   $ GetBooks��6J   �� 5   
   8    5        5      $ 	Publisher��6+   5      5      .��5      �  � DataContext# [ 6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5        	 ��Name$	 IsGroupStyle��5   "   $��5q�6   .��6m   Group Style5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 grid1��5      $��1��6"      CanUserAddRows .    CanUserSortColumns .    AutoGenerateColumns .    AlternatingRowBackground �	#FFD4D09E J� 	AllowDrop .    HeadersVisibility$	 All=�6�      GridLinesVisibility$	 All=�6�   ��6/   ��  �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5         ContainerStyle 5      �� 5       �� 
TargetType" ��6    .�5       ��  �� Property � �� �� Value 5!   "   �� 5"   &    �� 
TargetType" ��66   .R�5#   *   9�  9� 
IsExpanded .  
���������5$   .   �� 5%   2   $ 
Horizontal=�6=   .+�5&   6   �� ��6<   ��  �� Path$
 Name��� 5'   6   ��6<   �� $ 	ItemCount�5(   3   ��5*   .   �� 5+   2   5-   +   5/   '   51      52      55         Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ 	Publisher�  59      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6D    6%   �� $ Title�6D     5:      $
 ISBN��6C    6%   �� $
 Isbn�6C   5=      5?      5@      