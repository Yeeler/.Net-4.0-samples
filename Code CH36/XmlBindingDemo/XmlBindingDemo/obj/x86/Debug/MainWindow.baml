   M S B A M L   `   `   `  ����  XmlBindingDemo    XmlBindingDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Main Window��5   	   $	��240��6   $	��500��6*    � 	Resources 5       	  books � Source � XPath  listTemplate �� XPath  
labelStyle �� 
TargetType �� Property �� Value��%$  &	        &	 4     &	 v     � 5   
   $ 	Books.xml?�6(   $ Books��6;   �� 5   
   .R�5      �� ��6   �� $ Title��5	      �� 5   
   " ��6#   .�5      ��  � ��$	 190��6&   �� 5       � ��$ 40��6'   �� 5       � ��$ 5q�6'   5      5      .��5      �  � DataContext 6   �� 	 �� Source#	 [  $
 Book��
 � RowDefinitions
 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $ �� IsSynchronizedWithCurrentItem$
 TrueY�6   $��5q�67   $��0��5      $��4��6   #��[ 5       ��5   ,   �� 5       �� 5"   
   #��[ 6   $��0��5#      $��1��6   ��5"   5   �� $ Title��5#      �� 5$   
   #��[ 6   $��1��5&      $��1��6   ��5%      �� $ 	Publisher��5&      �� 5'   
   #��[ 6   $��2��5)      $��1��6   ��5(      �� $ @isbn��5)      5+      5,      