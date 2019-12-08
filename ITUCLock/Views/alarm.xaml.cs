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

namespace ITUCLock.Views
{
    /// <summary>
    /// Interaction logic for alarm.xaml
    /// </summary>
    public partial class alarm : UserControl
    {
        public alarm()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            
            SetActiveUserControl(alarmSetTimeDayView);
        }

        private void backButton_Clicked(object sender, RoutedEventArgs e)
        {
                
        }
        public void SetActiveUserControl(UserControl control)
        {
            alarmSetTimeDayView.Visibility = Visibility.Collapsed;

            control.Visibility = Visibility.Visible;

            if (control == alarmSetTimeDayView)
            {
                backButton.Visibility = Visibility.Visible;
                AddButton.Visibility = Visibility.Collapsed;
            }
            
        }

    }
}
