   M S B A M L   `   `   `  ����N  JSwabianWPFChallenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SwabianWPFChallenge.ViewsSwabianWPFChallenge.Views  5      ,    &SwabianWPFChallenge.Views.EquationView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SwabianWPFChallenge.Views     5      R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5      .��5
      � $��15q�6     � ColumnDefinitions  5   
   �� 5      $��50 �6   �� 5      $	��400 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Swabian WPF Challenge��6   $��0��5      $��1��5      $��2��5      $��30(�5      $��Center=�5       $
��Bold"�5!      $	��5,8q�5"       �� Padding$ 3q�5#      �� 5$   
   $��Coefficients��6   $��25(�5%      $
��Bold"�5&      $��1��5'      $��0��5(      $	��5,8q�5)      $��2��5*      $ 3q�5+      �� 5,   
   $��a:��6   $��20(�5-      $��2��5.      $��0��5/      $	��Top=�50      $	��5,8q�51      $ 3q�52      �� 53   
   $��b:��6   $��20(�54      $��3��55      $��0��56      $	��Top=�57      $	��5,8q�58      $ 3q�59      �� 5;   
   -   5        $
��txtA��5;      $��2��5<      $��1��5=      $	��5,8q�5>      $��30��5?      $��50��5@      $��3q�5A      $
��Left=�5B      $	��Top=�5C       �� TextAlignment$
 Left=�5D      ��5E      ��  �� Path$ A� �� Mode$ TwoWay=��� 5F   
   -   5        $
��txtB��5F      $��3��5G      $��1��5H      $	��5,8q�5I      $��30��5J      $��50��5K      $��3q�5L      $
��Left=�5M      $	��Top=�5N      $
 Left=�5O      ��5P      �� $ B�$ TwoWay=��� 5Q   
   -   5        $��txtBlockMessage��5Q      $��4��5R      $��1��5S      $	��5,8q�5T      $ 3q�5U      $��20(�5V      $
��Bold"�5W      ��5X      �� $ Message�$ OneWay=��� 5[   
    �� Orientation$ 
Horizontal=�6   $��5��5\      $��0��5]      $��2��5^      .+�5_      �� -   5        $��	btnLinear��5_      $��Linear��5`      $	��5,8q�5a      $��3q�5b      $��80��5c      ��5d      �� $ LinearCommand��� 5e      -   5        $��btnExponential��5e      $��Exponential��5f      $	��5,8q�5g      $��3q�5h      $	��150��5i      ��5j      �� $ ExponentialCommand��� 5k      -   5        $��btnPowerFunction��5k      $��Power Function��5l      $	��5,8q�5m      $��3q�5n      $	��150��5o      ��5p      �� $ PowerFunctionCommand�5r      �� 5t   
   -   5         ��Name$ 
ActiveItem��5u      $��1��5t      $��2��6&   $��5��66   5u      5w      5y      