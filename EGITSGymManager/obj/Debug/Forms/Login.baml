   M S B A M L   `   `   `  ����  EGITSGymManager!    EGITSGymManager.Forms.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login��5   	   $	��120��6   $	��300��6$   $��1q�60   
������� � 
ResizeMode$ NoResize=�6[   ���	#FF8E97A2 � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
 None=�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 0q�6)    � 	Resources 5         CustomButton �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5	   
   " ��6%   .�5
      �� 	 �@�OverridesDefaultStyle
 . 66   �� 5      	 �@�Cursor$

 Hand��6'   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   $��0,0,0,0q�6g   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� 	 �@J�Opacity$	
 0.8Q�6<   5      5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6   .+�5!   
   � $��0��6   ���	#FF7C6A6A � ColumnDefinitions 5"      �� 5#      $��6* �6#   �� 5$      $��* �6#   �� 5%      $��* �6#   .+�5'      �� $��Login��6   $��10,0,0,0q�6%   $��Center=�67   
�������$
��Bold"�6e   6y   �� 5(      -   5        $��MinimizeBtn��5(   K   $��1��6   #��[  6%   $��__��6x   
����������	#FF3D50666�   �� 5)      -   5        $��CloseBtn��5)   K   $��2��6   #��[  6%   $��X��6r   
����������	#FFEE64646�   5*      � 5+   
   $��1��6    5,      �� 5-      $��* �6    �� 5.      $��8* �6    �� 5/      $��* �6     51      �� 52      $��* �6#   �� 53      $��8* �6#   �� 54      $��* �6#   .+�56      � $��1��6   $��1��6#    57      �� 58      $��* �6$   �� 59      $��* �6$   �� 5:      $��* �6$    5<      �� 5=      $��* �6'   �� 5>      $��2* �6'   .+�5@      �� $��User ID:��6   
�������$��Center=�6>   $��0��6Y   $��0��6f   6x   �� 5A      -   5        $��userIdTB��5A      $��0��6*   $��Center=�67   $��1��6R   �� 5C      -   5        $��errorTB��5C      
���k���$#��sdsdjsnndsjsdjdnjnsjndsjsdnss��6B   $��0��6g   $��1��6w   $��Center=�6�   $��2��6�   $��Center=�6�   �� 5D      -   5        $��LoginBtn��5D   ?   #��[  6   $��0��6O   $��2��6_   $��25��6l   $��2��6x   $��Login��6�   
����������	#FF3D50666�   5E      5F      5G      5H      