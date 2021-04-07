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
    /// Interaction logic for SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Page
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/AnalyzerGui;component/StartupPage.xaml", UriKind.Relative));
        }

        private void ShowRunningProcesses(object sender, RoutedEventArgs e)
        {
          //  SelectionFrame.NavigationService.Navigate(new Uri("/AnalyzerGui;component/RunningProcesses.xaml", UriKind.Relative));
        }

        private void FrameLoaded(object sender, RoutedEventArgs e)
        {
         //   SelectionFrame.NavigationService.Navigate(new Uri("/AnalyzerGui;component/RunningProcesses.xaml", UriKind.Relative));
        }
    }
}
