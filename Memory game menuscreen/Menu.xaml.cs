using System;
using System.Collections.Generic;
using System.IO;
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


namespace Memory_game_menuscreen
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public bool IsZes;
        Menu tempmenu;
        private string naam1;
        private string naam2;
        public int Aantalspelers;
        string file;
        private MainWindow mainWindow;

        /// <summary>
        /// Initialiseerd een component en LoadSize wat er voor zorgt dat de grootte van het speelveld op het menu wordt weer gegeven
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            LoadSize();
            SetFile();
            InitializeHighscore();
        }

        /// <summary>
        /// Setter om later in deze class de mainwindow aan te roepen
        /// </summary>
        public void SetMainWindow(MainWindow input)
        {
            mainWindow = input;
        }

        /// <summary>
        /// haalt de goede .sav file op
        /// </summary>
        public void SetFile()
        {
            if (IsZes)
            {
                file = "highscores6.sav";
            }
            else
            {
                file = "highscores4.sav";
            }
        }
        /// <summary>
        /// set de tempmenu vanuit een andere class om verder doortegeven aan andere classes zodat er methodes van het menu geroepen kunnen worden vanuit andere classes
        /// </summary>
        /// <param name="menu">Het menu dat wordt opgegeven vanuit een andere class</param>
        public void SetMenu(Menu menu)
        {
            this.tempmenu = menu;
        }

        /// <summary>
        /// haalt highscores op en toont de hoogste drie scores in het menu van het gekozen veld grootte
        /// </summary>
        public void InitializeHighscore()
        {
            lblHighscores.Content = "";
            List<string> highscores = File.ReadAllLines(file).ToList();
            List<string> newHighscores = new List<string>();
            highscores.Sort();
            if (File.ReadAllText(file) == "")
            {
                lblHighscores.Content = "Er is nog geen record";
            }
            else
            {
                foreach (string element in highscores)
                {
                    string[] highscore = element.Split('-');
                    string scorenaam = highscore[1];
                    int scoretijd = Convert.ToInt32(highscore[0]);
                    string scoreSec = (scoretijd % 60).ToString();
                    if (scoreSec.Length == 1) { scoreSec = "0" + scoreSec; }
                    string scoreMin = (scoretijd / 60).ToString();
                    if (scoreMin.Length == 1) { scoreMin = "0" + scoreMin; }
                    string score = scorenaam + ": " + scoreMin + ":" + scoreSec;
                    newHighscores.Add(score);
                }
                lblHighscores.Content += newHighscores[0];
                try { lblHighscores.Content += "\n" + newHighscores[1]; } catch (ArgumentOutOfRangeException e) { lblHighscores.Content += ""; }
                try { lblHighscores.Content += "\n" + newHighscores[2]; } catch (ArgumentOutOfRangeException e) { lblHighscores.Content += ""; }
            }
        }
       
        /// <summary>
        /// Geeft door hoeveel spelers er mee doen
        /// </summary>
        /// <param name="Spelers"></param>
        public void SetAantalSpelers(int Spelers)
        {
            Aantalspelers = Spelers;
        }

        /// <summary>
        /// Plaatst de variabele van de speler namen op het menu scherm
        /// </summary>
        /// <param name="in1">naam speler 1</param>
        /// <param name="in2">naam speler 1</param>
        public void SetNames(string in1, string in2)
        {
            this.naam1 = in1;
            this.naam2 = in2;
            Naamspeler1.Text = naam1;
            Naamspeler2.Text = naam2;
        }
        /// <summary>
        /// Sluit de applicatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        /// <summary>
        /// Het opties scherm wordt aangemaakt, het zorgt er voor dat je gegevens van het optionwindow kan doorgeven aan het menu scherm, en het opent optionwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToOptions(object sender, RoutedEventArgs e)
        {
            OptionWindow1 optionWindow1 = new OptionWindow1();
            optionWindow1.SetGameMode(optionWindow1);
            optionWindow1.SetMenu(tempmenu);
            optionWindow1.Show();
        }
        /// <summary>
        /// Haalt IsZes op
        /// </summary>
        /// <param name="input">De bool om te kijken hoe groot het speeldveld is</param>
        public void SetIsZes(bool input)
        {
            IsZes = input;
        }
        /// <summary>
        /// Toont de grootte van het speelveld op het menu
        /// </summary>
        public void LoadSize()
        {
            if (IsZes)
            {
                Speelveldgrootte.Text = "6x6";
            }
            else
            {
                Speelveldgrootte.Text = "4x4";
            }
        }

        /// <summary>
        /// Dit opent het spel en check hoeveel spelers er mee doen en hoe groot het speelveld moet zijn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpelStarten(object sender, RoutedEventArgs e)
        {
            if (Aantalspelers == 1)
            {
                if (IsZes)
                {
                    GameWindow gameWindow = new GameWindow(6);
                    gameWindow.SetNames(naam1);
                    gameWindow.Show();
                }
                else
                {
                    GameWindow gameWindow = new GameWindow(4);
                    gameWindow.SetNames(naam1);
                    gameWindow.Show();
                }
                
            }
            else if (Aantalspelers == 2)
            {
                if (IsZes)
                {
                    GameWindowMP gameWindow2 = new GameWindowMP(6);
                    gameWindow2.SetTempGameWindow(gameWindow2);
                    gameWindow2.SetNames(naam1, naam2);
                    gameWindow2.Show();
                }
                else
                {
                    GameWindowMP gameWindow2 = new GameWindowMP(4);
                    gameWindow2.SetTempGameWindow(gameWindow2);
                    gameWindow2.SetNames(naam1, naam2);
                    gameWindow2.Show();
                }
                
            }
            else {
                MessageBox.Show("Er zijn geen instellingen gekozen");
            }
            
        }

        private void ToHighscore(object sender, RoutedEventArgs e)
        {
            HighscorePage highscorePage = new HighscorePage();
            highscorePage.Show();
        }
    }
}
