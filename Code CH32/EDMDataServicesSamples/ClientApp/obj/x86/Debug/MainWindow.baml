   M S B A M L   `   `   `  ����  	ClientApp,    &Wrox.ProCSharp.DataServices.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Restaurant��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $��5 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ comboCategories��5      $��0��6,    �� SelectedIndex$ 0��6a   ��69   ��  �� Path$ 
Categories���5      �� 5      .R�5      �� ��6    �� $
 Name�5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5      �� -   5        $��Add Menu��5      $��5q�6:   $��4q�6E   �� 5      -   5        $��Show Entities��5      $��5q�6D   $��4q�6O   �� 5      -   5        $
��Save��5      $��5q�63   $��4q�6>   �� 5      -   5        $
��Exit��5      $��5q�63   $��4q�6>   5      &   System.Windows.Controls.DataGrid  5   
   $��2��6      AutoGenerateColumns .  ��6    �� $ Menus�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $
 Name�  5       6%   �� $ Description�  5       6%   �� $ Price�  5        6%   �� $ 
CategoryId�5#      �� 5$   
   $��3��6   $��Center=�6$   $��Stretch=�6?   
����ح�	 �� ShowsPreview	 . 
 K� ZIndex$
 1��6�   $��5��6�   �� 5%   
   $
��Auto=�6   $��4��6:   .��5&      �� -   5         ��Name$ 
textStatus��5&      5'      5)      5*      