   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      G CFormula1Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Formula1DemoFormula1Demo 5      !   Formula1Demo.GridGroupingUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      ,localclr-namespace:Formula1Demo     5      .��5
      �   � 	Resources  5   
     Formula1Demo.IntToString   intToStringConverter  Formula1Demo.Int32ToDouble  intToDoubleConverter 	 races S� 
ObjectType  Formula1Demo.F1Races S� 
MethodName S� MethodParameters  
viewSource �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%/  &	        &	      &	 &     &	 �     7    5      6      5      6"   S� 5      "  6/   $ GetRaces��6S    5      ��5      0��6#   ��5      20��6$   5      �� 5      8    5        5      $
 Year��6/     5      $ Country��6/   5      5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5       �� $��5q�6   	 �� Padding$	 4q�6#   $��Center=�6/   Page:6Q   �� 5!      -   5        
 ��Name$
 textPageNumber��5!   H   $��5q�6   $��4q�6!   $��Center=�6-   $��0��6`   �� 5"      -   5        .��5"   '   
Get Page61   5#      (� 5$   
   $��1��6    (� Stretch$
 Fill=�6   .��5%      &   System.Windows.Controls.DataGrid   � IsSharedSizeScope .  � DataContext# [ 65      AutoGenerateColumns .  ��6_   ��    Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Position��6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
Position+ �� Mode$ OneWay=�6S     5(      $ Racer��6P    6)   �� *Racer+$ OneWay=�6P      RowDetailsTemplate 5*      �� 5+      .R�5,      �� $ 
Horizontal=�6%   .+�5-      �� $
��Car:��6(   $��5,0,0,0q�64   �� 5.      $��5,0,0,0q�6=   ��6(   �� *Car+6=   �� 5/      $��Points:��6(   $��5,0,0,0q�67   �� 50      ��6(   �� *Points+51      52       �� 
GroupStyle 54      (	  "System.Windows.Controls.GroupStyle	  55       	  ContainerStyle 56      �� 57       �� 
TargetType" ��6$   .�58   "   ��  �� Property � �� �� Value 59   &   �� 5:   *   .R�5;   .   �� $ 
Horizontal=�69   .+�5<   2   �  � ColumnDefinitions 5=   6   �� 5>   :    z� SharedSizeGroup$ 
LeftColumn��6K   �� 5?   :   �� 5@   :   .+�5B   6   �� $��0��6<   
��� �����6`   �� *Name+�� 5C   6   $��1��6<   ��6L   �� *	ItemCount+� 5D   6   $��2��6;   $��Center=�6K   $��Center=�6h   .+�5E   :   �� 5F   7   5G   3   5I   /   5J   +   5L   #   5M      5O      5S      5T      5U      5V      