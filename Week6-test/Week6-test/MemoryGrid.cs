using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Week6_test
{
    class MemoryGrid
    {
        private Grid grid;
        private int cols, rows;
        private List<Card> cards = new List<Card>();
        private int NrOfClickedCards = 0;
        private int previousCard;
        private bool timerrunning;
        private DispatcherTimer Timer;
        
        
        public MemoryGrid(Grid grid, int cols, int rows, DispatcherTimer Timer, bool Timerrunning)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;
            this.Timer = Timer;
            timerrunning = Timerrunning;
            InitializeGameGrid(cols, rows);
            AddImages();
            ShowCards();
        }

        public bool GetTimerrunning()
        {
            return timerrunning;
        }

        public void SetTimerrunning(bool value)
        {
            timerrunning = value;
        }

        int couplecount = 0;
        private void CardClick(object sender,MouseButtonEventArgs e)
        {
            if (NrOfClickedCards < 2)
            {
                Image card = (Image)sender;
                int index = (int)card.Tag;
                if (cards[index].Clickable()) {
                    NrOfClickedCards++;
                    card.Source = null;
                    cards[index].Clicked();

                    ShowCards();
                    if(NrOfClickedCards == 2)
                    {
                        string pic1 = Convert.ToString(cards[index].GetImage());
                        string pic2 = Convert.ToString(cards[previousCard].GetImage());

                        string pic1short = pic1.Substring(pic1.Length-8);
                        string pic2short = pic2.Substring(pic2.Length - 8);
                        if (pic1short==pic2short)
                        {
                            Timer.Stop();
                            MessageBox.Show("Goed!");
                            Timer.Start();
                            cards[index].MakeInvisible();
                            cards[previousCard].MakeInvisible();
                            couplecount++;
                            ShowCards();
                        }
                        else 
                        {
                            Timer.Stop();
                            MessageBox.Show("Fout");
                            Timer.Start();
                            cards[index].FlipToBack();
                            cards[previousCard].FlipToBack();
                            ShowCards();
                        }

                        NrOfClickedCards = 0;
                    }
                    else
                    {
                        previousCard = index;
                    }

                }
            }
            if (couplecount == rows*rows / 2) {
                Timer.Stop();
                MessageBox.Show("Spel is klaar");
            }
        }

        private List<ImageSource> GetImageList()
        {
            List<ImageSource> images = new List<ImageSource>();
            int ImageAmount = 20;
            for (int i = 0; i < ((cols * rows)/2); i++)
            {
                for(int j = 0; j < 2; j++) { 
                    int imageNr = (i % ImageAmount)+1;
                    ImageSource source = new BitmapImage(new Uri("driver cards/driver"+imageNr+".jpg",UriKind.Relative));

                    images.Add(source);
                }
            }

            Random random = new Random();
            for(int i = 0; i < (cols * rows); i++)
            {
                int r = random.Next(0, (cols * rows));
                ImageSource Temp = images[r];
                images[r] = images[i];
                images[i]=Temp;
            }
            return images;
        }

        private void AddImages()
        {
            List<ImageSource> images = GetImageList();
            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    cards.Add(new Card(images.First(), this));
                    images.RemoveAt(0);
                    
                }
            }
        }

        private void ShowCards()
        {
            for(int i = 0; i < rows; i++)
            {
                for( int j = 0; j < cols; j++)
                {
                    Image Image = new Image();
                    Image.Margin = new Thickness(10);
                    Image.MouseDown += new MouseButtonEventHandler(CardClick);
                    Image.Source = cards[j * cols + i].Show();
                    Image.Tag = j * cols + i;
                    Grid.SetColumn(Image, j);
                    Grid.SetRow(Image, i);
                    grid.Children.Add(Image);
                }
            }
        }

        public void InitializeGameGrid(int cols, int rows)
        {
            for(int i = 0; i < rows; i++)
            {
                RowDefinition rowDef = new RowDefinition();
                rowDef.Height = new GridLength(1, GridUnitType.Star);
                grid.RowDefinitions.Add(rowDef);
            }
            for (int i = 0; i < cols; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                colDef.Width = new GridLength(1, GridUnitType.Star);
                grid.ColumnDefinitions.Add(colDef);
            }
        }
    }
}
