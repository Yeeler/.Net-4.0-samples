   M S B A M L   `   `   `  ����  WebRequestClient8    2Wrox.ProCSharp.DataServices.WebRequestClientWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Web Request Client��5   	   $	��300��6$   $	��500��61   .��5      ]� .+�5   
   � $	��Top=�6    � RowDefinitions 5      �� 5      �� 5	       � ColumnDefinitions 5      �� 5      $��* �6#   $��65��6-   �� 5      $��3* �6#   �� 5      $��2* �6#   .+�5      �� $��0��6   $��0��6$   $
��Url:��61   �� 5      -   5         ��Name$ textUrl��5      $��2��6'   $��0��6;   $��1��6H   $��4q�6Y   $)��#http://localhost:9000/Samples/Menus��6d   �� 5       �� Orientation$ 
Horizontal=�6   $��0��62   $��1��6B   $��2��6O   .+�5      �� -   5         ��Name$ 	checkJSON��5      $
��JSON��6.   $��Center=�6=   $��5q�6X   �� 5      -   5        $ 	checkPOST��5      $
��POST��6.   $��Center=�6=   $��5q�6X   5      �� 5      -   5        $��5q�5      $��1��62   $��2��6?   $��Call Data Service��6O   5      � 5   
    5      �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� -   5        $ 	textInput��5   >    �� AcceptsReturn .  �� 
AcceptsTab . $��0��6Q   {�6b   ��  �� Path$ 	IsChecked�	 �� ElementName$	 checkPUT���� 5       $��2q�6   
����ح�$��Center=�6=   $��Stretch=�6[   $��5��6w   
 �� ShowsPreview
 .  K� ZIndex$ 1��6�   $��1��6�   �� 5!      $
��Auto=�6   $��2��6>   .��5#      �� -   5        $ 
textResult��5#   %   $��5q�6    �� 
IsReadOnly . 69   5$      5%      5&      5(      