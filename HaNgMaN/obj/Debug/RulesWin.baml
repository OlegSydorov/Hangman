   M S B A M L   `   `   `  ����B  >HaNgMaN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HaNgMaNHaNgMaN  5   	       HaNgMaN.RulesWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HaNgMaN     5   	     � Title$  RulesWin��5   	   $	��450��6   $	��800��6'    � WindowStyle$
 None=�63    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\    � 	Resources 5	         buttonTemplate �� 
TargetType ��Name �� RadiusX �� RadiusY	 �� Color
 J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity   
BlurRadius   Color �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value �� ScaleX �� ScaleY N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions :� RoutedEvent g� AutoReverse g� RepeatBehavior	 �� To��%�  &	        �� 5
   
   " ��61   .R�5      � .+�5      �� $ rect1��6   $ 20��6+   $ 20��68   
�������#��z��6T   #��z��6{   $��2��6�   ��5      �� 5      MyAnimatedBrush��$	 Transparent��6C   
 5        5      shadow1��$ 1Q�6<   $ 10Q�6H   $ Yellow��6X   5      �� 5      #��z��6#   $��Center=�6M   $��Center=�6j   #��z��6�   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ rect1��6    � ��
 ����6@   5      P� 5       � �� . . �5      ��  � z� 5      �� 5       $	 0.9Q�6-   $	 0.9Q�6:   5"      �� 5#       �@J�RenderTransformOrigin$ .5,.5&�6>   �� 5%      $ rect1��6    � ��
 � d �6@    5&      �� 5'      .��5(      �� .��5)   "   W� $ shadow1��62   $ 
BlurRadius�5*   2   $ 40X�5+   2   $ 0:0:0.1D�6:   5,      5-       50      �� 51      .��52      �� .��53   "   W� $ shadow1��62   $ 
BlurRadius�54   2   $ 10X�55   2   $ 0:0:0.1D�6:   56      57      59      :� 5;      $ Button.Loaded��6   .[�5<      �� .��5=      �� .��5>      W� $ shadow1��6.   $ 
BlurRadius�5?   2   $ 40X�5@   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5B      $ shadow1��6-   $ Color�5C   -   $ 	DarkGreenX�5D   2    . $ Forever��6T   $ 0:0:2D�6m   5E      5F      5G      5J      5L      .��5M      � .+�5N   
   �� 
��� d �$��5q�6)   ._�5O      � .+�5P      �� -   5          ��Name$  tBlock��5P      
���2�2�$��20, 20, 20, 20q�6C   $��Bodoni MT Black)�6[   $��25(�6x   
�������$
��Wrap=�6�   
 5Q        5R      -   5        shadow1��!   ShadowDepth$! 10Q�5R   8   $ 20Q�6I   $ 	DarkGreen��6Y   "   RenderingBias$" Performance=�6k   # � Triggers# 5T      :� 5U      $ TextBlock.Loaded��6#   .[�5V      �� .��5W      �� .��5X   "   W� $ shadow1��62   $ 
BlurRadius�5Y   2   $ 40X�5Z   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5\   "   $ shadow1��61   $ Color�5]   -   $ YellowX�5^   2    . $ Forever��6Q   $ 0:0:2D�6j   5_      5`      5a      5c      �� 5d      -   5        $ ��Name$$ okButton��5d      $��OK��6+   
�������$��30(�6L   $��Bodoni MT Black)�6Z   $��350, 340, 300, 5q�6w   #��[  6�   $��83��6�   $��41��6�   6�   5e      5f      5h      5i      