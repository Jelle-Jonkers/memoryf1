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

        public Menu()
        {
            InitializeComponent();
        }

        public void SetMenu(Menu menu)
        {
            this.tempmenu = menu;
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void ToOptions(object sender, RoutedEventArgs e)
        {
            OptionWindow1 optionWindow1 = new OptionWindow1();
            optionWindow1.SetMenu(tempmenu);
            optionWindow1.Show();
        }

        public void SetIsZes(bool input)
        {
            IsZes = input;
        }

        

        private void SpelStarten(object sender, RoutedEventArgs e)
        {
            if(IsZes)
            {
                GameWindow gameWindow = new GameWindow(6);
                gameWindow.Show();
            }
            else
            {
                GameWindow gameWindow = new GameWindow(4);
                gameWindow.Show();
            }

            
            
            
        }
    }
}
