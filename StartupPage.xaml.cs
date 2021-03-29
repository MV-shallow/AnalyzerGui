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

namespace AnalyzerGui
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class StartupPage : Page
    {
        public StartupPage()
        {
            InitializeComponent();
        }

        private void GatherProcInfo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/AnalyzerGui;component/SelectionPage.xaml", UriKind.Relative));
        }
    }
}
