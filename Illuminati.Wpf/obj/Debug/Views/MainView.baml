   M S B A M L   `   `   `  ����R  NMvvmCross.Platforms.Wpf, Version=8.0.2.0, Culture=neutral, PublicKeyToken=nullnLclr-namespace:MvvmCross.Platforms.Wpf.Views;assembly=MvvmCross.Platforms.WpfMvvmCross.Platforms.Wpf.Views  5      rNclr-namespace:MvvmCross.Platforms.Wpf.Binding;assembly=MvvmCross.Platforms.WpfMvvmCross.Platforms.Wpf.Binding  5      I EIlluminati.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Illuminati.Wpf.ViewsIlluminati.Wpf.Views 5	      J FIlluminati.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:Illuminati.Core.ViewModels;assembly=Illuminati.CoreIlluminati.Core.ViewModels 5      #   Illuminati.Wpf.Views.MainView   5      VviewsLclr-namespace:MvvmCross.Platforms.Wpf.Views;assembly=MvvmCross.Platforms.Wpf  VmvxNclr-namespace:MvvmCross.Platforms.Wpf.Binding;assembly=MvvmCross.Platforms.Wpf  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Illuminati.Wpf.Views     5	      X
viewmodelsAclr-namespace:Illuminati.Core.ViewModels;assembly=Illuminati.Core     5      -   5        .   (MvvmCross.Platforms.Wpf.Views.MvxWpfView   Name$
  main��5
      .��5      � .+�5   
   �� $	��120��6    K� ZIndex$ 1��6!   .+�5      �� -   5         ��Name$ SPlayers��5      ��6)   �� *	Players+ �� SelectedIndex 6I   �� *SelectedPlayerIndex+ �� SelectedItem 6w   �� *PlayersView+5      �� 5   
   $��20��6   $ 1��6`   $	��Top=�6q   $��Right=�6�   $��	20,6,20,0q�6�   ��6!   �� *ActionCount+ �� StringFormat$ Actions left: {0}��6�   �� 5   
   $	��120��6   $ 1��6"   $��Right=�63   $��
0,30,0,302q�6O   
������ .+�5      �� -   5         ��Name$ AttacktoControl��5      $��Attack to Control��6R   $	��100��6n   $��20��6z   (   "MvvmCross.Platforms.Wpf.Binding.Bi	   nd$$ Command AttacktoControlCommand��6�   {�6.   �� *ButtonEnabled+6�   �� 5      -   5        $ AttacktoDestroy��5      $��Attack to Destroy��6R   $	��100��6n   $��20��6z   $$ Command AttacktoDestroyCommand��6�   {�6.   �� *ButtonEnabled+6�   �� 5      -   5        $ AttacktoNeutralize��5      $��Attack to Neutralize��6U   $	��100��6t   $��20��6�   $' !Command AttacktoNeutralizeCommand��6�   {�61   �� *ButtonEnabled+6�   �� 5      -   5        $ 	MoveGroup��5      $��
Move Group��6L   $	��100��6a   $��20��6m   $ Command MoveGroupCommand��6y   {�6(   �� *ButtonEnabled+6y   �� 5      -   5        $ TransferMoney��5      $��Transfer Money��6P   $	��100��6i   $��20��6u   $" Command TransferMoneyCommand��6�   {�6,   �� *ButtonEnabled+6�   �� 5      -   5        $ 	DropGroup��5      $��
Drop Group��6(   $	��100��6=   $��20��6I   $ Command DropGroupCommand��6U   �� 5      -	   5        $ EndTurn��5      $��End Turn��6&   $	��100��69   $��20��6E   $ Command EndTurnCommand��6Q   5       � 5"   
   $��Center=�65   $��Center=�6R   $ 1��6m   
�������$��50��6�   $��326,445,326,105q�6�   $	��268��6�   y�6   �� *SliderEnabled+ � ColumnDefinitions 5#      �� 5$      $
��250* �6#   �� 5%      $
��250* �6#   .+�5'      �� -
   5        $��R��5'      	 �� Orientation$	 
Horizontal=�6   
 � Minimum$
 0Q�5(       �� TickPlacement$ BottomRight=�5)       �� TickFrequency$ 1Q�6-    �� IsSnapToTickEnabled . $��Center=�6Z   $��2��6�   $��
0,13,28,13q�6�    � Maximum 5(      �� *	CardValue+ � Value 5)   u   �� *SliderValue+6�   �� 5*      $
��Left=�6C   $��1��6^   $��128,17,0,17q�6n   $��Center=�6�   ��6   ��  �� ElementName$ R�� �� Path$ Value�6�   5+      � 5-   
   $��Center=�68   $��Center=�6U   $ 1��6p   
�������$��50��6�   y�6   �� *SelectionEnabled+ 5.      �� 5/      $
��250* �6#   �� 50      $
��250* �6#   .+�52      �� -   5        $ SPlayer��52      $ 0��6x   ��6(   �� *SelectionPlayers+ 6Q   �� *SelectionPlay+6x   53      �� 55      -   5        $��listBox��55      $	��460��6<   $	��100��6H   ���	#00000000
���   �$ 1��6�   $
��Left=�6�   $��Bottom=�6�   
���   ���6   �� *
Messages+56      >� 58      -   5        $��PlayerViews��58      ��6#   �� *PlayersView+ � 	Resources 59       �� DataType0  *Illuminati.Core.ViewModels.PlayerViewModel%  Illuminati.Wpf.Views.PlayerView6  0Illuminati.Core.ViewModels.UncontrolledViewModel+  %Illuminati.Wpf.Views.UncontrolledView��%�   (��       5:      *, +)(�� 2     5=      *, +)�� 5:      "  6   .R�5;        5<      �� 5=      "  6   .R�5>        5?      5@      5A      5B      5C      