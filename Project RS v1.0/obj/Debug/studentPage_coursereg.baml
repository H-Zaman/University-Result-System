   M S B A M L   `   `   `  ����J  FProject RS v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project_RS_v1._0Project_RS_v1._0  5      ,    &Project_RS_v1._0.studentPage_coursereg   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Project_RS_v1._0     5        N� Title$  studentPage_coursereg��5	      .��5      � ���	#FF958F8F � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $
��280* �6   �� 5      $	��31* �6    � ColumnDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��155* �6   �� 5      $	��20* �6   �� 5      $
��380* �6   �� 5      $	��18* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grid_stuCourseReg��5         CanUserAddRows .  $��3��6E   $
��Left=�6U   $	��210��6p   $��1��6}   $	��Top=�6�   $	��380��6�   6�   �� 5   
   -   5         ��Name$ btn_registerCourse��5      $��Regsiter��6-   $��3��6@   $
��Left=�6P   $��45��6k   $��120,225,0,0q�6w   $��1��6�   $	��Top=�6�   $	��130��6�   6�   �� 5   
   -   5        $ btn_show��5      $
��Show��6#   $��1��62   $
��Left=�6B   $��35��6]   $��
15,245,0,0q�6i   $��1��6}   $	��Top=�6�   $	��130��6�   6�   �� 5   
   -   5         ��Name$ label��5      $��Select Year :��6   $��1��67   $
��Left=�6G   $��35��6b   $��1��6n   $	��Top=�6{   $	��155��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Select Semester :��6$   $��1��6@   $
��Left=�6P   $��35��6k   $��1��6w   $	��Top=�6�   $	��155��6�   $��	0,120,0,0q�6�   �� 5   
   -   5         ��Name$ 	comboYear��5      $��1��6&   $
��Left=�66   $��40��6Q   $��0,40,0,0q�6]   $��1��6o   $	��Top=�6|   $	��155��6�   .@�5      �� $	��1st��6   �� 5      $	��2nd��6   �� 5       $	��3rd��6   5!      �� 5"   
   -   5        $ comboSem��5"      $��1��6%   $
��Left=�65   $��40��6P   $��	0,160,0,0q�6\   $��1��6o   $	��Top=�6|   $	��155��6�   .@�5#      �� $	��1st��6   �� 5$      $	��2nd��6   �� 5%      $	��3rd��6   �� 5&      5'      5)      5*      