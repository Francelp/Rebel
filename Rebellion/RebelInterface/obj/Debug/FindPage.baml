   M S B A M L   `   `   `  ����  RebelInterface    RebelInterface.Find   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$
  Find��5      .��5
      � ���#802A2A � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      5      .+�5   
   �� $��25(�6   $��
Find Rebel��6"    �� TextAlignment$ Center=�64   $��Center=�6L   $��10,10,10,10q�6g   $��0��6|   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#    5      �� 5      $��* �6    �� 5      $��* �6    .+�5      �� -   5         ��Name$ EnterRebelTextBox��5      $�� ��61   $	��300��69    �� TextAlignment$
 Left=�6F   $��10,10,10,10q�6[   $��0��6q   $��0��6~   �� 5       J� IsHitTestVisible .  $��Enter Rebel ID��61   $
 Left=�6H   $��30��6]   $��0��6i   $��0��6v    �� Padding$ 
5, 5, 5, 5q�6�   
�������$��10,10,10,10q�6�   ��5      �� 5       �� 
TargetType" ��6   .�5       �� 	 �� Property	 � y�
 �� Value$
 	Collapsed=�67    �� Triggers 5!      �� 5"       �� Binding 6*   �� *Text+ �� ElementName$ EnterRebelTextBox�� �� Value  6b   .a�5#   "   �� 	 � y�$
 Visible=�6?   5$      �� 5%       6*   �� $ InvoiceDate�� �� Path$ 	IsFocused� True6f   .a�5&   "   �� 	 � y�$
 	Collapsed=�6?   5'      5*      5,      �� 5.      $��Search��6   $��10,10,10,10q�6&   $��0��6;   $��1��6H   
�������6X   �� 50      $�� 10,10,10,10q�6   $��1��6.   $��1��6;   
�������6K   �� 51      $�� 10,10,10,10q�6   $��1��6.   $��0��6;   
�������6K   53      54      55      