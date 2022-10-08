using System;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace BarberShop.ViewingFolder.WindowsFolder
{
    public partial class ProgressLoadingWindows : Window
    {
        //private Timer timer;

        public ProgressLoadingWindows()
        {
            InitializeComponent();
            //timer = new Timer(10);
            //timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
        }
        //void timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, (Action)(() =>
        //    {
        //        if (ProgressBarTimer.Value < 10)
        //        {
        //            ProgressBarTimer.Value += 1;
        //        }
        //        else
        //        {
        //            timer.Stop();
        //            ProgressLoadingWindows progressLoadingWindows = new ProgressLoadingWindows();
        //            progressLoadingWindows.Hide();
        //        }
        //    }));
        //}

        private void RollUp_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //timer.Start();
        }
    }
}
