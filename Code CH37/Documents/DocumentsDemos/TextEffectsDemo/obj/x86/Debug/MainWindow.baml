   M S B A M L   `   `   `  ����  TextEffectsDemo    TextEffectsDemo.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  TextEffect Demo��5   	   $	��300��6!   $	��300��6.   .��5      ��  � Triggers 5   
   :� 5       :� RoutedEvent$ TextBlock.Loaded��6   .[�5      �� .��5	      �� .��5
      ��  g� AutoReverse .  g� RepeatBehavior$ Forever��6<    �� From$	 RedX�5   )   	 �� To$ YellowX�64    g� Duration$ 0:0:6D�6@    �� 
TargetName$ brush1��5   )   	 �� TargetProperty$	 Color�5   )   W� 5       . $ Forever��6=   
 W� From$	
 0.2X�5   *   	 W� To$ 12X�65   $ 0:0:6D�6=   $ scale1��5   *   $	 ScaleX�5   *   W� 5       . $ Forever��6=   $	
 0.2X�5   *   $ 12X�65   $ 0:0:6D�6=   $ scale1��5   *   $	 ScaleY�5   *   5      5      5      �� 5   
   $��Mangal)�6   .�6"   cn|elements x� TextEffects 5      z�  z� PositionStart$ 0��6    z� PositionCount$ 30��6/    z� 
Foreground 5      �� 5      -   5        
brush1�� �� Color$
 Blue��5   :   6I    z� 	Transform 5!      �� 5"      -   5        
scale1�� �� ScaleX$ 3Q�5"   9    �� ScaleY$ 3Q�6D   5$      .�5%      5'      5)      5+      