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
        /// <summary>
        /// intialiseerd het gamewindowmp scherm
        /// </summary>
        /// <param name="size"></param>
        public GameWindowMP(int size)
        {
            InitializeComponent();
            tempsize = size;
            grid = new MemoryGridMP(MainGridMP, size, size);
        }

        /// <summary>
        /// roept de namen uit het menu op en plaatst die in de juiste labels
        /// </summary>
        /// <param name="in1"></param>
        /// <param name="in2"></param>
        public void SetNames(string in1, string in2)
        {
            this.naam1 = in1;
            this.naam2 = in2;
            Naam1.Content = in1;
            Naam2.Content = in2;
        }
        /// <summary>
        /// wordt gebruikt om variabelen over te zetten naar gamewindowMP
        /// </summary>
        /// <param name="gamewindow"></param>
        public void SetTempGameWindow(GameWindowMP gamewindow)
        {
            grid.SetGameWindow(gamewindow);
        }
        /// <summary>
        /// roept de punten op uit MemoryGridMP op en plaatst die in de juiste labels
        /// </summary>
        /// <param name="speler1points"></param>
        /// <param name="speler2points"></param>
        public void UpdateScores(int speler1points, int speler2points)
        {
            Score1.Content = speler1points;
            Score2.Content = speler2points;
        }

        /// <summary>
        /// ververst het speelscherm met de huidige instellingen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, RoutedEventArgs e)
        {
            GameWindowMP gamewindow = new GameWindowMP(tempsize);
            gamewindow.Show();
            this.Close();
        }

        /// <summary>
        /// sluit het huidige scherm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackMP(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
