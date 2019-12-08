using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ITUCLock.ViewModels;

namespace ITUCLock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new analogViewModel();
        }

        private void TimerButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new timerViewModel();

        }

        private void AlarmButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new alarmViewModel();
        }

        private void DigitClock_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new  digitViewModel();
        }

        private void StopwatchBtn_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new stopwatchViewModel();
        }

        private void AnalogButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new analogViewModel();
        }
    }
}
