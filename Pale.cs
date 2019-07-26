using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Final_Project
{
    class Pale
    {
        Rectangle rect = new Rectangle();
        public int x, y, w, h;
        int ydir = 0;

        public Pale(Canvas c, int x)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(0, 0, 150);
            rect.Fill = color;
            this.x = x;
            y = 80;
            w = 25;
            h = 95;
            rect.Width = w;
            rect.Height = h;
            Canvas.SetLeft(rect, this.x);
            Canvas.SetTop(rect, y);
            c.Children.Add(rect);

        }
        public void movement()
        {
            y += ydir;
            Canvas.SetTop(rect, y);
        }
        public void baj()
        {
            if (y <= 0)
            {
                ydir = 0;
            }
            else
            {
                ydir = 5;
            }
        }
        public void sub()
        {
            if (y >= 185)
            {
                ydir = 0;
            }
            else
            {
                ydir = -5;
            }
        }
        public void para()
        {
            ydir = 0;
        }
    }
}
