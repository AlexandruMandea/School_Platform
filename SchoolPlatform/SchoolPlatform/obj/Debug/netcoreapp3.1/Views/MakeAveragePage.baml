   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchoolPlatform.ViewsSchoolPlatform.Views  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      E'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      *    $SchoolPlatform.Views.MakeAveragePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SchoolPlatform.Views     5      =	converter'clr-namespace:SchoolPlatform.Converters     5      7ctx'clr-namespace:SchoolPlatform.ViewModels     5        N� Title$  MakeAveragePage��5       N� 
Background
 ����� � DataContext 5      )  #SchoolPlatform.ViewModels.TeacherVM  5   
   .��5      �  � 	Resources 5   
   0  *SchoolPlatform.Converters.AverageConverter   averageConverter��%   &	          5      6)   5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��90 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��20 �6   �� 5      $	��200 �6    � ColumnDefinitions 5   
   �� 5       �� 5!      �� 5"      �� 5#      .+�5&   
   �� $�� Make average:��6   $��30(�6*   $��0��68   $��2��6E   $
��Left=�6Y   �� 5(   
   $��
Classroom:��6   $��0��6%   $��2��65   $��30��6B   $��16(�6N   $	��150��6\   $	��Top=�6h   �� 5)   
   $��Student:��6   $��1��6#   $��2��63   $��30��6@   $��16(�6L   $	��150��6Z   $	��Top=�6f   �� 5*   
   $��Subject name:��6   $��2��6(   $��2��65   $��30��6E   $��16(�6Q   $	��150��6_   $	��Top=�6k   �� 5+   
   $��	Semester:��6   $��2��6$   $��3��61   $��30��6A   $��16(�6M   $	��150��6[   $	��Top=�6g   �� 5-   
   -   5        $��
Classrooms��5-       �� DisplayMemberPath$
 Name��6P   $��3��6i   $��0��6v   $��30��6�   $��16(�6�   $	��150��6�   ��6%   �� *TeachersClassrooms+6�   �� 5.   
   -   5        $��Students��5.      $
 Name��6Y   $��3��6r   $��1��6   $��30��6�   $��16(�6�   $	��150��6�   ��6#   �� *StudentsFromSelectedClassroom+6�   �� 5/   
   -   5        $��Subjects��5/      $
 Name��6b   $��3��6{   $��2��6�   $��30��6�   $��16(�6�   $	��150��6�   ��6#   �� *(&SubjectsForTeacherForSelectedClassroom+6�   �� 50   
   -   5        $��Semester��50      $��3��6E   $��3��6R   $��30��6b   $��16(�6n   $	��150��6|   ��6#   �� *	Semesters+6|   �� 52   
   -   5         ��Name$ makeAverage��52      $��Make average��6&   $��Center=�6=   $��5��6X   $��40��6e   $	��150��6q   $��18(�6}   $��4��6�   ��6�   �� *MakeAverage+��53      `� 54       `� 	Converter# [  6   .1�55      �� 	 �� ElementName$	 Semester��6   
 �� Path$
 SelectedItem�65   �� 56      $	 Subjects��6   $
 SelectedItem.SubjectId�65   �� 57      $	 Students��6   $
 SelectedItem.UserId�65   58      5:      5;      5<      