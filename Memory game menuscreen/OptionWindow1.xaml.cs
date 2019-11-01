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

        public OptionWindow1()
        {
            InitializeComponent();

        }

        public void SetMenu(Menu menu)
        {
            this.menu = menu;
        }


        private void Singleplayer(object sender, RoutedEventArgs e)
        {
            Aantalspelers = 1;
            Speler2.Visibility = Visibility.Hidden;
        }

        private void Multiplayer(object sender, RoutedEventArgs e)
        {
            Aantalspelers = 2;
            Speler2.Visibility = Visibility.Visible;
        }
        public void namen()
        {
            Naam1 = Speler1.Text;
            Naam2 = Speler2.Text;
            menu.SetNames(Naam1, Naam2);
        }

        private void Sluiten(object sender, RoutedEventArgs e)
        {
            menu.SetIsZes(IsZes);
            menu.SetAantalSpelers(Aantalspelers);
            this.namen();
            this.Close();
        }

        public void SetGameMode(OptionWindow1 optionWindow1)
        {
            this.optionWindow1 = optionWindow1;
        }

        private void ZesBijZes(object sender, RoutedEventArgs e)
        {
            IsZes = true;
        }

        private void VierBijVier(object sender, RoutedEventArgs e)
        {
            IsZes = false;
        }
    }
}
