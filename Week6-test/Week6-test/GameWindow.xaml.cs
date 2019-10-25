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

namespace Memory_game_menuscreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        const int rows = 4;
        const int cols = 4;
        MemoryGrid grid;
        public GameWindow()
        {
            InitializeComponent();
            grid = new MemoryGrid(MainGrid, cols, rows);
            
        }
    }
}
