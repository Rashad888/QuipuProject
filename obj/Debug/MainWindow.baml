   M S B A M L   `   `   `  ����@  <Quipu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:QuipuQuipu  5   	       Quipu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Quipu     5   	     � Title$  
MainWindow��5   	   $	��428��6   $	��896��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��211* �6   �� 5      $	��81* �6   .+�5   
   �� -   5         ��Name$ urlBox��5      $
��Left=�6"   $	��318��6=   $��	10,52,0,0q�6J   $	��Top=�6]   $	��194��6u   6�   �� 5   
   $��URL list��6   $
��Left=�6#   $��	57,10,0,0q�6>   $	��Top=�6Q   $��20(�6i   $��37��6w   $��76��6�   �� 5   
   -   5         ��Name$ htmlTxt��5      $	��318��6%   $��227,52,62,0q�62   $	��Top=�6G    �� 
IsReadOnly . $
��Auto=�6q   $
��Auto=�6�   �� 5   
   $��HTML content��6   $
��Left=�6'   $��
337,10,0,0q�6B   $	��Top=�6V   $��20(�6n   $��37��6|   $	��135��6�   �� 5   
   -   5         ��Name$ startBtn��5      $��Start counting��6#   $
��Left=�6<   $��	0,274,0,0q�6W   $	��Top=�6j   $	��224��6�   $��44��6�   $��1��6�   �� 5   
   -   5        $ 	cancelBtn��5      $��Cancel counting��6$   $
��Left=�6>   $��	0,326,0,0q�6Y   $	��Top=�6l   $	��224��6�   $��44��6�   $��1��6�   {�.  6�   �� 5   
   -   5         ��Name$ 
procescLbl��5      $
��Left=�6$   $��
592,10,0,0q�6?   $	��Top=�6S   $��20(�6k   $��37��6y   $	��270��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid��5      $
��Left=�6%   $	��206��6@   $��
592,52,0,0q�6M   $	��Top=�6a   $	��274��6y   $��2��6�      
IsReadOnly . 5      5      5      