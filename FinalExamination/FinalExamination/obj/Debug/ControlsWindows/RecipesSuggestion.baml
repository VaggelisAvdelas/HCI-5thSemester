   M S B A M L   `   `   `  ����K  GFinalExamination, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:FinalExamination.ControlsWindows FinalExamination.ControlsWindows  5   	   8    2FinalExamination.ControlsWindows.RecipesSuggestion   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:FinalExamination.ControlsWindows     5   	   -   5          �Name$  Recipes��5   	    � Title$ Recipes��5   	   $	��450��6   $	��460��6&   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFF32A2A��6    � Offset$ 0Q�6-   � 5      $ 	#FFF08383��6   $
 0.75Q�6-   5      .��5      � .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��127��6@   $��	44,10,0,0q�6M   
���   �$	��Top=�6o   $	��354��6�   �� 5   
   -   5         ��Name$ OnlineRecipes��5      $��Search Online��6(   $
��Left=�6@   $��31��6[   $��278,142,0,0q�6g   $	��Top=�6|   $	��120��6�    J� RenderTransformOrigin$ 0.446,8.974&�6�   $��16(�6�   �� 5   
   -   5         ��Name$ RecipeImage��5      $
��Left=�6%   $	��127��6@   $	��Top=�6M   $	��163��6e   $��
235,10,0,0q�6q   $
��Fill=�6�   �� 5   
   -   5        	 ��Name$	 RecipesListView��5      $
��Left=�6,   $	��127��6G   $��	44,10,0,0q�6T   $	��Top=�6g   $	��191��6   .@�5      �� -   5        $ BologneseRec��5      $��	Bolognese��6+   $	��177��6?   $��16(�6f   �� 5      -   5        $ PastitsioRec��5      $��	Pastitsio��6+   $	��177��6?   $��16(�6f   �� 5      -   5        $ 
ChickenRec��5      $��Chicken Ala Cream��6)   $	��177��6E   $��16(�6j   5      �� 5   
   -   5        $ 	AddRecipe��5      $��
Add Recipe��6$   $��44,142,207,246q�69   $��16(�6i   � 5   
   $
��Left=�6   $	��187��6*   $��
14,209,0,0q�67   $	��Top=�6K   $	��309��6c   ���	#FFE47070.+�5      �� $��Ingredients��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $
��Bold"�6p   ���	#FF474949$��14(�6�   �� 5      $��Quantity��6   $
��Left=�6'   $��
120,10,0,0q�6B   $	��Top=�6V   $
��Bold"�6n   ���	#FF474949$��14(�6�   �� 5      $��Stock in Fridge��6   $
��Left=�6.   $��
198,10,0,0q�6I   $	��Top=�6]   $
��Bold"�6u   ���	#FF474949$��14(�6�   5      �� 5   
   -	   5        
 ��Name$
 IngredientsTextblock��5      $
��Left=�62   $��
40,256,0,0q�6M   $
��Wrap=�6a   $	��Top=�6u   $	��120��6�   $��78��6�   
�������6�   �� 5    
   -
   5        $
 QuantityTextblock��5       $
��Left=�6/   $��142,256,0,0q�6J   $
��Wrap=�6_   $	��Top=�6s   $	��120��6�   $��35��6�   
�������6�   �� 5!   
   -   5        $
 StockTextbox��5!      $
��Left=�6*   $��235,256,0,0q�6E   $
��Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��42��6�   
�������6�   �� 5"   
   -   5        $ OrderButton��5"      $��Order Missing Items��6&   $��329,288,0,0q�6D   $	��Top=�6Y   $��29��6q   $
��Left=�6}   $	��113��6�   6�   5$      5%      