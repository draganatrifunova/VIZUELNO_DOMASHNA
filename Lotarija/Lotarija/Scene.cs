using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotarija
{
    public class Scene
    {
        public List<Ball> balls { get; set; }
        public List<Livce> tickets { get; set; }
        public Random random { get; set; }

        public Scene(Random random)
        {
            balls = new List<Ball>();
            tickets = new List<Livce>();
            this.random = random;
        }

        public void AddBall(Ball b)
        {
            balls.Add(b);
        }

        public void AddTicket(Livce l)
        {
            tickets.Add(l);
        }

        public void ClearTickets()
        {
            tickets.Clear();
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in balls)
            {
                b.Draw(g);
            }
        }

        public void GenerateBalls()
        {
            balls.Clear();
            for (int i = 0; i < 7; i++)
            {
                int number;
                do
                {
                    number = random.Next(1, 38);
                } while (balls.Any(b => b.Number == number));

                Point center = new Point(150 + i * 70, 150); 
                balls.Add(new Ball(center, number));
            }
        }

        public void CheckTickets()
        {
            List<Livce> matchedtickets7 = new List<Livce>();
            List<Livce> matchedtickets6=new List<Livce> ();
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;

            foreach (Livce ticket in tickets)
            {
                int matchCount = 0;
                foreach (Ball ball in balls)
                {
                    if (ticket.ContainsNumber(ball.Number))
                    {
                        matchCount++;
                    }
                }
                if (matchCount == 6) 
                {
                    matchedtickets6.Add(ticket); 
                    count6++;
                }
                if (matchCount == 7) 
                {
                    matchedtickets7.Add(ticket); 
                    count7++;
                }
                if(matchCount == 4)
                {
                    count4++;
                }
                if (matchCount == 5)
                {
                    count5++;
                }
            }
            string matchedTicketsText = "Ливчиња со 4 погодоци: " + count4;
            matchedTicketsText += "\n" + "Ливчиња со 5 погодоци: " + count5;
            matchedTicketsText += "\n" + "Ливчиња со 6 погодоци: " + count6;
            matchedTicketsText += "\n" + "Ливчиња со 7 погодоци: " + count7;
            matchedTicketsText += "\n" + "\n";



            if (matchedtickets6.Count > 0)
            {
               
                matchedTicketsText += "\nСреќните добитници со 6 погодоци беа: " ;
                foreach (Livce l in matchedtickets6)
                {
                    matchedTicketsText += "\n Продавница: " + l.prodavnica + " Број на сметка: " + l.smetka;
                }
               
            }

            if (matchedtickets7.Count > 0)
            {

                matchedTicketsText += "\nСреќните добитници со 7 погодоци беа: ";
                foreach (Livce l in matchedtickets7)
                {
                    matchedTicketsText += "\n Продавница: " + l.prodavnica + " Број на сметка: " + l.smetka;
                }

            }
            MessageBox.Show(matchedTicketsText, "Погодоци");

        }
    }
}
    
