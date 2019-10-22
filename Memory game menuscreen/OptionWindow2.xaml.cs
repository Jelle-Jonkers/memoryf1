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
    /// Interaction logic for OptionWindow2.xaml
    /// </summary>
    public partial class OptionWindow2 : Window
    {
        

        public OptionWindow2()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            OptionWindow3 optionWindow3 = new OptionWindow3();
            this.Close();
            optionWindow3.Show();
        }

       
    }
}
