   M S B A M L   `   `   `  ����D  @BooksDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Wrox.ProCSharp.WPFWrox.ProCSharp.WPF  5   	   #    Wrox.ProCSharp.WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2local clr-namespace:Wrox.ProCSharp.WPF     5   	     � Title$  Main Window��5   	   $	��400��6   $	��600��6*    � 	Resources 5         tabItemButtonStyle �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint � Offset � Color	 �� Angle
 �� CenterX �� CenterY��%�  &	        �� 5   
   " ��6+   .�5      ��  � �� 5	      �� 5
      .R�5      � .+�5      A� $��20��6&   $��20��61   ��5   "   �� 5   &   $	 1,0&�6:   $ 0.2,1&�6K   .��5   *   � $ 0Q�67   $ 
LightGreen��6B   � 5   *   $	 0.6Q�67   $ Green��6D   � 5   *   $ 1Q�67   $ 	DarkGreen��6B   5   '   5      A� 5      
��� ���$��16��64   $��3��6?   z�5   "   �� 5   &   $	 45Q�66   $
 8Q�6A   $	 1.5Q�6M   5      A� 5      
��� ���$��16��64   $��3��6?   z�5   "   �� 5   &   $		 -45Q�66   $
 8Q�6B   $	 1.5Q�6N   5      5      5       5"      5#      5$       J� CommandBindings 5%      )  #System.Windows.Input.CommandBinding  5&   
   -   5           Command$ ApplicationCommands.Close��5&      6=     5'   
   -   5        $" local:BooksCommands.ShowBook��5'      6@   .��5)      ]� .+�5*   
   o� $	��Top=�6   .@�5+      m� $��_File��6   .@�5,      m� $��_Show Books��6    m� Command$# local:BooksCommands.ShowBooks��60   �� 5-      m� 5.      $��E_xit��6   $ ApplicationCommands.Close��6*   5/      m� 50      $��_Edit��6   .@�51      m� $
��Undo��6   $ ApplicationCommands.Undo��6)   �� 52      m� 53      $	��Cut��6   $ ApplicationCommands.Cut��6(   m� 54      $
��Copy��6   $ ApplicationCommands.Copy��6)   m� 55      $��Pastee��6   $ ApplicationCommands.Paste��6+   56      57      c� 58   
   $	��Top=�6   5:      �� 5;   
   $
��Left=�6   $��5q�6(   $	��120��63   .@�5=      �� -   5        .�5=   /   	Show Book6:   �� 5?      -   5        .�5?   0   
Show Books6<   �� 5@      -   5        .�5@   +   	Show Grid66   5B      �� 5C   
   -   5         ��Name$ tabControl1��5C       $��5q�6   6    5D      5E      