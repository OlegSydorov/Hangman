   M S B A M L   `   `   `  ����B  >HaNgMaN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HaNgMaNHaNgMaN  5   	       HaNgMaN.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HaNgMaN     5   	     � Title$  	Load game��5   	   $	��300��6   $	��300��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � 	Resources 5	         textBoxStyle �� Property �� Value  
labelStyle  buttonTemplate �� 
TargetType ��Name �� RadiusX	 �� RadiusY
 �� Color J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity   
BlurRadius �� Triggers P� Property P� Value �� 
TargetName �� ScaleX �� ScaleY N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions��%�  &	        &	 i    &	 �    �� 5
   
   .�5      ��  � ��
 �����63   �� 5       � ��
 � � �63   �� 5       � ��$ Bodoni MT Black)�63   �� 5       � ��$ 30(�61   �� 5       � ��$ Normal"�63   �� 5       �@��TextAlignment$ Center=�66   �� 5       � ��$ Center=�6C   �� 5       � ��$ Center=�6A   5      �� 5   
   .�5      ��  � ��
 �����65   �� 5       � ��
 � � �65   �� 5       � ��$ Bodoni MT Black)�65   �� 5       � ��$ 30(�63   �� 5       � ��$ Normal"�65   �� 5       �@��TextAlignment$ Center=�68   5      �� 5   
   " ��61   .R�5      � .+�5       �� $ rect1��6   $ 20��6+   $	 20��68   
�������#��z��6T   #��z��6{   $��2��6�   ��5!      �� 5"      MyAnimatedBrush��$
 	LimeGreen��6C    5$        5%      shadow1��$ 1Q�6<   $ 10Q�6H   5.      �� 5/      #��z��6#   $��Center=�6M   $��Center=�6j   #��z��6�   50       52      P� 53       �@J�IsMouseOver . . �54      �� $ rect1��6    � ��
 ����6@   55      P� 57       � �� . . �58      ��  � z� 59      �� 5:      $	 0.9Q�6-   $	 0.9Q�6:   5<      �� 5=       �@J�RenderTransformOrigin$ .5,.5&�6>   �� 5?      $ rect1��6    � ��
 � d �6@    5@      �� 5A      .��5B      �� .��5C   "   W� $ shadow1��62   $ 
BlurRadius�5D   2   $ 40X�5E   2   $ 0:0:0.1D�6:   5F      5G       5K      �� 5L      .��5M      �� .��5N   "   W� $ shadow1��62   $ 
BlurRadius�5O   2   $ 10X�5P   2   $ 0:0:0.1D�6:   5Q      5R      5V      5�      5�      .��5�      � 
���2�2�.+�5�   
   �� -   5         ��Name$ Label1��5�      $��Enter name:��6    $��10,30,10,170q�66   #��[ 6L   �� 5�   
   -   5         ��Name$ textBox��5�      $��10,110,10,90q�6#   #��[  69   �� 5�   
   -   5         ��Name$ okButton��5�      $��OK��6#   
�������$��30(�6C   $��Bodoni MT Black)�6Q   $��50, 200, 50, 20q�6n   #��[ 6�   6�   5�      5�      