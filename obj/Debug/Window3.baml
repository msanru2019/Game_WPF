   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   H DFinal_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Final_ProjectFinal_Project 5   	      Final_Project.Window3   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Y UMahApps.Metro.IconPacks.Modern, Version=2.3.0.4, Culture=neutral, PublicKeyToken=nullR NMahApps.Metro.IconPacks, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   )localclr-namespace:Final_Project   5   	     � Title$  Window3��5
   	   $	��450��6   $	��800��6&   (   "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5         ��Name$ home_button��5      $
��Home��6*   6V   �� 5      -   5        $ 
Memory_btn��5      $��Memory-Game��6)   6A   �� 5      -   5        $ 	Catch_btn��5      $��Catch-Me��6(   6=   �� 5      -   5        $ Stat_btn��5      $��	Statistic��6'   6=   �� 5      $��  ��6   6#   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��4 5 0 6q�6   $��Center=�6-   $��
Follow-US ��6H   6\   ,  &MahApps.Metro.IconPacks.PackIconModern  5      E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconModernKind, MahApps.Metro.IconPacks.Modern, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ SocialTwitter=�6+   $��20��6A   $��20��6L   $��0 5 0 2q�6X   6k     5      $ SocialFacebook=�6+   $��20��6B   $��20��6M   $��0 5 0 2q�6Y   6l     5      $ SocialWhatsapp=�6+   $��20��6B   $��20��6M   $��0 5 0 2q�6Y   6l   �� 5      $��  ��6   6'   5      5      .��5      � ���#36135A.+�5   
   �� -   5         ��Name$ catch_me��5      $��Catch-Me Game��6"   $
��Left=�6:   $	��Top=�6U   
�������$��Segoe UI Light)�6�   $
��Bold"�6�   $��36(�6�   �� 5   
   -   5         ��Name$ MyCanvas��5      $��63,81,58.6,60q�6#    J� OpacityMask �	#FF55147A���	#FF55147A.+�5      �� -   5        $ buttonStartStop��5      $��
Start/Stop��6.   $
��Left=�6C   $	��Top=�6^    �� Left$	 314��6v   
	 �� Top$		 182��6�   
��� � �
�������$��Segoe UI Light)�6�   $��22(�6�   �� 5      -   5        
 ��Name$
 checkBoxFast��5      $��
Tyson-mode��6-   $
��Left=�6B   $	��Top=�6]   $	 302��6u   $		 244��6�   
�������$
��Bold"�6�   $��Segoe UI Light)�6�   $��22(�6�   	� 5       -	   5         	�Name$ radioButtonRed��5       $	��Red��62   $
��Left=�6@   $	��Top=�6[    d� 	IsChecked$
 TrueY�6s   $ 10��6�   $	 10��6�   
�������$
��Bold"�6�   $��Segoe UI Light)�6�   $��20(�6�   6�   	� 5!      -
   5        $ radioButtonGreen��5!      $��Green��64   $
��Left=�6D   $	��Top=�6_   $ 97��6w   $	 10��6�   
�������$
��Bold"�6�   $��Segoe UI Light)�6�   $��20(�6�   6�   	� 5"      -   5        $ radioButtonBlue��5"      $
��Blue��63   $
��Left=�6B   $	��Top=�6]   $	 215��6u   $	 10��6�   
�������$
��Bold"�6�   $��Segoe UI Light)�6�   $��20(�6�   6�   A� 5#      -   5         A�Name$
 ball��5#      $��25��6B   $��25��6M   $	 150��6Y   $		 100��6k   
���  ��$	��Top=�6�   �� 5$      -   5        $ 
labelScore��5$      $��0��6(   $
��Left=�64   $	��Top=�6O   $	 479��6g   $		 219��6y   $��32��6�   $	��183��6�   
�������$
��Bold"�6�   $��Segoe UI Light)�6�   $��20(�6�   5%      5&      5'      