   M S B A M L   `   `   `  ����C  ?OxtaPark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:OxtaParkOxtaPark  5   	       OxtaPark.WindowSeller   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:OxtaPark     5   	     � Title$  WindowSeller��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67    � 	Resources 5	         d �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5
   
   $ 1,0.2&�6(   $	 1,1&�6;   .��5      � $
 #5CB��6   $	 0.0Q�6)   � 5      $ #2F2FA2��6   $	 1.1Q�6,   5      5      .��5      (�  (� Stretch$
 Fill=�6   .��5   
   � #��[  6   $	��450��6/   $	��800��6<   .+�5      �� -   5         ��Name$ AddOrder��5   W   $!��Добавить заказ��6   $��20(�6.   $��Comic Sans MS)�6<   ���#76E383$
��Left=�6�   $��277,348,0,0q�6�   $	��Top=�6�   $��40��6�   $	��280��6�    5      	 �� 
TargetType
 �� Property �� Value��%_   '��       �� 5      "	 ��6   .�5      �� 
 �@��CornerRadius$ 15��69   5      5      5      �� 5      -   5        $
 exit��5   N   $��
Выход��6   $��20(�6%   $��Comic Sans MS)�63   ���#76E383$
��Left=�6�   $��	666,8,0,0q�6�   $	��Top=�6�   $��28��6�   $	��124��6�    5      ��%_   '��       �� 5      "	 ��6   .�5      �� 
 �@��CornerRadius$ 15��69   5      5      5       �� 5!      -   5         ��Name$ 
TimerLabel��5!      $��24(�6(   $
��Left=�66   $	��Top=�6Q   $��93��6i   $��	540,2,0,0q�6t   $��40��6�   &   System.Windows.Controls.DataGrid  5$      -   5          Name$ DgOrder��5$   �   
�������$��2q�6,   $��15(�6A      CanUserResizeColumns .     CanUserResizeRows .  
�������   AutoGenerateColumns .  $��
53,67,19,0q�6�   $	��250��6�   $	��Top=�6�    5&      =  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%  '        '  �     '��     �� 5(      daf��"	  6)   .�5)      �� 
 � ��
 �   �67   �� 5*      
 � ��
 �����67   �� 5+      
 � ��$ 	ExtraBold"�67   �� 5,      
 � ��$ 5q�64   5.      �� 5/      "	  6   .�50      �� 
 � ��$ 5q�64   51      �� 52      "	 ��6   .�53      �� 
 �@��CornerRadius$ 3��69   54      56         Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ Код��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	CodeOrder+  5:      $ Дата создания��6)    6@   �� *
DateCreate+  5;      $ 
Время��6)    68   �� *
Timecreate+  5<      $ Код клиента��6)    6>   �� *
CodeClient+  5=      $ Статус��6)    69   �� *StatusOrder.NameStatus+  5>      $ Дата закрытия��6)    6@   �� *	DateClose+  5?      $ Время проката��6)    6@   �� *
RentalTime+5B      �� 5C      $��Заказы��6   
���   �$��Heavy"�68   $��Comic Sans MS)�6K   $��30(�6f   $
��Left=�6t   $��
360,10,0,0q�6�   $	��Top=�6�   5F      5H      5I      