   M S B A M L   `   `   `  ����F  BFirstWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FirstWPFApp.ViewModelFirstWPFApp.ViewModel  5   	       FirstWPFApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9	ViewModel#clr-namespace:FirstWPFApp.ViewModel     5   	     � Title$  FirstWindow��5   	   $	��450��6   $	��600��6*    � DataContext 5	      !   FirstWPFApp.ViewModel.Agent  5
   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5      �� $	��Top=�6   $
��Left=�6)   $��0��6D   .+�5   
   �� $��48(�6   Enter Details!62   �� 5   
   $��5q�6   First Name:6-   �� 5      -   5         ��Name$ fn��5      $��5q�6#   ��6.   �� *Fname+�� 5   
   $��5q�6   
Last Name:6+   �� 5      $��5q�6   ��6!   �� *Lname+�� 5   
   $��5q�6   $	��Age��6   �� 5      $��5q�6   ��6!   �� *Age+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5       $	��Top=�6   $��Right=�6)   $��1��6E   $
��50,0q�6U   .+�5!      �� $��38(�6   
Verdict :-62   �� 5"      ��6   �� *Info+ �� Mode$ OneWay=�5#      5$      5&      