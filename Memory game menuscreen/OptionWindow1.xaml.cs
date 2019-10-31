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
        int Aantalspelers = 1;
        bool IsZes = false;
        Menu menu;
        
        public OptionWindow1(int Aantalspelers)
        {
            InitializeComponent();
            this.Aantalspelers = Aantalspelers;
        }
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

        private void Sluiten(object sender, RoutedEventArgs e)
        {
            //TODO: Geopende menu selecteren in plaats van nieuwe aanmaken.
            //Menu menu = new Menu();
            menu.SetIsZes(IsZes);
            this.Close();
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
