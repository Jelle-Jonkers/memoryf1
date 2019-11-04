using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Memory_game_menuscreen
{
    class MemoryGridMP
    {

        private Grid grid;
        private int cols, rows;
        private List<CardMP> cards = new List<CardMP>();
        private int NrOfClickedCards = 0;
        private int previousCard;
        private int speler1points = 0;
        private int speler2points = 0;
        private bool speler1 = true;
        private bool speler2 = false;
        private GameWindowMP gamewindow;
        

        /// <summary>
        /// Maakt het gamegrid aan waar alle kaartjes in komen te liggen
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>

        public MemoryGridMP(Grid grid, int cols, int rows)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;
            InitializeGameGrid(cols, rows);
            AddImages();
            ShowCards();
        }
        
        public void SetWindow(GameWindowMP input)
        {
            this.gamewindow = input;
        }
        public void SetGameWindow(GameWindowMP gamewindow)
        {
            this.gamewindow = gamewindow;
        }

        /// <summary>
        /// controleert hoeveel plaatjes zijn aangeklikt en checkt of die hetzelfde zijn
        /// zo ja dan word er een punt gegeven aan de juiste speler en laat die speler nog een keer gaan
        /// zo niet dan worden de beurten omgedraaid en wordt er gecheckt of het totale aantal punten behaal is
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            if (NrOfClickedCards < 2)
            {
                Image card = (Image)sender;
                int index = (int)card.Tag;
                if (cards[index].Clickable())
                {
                    NrOfClickedCards++;
                    card.Source = null;
                    cards[index].Clicked();

                    ShowCards();
                    if (NrOfClickedCards == 2)
                    {
                        string pic1 = Convert.ToString(cards[index].GetImage());
                        string pic2 = Convert.ToString(cards[previousCard].GetImage());

                        string pic1short = pic1.Substring(pic1.Length - 8);
                        string pic2short = pic2.Substring(pic2.Length - 8);
                        if (pic1short == pic2short)
                        {
                            if (speler1 == true)
                            {
                                speler1points++;
                                gamewindow.UpdateScores(speler1points, speler2points);
                                speler1 = true;
                                speler2 = false;
                            }
                            else
                            {
                                speler2points++;
                                gamewindow.UpdateScores(speler1points, speler2points);
                                speler1 = false;
                                speler2 = true;
                            }
                            MessageBox.Show("Goed!");
                            cards[index].MakeInvisible();
                            cards[previousCard].MakeInvisible();
                            ShowCards();
                        }
                        else
                        {
                            if (speler1 == true)
                            {
                                speler1 = false;
                                speler2 = true;
                            }
                            else
                            {
                                speler1 = true;
                                speler2 = false;
                            }
                            MessageBox.Show("Fout");
                            cards[index].FlipToBack();
                            cards[previousCard].FlipToBack();
                            ShowCards();
                        }
                        if (speler1 == true)
                        {
                            MessageBox.Show("speler 1 is aan de beurt, speler 1 heeft: " + speler1points + " punten");
                        }
                        else
                        {
                            MessageBox.Show("speler 2 is aan de beurt, speler 2 heeft: " + speler2points + " punten");
                        }

                        if (speler1points + speler2points == (rows * rows) / 2)
                        {
                            if (speler1points > speler2points)
                            {
                                MessageBox.Show("Gefeliciteerd, Speler 1 heeft gewonnen");
                                MPwin1 w1 = new MPwin1();
                                gamewindow.Content = w1;

                            }
                            else if (speler2points > speler1points)
                            {
                                MessageBox.Show("Gefeliciteerd, speler 2 heeft gewonnen");
                                MPwin2 w2 = new MPwin2();
                                gamewindow.Content = w2;


                            }
                            else
                            {
                                MessageBox.Show("Het is gelijkspel, beide spelers hebben goed gespeeld");
                                MPgelijk gsp = new MPgelijk();
                                gamewindow.Content = gsp;
                            }
                        }



                        NrOfClickedCards = 0;
                    }
                    else
                    {
                        previousCard = index;
                    }

                }
            }
        }

        /// <summary>
        /// Methode voor ophalen van lijst met afbeeldingen
        /// </summary>
        /// <returns></returns>

        private List<ImageSource> GetImageList()
        {
            List<ImageSource> images = new List<ImageSource>();
            int ImageAmount = 20;
            for (int i = 0; i < ((cols * rows) / 2); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int imageNr = (i % ImageAmount) + 1;
                    ImageSource source = new BitmapImage(new Uri("driver cards/driver" + imageNr + ".jpg", UriKind.Relative));

                    images.Add(source);
                }
            }

            Random random = new Random();
            for (int i = 0; i < (cols * rows); i++)
            {
                int r = random.Next(0, (cols * rows));
                ImageSource Temp = images[r];
                images[r] = images[i];
                images[i] = Temp;
            }
            return images;
        }

        /// <summary>
        /// maakt kaarten aan met een afbeelding uit de lijst en voegt deze toe aan een list met kaarten
        /// </summary>
        private void AddImages()
        {
            List<ImageSource> images = GetImageList();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    cards.Add(new CardMP(images.First()));
                    images.RemoveAt(0);

                }
            }
        }

        /// <summary>
        /// voegt alle kaarten uit de list met kaarten toe aan het speelveld en laat ze zien
        /// </summary>
        private void ShowCards()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Image Image = new Image();
                    Image.Margin = new Thickness(10);
                    Image.MouseDown += new MouseButtonEventHandler(CardClick);
                    Image.Source = cards[(j * cols) + i].Show();
                    Image.Tag = j * cols + i;
                    Grid.SetColumn(Image, j);
                    Grid.SetRow(Image, i);
                    grid.Children.Add(Image);
                }
            }
        }

        /// <summary>
        /// Creeërt het gamegrid met opgegeven lengte en breedte
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public void InitializeGameGrid(int cols, int rows)
        {
            for (int i = 0; i < rows; i++)
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
