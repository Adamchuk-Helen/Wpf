   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	   5clr-namespace:Weather.ViewModelWeather.ViewModel  5   	   7 clr-namespace:Weather.ConvertersWeather.Converters  5   	   7 clr-namespace:Weather.ConvertersWeather.Converters  5	   	   7 clr-namespace:Weather.ConvertersWeather.Converters  5
   	       Weather.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	   .vmclr-namespace:Weather.ViewModel     5   	   0con clr-namespace:Weather.Converters     5   	   2conbr clr-namespace:Weather.Converters     5	   	   3conimg clr-namespace:Weather.Converters     5
   	     � Title$  
MainWindow��5   	   $��766.038��6   $	��300��6-    � 	Resources 5      !   Weather.ViewModel.WeatherVM   vm-  'Weather.Converters.ConvertValueToString  con'  !Weather.Converters.ConvertToBrush 	 brush,  &Weather.Converters.ConvertValueToImage 
 conimg��%t   &	        &	      &	 &     &	 9       5   
   6     5   
   6#     5   
   6     5   
   6%   5      .��5      �  � DataContext# [  6   $��0,0,0,-2q�6.    � RowDefinitions 5   
   �� 5      $
��113* �6   �� 5      $
��325* �6   �� 5      $
��299* �6   .+�5   
   �� .+�5      �� $��5q�6   $��
Enter City��6   �� 5      $
��20,5q�6   ��6$   �� *Query+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Search��6   $	��100��6&   $��5q�62   ��6=   �� *searchCommand+��6_   �� *Query+5      �� 5   
   $��1��6   $��10,10,10,46q�6   ��64   �� *Cities+ �� SelectedItem 6S   �� *SelectedCity+��5       �� 5!      .R�5"      ��  �� Orientation$ 
Horizontal=�6!   .+�5#      �� $	��100��6$   ��60   �� *LocalizedName+�� 5$      $	��100��6$   ��60   �� *" AdministrativeArea.LocalizedName+�� 5%      $	��100��6$   ��60   �� *Country.LocalizedName+5&      5'      5)      �� 5*   
   $��2��6   .@�5+      �� $�� One Day Weather��6   ��5,      �� 5-      ��6"   �� *CurrentConditions.IsDayTime+ �� 	Converter# [ .+�5.      �� $
��City��6    �� 5/      $��5q�6$   ��6/   �� *SelectedCity.LocalizedName+�� 50      $��Temperature��6    �� 51      $��5q�6$   ��6/   �� *,*CurrentConditions.Temperature.Metric.Value+�� 52      $��Winter Text��6    �� 53      $��5q�6$   ��6/   �� *CurrentConditions.WeatherText+�� 54      $
��Icon��6    �� 55      $��5q�6    $��20��6+   $��30��67   $
��Left=�6B   $y�Visible=�6]   ��6s   �� *CurrentConditions.WeatherIcon+# [ �� 56      $��Precipitation��6    �� 57      $��5q�6$   ��6/   �� *$"CurrentConditions.HasPrecipitation+# [ 58      5:      �� 5<      $�� Five Days Weather��6   ��5=      �� 5>      .��5?      �� .@�5@      �� .+�5A      �� $
��Date��6$   �� 5B      $��5q�6(   ��63   �� *FiveDaysWeather.Date+�� 5C      $��Temperature��6$   �� 5D      $��5q�6(   ��63   �� *$"FiveDaysWeather.Temperature.Metric+�� 5E      $��Winter Text��6$   �� 5F      $��5q�6(   ��63   �� * FiveDaysWeather.Day.IconPhrase+5H      5I      5J      5L      5N      5O      5P      