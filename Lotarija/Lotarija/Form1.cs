using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotarija
{
    public partial class Form1 : Form
    {
        public Scene scene;
        public int ballIndex;
        public int animationStep;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            btnGenerateBalls.Visible= false;
            this.DoubleBuffered = true;
            scene = new Scene(random);
            ballIndex = 0;
            animationStep = 0;

            
            File.WriteAllText("uplata.txt", string.Empty);

            for (int k = 0; k < 1500; k++)
            {
                String line = "";
                HashSet<int> generatedNumbers = new HashSet<int>();

                for (int i = 0; i < 7; i++)
                {
                    int lotoNumber;
                    do
                    {
                        lotoNumber = random.Next(1, 38);
                    } while (!generatedNumbers.Add(lotoNumber)); // Add returns false if the number is already in the set

                    line += lotoNumber;
                    line += ";";
                }



                List<string> tobaka = new List<string> {
                "tobako1-Kochani", "tobako2-Kochani", "tobako3-Kochani", "tobako4-Kochani",
                "tobako1-Gevgelija", "tobako2-Gevgelija", "tobako3-Gevgelija", "tobako4-Gevgelija",
                "tobako1-Struga", "tobako2-Struga", "tobako3-Struga", "tobako4-Struga",
                "tobako1-Kumanovo", "tobako2-Kumanovo", "tobako3-Kumanovo", "tobako4-Kumanovo","tobako5-Kumanovo", "tobako6-Kumanovo", "tobako7-Kumanovo", "tobako8-Kumanovo",
                "tobako1-Bitola", "tobako2-Bitola", "tobako3-Bitola", "tobako4-Bitola","tobako5-Bitola", "tobako6-Bitola", "tobako7-Bitola", "tobako8-Bitola",
                "tobako1-Resen", "tobako2-Resen",
                "tobako1-Vinica", "tobako2-Vinica",
                "tobako1-Radovis", "tobako2-Radovis", "tobako3-Radovis",
                "tobako1-Ohrid", "tobako2-Ohrid", "tobako3-Ohrid", "tobako4-Ohrid","tobako5-Ohrid",
                "tobako1-Skopje", "tobako2-Skopje", "tobako3-Skopje", "tobako4-Skopje","tobako5-Skopje", "tobako6-Skopje", "tobako7-Skopje", "tobako8-Skopje",
                "tobako9-Skopje", "tobako10-Skopje", "tobako11-Skopje", "tobako12-Skopje","tobako13-Skopje", "tobako14-Skopje", "tobako15-Skopje", "tobako16-Skopje",
                "tobako17-Skopje", "tobako18-Skopje", "tobako19-Skopje", "tobako20-Skopje","tobako21-Skopje", "tobako22-Skopje", "tobako23-Skopje", "tobako24-Skopje"
            };


                int randomIndex = random.Next(tobaka.Count);

                string randomTobako = tobaka[randomIndex];

                line += randomTobako;

                line += ";";

                String ID_fiskalna = "#";

                int num;

                num = random.Next(0, 10000);

                string formattedNum = num.ToString("D4");

                ID_fiskalna += formattedNum;

                line += ID_fiskalna;

                line += "\n";


                File.AppendAllText("uplata.txt", line.ToString());

            }
        
        }


        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            lblSoSreka.Visible = false;
            btnGenerateBalls.Visible = true;
            string fileName = "uplata.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                       
                        while ((line = reader.ReadLine()) != null)
                        {
                            Livce livce = new Livce(line);
                            scene.AddTicket(livce);
                      
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("The file path does not exist.");
            }


        
        }

        private void btnGenerateBalls_Click(object sender, EventArgs e)
        {
            btnGenerateBalls.Enabled = false;
            scene.GenerateBalls();
            ballIndex = 0;
            animationStep = 0;
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationStep++;
            if (animationStep >= 7)
            {
                ballIndex++;
                animationStep = 0;
            }

            if (ballIndex >= scene.balls.Count)
            {
                animationTimer.Stop();
                btnGenerateBalls.Enabled = true;
                scene.CheckTickets();

                
              
            }

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

           
            for (int i = 0; i < ballIndex; i++)
            {
                if (i < scene.balls.Count)
                {
                    scene.balls[i].Draw(e.Graphics);
                }
            }

            if (ballIndex < scene.balls.Count && animationStep > 0)
            {
                scene.balls[ballIndex].Draw(e.Graphics);
            }
        }
    }
}
