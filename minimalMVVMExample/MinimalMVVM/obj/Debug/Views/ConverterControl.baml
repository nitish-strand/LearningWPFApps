   M S B A M L   `   `   `  ����F  BMinimalMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MinimalMVVM.ViewModelsMinimalMVVM.ViewModels  5      (    "MinimalMVVM.Views.ConverterControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;
ViewModels$clr-namespace:MinimalMVVM.ViewModels     5        J� InputBindings  5      �� 5   
   
 �� Key$ Enter��6    �� Command 6!   �� *ConvertTextCommand+.��5      �� $	��336��6   .+�5   
   �� 
����  �$��5,5,5,0q�6"   .��63   Text To Convert6D   �� 5   
   $��5q�6Q   ��6   �� *
SomeText+ �� UpdateSourceTrigger$ PropertyChanged=�6Q   �� 5   
   
����  �$��5,5,5,0q�6"   .��63   	History6<   �� 5   
   $	��200��62   $��5q�6?   ��6   �� *	History+6?   �� 5   
   $��5q�68   ��6   �� *ConvertTextCommand+.��6C   	Convert6L   5      5      