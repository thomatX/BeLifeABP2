   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.ClientesWPF   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1100��6)    � WindowStyle$
 None=�66   .��5	      � -   5         �Name$ MainBG��5	      ���#f6f6f6$��0,2,-0.4,-1.6q�60   .+�5   
   � -   5        $ Title��5      $��600px��6   $��90��6,   $	��Top=�68   $
��Left=�6P   $��
82,100,0,0q�6k    � ColumnDefinitions 5      �� 5      $
��121* �6#   �� 5      $��4* �6#   .+�5      �� $��40(�6   ���#c1c1c1$
��Bold"�6;   $��Font Awesome 5 Free Solid)�6M   $��0,10,435.3,-1q�6t   home6�   �� 5      $��40(�6   ���#c1c1c1$��	53,0,0,-1q�6;   $��91��6N   $��Bottom=�6Z   $��2��6u   Seguros BeLife - Clientes6�   5      � 5   
   -   5        $ TopBar��5      $��70��6   ���#FFF$	��Top=�6=    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      Color$ 	#FFF6F6F6��63   .+�5      �� $��75,10,861.4,14q�6   $��Logo BeLife.png��6,   $
��Fill=�6E   � 5      $��90��6   $��30��6   $��	0 10 10 0q�6*   $	��Top=�6=   $��Right=�6U   .+�5      �� ���#FFF���#FFF$��0,0,62,0q�6>   .��5      �� $��20��6   $��
adjust.png��6(   $
��Fill=�6<   $��20��6K   5      �� 5      -   5        ���#FFF���#FFF$��	30,0,32,0q�5   >   .��5      �� $��Bottom=�6   $��2��67   $��minimize.png��6B   $��11��6X   5      �� 5       ���#FFF���#FFF$��63,0,0,0q�6>   .��5!      �� -   5        $��15��5!      $��	close.png��6(   $
��Fill=�6;   $��16��6J   6U   5"      5#      5$      � 5%   
   -   5        $ SideBar��5%      $��50��6    ���#2c2c2c$	��800��6@   $	��Top=�6M   $
��Left=�6e   � 5&   
   -   5        $
 Home��5&      $��50��6   $��50��6(   ���#2c2c2c$	��Top=�6I   $
��Left=�6a   $��	0,100,0,0q�6|   .+�5'      �� -   5         ��Name$ HomeBtn��5'       �� TextAlignment$ Center=�6)   ���#FFF$
��Bold"�6R   $��40(�6d   $��Font Awesome 5 Free Solid)�6r   $��0,0,0,-1q�6�   home6�   5(      � 5)   
   -	   5        $ 
Separator1��5)      $��50��6#   $��1��6.   $	��Top=�69   $
��Left=�6Q   ���#464646$��	0,160,0,0q�6�   6�   � 5*   
   -
   5        $ Clientes��5*      $��50��6!   $��50��6,   ���#2c2c2c$	��Top=�6M   $
��Left=�6e   $��	0,170,0,0q�6�   .+�5+      �� -   5        $ 
ClientsBtn��5+      $ Center=�6,   ���#c3c3c3$
��Bold"�6X   $��35(�6j   $��Font Awesome 5 Free Solid)�6x   $��0,7,0,-1q�6�   users6�   5-      � 5.   
   -   5        $ 
Separator2��5.      $��50��6#   $��1��6.   $	��Top=�69   $
��Left=�6Q   ���#464646$��	0,230,0,0q�6�   6�   � 5/   
   -   5        $ 	Contratos��5/      $��50��6"   $��50��6-   ���#2c2c2c$	��Top=�6N   $
��Left=�6f   $��	0,240,0,0q�6�   .+�50      �� -   5        $ ContratosBtn��50      $ Center=�6.   ���#FFF$
��Bold"�6W   $��40(�6i   $��Font Awesome 5 Free Solid)�6w   $��0,0,0,-1q�6�   file6�   52      � 54   
   -   5        $ Footer��54      ���#2c2c2c$��30��64   $��Bottom=�6@   $
��Left=�6[   $
��1100��6v   � 5;   
   -   5        $��220px��5;      $��82,190,792,378.2q�6   .+�5<      �� $��150px��6   $��150px��6&   $��
35,0,35,70q�65   $
��Bold"�6I   $��Font Awesome 5 Free Solid)�6[   $��140px(�6�   $ Center=�6�   ���#7e3b82plus6�   �� 5=      $��
0,150,0,-3q�6   $
��50px(�6,   $ Center=�6<   ���#7e3b82	Agregar6q   5>      � 5@   
   -   5        $��220px��5@      $��220px��6   $��445,195,429,378.2q�6,   .+�5A      �� $��150px��6   $��150px��6&   $��
35,0,35,70q�65   $
��Bold"�6I   $��Font Awesome 5 Free Solid)�6[   $��140px(�6�   $ Center=�6�   ���#7e3b82trash6�   �� 5B      $��
0,150,0,-3q�6   $
��50px(�6,   $ Center=�6<   ���#7e3b82
Eliminar6r   5C      � 5E   
   -   5        $��220px��5E      $��838,195,28,378.2q�6   .+�5F      �� $��150px��6   $��150px��6&   $��
35,0,35,70q�65   $
��Bold"�6I   $��Font Awesome 5 Free Solid)�6[   $��140px(�6�   $ Center=�6�   ���#7e3b82cog6�   �� 5G      $��
0,150,0,-3q�6   $
��50px(�6,   $ Center=�6<   ���#7e3b82
Actualizar6t   5H      � 5J   
   -   5        $��220px��5J      $��220px��6   $��82,502,792,71.2q�6,   .+�5K      �� $��150px��6   $��150px��6&   $��
35,0,35,70q�65   $
��Bold"�6I   $��Font Awesome 5 Free Solid)�6[   $��140px(�6�   $ Center=�6�   ���#7e3b82search6�   �� 5L      $��
0,150,0,-3q�6   $
��50px(�6,   $ Center=�6<   ���#7e3b82Buscar6p   5M      � 5O   
   -   5        $��220px��5O      $��220px��6   $��445,502,429,71.2q�6,   .+�5P      �� $��150px��6   $��150px��6&   $��
35,0,35,70q�65   $
��Bold"�6I   $��Font Awesome 5 Free Solid)�6[   $��140px(�6�   $ Center=�6�   ���#7e3b82list6�   �� 5Q      $��
0,150,0,-3q�6   $
��50px(�6,   $ Center=�6<   ���#7e3b82Listar6p   5R      5T      5U      