   M S B A M L   `   `   `  ����  EGITSGymManager     EGITSGymManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  VIBE GYM MANAGER��5   	    � WindowState$ 	Maximized=�6"    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � WindowStyle$
 None=�6u   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 0q�6)    � 	Resources 5         CustomButton	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5	   
   "	 ��6%   .�5
      �� 
 �@�OverridesDefaultStyle . 66   �� 5      
 �@�Cursor$
 Hand��6'   �� 5      
 � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   $��0,0,0,0q�6g   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� 
 �@J�Opacity$	 0.8Q�6<   5      5      5      5      5      ��5      �� 5   
    �� ImageSource$ Assets/gym-background.jpg��6    j� Stretch$ UniformToFill=�6=    j� TileMode$
 Tile=�6U   .��5      �  � RowDefinitions 5    
   �� 5!      $��* �6   �� 5"      $	��45* �6   .+�5$   
   � $��0��6   ���	#FF7C6A6A � ColumnDefinitions 5%      �� 5&      $	��45* �6#   �� 5'      $��* �6#   �� 5(      $��* �6#   .+�5*      �� $��VIBE GYM MANAGER��6   $��10,0,0,0q�60   $��Center=�6B   
�������$
��Bold"�6p   6�   �� 5+      -   5        $��MinimizeBtn��5+   K   $��1��6   #��[  6%   $��__��6x   
����������	#FF3D50666�   �� 5,      -   5        $��CloseBtn��5,   K   $��2��6   #��[  6%   $��X��6r   
����������	#FFEE64646�   5-      � 5.   
   $��1��6    5/      �� 50      $��* �6    �� 51      $��3* �6    �� 52      $	��20* �6    �� 53      $��* �6     55      �� 56      $��* �6#   �� 57      $	��30* �6#   �� 58      $��* �6#   .+�5:      �� $��1��6   $��1��6!   $��5q�61   $��Assets/logo.png��6<   $��Right=�6U   5;      5<      5=      