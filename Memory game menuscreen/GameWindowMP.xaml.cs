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
    /// Interaction logic for GameWindowMP.xaml
    /// </summary>
    public partial class GameWindowMP : Window
    {
        public bool speler1, speler2;
        private int tempsize;
        private string naam1;
        private string naam2;
        MemoryGridMP grid;
        GameWindowMP tempGameWindow;

        public GameWindowMP(int size)
        {
            InitializeComponent();
            tempsize = size;
            grid = new MemoryGridMP(MainGridMP, size, size);
        }

        public void SetNames(string in1, string in2)
        {
            this.naam1 = in1;
            this.naam2 = in2;
            Naam1.Content = in1;
            Naam2.Content = in2;
        }

        public void SetTempGameWindow(GameWindowMP gamewindow)
        {
            
            grid.SetGameWindow(gamewindow);
        }

        public void UpdateScores(int speler1points, int speler2points)
        {
            Score1.Content = speler1points;
            Score2.Content = speler2points;
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            GameWindowMP gamewindow = new GameWindowMP(tempsize);
            gamewindow.Show();
            this.Close();
        }
        private void BackMP(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
