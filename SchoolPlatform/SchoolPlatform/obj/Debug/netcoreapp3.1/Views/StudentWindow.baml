   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchoolPlatform.ViewsSchoolPlatform.Views  5   	   E'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5   	   (    "SchoolPlatform.Views.StudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SchoolPlatform.Views     5   	   7ctx'clr-namespace:SchoolPlatform.ViewModels     5   	     � Title$  Student��5	   	   $	��450��6   $	��800��6&   
������� � DataContext 5      )  #SchoolPlatform.ViewModels.StudentVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��40 �6   �� 5      $	��110 �6   �� 5      $��40 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��2��6!   $��30(�65   $��5,5,0,0q�6a   ��6C   �� *Student.Name+6a   �� 5   
   $��1��6   $��0��6!   $��Marks:��61   $	��290��6?   $��23(�6K   �� 5    
   $��1��6   $��1��6!   $��	Absences:��61   $	��290��6B   $��23(�6N   �� 5!   
   $��3��6   $��2��6!   $��	Averages:��65   $	��290��6F   $��23(�6R   �� 5#   
   -   5        $��Subjects��5#       �� DisplayMemberPath$
 Name��6Q   $��0��6j   $��40��6w   $��23(�6�   $	��200��6�   $��Bottom=�6�   $��2��6�   ��6#   �� *SubjectsFromClassroom+6�   &   System.Windows.Controls.DataGrid  5%   
   -   5        $��	MarksGrid��5%      $��2��6$   $	��290��61   $	��110��6=      AutoGenerateColumns$ False��6J      
IsReadOnly$
 True��5&   a   $��Visible=�5'      ��5&      �� *MarksForASubject+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Subject��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *SubjectName+  5*      $
	 Mark��6%   
 63   �� *Value+  5+      $
	 Date��6%   
 63   �� *Date+  5,      $	 Thesis��6%   
 65   �� *Thesis+5.        50   
   -   5        $��AbsencesGrid��50      $��2��6'   $��1��64   $	��290��6D   $	��110��6P   $ False��6]   $
 True��51   d   $��Visible=�52      $��	55,0,55,0q�6F   ��51      �� *AbsencesForASubject+$ PropertyChanged=� 53        54      $	 Subject��6%   
 66   �� *SubjectName+  55      $
	 Date��6%   
 63   �� *Date+  56      $	 Can be excused��6%   
 6=   �� *CanBeExcused+  57      $	 Excused��6%   
 66   �� *	Excused+59        5;   
   -   5        $��AveragsGrid��5;      $��4��6&   $	��Top=�63   $��2��6K   $	��290��6_   $	��110��6k   $ False��6x   $
 True��5<   Y   $��Visible=�5=      $��	55,0,55,0q�6F   ��5<      �� *
Averages+$ PropertyChanged=� 5>        5?      $	 Subject��6%   
 66   �� *SubjectName+  5@      $	 Value��6%   
 64   �� *Value+  5A      $	 Semester��6%   
 67   �� *
Semester+5C      5D      5E      