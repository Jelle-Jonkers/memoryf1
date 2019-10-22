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
        public OptionWindow1(int Aantalspelers)
        {
            InitializeComponent();
            this.Aantalspelers = Aantalspelers;
        }

        public OptionWindow1()
        {
            InitializeComponent();
        }

        private void Sluiten(object sender, RoutedEventArgs e)
        {
            OptionWindow2 optionWindow2 = new OptionWindow2();
            this.Close();
            optionWindow2.Show();
        }

        private void Singleplayer(object sender, RoutedEventArgs e)
        {
            Aantalspelers = 1;
        }

        private void Multiplayer(object sender, RoutedEventArgs e)
        {
            Aantalspelers = 2;
        }
    }
}
