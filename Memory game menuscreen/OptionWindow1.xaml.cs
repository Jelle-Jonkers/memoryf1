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
using System.Windows.Shapes;

namespace Memory_game_menuscreen
{
    /// <summary>
    /// Interaction logic for OptionWindow1.xaml
    /// </summary>
    public partial class OptionWindow1 : Window
    {
        public int Aantalspelers = 0;
        bool IsZes = false;
        string Naam1;
        string Naam2;
        Menu menu;
        OptionWindow1 optionWindow1;
        /// <summary>
        /// Initialiseerd een component.
        /// </summary>
        public OptionWindow1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Zorgt er voor dat je gegevens kunt doorgeven aan het menu scherm vanuit het optie scherm
        /// </summary>
        /// <param name="menu"></param>

        public void SetMenu(Menu menu)
        {
            this.menu = menu;
        }

        /// <summary>
        /// Zorgt er voor dat het speler aantal op 1 wordt gezet en dat de 2e textbox waar je je naam kan invullen onzichtbaar wordt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Singleplayer(object sender, RoutedEventArgs e)
        {
            Aantalspelers = 1;
            Speler2.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Zorgt ervoor dat het speler aantal op 2 komt en dat de 2e textbox weer zichtbaar wordt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Multiplayer(object sender, RoutedEventArgs e)
        {
            Aantalspelers = 2;
            Speler2.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Geeft de speler door naar het menu en bekijkt ook wat de ingevulde namen zijn
        /// </summary>
        public void namen()
        {
            Naam1 = Speler1.Text;
            Naam2 = Speler2.Text;
            if (Naam1.Contains("-"))
            {
                MessageBox.Show("Naam 1 bevat een '-', dit levert problemen op en is dus niet toegestaan");
                Naam1 = "vul opnieuw in";
            }

            if (Naam2.Contains("-"))
            {
                MessageBox.Show("Naam 2 bevat een '-', dit levert problemen op en is dus niet toegestaan");
                Naam2 = "vul opnieuw in";
            }
            menu.SetNames(Naam1, Naam2);
        }
        /// <summary>
        /// Sluit het optionwindow en geeft door aan het main menu hoe groot het speelveld moet zijn en hoeveel spelers het spel spelen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sluiten(object sender, RoutedEventArgs e)
        {
            menu.SetIsZes(IsZes);
            menu.SetAantalSpelers(Aantalspelers);
            menu.SetFile();
            menu.InitializeHighscore();
            menu.LoadSize();
            this.namen();
            this.Close();
        }
        /// <summary>
        /// Hiermee worden de geselecteerde gegevens op het optionwindow doorgegeven
        /// </summary>
        /// <param name="optionWindow1"></param>
        public void SetGameMode(OptionWindow1 optionWindow1)
        {
            this.optionWindow1 = optionWindow1;
        }
        /// <summary>
        /// Geeft aan hoe groot het speelveld moet zijn door middel van een bool, zes bij zes in dit geval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZesBijZes(object sender, RoutedEventArgs e)
        {
            IsZes = true;
        }
        /// <summary>
        /// geeft aan hoe groot het speelveld moet zijn door middel van een bool, vier bij vier in dit geval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VierBijVier(object sender, RoutedEventArgs e)
        {
            IsZes = false;
        }
    }
}
