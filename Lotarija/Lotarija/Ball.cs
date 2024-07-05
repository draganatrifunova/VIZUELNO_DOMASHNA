using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotarija
{
    public class Ball
    {
        public int Number { get;  set; }
        public Point Center { get;  set; }
        public float Opacity { get;  set; }

        public Ball(Point center, int number)
        {
            this.Center = center;
            this.Number = number;
            this.Opacity = 0.0f; 
        }

        public void Draw(Graphics g)
        {
            if (Opacity < 1.0f)
            {
                Opacity += 0.1f; 
            }

            Brush brush = new SolidBrush(Color.FromArgb((int)(Opacity * 255), Color.Yellow));
            g.FillEllipse(brush, Center.X - 20, Center.Y - 20, 40, 40);

            brush.Dispose(); 
            Pen pen = new Pen(Color.Black, 2);
            g.DrawEllipse(pen, Center.X - 20, Center.Y - 20,  40, 40);
            pen.Dispose();

           
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Brush textBrush = new SolidBrush(Color.Black);
            g.DrawString(Number.ToString(), font, textBrush, Center.X - 10, Center.Y - 10);
            textBrush.Dispose();
            font.Dispose();
        }
    }
    }
