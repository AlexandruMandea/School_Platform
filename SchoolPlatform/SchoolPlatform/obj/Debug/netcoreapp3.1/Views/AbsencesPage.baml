   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchoolPlatform.ViewsSchoolPlatform.Views  5      E'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      '    !SchoolPlatform.Views.AbsencesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SchoolPlatform.Views     5      7ctx'clr-namespace:SchoolPlatform.ViewModels     5      =	converter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  Absences Catalog��5       N� 
Background
 ����� � DataContext 5      )  #SchoolPlatform.ViewModels.TeacherVM  5   
   .��5      �  � 	Resources 5   
   0  *SchoolPlatform.Converters.AbsenceConverter   absenceConverter��%   &	          5      6)   5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��20 �6   �� 5      $	��200 �6   �� 5      $��40 �6   �� 5      $	��200 �6    � ColumnDefinitions 5    
   �� 5!      �� 5"      �� 5#      �� 5$      .+�5'   
   �� $��0��6   $��4��6!   $	��Top=�66   
���i��6N   �� 5)   
   $�� Show absences:��6   $��30(�6+   $��0��69   $��2��6F   $
��Left=�6Z   �� 5+   
   $��
Classroom:��6   $��0��6%   $��1��65   $��30��6B   $��16(�6N   $	��150��6\   $	��Top=�6h   �� 5,   
   $��Student:��6   $��1��6#   $��1��63   $��30��6@   $��16(�6L   $	��150��6Z   $	��Top=�6f   �� 5-   
   $��Subject name:��6   $��1��6(   $��2��65   $��30��6E   $��16(�6Q   $	��150��6_   $	��Top=�6k   �� 5.   
   $��	Semester:��6   $��1��6$   $��3��61   $��30��6A   $��16(�6M   $	��150��6[   $	��Top=�6g   �� 50   
   -   5        $��
Classrooms��50       �� DisplayMemberPath$
 Name��6P   $��2��6i   $��0��6v   $��30��6�   $��16(�6�   $	��150��6�   ��6%   �� *TeachersClassrooms+6�   �� 51   
   -   5        $��Students��51      $
 Name��6Y   $��2��6r   $��1��6   $��30��6�   $��16(�6�   $	��150��6�   ��6#   �� *StudentsFromSelectedClassroom+6�   �� 52   
   -   5        $��Subjects��52      $
 Name��6b   $��2��6{   $��2��6�   $��30��6�   $��16(�6�   $	��150��6�   ��6#   �� *(&SubjectsForTeacherForSelectedClassroom+6�   �� 53   
   -   5        $��Semester��53      $��2��6E   $��3��6R   $��30��6b   $��16(�6n   $	��150��6|   ��6#   �� *	Semesters+6�   &   System.Windows.Controls.DataGrid  55   
   -   5        $��AbsencesGrid��55      $��4��6'   $	��Top=�6;   $��Center=�6S   $��4��6p   $	��340��6}   $	��150��6�      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��56   d   $��Visible=�57      $��	55,0,55,0q�6F   	   SelectionMode$	 Single=�58      ��56      �� *AbsencesForAStudent+
 �� UpdateSourceTrigger$
 PropertyChanged=�   Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Subject��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *SubjectName+  5;      $
 Date��6%    63   �� *Date+  5<      $ Semester��6%    67   �� *
Semester+  5=      $ Can be excused��6%    6=   �� *CanBeExcused+  5>      $ Excused��6%    66   �� *	Excused+5@      �� 5B   
   -   5         ��Name$ Excuse��5B      $��Excuse Absence��6!   $��Bottom=�6:   $��10q�6U   $��4��6a   $��30��6n   $	��150��6z   $��18(�6�   $��4��6�   ��6�   �� *ExcuseAbsence+��6�   ��  �� ElementName$ AbsencesGrid�� �� Path$ SelectedItem��� 5D   
   $��4��6   $��4��6!   $��Bottom=�66   
���i��6Q   �� 5F   
   $�� Add an absence:��6   $��30(�6,   $��5��6:   $��2��6G   $
��Left=�6[   �� 5H   
   $��
Classroom:��6   $��0��6%   $��6��65   $��30��6B   $��16(�6N   $	��150��6\   $	��Top=�6h   �� 5I   
   $��Subject name:��6   $��6��6(   $��30��65   $��16(�6A   $	��150��6O   $	��Top=�6[   $��0,80,0,0q�6s   �� 5J   
   $��Date:��6   $��1��6    $��6��60   $��30��6=   $��16(�6I   $	��150��6W   $	��Top=�6c   �� 5K   
   $��	Semester:��6   $��2��6$   $��6��64   $��30��6A   $��16(�6M   $	��150��6[   $	��Top=�6g   �� 5L   
   $��Student's name:��6   $��3��6*   $��6��6:   $��30��6G   $��16(�6S   $	��150��6a   $	��Top=�6m   �� 5M   
   $��Can be excused:��6   $��1��6*   $��2��6:   $��Center=�6N   $��6��6i   $��30��6v   $��16(�6�   $	��125��6�   �� 5O   
   -   5        $��Classrooms2��5O      $
 Name��6�   $��6��6�   $	��Top=�6�   $
��0,30q�6�   $��0��6�   $��30��6�   $��16(�6	  $	��150��6   �� SelectedItem 6&   �� $ 
Classrooms��$ SelectedItem� �� Mode$ TwoWay=���6v   �� *TeachersClassrooms+6#  �� 5P   
   -   5        $��	Subjects2��5P      $
 Name��6c   $	��Top=�6|   $��	0,110,0,0q�6�   $��6��6�   $��0��6�   $��30��6�   $��16(�6�   $	��150��6�   ��6$   �� *(&SubjectsForTeacherForSelectedClassroom+6�   �� 5Q   
   -	   5        $��	Students2��5Q      $
 Name��6Z   $	��Top=�6s   $
��0,30q�6�   $��6��6�   $��3��6�   $��30��6�   $��16(�6�   $	��150��6�   ��6$   �� *StudentsFromSelectedClassroom+6�   �� 5R   
   -
   5         ��Name$
 Date��5R      $��6��6    $��1��6-   $��30��6=   $��16(�6I   $	��150��6W   $	��Top=�6c   $
��0,30q�6{   �� 5S   
   -   5        $ SemesterTextBox��5S      $��6��6+   $��2��68   $��30��6H   $��16(�6T   $	��150��6b   $	��Top=�6n   $
��0,30q�6�   �� 5U   
   -   5         ��Name$ CanBeExcusedChckB��5U      $��Center=�6.   $��Bottom=�6K   $��50q�6f   $��15��6r   $��15��6~   $��6��6�   $��1��6�   $��2��6�    � LayoutTransform 5V      �� 5W       �� ScaleX$ 2Q�6!    �� ScaleY$ 2Q�6,   5Y      �� 5[   
   -   5        $	 Add��5[      $��Add Absence��6   $��Bottom=�64   $��6��6O   $��40��6\   $	��150��6h   $��18(�6t   $��4��6�   ��6�   �� *
AddAbsence+��5\      `� 5]       `� 	Converter# [  6   .1�5^      �� $ 	Subjects2��6   $ SelectedItem.SubjectId�66   �� 5_      $
 Date��6   $
 Text�61   �� 5`      $ SemesterTextBox��6   $
 Text�6<   �� 5a      $ CanBeExcusedChckB��6   $ 	IsChecked�6>   �� 5b      $ 	Students2��6   $ SelectedItem.UserId�66   �� 5c      $ 	Subjects2��6   $ SelectedItem.Name�66   5d      5f      5g      5h      