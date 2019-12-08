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
    /// Interaction logic for alarmExist.xaml
    /// </summary>
    public partial class alarmExist : UserControl
    {
        public alarmExist()
        {
            InitializeComponent();
        }

        private void AddButtonagain(object sender, RoutedEventArgs e)
        {
        }


        public void SetActiveUserControl(UserControl control)
        {

        }

        private void ContextMenuCliked(object sender, RoutedEventArgs e)
        {
            MenuAlarm sW = new MenuAlarm();
            sW.Show();
            

        }

    }
}
