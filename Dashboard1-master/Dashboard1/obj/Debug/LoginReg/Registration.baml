   M S B A M L   `   `   `  ����E  ADashboard1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Dashboard1
Dashboard1  5   	   ` \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5   	       Dashboard1.Registration   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Dashboard1     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   e
MetroChartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart  5   	   $	��700��5	      $
��1024��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o    � 	Resources 5         ScrollThumbs �� 
TargetType �� Property �� Value �� 
TargetType �Name	 ��Name
 �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle�� 5   
   %�  &	        '�� D    �� 5      " n�6)   .�5      ��  � �� 5      �� 5      " n�6*   .R�5      � $
 Grid��6#   .+�5   "   �� $��Stretch=�6,   $��Stretch=�6J   $
��Auto��6f   $
��Auto��6s   
������ 6�   �� 5   "   $	 
Rectangle1��6)   $
 10��6=   $��Stretch=�6O   $��Stretch=�6m   $
��Auto��6�   $
��Auto��6�   #��z��6�   5       5      P� 5   "    �@�Tag$ 
Horizontal��69   . �5   &   �� $ 
Rectangle1��6-    � ��$
 Auto��6V   �� 5   &   $ 
Rectangle1��6-    � ��$ 7��6W   5   #   5      5      5      �� 5!      " ��6/   .�5"      ��  �@��IsFlicksEnabled .  6;   �� 5#       � ��
 �����6/   �� 5$       � ��
 �����6/   �� 5%       � ��$ 10��6*   �� 5&       � �� 5'      �� 5(      " ��6*   .R�5)      � $ GridRoot��6#   $��19��65   ��6@   Z� .+�5*   "   ]� $ 
PART_Track��6(   $��0��6<   ��. |�.   5+   &   n� 5,   *   $ Thumb��60   #��z��6?   #���   6i    5.   &   �� 5/   *   $ PageUp��67   $��ScrollBar.PageDownCommand��6G   $ 0Q�6k   |�.  6w    51   &   �� 52   *   $ PageDown��67   $��ScrollBar.PageUpCommand��6I   $ 0Q�6k   |�.  6w   54   #   55       57      P� 58   "   $ Thumb��6*    �@J�IsMouseOver . . �59   &   �� # �  6-   $ Thumb��6Y    � ��6l   5:   #   P� 5;   "   $ Thumb��6*    �@n�
IsDragging . . �5<   &   �� # �  6-   $ Thumb��6Q    � ��6d   5=   #   P� 5?   "    � {� .  . �5@   &   �� $ Thumb��6-    � y�$ 	Collapsed=�6V   5A   #   P� 5B   "    �@��Orientation$ 
Horizontal=�6A   . �5C   &   �� $ GridRoot��6-    �@�LayoutTransform 5D   *   �� 5E   .   $	 -90Q�6>   5G   '   �� 5H   &   $ 
PART_Track��6-    �@�LayoutTransform 5I   *   �� 5J   .   $	 -90Q�6>   5L   '   �� 5M   &    � ��$
 Auto��6>   �� 5N   &    � ��$ 12��6?   �� 5O   &   $ Thumb��6-    �@�Tag$ 
Horizontal��6O   �� 5P   &   $ PageDown��6-    � ��$ ScrollBar.PageLeftCommand��6V   �� 5Q   &   $ PageUp��6-    � ��$  ScrollBar.PageRightCommand��6T   5R   #   5T      5V      5W      5X      .��5\      �  � ColumnDefinitions 5]   
   �� 5^      $	��200 �6   �� 5_      $��* �6    � RowDefinitions 5a   
   �� 5b      $��30 �6   �� 5c      $��* �6   .+�5g   
   � $��1��6   $��1��6   ���	#FFCFCFCF.+�5h      �� .��5i      �  5j      �� 5k      $	��200 �6(   �� 5l      $��* �6(   �� 5m      $��* �6(    5o      �� 5p      $��1* �6+   �� 5q      $��1* �6+   �� 5r      $��1* �6+   .+�5w      � $��1��6   $��2��6(   $��3��69   $��Center=�6M   $	��580��6j   $	��510��6v   .+�5x      � 
�������$��20 50 20 100q�62    J� OpacityMask 5y      !� 5z   "    !� Visual 6.   ��  �� ElementName$ BorderG1��.+�5|      �� -   5        $	 BorderG1��5|   %   $
 5��67   
�������6H   5~      � 5      $��50 20 50 200q�6    5�      !� 5�   "    6.   �� $ BorderG2��.+�5�      �� -   5        $	 BorderG2��5�   %   $
 15��67   ���	#FF3400516I   �� 5�      $��20q�6)   .+�5�   "   �� $��Registration��6(   
�������$��25(�6R   $��Center=�6`   �� 5�   "   6.   �� 5�   "   $��Username��6(   
�������6;   �� 5�   "   -   5        $��txtUsername��5�   *   ���#545d6a
�������$��18(�6e   $��5,0,5,0q�6s   �� 5�   "   $��Password��6(   
�������6;   G� 5�   "   -   5        $��txtPassword��5�   .   ���#545d6a
�������$��18(�6i   $��5,0,5,0q�6w   �� 5�   "   -   5        $��10q�5�   )   ���	#FF8522BD���	#FF8522BD$	��200��6d   .��5�   &   � $	��150��6+   .+�5�   *   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6B   $��Center=�6Q   �� 5�   *   $��Center=�64   $��Registration��6Q   $��Champagne & Limousines)�6e   5�   '   5�   #   5�      5�      5�      5�      5�      5�      � 5�   
   $��1��6   ��5�      �� 5�       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5�      �   � Color$  	LightGray��6#   ! � Offset$! 1Q�65   � 5�      $  	#FFE6E6E6��6#   5�       5�      �� 5�      $	��100 �6    �� 5�      $��* �6    " J� Effect" 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      #   
BlurRadius$# 20Q�6#   $   Color$$ 	#FFDEDEDE��63   %   RenderingBias$% Quality=�6E   &   ShadowDepth$& 1Q�6]   .+�5�      � ���	#FFA46FE4.+�5�      �� $��REGISTRATION��6   $��Center=�60   $��Center=�6M   $��WS Simple Gallifreyan)�6h   ���	#FFBC96EA$��16(�6�   5�      5�      � 5�   
   -   5        $ GridBarraTitulo��5�      $��2��6(   ���	#FF8522BD.+�5�      �� ' �� Orientation$' 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5�      ��  0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6   $��25��6_   $��25��6j   
���������6v   Z� ��6�   Z� .��5�        $
 Bell=�6.   5�      �� 5�      #��[ 6   $��25��6_   $��25��6j   
���������6v   Z� ��6�   Z� .��5�        $ Account=�6.   5�      �� 5�      -   5        ( ��Name$( ButtonFechar��5�      #��[ 6/   $��25��6u   $��25��6�   
���������6�   Z� ��6�   Z� .��5�        $ Power=�6.   5�      5�      5�      5�      5�      