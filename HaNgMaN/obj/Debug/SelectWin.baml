   M S B A M L   `   `   `  ����B  >HaNgMaN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HaNgMaNHaNgMaN  5   	       HaNgMaN.SelectWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HaNgMaN     5   	     � Title$  Select level��5   
   $	��600��6   $	��300��6,    � 
ResizeMode$ NoResize=�68    � WindowStyle$
 None=�6N    � WindowStartupLocation$ CenterScreen=�6a    � 	Resources 5	         textBoxStyle �� Property �� Value  
labelStyle  buttonTemplate �� 
TargetType ��Name	 �� RadiusX
 �� RadiusY �� Color J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity   
BlurRadius   Color �� Triggers P� Property P� Value �� 
TargetName �� ScaleX �� ScaleY N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions :� RoutedEvent g� AutoReverse g� RepeatBehavior	 �� To��%=  &	        &	 i    &	 �    �� 5
   
   .�5      ��  � ��
 �����63   �� 5       � ��
 � � �63   �� 5       � ��$ Bodoni MT Black)�63   �� 5       � ��$ 30(�61   �� 5       � ��$ Normal"�63   �� 5       �@��TextAlignment$ Center=�66   �� 5       � ��$ Center=�6C   �� 5       � ��$ Center=�6A   5      �� 5   
   .�5      ��  � ��
 �����65   �� 5       � ��
 � � �65   �� 5       � ��$ Bodoni MT Black)�65   �� 5       � ��$ 30(�63   �� 5       � ��$ Normal"�65   �� 5       �@��TextAlignment$ Center=�68   5      �� 5   
   " ��61   .R�5      � .+�5       �� $ rect1��6   $	 20��6+   $
 20��68   
�������#��z��6T   #��z��6{   $��2��6�   ��5!      �� 5"      MyAnimatedBrush��$ 	LimeGreen��6C    5$        5%      shadow1��$ 1Q�6<   $ 10Q�6H   $ Yellow��6X   5.      �� 5/      #��z��6#   $��Center=�6M   $��Center=�6j   #��z��6�   50       52      P� 53       �@J�IsMouseOver . . �54      �� $ rect1��6    � ��
 ����6@   55      P� 57       � �� . . �58      ��  � z� 59      �� 5:      $	 0.9Q�6-   $	 0.9Q�6:   5<      �� 5=       �@J�RenderTransformOrigin$ .5,.5&�6>   �� 5?      $ rect1��6    � ��
 � d �6@    5@      �� 5A      .��5B      �� .��5C   "   W� $ shadow1��62   $ 
BlurRadius�5D   2   $ 40X�5E   2   $ 0:0:0.1D�6:   5F      5G       5K      �� 5L      .��5M      �� .��5N   "   W� $ shadow1��62   $ 
BlurRadius�5O   2   $ 10X�5P   2   $ 0:0:0.1D�6:   5Q      5R      5T      :� 5V      $ Button.Loaded��6   .[�5W      �� .��5X      �� .��5Y      W� $ shadow1��6.   $ 
BlurRadius�5Z   2   $ 40X�5[   2    . $ Forever��6M   $ 0:0:2D�6f   �� 5]      $ shadow1��6-   $ Color�5^   -   $ 	DarkGreenX�5_   2    . $ Forever��6T   $ 0:0:2D�6m   5`      5a      5b      5e      5h      .��5i      � 
���2�2�.+�5j   
   �� 
��� d �$��3q�6)   ._�5k      �� 
�������$��3q�6)   ._�5l      � .+�5n   
   �� -   5          ��Name$  Label1��5n      $��Select level:��6    $��10,30,10,490q�68   #��[ 6N   �� 5p   
   -   5        ! ��Name$! b1��5p      $
��Easy��6   
�������$��30(�6?   $��Bodoni MT Black)�6M   $��50, 80, 50, 430q�6j   #��[ 6�   6�   �� 5q   
   -   5        $! b2��5q      $��Medium��6   
�������$��30(�6A   $��Bodoni MT Black)�6O   $��50, 170, 50, 340q�6l   #��[ 6�   6�   �� 5r   
   -   5        $! b3��5r      $
��Hard��6   
�������$��30(�6?   $��Bodoni MT Black)�6M   $��50, 260, 50, 250q�6j   #��[ 6�   6�   �� 5s   
   -   5        $! b4��5s      $��	Very hard��6   
�������$��30(�6D   $��Bodoni MT Black)�6R   $��50, 350, 50, 160q�6o   #��[ 6�   6�   �� 5t      -   5        $! b5��5t      $��
Abort game��6)   
��� ���$��30(�6R   $��Bodoni MT Black)�6`   $��50, 470, 50, 40q�6}   #��[ 6�   6�   5u      5v      5w      5x      5y      