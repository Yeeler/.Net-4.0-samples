   M S B A M L   `   `   `  ����  BackgroundWorkerSample5    /Wrox.ProCSharp.Threading.BackgroundWorkerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  BackgroundWorker Sample��5   	   $	��300��6)   $	��300��66   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5	      �� 5
      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��5q�6   $��X:��6   $��0��6(   $��0��68   $��Center=�6E   �� 5   
   $��5q�6   $��Y:��6   $��0��6(   $��1��68   $��Center=�6E   �� 5   
   $��5q�6   $��Result:��6   $��0��6-   $��2��6=   $��Center=�6J   �� 5   
   -   5         ��Name$ textX��5      $��5q�6!   $��1��6,   $��0��6<   �� 5   
   -   5        $ textY��5      $��5q�6!   $��1��6,   $��1��6<   �� 5   
   -   5        $ 
textResult��5      $��5q�6&   $��1��61   $��2��6A   �� 5   
   -   5         ��Name$ buttonCalculate��5      $��5q�6*   $��3��65   $��0��6B   $��	Calculate��6R   6f   �� 5   
   -   5        $ buttonCancel��5      $��5q�6'   $��3��62   $��1��6?   $��Cancel��6O   {�.  6r   � 5   
   -   5         �Name$ progressBar��5      $��2��6+   $��4��6?   $��5q�6L   5      5      