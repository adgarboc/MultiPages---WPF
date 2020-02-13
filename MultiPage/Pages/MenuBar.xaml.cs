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

namespace MultiPage.Pages
{
    /// <summary>
    /// Lógica de interacción para MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void btnControlPage_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PageControls());
        }

        private void btnAlarmPage_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PageAlarms());
        }

        private void btnGraphPage_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PageGraph());
        }

        private void btnMenuPage_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PageMenu());
        }
    }
}
