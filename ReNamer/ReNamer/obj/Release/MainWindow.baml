   M S B A M L   `   `   `  ���� B  >ReNamer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:VideoDemo	VideoDemo      VideoDemo.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:VideoDemo       � Title$   ReNamer��$	��380��$	��270�����	#FF454545 � 
ResizeMode$ NoResize=� � Icon$ icon.png��$
��Left=�$	��Top=�.���� $
��Left=�$	��350��$	��Top=�$	��255��.��� -    �Name$ My_reNameGrid��$��0q�$	��700��$	��230��$
��Left=�$	��Top=�.+��� -    ��Name$ 	My_PsText��$��Center=�$
��Wrap=�$��拖拽文件进入��$	��Top=�$��0,60,0,0q�$	��120�����	#FFBFBFBF �� TextAlignment$ Center=��� -    ��Name$ 
My_ListBox��$��Center=�$	��100��$	��Top=�$	��200��$��0,20,0,0q����	#FFBFBFBF���	#7F1D1D1D J� 	AllowDrop . �� -   $ My_TB_Seach��$��Center=�$
��Wrap=�$��寻找��$	��Top=�$��-100,155,0,0q�$��50�����	#FFBFBFBF$ Center=��� $��Center=�$
��Wrap=�$	��Top=�$��-100,205,0,0q�$��50�����	#FFBFBFBF$ Center=�$��替换���� -    ��Name$ 
My_oldText��$��Center=�$��25��	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��120��$��0,150,-80,0q����	#FF313131���	#FFBFBFBF�� -   $ 
My_newText��$��Center=�$��25��$
	 Wrap=�$	��Top=�$	��120��$��0,200,-80,0q����	#FF313131���	#FFBFBFBF�� -   
 ��Name$
 ReplaceButton��$��批量替换关键词��$��Center=�$	��Top=�$	��200��$��25�����	#FF595959���	#FFBFBFBF$��	0,250,0,0q��� -   $ My_RenameText��$��Center=�$��25��$
	 Wrap=�$	��Top=�$	��120��$��0,355,-80,0q����	#FF313131���	#FFBFBFBF�� $��Center=�$
��Wrap=�$��重命名为��$	��Top=�$��-100,360,0,0q�$��50�����	#FFBFBFBF$ Center=��� -	   $
 RenameButton��$��批量重命名��$��Center=�$	��Top=�$	��200��$��25�����	#FF595959���	#FFBFBFBF$��	0,455,0,0q��� -
   $ 
My_AddText��$��Center=�$��25��$
	 Wrap=�$	��Top=�$	��120��$��0,530,-80,0q����	#FF313131���	#FFBFBFBF�� -   $
 AddStringButton��$'��!插入命名（默认从头部）��$��Center=�$	��Top=�$	��200��$��25�����	#FF595959���	#FFBFBFBF$��	0,580,0,0q��� -    ��Name$ My_CheckBox��$��	从尾部��$��Center=�$	��Top=�$��-120,535,0,0q����	#FFBFBFBF�� $��Center=�$
��Wrap=�$)��# -本软件永久免费-ZeroSkyline��$��Center=�$��	0,630,0,0q�$	��120�����	#FFBFBFBF$��10(�$ Center=��� -   $ My_R_StarIndex��$��Center=�$��25��$
	 Wrap=�$	��Top=�$	��120��$��
80,405,0,0q����	#FF313131���	#FFBFBFBF$��0�� �� TextAlignment$ Center=��� $��Center=�$
��Wrap=�$	��Top=�$��-120,410,0,0q�$��80�����	#FFBFBFBF$ Center=��� $�结尾���� $�序号起点���� -   $ 
My_C_Regex��$��使用正则表达式��$��Center=�$	��Top=�$��	0,290,0,0q����	#FFBFBFBF