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
        int x, y = 0;//x and y are for moving horizontally
        string launch = "Go";
      


     

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
            lblJet.SetBounds(x, y, 1, 1);
            if (launch == "Go")
            {
                y++;
            }

            if (y == 88)
            {
                launch = "Evade";
                x++; 
            }
                if (true)
            {

            }
            if (x == 227)
            {
                y++;
            }
            if (y == 170) //155
            {
                x++;
            }
            if (x == 327)
            {
                y++;
            }
            if (y == 500)
            {
                x++;
            }
            if (x == 558)
            {
                y--; 
            }
            if (y == 190)
            {
                x++; 
            }
            if (x == 786)
            {
                y++; 
            }
            if (y == 220)
            {
                y--;
            }
            if (lblJet.Bounds.IntersectsWith(lblEnemyCamp.Bounds))
            {
                x = 868;
                y = 198;
                lblJet.Hide();
                timer1.Stop();
                MessageBox.Show("The pilot has safely entered the enemy camp zone");
            }
        }
    }
}
