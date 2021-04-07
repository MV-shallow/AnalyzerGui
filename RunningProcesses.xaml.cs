using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Collections;


namespace AnalyzerGui
{
    /// <summary>
    /// Interaction logic for RunningProcesses.xaml
    /// </summary>
    public partial class RunningProcesses : Page
    {
        public RunningProcesses()
        {
            InitializeComponent();
        }

        static List<ProcessInfo> ls;



        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ls = new List<ProcessInfo>();

            Process[] runningProcesses = Process.GetProcesses();
            var currentSessionID = Process.GetCurrentProcess().SessionId;

            Process[] sameAsThisSession =
                runningProcesses.Where(p => p.SessionId == currentSessionID).ToArray();

            foreach (var p in sameAsThisSession)
            {
                Trace.WriteLine(p.ProcessName);
                ls.Add(new ProcessInfo { Name = p.ProcessName, Pid = p.Id });
            }

            ProcList.ItemsSource = ls;
            
         //   Thread th = new Thread(FindRunningProcesses);
        //    th.Start();
        }

        public static void FindRunningProcesses()
        {
            while (true)
            {
                ls.Clear();

                Process[] runningProcesses = Process.GetProcesses();
                var currentSessionID = Process.GetCurrentProcess().SessionId;

                Process[] sameAsThisSession =
                    runningProcesses.Where(p => p.SessionId == currentSessionID).ToArray();

                foreach (var p in sameAsThisSession)
                {
                    Trace.WriteLine(p.ProcessName);
                    ls.Add(new ProcessInfo { Name = p.ProcessName, Pid = p.Id });
                }
                Thread.Sleep(2000);
            }
        }
    }
}
