   M S B A M L   `   `   `  ����B  >HaNgMaN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HaNgMaNHaNgMaN  5   	       HaNgMaN.ResumeWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HaNgMaN     5   	     � Title$  Resume select��5      $	��300��6   $	��600��6+    � 
ResizeMode$ NoResize=�67    � WindowStyle$
 None=�6M    � WindowStartupLocation$ CenterScreen=�6`    � 	Resources 5	         
labelStyle �� Property �� Value  buttonTemplate �� 
TargetType ��Name	 �� RadiusX
 �� RadiusY �� Color J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity   
BlurRadius   Color �� Triggers P� Property P� Value �� 
TargetName �� ScaleX �� ScaleY N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions :� RoutedEvent g� AutoReverse g� RepeatBehavior	 �� To��%�  &	        &	     �� 5   
   .�5      ��  � ��
 �2�2�61   �� 5       � ��
 �����61   �� 5       � ��$ Bodoni MT Black)�61   �� 5       � ��$ 30(�6/   �� 5       � ��$ Normal"�61   �� 5       � ��$ Center=�6A   5      �� 5   
   " ��61   .R�5      � .+�5      �� $ rect1��6   $	 20��6+   $
 20��68   
�������#��z��6T   #��z��6{   $��2��6�   ��5      �� 5      MyAnimatedBrush��$ 	LimeGreen��6C    5        5      shadow1��$ 1Q�6<   $ 10Q�6H   $ Yellow��6X   5$      �� 5%      #��z��6#   $��Center=�6M   $��Center=�6j   #��z��6�   5&       5(      P� 5)       �@J�IsMouseOver . . �5*      �� $ rect1��6    � ��
 ����6@   5+      P� 5-       � �� . . �5.      ��  � z� 5/      �� 50      $	 0.9Q�6-   $	 0.9Q�6:   52      �� 53       �@J�RenderTransformOrigin$ .5,.5&�6>   �� 55      $ rect1��6    � ��
 � d �6@    56      �� 57      .��58      �� .��59   "   W� $ shadow1��62   $ 
BlurRadius�5:   2   $ 40X�5;   2   $ 0:0:0.1D�6:   5<      5=       5A      �� 5B      .��5C      �� .��5D   "   W� $ shadow1��62   $ 
BlurRadius�5E   2   $ 10X�5F   2   $ 0:0:0.1D�6:   5G      5H      5J      :� 5L      $ Button.Loaded��6   .[�5M      �� .��5N      �� .��5O      W� $ shadow1��6.   $ 
BlurRadius�5P   2   $ 40X�5Q   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5S      $ shadow1��6-   $ Color�5T   -   $ 	DarkGreenX�5U   2    . $ Forever��6T   $ 0:0:2D�6m   5V      5W      5X      5[      5^      .��5`      � 
���2�2�.+�5a   
   �� -   5          ��Name$  Label1��5a      #��[  6    $��10,49,10,126q�6D   $(��"Want to resume where you left off?��6Z   ! J� Opacity$! 0Q�6�   " � Triggers" 5b      :� 5c      $ Loaded��6   .[�5d      �� .��5e      �� .��5f      W� $ Opacity�5g   2   $ 1X�5h   2   $ 0:0:0.2D�69   5i      5j      5k      5m      �� 5p   
   -   5        # ��Name$# b1��5p      $	��Yes��6   
�������$��25(�6>   $��Bodoni MT Black)�6L   $��10,200,340,10q�6i   #��[ 6�   $! 0Q�6�   " 5q      :� 5r      $ Loaded��6   .[�5s      �� .��5t      �� .��5u      W� $ Opacity�5v   2   $ 1X�5w   2   $ 0:0:3D�69   5x      5y      5z      5|      �� 5~   
   -   5        $# b2��5~      $��No, start anew��6   
�������$��25(�6I   $��Bodoni MT Black)�6W   $��328,200,22,10q�6t   #��[ 6�   $! 0Q�6�   " 5      :� 5�      $ Loaded��6   .[�5�      �� .��5�      �� .��5�      W� $ Opacity�5�   2   $ 1X�5�   2   $ 0:0:3D�69   5�      5�      5�      5�      5�      5�      