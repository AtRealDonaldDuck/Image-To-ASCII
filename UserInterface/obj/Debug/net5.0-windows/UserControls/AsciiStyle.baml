   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:UserInterfaceUserInterface  5      +    %UserInterface.UserControls.AsciiStyle   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:UserInterface     5      -   5          >�Name$  AsciiStyleUserControl��5      $��60��5
      $	��200��6   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ btnAddCharacterSlot��5      $��+��6.    � ToolTip$* $Add a slot for a new ASCII character��6:   $��1��6i   $��0��6y   5      �� 5   
   -   5        $ btnRemoveCharacterSlot��5      $��-��61   $6 0Remove the rightmost slot for an ASCII character��6=   $��1��6x   $��1��6�   5      �� 5   
   -   5         ��Name$ brdrBlackToWhiteGradient��5      $��0��63   $��1q�6A   
���   ���5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � -   5        grdntStpLeft�� � Offset$ 0Q�5   9   	 � Color$	 #000000��6D   � 5      -   5        grdntStpRight��$ 1Q�5   :   $	 #ffffff��6E   5      5!      �� 5"   
   -   5        $ btnReverseGradient��5"      $	��↔��6-   $��0��69   $��Center=�6F   $��Center=�6c   $y�	Collapsed=�6~   6�   � 5$   
   -   5        
 �Name$
 grdCharactersPanel��5$      $��1��6+   5&      5'      5(      