   M S B A M L   `   `   `  ����D  @BooksDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Wrox.ProCSharp.WPF.DataWrox.ProCSharp.WPF.Data  5      K*clr-namespace:Wrox.ProCSharp.WPF.UtilitiesWrox.ProCSharp.WPF.Utilities  5           Wrox.ProCSharp.WPF.BooksUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Wrox.ProCSharp.WPF.Data     5      <utils*clr-namespace:Wrox.ProCSharp.WPF.Utilities     5        � 	Resources  5
      7  1Wrox.ProCSharp.WPF.Utilities.StringArrayConverter   stringArrayConverter7   1Wrox.ProCSharp.WPF.Utilities.BookTemplateSelector  bookTemplateSelector 	 books S� 
ObjectType)   #Wrox.ProCSharp.WPF.Data.BookFactory S� 
MethodName  wroxTemplate �� DataType"   Wrox.ProCSharp.WPF.Data.Book �� Padding  dummiesTemplate  bookTemplate��%�  &	        &	      &	 &     &	 R     &	 !    &	 �      5   
   6%     5   
   6%   S� 5   
   "  6+   $ GetBooks��6J   �� 5   
   "  6,   .R�5      �� 
���  ��$��10q�6&   $ 10q�62   ._�5      �� .+�5      �� ��6   �� *Title+�� 5      ��6   �� *	Publisher+5      5      5      �� 5   
   "  6/   .R�5      �� 
��� ���$��10q�6)   $ 10q�65   ._�5      �� .+�5      �� ��6   �� *Title+�� 5      ��6   �� *	Publisher+5      5      5      �� 5!   
   "  6,   .R�5"      �� 
����ح�$��10q�6,   $ 10q�68   ._�5#      �� .+�5$      �� ��6   �� *Title+�� 5%      ��6   �� *	Publisher+5&      5'      5(      5)      .��5*      ]�  � DataContext# [ 6   .+�5+   
   ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6F   .+�5,      �� -   5        $��5q�5,      $��4q�6    $��Add Book��6,   6?   5-      �� 5.   
   $
��Left=�6   $��5q�6@   $	��120��6K   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6Z   #��[ 6   ��6(   �� 5/      � 50   
    � RowDefinitions 51      �� 52      �� 53      �� 54      �� 55      	 � ColumnDefinitions	 57      �� 58      $
��Auto �6#   �� 59      $��* �6#   .+�5;      �� $��Title��6   $��0��6$   $��0��61   $��10,0,5,0q�6A   $
��Left=�6S   $��Center=�6n   �� 5<      $��	Publisher��6   $��1��6(   $��0��65   $��10,0,5,0q�6E   $
��Left=�6W   $��Center=�6r   �� 5=      $
��Isbn��6   $��2��6#   $��0��60   $��10,0,5,0q�6@   $
��Left=�6R   $��Center=�6m   �� 5>      $��Authors��6   $��3��6&   $��0��63   $��10,0,5,0q�6C   $
��Left=�6U   $��Center=�6p   �� 5?      $��0��6.   $��1��6;   $��5q�6K   ��6   �� *Title+6K   �� 5@      $��1��61   $��1��6>   $��5q�6N   ��6   �� *	Publisher+6N   �� 5A      $��2��6,   $��1��69   $��5q�6I   ��6   �� *Isbn+6I   �� 5B      $��3��6|   $��1��6�   $��5q�6�   $��Center=�6�   $
��Wrap=�6�   ��6   �� *	Authors+
 �� 	Converter#
 [   �� ConverterParameter$ , ��6�   5C      5D      5E      