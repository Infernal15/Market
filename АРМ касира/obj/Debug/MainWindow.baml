   M S B A M L   `   `   `  ����N  JАРМ касира, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:АРМ_касираАРМ_касира  5   	   $    АРМ_касира.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:АРМ_касира     5   	     � Title$  
MainWindow��5   	   $	��502��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$
 sell��5
      $��Продаж квитка��6   $
��Left=�67   $��
335,60,0,0q�6R   $	��Top=�6f   $	��115��6~   $��35��6�   6�   �� 5   
   -   5        $	 rep��5      $!��Добавити подію��6   $
��Left=�67   $��335,155,0,0q�6R   $	��Top=�6g   $	��115��6   $��35��6�   �� 5   
   -   5        $
 exit��5      $��
Вихід��6   $
��Left=�6/   $��335,305,0,0q�6J   $	��Top=�6_   $	��115��6w   $��35��6�   6�   �� 5   
   -   5        $	 ret��5      $��повернутися��6   $
��Left=�64   $��	5,441,0,0q�6O   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5         ��Name$ combo��5      $
��Left=�6"   $��	10,13,0,0q�6=   $	��Top=�6P   $	��120��6h   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.321Q�6&   T� 5      5      5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   &   System.Windows.Controls.Calendar  5   
   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          Name$ 	calendar1��5         FirstDayOfWeek$ Monday=�6&      SelectionMode$ SingleRange=�6>   $��80,1,177,-1q�5   <   6Q   � 5   
   -   5         �Name$
 grid��5      $
��Left=�6   $	��255��68   $��10,174,0,-10q�6E   $	��Top=�6[   $	��535��6s   �� 5   
   -   5        $ reserv��5      $ ��Зарезервувати��6!   $
��Left=�69   $��455,429,0,0q�6T   $	��Top=�6i   $��90��6�   $��25��6�   �� 5   
   -	   5         ��Name$ price��5      $��0��6   $
��Left=�6+   $��370,428,0,0q�6F   $	��Top=�6[   �� 5   
   -
   5        $ s��5      $��	Ціна:��6   $
��Left=�6+   $��305,429,0,0q�6F   $	��Top=�6[   5       5!      