   M S B A M L   `   `   `  ����C  ?OxtaPark, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:OxtaParkOxtaPark  5   	       OxtaPark.AddOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:OxtaPark     5   	     � Title$  AddOrder��5   	   $	��450��6   $	��850��6'    � WindowStartupLocation$ CenterScreen=�63    � 	Resources 5	         d �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5
   
   $ 1,0.2&�6(   $	 1,1&�6;   .��5      � $
 #5CB��6   $	 0.0Q�6)   � 5      $ #2F2FA2��6   $	 1.1Q�6,   5      5      .��5      (�  (� Stretch$
 Fill=�6   .��5   
   � $	��450��6   $	��850��6   #��[  6)   .+�5      �� -   5         ��Name$ searchtb��5   s   $
��Left=�6C   	 �� TextWrapping$
	 Wrap=�6_   $�� ��6�   $	��Top=�6�   $	��120��6�   $��
339,22,0,0q�6�   �� 5      $��Код заказа:��6   
���   �$��Heavy"�6=   $��Comic Sans MS)�6P   $��22(�6k   $
��Left=�6y   $��
538,75,0,0q�6�   $	��Top=�6�   �� 5      -   5        
 ��Name$	
 Add��5   W   $!��Добавить заказ��6   $��20(�6.   $��Comic Sans MS)�6<   ���#76E383$��Center=�6�   $��	0,362,0,0q�6�   $	��Top=�6�   $��40��6�   $	��280��6�    5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 15��69   5      5      5      �� 5      -   5        $

 Exit��5   O   $��Отмена��6   $��20(�6&   $��Comic Sans MS)�64   ���#76E383$
��Left=�6�   $��606,363,0,0q�6�   $	��Top=�6�   $��39��6�   $	��234��6�    5      ��%_   '��       �� 5       " ��6   .�5!      ��  �@��CornerRadius$ 15��69   5"      5#      5$      �� 5&      $)��#Выберите клиента ⇩��6   
���   �$��Heavy"�6D   $��Comic Sans MS)�6W   $��22(�6r   $
��Left=�6�   $��0,7,0,0q�6�   $	��Top=�6�   �� 5'      $��Услуги:��6   
���   �$��Heavy"�69   $��Comic Sans MS)�6L   $��22(�6g   $
��Left=�6u   $��
21,242,0,0q�6�   $	��Top=�6�   �� 5(      $��Код клиента:��6   
���   �$��Heavy"�6>   $��Comic Sans MS)�6Q   $��22(�6l   $
��Left=�6z   $��528,140,0,0q�6�   $	��Top=�6�   �� 5)      $��Поиск:��6   
���   �$��Heavy"�68   $��Comic Sans MS)�6K   $��22(�6f   $
��Left=�6t   $��	250,7,0,0q�6�   $	��Top=�6�   �� 5+      $ ��Дата закрытия:��6   
���   �$��Heavy"�6@   $��Comic Sans MS)�6S   $��22(�6n   $
��Left=�6|   $��496,294,0,0q�6�   $	��Top=�6�   �� 5,      $ ��Время проката:��6   
���   �$��Heavy"�6@   $��Comic Sans MS)�6S   $��22(�6n   $
��Left=�6|   $��495,248,0,0q�6�   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5-      -   5          Name$ Datepick��5-      $
��Left=�6+   $��679,306,0,0q�6F   $	��Top=�6[   &   System.Windows.Controls.DataGrid  50      -   5          Name$ DgClient��50   �   
�������$��2q�6Y   $��15(�6n      CanUserResizeColumns .     CanUserResizeRows .  
�������   AutoGenerateColumns .  $��21,53,331,0q�6�   $	��174��6  $	��Top=�6    51      =  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%  '        '  �     '��     �� 53      daf��"  6)   .�54      ��  � ��
 �   �67   �� 55       � ��
 �����67   �� 56       � ��$ 	ExtraBold"�67   �� 57       � ��$ 5q�64   59      �� 5:      "  6   .�5;      ��  � ��$ 5q�64   5<      �� 5=      " ��6   .�5>      ��  �@��CornerRadius$ 3��69   5?      5A         Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
Lastname+  5E      $ Имя��6)    66   �� *Name+  5F      $ Код��6)    66   �� *
CodeClient+  5G      $ Паспорт��6)    6:   �� *
Passport+5K      �� 5M      -   5        $
 	clientadd��5M   Y   $%��Добавить клиента��6   $��20(�60   $��Comic Sans MS)�6>   ���#76E383$
��Left=�6�   $��
515,10,0,0q�6�   $	��Top=�6�   $��38��6�   $	��198��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    5N      ��%_   '��       �� 5O      " ��6   .�5P      ��  �@��CornerRadius$ 15��69   5Q      5R      5S      �� 5T      -   5        $ Timetb��5T   b   $
��Left=�6   $��674,262,0,0q�61   $
	 Wrap=�6F   $�� ��6Z   $	��Top=�6r   $	��120��6�   �� 5U      -   5        $ checkclient��5U   b   $
��Left=�6   $��682,154,0,0q�61   $
	 Wrap=�6F   $�� ��6Z   $	��Top=�6w   $	��120��6�   �� 5V      -	   5        $ CodeOrdertb��5V   a   $
��Left=�6   $��
679,90,0,0q�61   $
	 Wrap=�6E   $�� ��6Y   $	��Top=�6v   $	��120��6�   �� 5X      -
   5        $
 
addservice��5X   Y   $��20(�6   $��Comic Sans MS)�6$   
������ 
������ $
��Left=�6�   $��117,248,0,0q�6�   $	��Top=�6�   $��35��6�   $��35��6�   $ 0.5,0.5&�6�   .��5Y      ��  �� Orientation$ 
Horizontal=�6   .+�5Z      �� $
��Fill=�6   $��Image/add.png��6+   $��28��6B   $��27��6M   5\      5]      �� 5^      -   5        $��
CbService1��5^   8   $
��Left=�6J   $��166,248,0,0q�6e   $	��Top=�6z   $��23��6�   $	��145��6�    �� SelectedItem 6   �� *	Service+��5_      �� 5`      .R�5a      �� ��6$   �� *NameService+5b      5d      �� 5f      -   5        $��
CbService2��5f   8   $y�	Collapsed=�6J   $
��Left=�6a   $��
14,296,0,0q�6|   $	��Top=�6�   $��23��6�   $	��145��6�    6   �� *	Service+��5g      �� 5h      .R�5i      �� ��6$   �� *NameService+5j      5l      �� 5n      -   5        $��
CbService3��5n   8   $y�	Collapsed=�6J   $
��Left=�6a   $��166,296,0,0q�6|   $	��Top=�6�   $��23��6�   $	��145��6�    6   �� *	Service+��5o      �� 5p      .R�5q      �� ��6$   �� *NameService+5r      5t      5v      5w      5x      