   M S B A M L   `   `   `  ����E  AHelloWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HelloWorld
HelloWorld  5   	       HelloWorld.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:HelloWorld     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � WindowState$ 	Maximized=�65   .��5	      �� -   5         ��Name$ uxContainer��5	      
�������.+�5
   
   �� -   5         ��Name$ uxList��5
       �� View 5      �� 5      .P�5      �� $��	User Name��6O    �� Width$	 100��6b    �� DisplayMemberBinding 6%   �� *
UserName+6b   �� 5      $��Password��6S   $	 100��6e    6%   �� *UserPassword+6e   �� 5      $	��Age��6N   $	 100��6[    6%   �� *	UserAge+6[   5      5      �� 5   
   Enter Name:6!   �� 5   
   -   5         ��Name$ uxName��5      ��5   	   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnDataErrors	 . .��6`   5      �� 5   
   -   5        
 ��Name$
 uxNameError��5      ��5      �� *	NameError+$ PropertyChanged=�6R   �� 5   
   Enter Password:6%   G� 5   
   -   5         G�Name$ 
uxPassword��5      6,   �� 5   
   -   5         ��Name$ uxSubmit��5      
�������.��6V   Submit��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � {� �� Value . 62    �� Triggers 5      �� 5        �� Binding 6&   �� *Text+ �� ElementName$ uxName�� �� Value  6S   .a�5!      ��  � {� .  6:   5"      5$      5&      �� 5'   
   .��5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $*��$Images/ic_thumb_up_black_24dp_2x.png��6   �� 5*      $��	Thumbs Up��6   5+      5,      �� 5-   
   .��5.      �� .��6   
Check Me6!   5/      50      52      