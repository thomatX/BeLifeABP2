   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.ClientAddWPF   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Window1��5   	   $	��800��6   $	��450��6&    � WindowStyle$
 None=�62    � 
ResizeMode$ NoResize=�6E    � WindowStartupLocation$ CenterScreen=�6[   .��5	      � ���#616161$��
0,0,-0.4,0q�6    .+�5
   
   �� -   5         ��Name$ AddBtn��5
   &   $��Agregar��66   $
��Left=�6H   $��
76,691,0,0q�6c   $	��Top=�6w   $	��300��6�   $��60��6�   ���#616161���#2c2c2c���#FFF$
��25px(�6�   � 5   
   -   5        $
��30px��5   *   $
��30px��67   $��420,10,0,760q�6E   .+�5      �� ���#FFF$
��25px(�6*    �� TextAlignment$ Center=�6:   X6T   5      � 5   
   $
��70px��6   $��76,10,73.6,720q�6   .+�5      �� ���#FFF$
��40px(�6*   $ Center=�6:   $��-10,0,10,-2q�6Q   Nuevo cliente6u   5      �� 5   
   -   5         ��Name$ RutTxt��5      $
��Left=�6"   $��35��6=   $��
76,150,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Rut��6q   ���#616161$
��20px(�6�   $	��Top=�6�   $	��300��6�   �� 5   
   -   5        $ 	NombreTxt��5      $
��Left=�6%   $��35��6@   $��
76,204,0,0q�6L   $
 Wrap=�6`   $��Nombre��6v   ���#616161$
��20px(�6�   $	��Top=�6�   $	��300��6�   �� 5   
   -   5        $ ApellidoTxt��5      $
��Left=�6'   $��35��6B   $��
76,260,0,0q�6N   $
 Wrap=�6b   $��Nombre��6x   ���#616161$
��20px(�6�   $	��Top=�6�   $	��300��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ FechaNacimientoPicker��5      ���#616161$
��Left=�6J   $��
76,315,0,0q�6e   $	��Top=�6y   $	��300��6�   ���#616161$
��20px(�6�   �� 5   
   -   5        	 ��Name$	 SexoComboBox��5      $
��Left=�6)   $��
76,370,0,0q�6D   $	��Top=�6X   $	��300��6p   $��35��6|   �� 5   
   -   5        $	 EstadoCivilComboBox��5      $
��Left=�60   $��
76,426,0,0q�6K   $	��Top=�6_   $	��300��6w   $��35��6�   5      5      