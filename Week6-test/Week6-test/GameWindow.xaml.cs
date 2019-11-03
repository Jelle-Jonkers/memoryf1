using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Memory_game_menuscreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private int time = 0;
        private DispatcherTimer Timer;
        bool timerrunning;
        MemoryGrid grid;
        private string minutes;
        private string seconds;
        private int tempsize;
        private string naamspeler;

        public GameWindow(int size)
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            timerrunning = true;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += TimerTicks;
            Timer.Start();
            tempsize = size;
            grid = new MemoryGrid(MainGrid, size, size, Timer, timerrunning);

        }
    

        public void SetNames(string in1)
        {
            this.naamspeler = in1;
            naamspeler1.Content = in1;
        }



        private void TimerTicks(object sender, EventArgs e)
        {
            minutes = Convert.ToString(time / 60);
            seconds = Convert.ToString(time % 60);

            if (minutes.Length == 1)
            {
                minutes = "0" + minutes;
            }
            if (seconds.Length == 1)
            {
                seconds = "0" + seconds;
            }
            lblTime.Content = string.Format("{0}:{1}", minutes, seconds);
            time++;
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
            GameWindow gamewindow = new GameWindow(tempsize);
            gamewindow.Show();
            this.Close();
        }
    }
}
