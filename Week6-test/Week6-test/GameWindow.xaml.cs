using System;
using System.Collections.Generic;
using System.IO;
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
        string file;
        int NrofPauseClicks = 0;

        /// <summary>
        /// roept alles voor het gamewindow op
        /// </summary>
        /// <param name="size"></param>
        public GameWindow(int size)
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            timerrunning = true;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += TimerTicks;
            Timer.Start();
            tempsize = size;
            grid = new MemoryGrid(MainGrid, size, size, Timer, timerrunning, this);
            file = "highscores" + tempsize.ToString() + ".sav";
            InitializeHighscore();

        }

        /// <summary>
        /// de tijd wordt in een string gezet en m.b.v. nullen geformateerden wordt in de .sav file gezet
        /// </summary>
        public void EndGame()
        {
            string scoreTime = Convert.ToString(time);
            if (scoreTime.Length == 1) { scoreTime = "00" + scoreTime; }
            if (scoreTime.Length == 2) { scoreTime = "0" + scoreTime; }

            string score = scoreTime + "-" + naamspeler;
            using (StreamWriter sr = new StreamWriter(file, true))
            {
                sr.WriteLine(score);
            }
        }

        /// <summary>
        /// de file wordt in een list gezet en de hoogste score wordt in de label gezet
        /// </summary>
        public void InitializeHighscore()
        {
            List<string> highscores = File.ReadAllLines(file).ToList();
            highscores.Sort();
            if (File.ReadAllText(file) == "")
            {
                HighscoreTime.Content = "XX:XX";
            }
            else
            {
                string[] highscore = highscores[0].Split('-');
                string scorenaam = highscore[1];
                int scoretijd = Convert.ToInt32(highscore[0]);
                string scoreSec = (scoretijd % 60).ToString();
                if (scoreSec.Length == 1) { scoreSec = "0" + scoreSec; }
                string scoreMin = (scoretijd / 60).ToString();
                if (scoreMin.Length == 1) { scoreMin = "0" + scoreMin; }
                string score = scorenaam + ": " + scoreMin + ":" + scoreSec;

                HighscoreTime.Content = score;
            }
        }
        /// <summary>
        /// Plaatst de variabele spelernaam van speler1 op het scherm
        /// </summary>
        /// <param name="in1">naam speler 1</param>
        public void SetNames(string in1)
        {
            this.naamspeler = in1;
            naamspeler1.Content = in1;
        }


        /// <summary>
        /// Zet de seconden om in minuten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTicks(object sender, EventArgs e)
        {
            time++;
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
        }

        
        /// <summary>
        /// Pauzeert de timer en verandert de pauzeer knop zijn content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// herstart het spelscherm door het scherm opnieuw op te starten en de huidige af te sluiten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset(object sender, RoutedEventArgs e)
        {
            GameWindow gamewindow = new GameWindow(tempsize);
            gamewindow.Show();
            this.Close();
        }
        /// <summary>
        /// sluit het scherm af om weer terug te gaan naar het menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMenu(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
