   M S B A M L   `   `   `  ����K  GFinalExamination, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FinalExaminationFinalExamination  5   	   %    FinalExamination.WardrobeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   J FWpfAnimatedGif, Version=1.4.15.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   *localclr-namespace:FinalExamination  5   	   -   5          �Name$  WardrobePage��5   	    � Title$ Wardrobe Control��5	   	   $	��640��6"   $	��960��6/    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ NoResize=�6`   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFBAB5DA��6    � Offset$ 0Q�6-   � 5      $ 	#FF4735B8��6   $
 0.75Q�6-   5      .��5      � .+�5   
   �� ���	#FFF0C6EE$
��Left=�6%   $	��200��6@   $��665,178,0,0q�6M    �� RadiusY$ 19.833��6b   	 �� RadiusX$	 19.833��6s   
���   �$	��Top=�6�   $	��167��6�   �� 5   
   -   5        
 ��Name$
 
MainHeader��5      $��253,10,236,0q�6$   $��Stencil)�6:   $��36(�6O   $
��Bold"�6]   ���	#FF040303$��60��6�   $	��Top=�6�   $��Center=�6�   $	��465��6�   $��Wardrobe Control Pad��6�   �� 5   
   -   5         ��Name$ WardrobeCamera��5      $
��Left=�6(   $	��346��6C   $	��Top=�6P   $	��500��6h   $��100,178,0,0q�6t   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ Assets/Wardrobe/giphy.gif��6�   �� 5   
   -   5         ��Name$ DressCodeGrid��5      $
��Left=�6*   $	��200��6E   $��665,178,0,0q�6R   $	��Top=�6g   $	��167��6   $��Segoe UI)�6�   ��6�   Z� ��6�   Z� .@�5      �� -   5         ��Name$ CasualDressCodeButton��5      $��Casual��64   $	��150��6E   $��40��6Q   
�������$��20(�6o   $��	0,15,0,10q�6}   6�   �� 5      -   5        $ BussinessDressCodeButton��5      $��Business��67   $	��150��6J   $��40��6V   
�������$��20(�6t   $��0,5,0,10q�6�   6�   �� 5      -   5        $ FormalDressCodeButton��5      $��Formal��64   $	��150��6E   $��40��6Q   
�������$��20(�6o   $��0,5,0,0q�6}   6�   5      �� 5   
   -   5        $ lightsImage��5      $
��Left=�6%   $��45��6@   $��787,128,0,0q�6L   $	��Top=�6a   $��45��6y   $!��Assets/Wardrobe/clothes.png��6�   �� 5   
   -	   5        $
 DressCodeHeader��5      $
��Left=�6)   $��36��6D   $��665,128,0,0q�6P   $��
Dress Code��6e   $	��133��6z   $��24(�6�   $y�Visible=�6�   $	��Top=�6�   �� 5   
   -
   5        $
 WardrobeCamHeader��5      $
��Left=�6+   $��50��6F   $��203,128,0,0q�6R   $��Wardrobe Camera��6g   $	��Top=�6�   $	��318��6�   $��36(�6�   $y�Visible=�6�   �� 5   
   -   5        $ 	HelpImage��5      $��Assets/helpbutton.png��6#   $��50��6B   $��50��6M   $��894,551,0,0q�6Y   $
��Left=�6n   $	��Top=�6�   6�   5      5      