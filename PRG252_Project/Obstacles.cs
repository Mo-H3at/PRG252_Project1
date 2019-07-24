using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG252_Project
{
    public partial class Obstacles : Form
    {
        public Obstacles()
        {
            InitializeComponent();
        }
        int x, y, xx, cnt = 0; //x and y are for moving horizontally... xx is for moving diagoanlly and works along with cnt as centre
        double yy = 0.00; //yy for diagonal movement regarding y-axis


     

        private void Obstacles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1; //1 second
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //if (player.Bounds.IntersectsWith(enemies[i].Bounds))
            //{
            //    timerGame.Enabled = false;
            //    lives = lives - 1; //Lose a life
            //    lblLives.Text = "" + lives;

            lblJet.SetBounds(xx, Convert.ToInt32(yy) , 1, 1);
            if (xx != 203 && yy != 187)
            {
                if (cnt == 0)
                {
                    xx++;
                    yy = yy + 0.60;
                }
                if (cnt == 1)
                {
                    xx--;
                    yy = yy - 0.60;

                }
                if (xx == 700)
                {
                    xx--;
                    yy = yy - 0.60;

                }
                if (xx == 700)
                {
                    cnt = 1;
                }
                if (xx == 1)
                {
                    cnt = 0;
                }
            }
            else if(xx == 153 && yy == 163)
            {
                x++; 
            }

           





            //lblJet.SetBounds(x, y, 12, 20);
            //x--;

            //if (lblJet.Bounds.IntersectsWith(lblObstacle1.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle2.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle3.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle4.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle5.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle6.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle7.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle8.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle9.Bounds))
            //{

            //}
            //if (lblJet.Bounds.IntersectsWith(lblObstacle10.Bounds))
            //{

            //}

        }
    }
}
