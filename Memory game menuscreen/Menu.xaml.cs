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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public bool IsZes;
        Menu tempmenu;
        private string naam1;
        private string naam2;
        public int Aantalspelers;
        

        public Menu()
        {
            InitializeComponent();
           
        }

        public void SetMenu(Menu menu)
        {
            this.tempmenu = menu;
        }

        public void SetAantalSpelers(int Spelers)
        {
            Aantalspelers = Spelers;
        }

        
        public void SetNames(string in1, string in2)
        {
            this.naam1 = in1;
            this.naam2 = in2;
            Naamspeler1.Text = naam1;
            Naamspeler2.Text = naam2;
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void ToOptions(object sender, RoutedEventArgs e)
        {
            OptionWindow1 optionWindow1 = new OptionWindow1();
            optionWindow1.SetGameMode(optionWindow1);
            optionWindow1.SetMenu(tempmenu);
            optionWindow1.Show();
        }

        public void SetIsZes(bool input)
        {
            IsZes = input;
        }

        

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
    }
}
