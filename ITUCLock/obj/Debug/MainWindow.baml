   M S B A M L   `   `   `  ����C  ?ITUCLock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ITUCLockITUCLock  5   	   /clr-namespace:ITUCLock.ViewsITUCLock.Views  5   	   9!clr-namespace:ITUCLock.ViewModelsITUCLock.ViewModels  5   	       ITUCLock.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ITUCLock     5   	   3
viewmodelsclr-namespace:ITUCLock.Views     5   	   3views!clr-namespace:ITUCLock.ViewModels     5   	     � Title$  
MainWindow��5
   	   $	��356��6   $	��310��6)    � WindowStyle$
 None=�65    � 	Resources 5       �� DataType)   #ITUCLock.ViewModels.analogViewModel   ITUCLock.Views.analogView � DataContext(   "ITUCLock.ViewModels.digitViewModel   ITUCLock.Views.digitView(   "ITUCLock.ViewModels.alarmViewModel   ITUCLock.Views.alarm,   &ITUCLock.ViewModels.stopwatchViewModel   ITUCLock.Views.stopwatch(	   "ITUCLock.ViewModels.timerViewModel
   ITUCLock.Views.timer��%0  (��       5   3   *, +)(�� W     5   2   *, +)(�� �     5   2   *, +)(��     5   6   *, +)(�� ]    5   2   *,	 +)�� 5   
   analogViewTemplate��"  63   .R�5         6$   �� 5      �� 5   
   digitViewTemplate��"  62   .R�5         6#   �� 5      �� 5   
   alarmViewTemplate��"  62   .R�5         6   �� 5      �� 5   
   stopwatchViewTemplate��"  66   .R�5         6#   �� 5      �� 5   
   timerViewTemplate��" 	 62   .R�5      
   6   �� 5      5      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5"   
   �� 5#      $	��93* �6   �� 5$      $	��23* �6   .+�5&   
   ��  �� Orientation$ 
Horizontal=�6   $��69��6.   ���	#FF4F4F4F$��1��6Q   $��0��6^   $��Bottom=�6n   .+�5(      �� -   5        $��59��5(      $��analog��6    ���	#FF4F4F4F���	#FFE5E5E56~   �� 5*   
   -   5        $
��60.8��5*      $��digit��6   ���	#FF4F4F4F���	#FFE5E5E56y   �� 5+      -   5        $
��60.8��5+      $��timer��6"   ���	#FF4F4F4F���	#FFE5E5E56~   �� 5,      -   5        $
��60.8��5,      $��alarm��6"   ���	#FF4F4F4F���	#FFE5E5E56~   �� 5-      -   5        $
��60.8��5-      $��	stopwatch��6"   ���	#FF4F4F4F���	#FFE5E5E56�   5.      �� 50   
   $��0��6   $��0��6&   ��66   �� 52      53      