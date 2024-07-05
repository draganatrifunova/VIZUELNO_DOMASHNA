using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lotarija
{
    public class Livce{
        public int[] numbers = new int[7];
        public string prodavnica { get; set; }
        public string smetka { get; set; }

        public Livce(string line)
        {
            string[] parts = line.Split(';');

            for (int i = 0; i < 7; ++i)
            {
                numbers[i] = Convert.ToInt32(parts[i]);
            }
            prodavnica = parts[7];
            smetka = parts[8];
        }

        public bool ContainsNumber(int number)
        {
            return Array.Exists(numbers, n => n == number);
        }

    }
}
