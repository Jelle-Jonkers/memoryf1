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
using System.Windows.Shapes;

namespace Memory_game_menuscreen
{
    /// <summary>
    /// Interaction logic for HighscorePage.xaml
    /// </summary>
    
        public partial class HighscorePage : Window
        {
            private int size = 4;
            private string file;

            /// <summary>
            /// Voert de onderstaande methodes uit.
            /// </summary>
            public HighscorePage()
            {
                InitializeComponent();
                SetFile();
                InitializeHighscores();
            }
            
            /// <summary>
            /// Als de grootte van het speelveld 4x4 (4) is, wordt highscores4.sav geladen, hetzelfde geldt voor highscores6.sav 
            /// </summary>
            public void SetFile()
            {
                file = "highscores" + size.ToString() + ".sav";
            }
                
            /// <summary>
            /// Laad de complete highscore. De file wordt in een list gezet en gesorteerd. Als de file leeg is, is er nog geen record. Als de file niet leeg is, dan wordt elke string gesplit en met een goed format in de label gezet
            /// </summary>
            public void InitializeHighscores()
            {
                lbl_Highscores.Content = "";
                List<string> highscores = File.ReadAllLines(file).ToList();
                highscores.Sort();
                if (File.ReadAllText(file) == "")
                {
                    lbl_Highscores.Content = "Er is nog geen record";
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
                        lbl_Highscores.Content += score + "\n";
                    }
                }
            }
            
            /// <summary>
            /// als op de knop wordt geklikt dan wordt het speelveld 4x4 en wordt highscores4.sav geladen en in de label gezet.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btn_4x4_Click(object sender, RoutedEventArgs e)
            {
                size = 4;
                SetFile();
                InitializeHighscores();
            }

            /// <summary>
            /// als op de knop wordt geklikt dan wordt het speelveld 6x6 en wordt highscores6.sav geladen en in de label gezet.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btn_6x6_Click(object sender, RoutedEventArgs e)
            {
                size = 6;
                SetFile();
                InitializeHighscores();
            }

            /// <summary>
            /// als op de sluit knop word gedrukt, wordt deze window afgesloten en zie je het main menu
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Sluiten(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        }

    }

