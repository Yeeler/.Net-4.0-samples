   M S B A M L   `   `   `  ����D  @BooksDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Wrox.ProCSharp.WPF.DataWrox.ProCSharp.WPF.Data  5          Wrox.ProCSharp.WPF.BookUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Wrox.ProCSharp.WPF.Data     5      .��5	      ]�   � 	Resources  5
   
      theBook S� 
ObjectType)   #Wrox.ProCSharp.WPF.Data.BookFactory S� 
MethodName��%8   &	        S� 5      "  61   $ 
GetTheBook��6P   5      .+�5   
   �� $��Bottom=�6    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   .+�5      �� $��Resize��6   �� 5      -   5         ��Name$ slider1��5       � Value$ 1Q�6&    � Minimum$	 0.4Q�60    � Maximum$ 3Q�6>   $	��150��6J   $��Right=�6V   5      � 5   
   -   5         �Name$ grid1��5      	 � DataContext#	 [  6   
 � LayoutTransform
 5      �� 5      -   5        
scale1�� �� ScaleX 5   1   ��  �� Path$ Value� �� ElementName$ slider1�� �� ScaleY 6d   �� $ Value�$ slider1�� � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5       �� $��Title��6   $��0��6$   $��0��61   $��10,0,5,0q�6A   $
��Left=�6S   $��Center=�6n   �� 5!      $��	Publisher��6   $��1��6(   $��0��65   $��10,0,5,0q�6E   $
��Left=�6W   $��Center=�6r   �� 5"      $
��Isbn��6   $��2��6#   $��0��60   $��10,0,5,0q�6@   $
��Left=�6R   $��Center=�6m   �� 5#      $��0��6.   $��1��6;   $��5q�6K   ��6   �� *Title+6K   �� 5$      $��1��61   $��1��6>   $��5q�6N   ��6   �� *	Publisher+6N   �� 5%      $��2��6,   $��1��69   $��5q�6I   ��6   �� *Isbn+6I   �� 5&      $��3��6   $��0��6&   $��2��66   $ 
Horizontal=�6J   $��Center=�6c   .+�5'      �� -   5        $��	Show Book��5'      $��5q�6-   68   �� 5(      -   5        $��Change Book��5(      $��5q�6/   6:   5)      5*      5+      5,      