using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Week6_test
{
    class Card
    {
        private ImageSource front, back;
        private bool clicked, visible;
        MemoryGrid game;


        public Card(ImageSource frontOfCard, MemoryGrid grid)
        {
            back = new BitmapImage(new Uri("driver cards/hidden.jpg", UriKind.Relative));
            clicked = false;
            visible = true;
            front = frontOfCard;
            game = grid;
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
            if (!(game.GetTimerrunning()))
            {
                MessageBox.Show("de game is gepauzeerd");
                return false;
            }
            else if (clicked || !visible)
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
