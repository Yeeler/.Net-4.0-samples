   M S B A M L   `   `   `  ����  SyndicationReader8    2Wrox.ProCSharp.Syndication.SyndicationReaderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $	��300��5   +   $	��450��68     � Title  6	   ��  �� Path$ 
Title.Text�.��5      ]� -   5         ]�Name$ feedContent��5      .+�5   
   � $	��Top=�6    � ColumnDefinitions 5      �� 5	      $��50 �6#   �� 5
      $��* �6#   �� 5      $��90 �6#   .+�5      �� $��0��6   $��5q�6$   .��6/   URL:65   �� 5      -   5         ��Name$ textUrl��5   &   $��1��6   $	��150��67   $��5q�6F   .��6Q   /-http://blogs.thinktecture.com/cnagel/rss.aspx5      �� 5      -   5        $��2��5      $��5q�6%   $��80��60   .��5   '   
Get Feed61   5      �� 5   
   -   5         ��Name$ heading��5   Y    �� Orientation$ Vertical=�6   $	��Top=�6,   
������.+�5      �� $��16(�68   ��6   �� $ 
Title.Text�68   �� 5      ��6   �� $ Description.Text�5      �� 5   
   $	��120��6   $
��Left=�6"      listTitleStyle#��[  5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      $��Stretch=�67   ��5   8   �� 5   7   ]� 5   
   -   5        $ content��5      .+�5      �� $	��Top=�6   ��6)   �� *Description.Text+ � 5        � Source 6   �� $ Links[0].Uri�5      5       5!      