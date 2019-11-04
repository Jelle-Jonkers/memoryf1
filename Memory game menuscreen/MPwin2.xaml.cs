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
    /// Interaction logic for MPwin2.xaml
    /// </summary>
    public partial class MPwin2 : Window
    {

        public MPwin2()
        {
            InitializeComponent();
        }

        private void ToMenu(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }   
}
