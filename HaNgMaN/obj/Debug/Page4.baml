   M S B A M L   `   `   `  ����B  >HaNgMaN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HaNgMaNHaNgMaN  5          HaNgMaN.Page4   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:HaNgMaN     5        N� Title$  Page4��5	       � 	Resources 5         buttonTemplate �� 
TargetType ��Name �� RadiusX �� RadiusY �� Color J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity	   
BlurRadius
   Color �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value �� ScaleX �� ScaleY N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions :� RoutedEvent g� AutoReverse g� RepeatBehavior	 �� To��%�  &	        �� 5   
   " ��61   .R�5      � .+�5      �� $ rect1��6   $ 20��6+   $ 20��68   
�������#��z��6T   #��z��6{   $��2��6�   ��5      �� 5      MyAnimatedBrush��$ Transparent��6C    5        5      shadow1��$ 1Q�6<   $	 10Q�6H   $
 Yellow��6X   5      �� 5      #��z��6#   $��Center=�6M   $��Center=�6j   #��z��6�   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ rect1��6    � ��
 ����6@   5      P� 5       � �� . . �5       ��  � z� 5!      �� 5"      $	 0.9Q�6-   $	 0.9Q�6:   5$      �� 5%       �@J�RenderTransformOrigin$ .5,.5&�6>   �� 5'      $ rect1��6    � ��
 � d �6@    5(      �� 5)      .��5*      �� .��5+   "   W� $ shadow1��62   $ 
BlurRadius�5,   2   $ 40X�5-   2   $ 0:0:0.1D�6:   5.      5/       52      �� 53      .��54      �� .��55   "   W� $ shadow1��62   $ 
BlurRadius�56   2   $ 10X�57   2   $ 0:0:0.1D�6:   58      59      5;      :� 5=      $ Button.Loaded��6   .[�5>      �� .��5?      �� .��5@      W� $ shadow1��6.   $ 
BlurRadius�5A   2   $ 40X�5B   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5D      $ shadow1��6-   $ Color�5E   -   $ 	DarkGreenX�5F   2    . $ Forever��6T   $ 0:0:2D�6m   5G      5H      5I      5L      5N      .��5O      � 
�������.+�5P   
   �� 
��� d �$��5q�6)   ._�5Q      � .+�5R      �� -   5         ��Name$ tBlock��5R      
���2�2�$��20,20,20,20q�6C   $��Bodoni MT Black)�6X   $��25(�6u   
�������$
��Wrap=�6�   $��Page 4��6�   $��Stretch=�6�   $��Stretch=�6�    �� TextAlignment$ Center=�6�    5S        5T      -   5        shadow1��   ShadowDepth$ 10Q�5T   <   $	 20Q�6M   $
 	DarkGreen��6]       RenderingBias$  Performance=�6o   ! � Triggers! 5V      :� 5W      $ TextBlock.Loaded��6'   .[�5X      �� .��5Y   "   �� .��5Z   &   W� $ shadow1��66   $ 
BlurRadius�5[   2   $ 40X�5\   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5^   &   $ shadow1��65   $ Color�5_   -   $ YellowX�5`   2    . $ Forever��6Q   $ 0:0:2D�6j   5a   #   5b      5c      5e      �� 5f      -   5        " ��Name$" okButton��5f      $��Close��6+   
�������$��30(�6O   $��Bodoni MT Black)�6]   $��350, 280, 300, 50q�6z   #��[  6�   $	��100��6�   $��60��6�   6�   F� 5h      -   5        # F�Name$
# back��5h      F����    ���� ��    � ��@x}� ��@x}� ���hx� ���hx� �� ��	$��50��6�   $	��100��6�   $ �� Stretch$
$ Fill=�6�   $��50, 280, 600, 50q�6�   ��5i      �� 5j      -   5        
colorFillB��$ White��5j   >    5l        5m      -   5        shadowB��$ 5Q�5m   <   $	 10Q�6L   $
 Yellow��6\   $  Performance=�6k   ! 5o      :� 5p      $ TextBlock.Loaded��6'   .[�5q      �� .��5r   "   �� .��5s   &   W� $ shadowB��66   $ 
BlurRadius�5t   2   $ 40X�5u   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5w   &   $ shadowB��65   $ Color�5x   -   $ 	DarkGreenX�5y   2    . $ Forever��6T   $ 0:0:2D�6m   5z   #   5{      5|      :� 5~      $ Path.MouseEnter��6'   .[�5      �� .��5�   "   �� .��5�   &   �� $ 
colorFillB��65   $ Color�5�   -   $ 	DarkGreenX�5�   2   $ 0:0:0.2D�6A   5�   #   5�      5�      :� 5�      $ Path.MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� $ 
colorFillB��65   $ Color�5�   -   $ WhiteX�5�   2   $ 0:0:0.2D�6=   5�   #   5�      5�      5�      5�      5�      5�      5�      