   M S B A M L   `   `   `  ����   ColorPicker    ColorPicker.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  
MainWindow��$	��650��$	��800��.��� $��0,0,0,4q� � ColumnDefinitions �� $
��465* ��� $
��236* � � RowDefinitions �� $
��214* ��� $
��401* �.+��� .+��� -    ��Name$ spAlpha�� �� Orientation$ 
Horizontal=�$��50��.+��� $��Alpha��$��10q��� -    ��Name$ slAlpha��$��10, 15q� � Minimum$ 0Q� � Maximum$	 255Q� �� IsSnapToTickEnabled . $	��400��	 � Value	 �� *Alpha+�� -   $ spRed��$ 
Horizontal=�$��50��.+��� $��Red   ��$��10q��� -   $ slRed��$��10, 15q�$ 0Q�$	 255Q� . $	��401��	 �� *Red+�� -   $ spGreen��$ 
Horizontal=�$��50��.+��� $��Green��$��10q��� -   $ slGreen��$��10, 15q�$ 0Q�$	 255Q� . $	��401��	 �� *Green+�� -   $ spBlue��$ 
Horizontal=�$��50��.+��� $��Blue ��$��10q��� -   $ slBlue��$��10, 15q�$ 0Q�$	 255Q� . $	��401��	 �� *Blue+�� -	   
 ��Name$
 lbColor��$��1��
���   �$��1q�$��20q����� *Brush+�� -
   $��1��$��1��$��50��$	��150��$	��Top=�$��20q�
��� � �$��18(�.��	Add color�� -   $ spShowColors��$��1��