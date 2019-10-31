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


namespace Week6_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int rows = 4;
        const int cols = 4;
        public bool speler1, speler2;
        MemoryGrid grid;

        private void Test1_Click(object sender, RoutedEventArgs e)
        {
            winst1 w1 = new winst1();
            this.Content = w1;
        }

        private void Test2btn_Click(object sender, RoutedEventArgs e)
        {
            winst2 w2 = new winst2();
            this.Content = w2;
        }

        private void Test3btn_Click(object sender, RoutedEventArgs e)
        {
            gelijkspel gsp = new gelijkspel();
            this.Content = gsp;
        }

        public MainWindow()
        {
            InitializeComponent();
            grid = new MemoryGrid(MainGrid, cols, rows);
            grid.SetWindow(this);
            
            
        }
    }      
}
