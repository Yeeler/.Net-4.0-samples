   M S B A M L   `   `   `  ����  	CreateXPS.    (Wrox.ProCSharp.Documents.MenuPlannerPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  DocumentPage��5      .��5	   
   �  � 	Resources 5
         	RemoveDay 
 AddDay��%�   &	        &	 K     �� 5      .R�5      �� -   5        .��5   1   -64   5      �� 5      .R�5      �� -   5        .��5   .   +61   5      5       � RowDefinitions 5      �� 5      $
��auto �6    �� 5      �� 5      $
��auto �6    .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ daySelection��5      $��0��6/      FirstDayOfWeek$ Monday=�6<      SelectedDateFormat$
 Long=�6T   $��4q�6n      Text$
 test��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	gridMenus��5      $��1��6*      AutoGenerateColumns .  	   GridLinesVisibility$
	 None=�6k   
   CanUserDeleteRows
 .     CanUserAddRows .  ��67   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$	 Day��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Day+ �� StringFormat$	 ddd��4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate# [  6-     5      # [ 6-     5       .  $
 Menu��6<      MinWidth$	 150Q�6J    6Y   �� *Menu+  5        .  $ Price��6<    6K   �� *Price+5"      �� 5#      $��2��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   .+�5$      �� -   5        $��Save Config��5$   .   $��5q�6D   $��5q�6O    � ToolTip$ Change Week Configuration��6[   �� 5%      -   5        $��
Create Doc��5%   -   $��5q�6B   $��5q�6M    �� 	IsDefault . $ Create XPS Document��6j   5&      5(      5)      