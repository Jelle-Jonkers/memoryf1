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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToOptionMenu(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("highscores4.sav"))
            {
                var writer = new StreamWriter("highscores4.sav");
            }
            if (!File.Exists("highscores6.sav"))
            {
                var writer = new StreamWriter("highscores6.sav");
            }

            Menu menu = new Menu();
            menu.SetMenu(menu);
            menu.SetMainWindow(this);
            this.Content = menu;
        }
        
        
    }
}
