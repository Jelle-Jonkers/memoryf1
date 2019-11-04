using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Memory_game_menuscreen
{
    class CardMP
    {
        private ImageSource front, back;
        private bool clicked, visible;
        private ImageSource imageSource;

        /// <summary>
        /// Constructor voor object Card
        /// </summary>
        /// <param name="frontOfCard"> imagescource die de kaart moet hebben als voorkant</param>
        /// <param name="grid">het grid waar ze in liggen zodat deze later aangeroepen kan worden</param>
        public CardMP(ImageSource frontOfCard)
        {
            back = new BitmapImage(new Uri("driver cards/hidden.jpg", UriKind.Relative));
            clicked = false;
            visible = true;
            front = frontOfCard;
        }
        /// <summary>
        /// methode om de aan te geven dat de kaart is aangeklikt
        /// </summary>
        public void Clicked()
        {
            clicked = true;
        }
        /// <summary>
        /// methode om aan te geven dat de kaart weer omgedraaid mag worden
        /// </summary>
        public void FlipToBack()
        {
            clicked = false;
        }

        /// <summary>
        /// Kijkt of deze kaart aangeklikt mag worden
        /// </summary>
        /// <returns>boolean of deze kaart omgedraaid mag worden</returns>

        public bool Clickable()
        {
            
            if (clicked || !visible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Geeft aan dat dit kaart uit het spel is, dit wordt gedaan als er een goed kaart paar is
        /// </summary>
        public void MakeInvisible()
        {
            visible = false;
        }
        /// <summary>
        /// haalt afbeelding van kaart op
        /// </summary>
        /// <returns>Imagesource van kaart</returns>

        public ImageSource GetImage()
        {
            return front;
        }
        /// <summary>
        /// Update alle kaarten in het speelveld zodat de juiste kant wordt laten zien
        /// </summary>
        /// <returns></returns>
        public ImageSource Show()
        {
            if (visible)
            {
                if (clicked)
                {
                    return front;
                }
                else
                {
                    return back;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
