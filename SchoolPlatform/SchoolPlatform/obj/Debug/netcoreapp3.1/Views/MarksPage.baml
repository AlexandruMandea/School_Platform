   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchoolPlatform.ViewsSchoolPlatform.Views  5      E'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5	      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5
      $    SchoolPlatform.Views.MarksPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SchoolPlatform.Views     5      7ctx'clr-namespace:SchoolPlatform.ViewModels     5	      =	converter'clr-namespace:SchoolPlatform.Converters     5
        N� Title$  Marks Catalog��5       N� 
Background
 ����� � DataContext 5      )  #SchoolPlatform.ViewModels.TeacherVM  5   
   .��5      �  � 	Resources 5   
   -  'SchoolPlatform.Converters.MarkConverter   markConverter��%   &	          5      6&   5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��20 �6   �� 5      $	��200 �6   �� 5      $��40 �6   �� 5      $	��200 �6    � ColumnDefinitions 5    
   �� 5!      �� 5"      �� 5#      �� 5$      .+�5'   
   �� $��0��6   $��4��6!   $	��Top=�66   
���i��6N   �� 5)   
   $�� Show marks:��6   $��30(�6(   $��0��66   $��2��6C   $
��Left=�6W   �� 5+   
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
   -   5        $��	MarksGrid��55      $��4��6$   $	��Top=�68   $��Center=�6P   $��4��6m   $	��340��6z   $	��150��6�      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��56   a   $��Visible=�57      $��	55,0,55,0q�6F   	   SelectionMode$	 Single=�58      ��56      �� *MarksForAStudent+
 �� UpdateSourceTrigger$
 PropertyChanged=�   Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Subject��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *SubjectName+  5;      $
 Mark��6%    63   �� *Value+  5<      $
 Date��6%    63   �� *Date+  5=      $ Semester��6%    67   �� *
Semester+  5>      $ Thesis��6%    65   �� *Thesis+5@      �� 5B   
   -   5         ��Name$ Delete��5B      $��Delete mark��6!   $��Bottom=�67   $��10q�6R   $��4��6^   $��30��6k   $	��150��6w   $��18(�6�   $��4��6�   ��6�   �� *
DeleteMark+��6�   ��  �� ElementName$ 	MarksGrid�� �� Path$ SelectedItem��� 5D   
   $��4��6   $��4��6!   $��Bottom=�66   
���i��6Q   �� 5F   
   $�� Add a mark:��6   $��30(�6(   $��5��66   $��2��6C   $
��Left=�6W   �� 5H   
   $��
Classroom:��6   $��0��6%   $��6��65   $��30��6B   $��16(�6N   $	��150��6\   $	��Top=�6h   �� 5I   
   $��Subject name:��6   $��6��6(   $��30��65   $��16(�6A   $	��150��6O   $	��Top=�6[   $��0,80,0,0q�6s   �� 5J   
   $��Value:��6   $��2��6!   $��6��61   $��30��6>   $��16(�6J   $	��150��6X   $	��Top=�6d   �� 5K   
   $��Date:��6   $��3��6    $��6��60   $��30��6=   $��16(�6I   $	��150��6W   $	��Top=�6c   �� 5L   
   $��	Semester:��6   $��3��6$   $��6��64   $��30��6A   $��16(�6M   $	��150��6[   $	��top=�6g   $��0,80,0,0q�6   �� 5M   
   $��Student's name:��6   $��1��6*   $��6��6:   $��30��6G   $��16(�6S   $	��150��6a   $	��Top=�6m   �� 5O   
   -   5        $��Classrooms2��5O      $
 Name��6�   $��6��6�   $	��Top=�6�   $��0,30,0,0q�6�   $��0��6�   $��30��6  $��16(�6  $	��150��6   �� SelectedItem 6&   �� $ 
Classrooms��$ SelectedItem� �� Mode$ TwoWay=���6v   �� *TeachersClassrooms+6'  �� 5P   
   -   5        $��	Subjects2��5P      $
 Name��6c   $	��Top=�6|   $��	0,110,0,0q�6�   $��6��6�   $��0��6�   $��30��6�   $��16(�6�   $	��150��6�   ��6$   �� *(&SubjectsForTeacherForSelectedClassroom+6�   �� 5Q   
   -	   5        $��	Students2��5Q      $
 Name��6Z   $	��Top=�6s   $
��0,30q�6�   $��6��6�   $��1��6�   $��30��6�   $��16(�6�   $	��150��6�   ��6$   �� *StudentsFromSelectedClassroom+6�   �� 5R   
   -
   5         ��Name$ Value��5R      $��6��6!   $��2��6.   $��30��6>   $��16(�6J   $	��150��6X   $	��Top=�6d   $
��0,30q�6|   �� 5S   
   -   5        $
 Date��5S      $��6��6    $��3��6-   $��30��6=   $��16(�6I   $	��150��6W   $	��Top=�6c   $
��0,30q�6{   �� 5T   
   -   5        $��	Semester2��5T      $��6��6F   $��3��6S   $	��Top=�6c   $��	0,110,0,0q�6{   $��Center=�6�   $��30��6�   $��16(�6�   $	��150��6�   ��6$   �� *	Semesters+6�   �� 5V   
   $��Thesis:��6   $��6��6"   $��1��6/   $��2��6?   $��Center=�6S   $��Bottom=�6p   $��80q�6�   $��16(�6�   �� 5W   
   -   5         ��Name$ isThesisChckB��5W      $��Center=�6*   $��Bottom=�6G   $��50q�6b   $��15��6n   $��15��6z   $��6��6�   $��1��6�   $��2��6�    � LayoutTransform 5X      �� 5Y       �� ScaleX$ 2Q�6!    �� ScaleY$ 2Q�6,   5[      �� 5]   
   -   5        $	 Add��5]      $��Add mark��6   $��Bottom=�61   $��6��6L   $��40��6Y   $	��150��6e   $��18(�6q   $��4��6   ��6�   �� *	AddMark+��5^      `� 5_       `� 	Converter# [  6   .1�5`      �� $ 	Subjects2��6   $ SelectedItem.SubjectId�66   �� 5a      $ Value��6   $
 Text�62   �� 5b      $
 Date��6   $
 Text�61   �� 5c      $ 	Semester2��6   $ SelectedItem�66   �� 5d      $ 	Students2��6   $ SelectedItem.UserId�66   �� 5e      $ 	Subjects2��6   $ SelectedItem.Name�66   �� 5f      $ isThesisChckB��6   $ 	IsChecked�6:   5g      5i      5j      5k      