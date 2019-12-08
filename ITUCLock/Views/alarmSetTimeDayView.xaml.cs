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

namespace ITUCLock.Views
{
    /// <summary>
    /// Interaction logic for alarmSetTimeDayView.xaml
    /// </summary>
    public partial class alarmSetTimeDayView : UserControl
    {
        public alarmSetTimeDayView()
        {
            InitializeComponent();
        }

        private void SaveButtonClicked(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(alarmExistView);

        }
        public void SetActiveUserControl(UserControl control)
        {
            alarmExistView.Visibility = Visibility.Collapsed;

            control.Visibility = Visibility.Visible;



        }



    }


}
