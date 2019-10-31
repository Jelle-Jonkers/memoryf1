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
using System.Windows.Threading;

namespace Week6_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int rows = 2;
        const int cols = 2;

        private int time = 0;
        private DispatcherTimer Timer;
        bool timerrunning;
        MemoryGrid grid;

        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            timerrunning = true;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += TimerTicks;
            Timer.Start();
            grid = new MemoryGrid(MainGrid, cols, rows, Timer, timerrunning);
        }

        private void TimerTicks(object sender, EventArgs e)
        {
            if (time > 608)
            {
                time++;
                lblTime.Content = string.Format("00:{0}:{1}", time / 60, time % 60);
            }
            else if (time > 598)
            {
                time++;
                lblTime.Content = string.Format("00:{0}:0{1}", time / 60, time % 60);
            }
            else if (time > 8)
            {
                time++;
                lblTime.Content = string.Format("00:0{0}:{1}", time / 60, time % 60);
            }
            else
            {
                time++;
                lblTime.Content = string.Format("00:0{0}:0{1}", time / 60, time % 60);
            }
        }
        int NrofPauseClicks = 0;

        private void PauzeBtn_Click(object sender, EventArgs e)
        {
            NrofPauseClicks++;
            if (NrofPauseClicks == 1)
            {
                Timer.Stop();
                grid.SetTimerrunning(false);
                PauzeBtn.Content = "Hervat";

            }
            else if (NrofPauseClicks == 2)
            {
                Timer.Start();
                grid.SetTimerrunning(true);
                PauzeBtn.Content = "Pauze";
                NrofPauseClicks = 0;
            }
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            MainWindow gamewindow = new MainWindow();
            gamewindow.Show();
            this.Close();
        }


        
    }
}
