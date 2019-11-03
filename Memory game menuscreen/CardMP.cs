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

        public CardMP(ImageSource frontOfCard)
        {
            back = new BitmapImage(new Uri("driver cards/hidden.jpg", UriKind.Relative));
            clicked = false;
            visible = true;
            front = frontOfCard;
        }

        public void Clicked()
        {
            clicked = true;
        }

        public void FlipToBack()
        {
            clicked = false;
        }

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
        public void MakeInvisible()
        {
            visible = false;
        }
        public ImageSource GetImage()
        {
            return front;
        }

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
