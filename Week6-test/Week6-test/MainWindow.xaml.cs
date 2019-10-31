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
        const int rows = 4;
        const int cols = 4;

        private int time = 0;
        private DispatcherTimer Timer;
        bool timerrunning;
        MemoryGrid grid;
        private string minutes;
        private string seconds;

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
            minutes = Convert.ToString(time / 60);
            seconds = Convert.ToString(time % 60);

            if(minutes.Length == 1)
            {
                minutes = "0" + minutes;
            }
            if(seconds.Length == 1)
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
            MainWindow gamewindow = new MainWindow();
            gamewindow.Show();
            this.Close();
        }
        List<string> HighScore4 = new List<string>();
        string StringNaamSpeler1 = "jelle";
        private void PrintHighscore()
        { 

            HighscoreTime.Content = String.Format("{0}:{1}", minutes, seconds);
            //String.Format alleen dan met een string van de highscore list
        }

        private void SaveScore()
        { 

            //er bestaat een list genaamd highscore4 en highscore6

        }
        
    }
}
