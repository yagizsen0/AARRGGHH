using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int zaman = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            zaman++;
            Point konum = new Point();

            if (zaman == 1)
            {
                konum.X = 32;
                konum.Y = 50;
                pictureBox1.Location = konum;
            }

            if (zaman == 2)
            {
                konum.X = 32;
                konum.Y = 60;
                pictureBox1.Location = konum;
            }

            if (zaman == 3)
            {
                konum.X = 32;
                konum.Y = 70;
                pictureBox1.Location = konum;
            }
            if (zaman == 4)
            {
                konum.X = 32;
                konum.Y = 80;
                pictureBox1.Location = konum; 
            }
            if (zaman == 5) 
            {
                konum.X = 32;
                konum.Y = 90;
                pictureBox1.Location = konum;
            }
            if (zaman == 6)
            {
                konum.X = 32;
                konum.Y = 100;
                pictureBox1.Location = konum;
            }
            if (zaman == 7)
            {
                konum.X = 32;
                konum.Y = 110;
                pictureBox1.Location = konum;
            }
            if (zaman == 8)
            {
                konum.X = 32;
                konum.Y = 120;
                pictureBox1.Location = konum;
            }
            if (zaman == 9)
            {
                konum.X = 32;
                konum.Y = 130;
                pictureBox1.Location = konum;
            }
            if (zaman == 10)
            {
                konum.X = 32;
                konum.Y = 140;
                pictureBox1.Location = konum;
            }
            if (zaman == 11)
            {
                konum.X = 32;
                konum.Y = 150;
                pictureBox1.Location = konum;
            }
            if (zaman == 12)
            {
                konum.X = 32;
                konum.Y = 160;
                pictureBox1.Location = konum;
            }
            if (zaman == 13)
            {
                konum.X = 32;
                konum.Y = 170;
                pictureBox1.Location = konum;
            }
            if (zaman == 14)
            {
                konum.X = 32;
                konum.Y = 180;
                pictureBox1.Location = konum;
            }
            if (zaman == 15)
            {
                konum.X = 32;
                konum.Y = 170;
                pictureBox1.Location = konum;
            }
            if (zaman == 16)
            {
                konum.X = 32;
                konum.Y = 160;
                pictureBox1.Location = konum;
            }
            if (zaman == 17)
            {
                konum.X = 32;
                konum.Y = 150;
                pictureBox1.Location = konum;
            }
            if (zaman == 18)
            {
                konum.X = 32;
                konum.Y = 140;
                pictureBox1.Location = konum;
            }
            if (zaman == 19)
            {
                konum.X = 32;
                konum.Y = 130;
                pictureBox1.Location = konum;
            }
            if (zaman == 20)
            {
                konum.X = 32;
                konum.Y = 120;
                pictureBox1.Location = konum;
            }
            if (zaman == 21)
            {
                konum.X = 32;
                konum.Y = 110;
                pictureBox1.Location = konum;
            }
            if (zaman == 22)
            {
                konum.X = 32;
                konum.Y = 100;
                pictureBox1.Location = konum;
            }
            if (zaman == 23)
            {
                konum.X = 32;
                konum.Y = 90;
                pictureBox1.Location = konum;
            }
            if (zaman == 24)
            {
                konum.X = 32;
                konum.Y = 80;
                pictureBox1.Location = konum;
            }
            if (zaman == 25)
            {
                konum.X = 32;
                konum.Y = 70;
                pictureBox1.Location = konum;
            }
            if (zaman == 26)
            {
                konum.X = 32;
                konum.Y = 60;
                pictureBox1.Location = konum;
            }
            if (zaman == 27)
            {
                konum.X = 32;
                konum.Y = 50;
                pictureBox1.Location = konum;
            }
            if (zaman == 28)
            {
                konum.X = 32;
                konum.Y = 40;
                pictureBox1.Location = konum;
                zaman = 0;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            zaman = 0;
            Point konum = new Point();
            konum.X = 32;
            konum.Y = 40;
            pictureBox1.Location = konum;
        }
    }
}
