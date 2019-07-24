using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project_Demo
{
    public partial class lblFuel : Form
    {
        int fuelCap;
        FuelTank ft;
        public lblFuel()
        {
            InitializeComponent();
        }

        int x = 643, y = 32;
        private void timer1_Tick(object sender, EventArgs e)
        {

            lblJet1.SetBounds(x, y, 2, 1);
            x--;
            if (x == 320)
            {
                y = 150;
            }
            if (x == 283)
            {
                lblJet1.Hide();
                MessageBox.Show("Air craft has been taken down", "ALERT", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                
            }
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {



            if (txtFuel.Text != "")
            {
                fuelCap = int.Parse(txtFuel.Text);
            }
            else
            {
                MessageBox.Show("Fuel amount cannot be empty.");
            }
        }

        //private void btnStart_Click(object sender, EventArgs e)
        //{
            
        //}
       

        private void btnScout_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1; //1 second
            timer1.Start();

            if (txtFuel.Text != "")
            {
                fuelCap = int.Parse(txtFuel.Text);
                ft = new FuelTank(fuelCap - 1);

                //Create thread and new method Elasped mins(fuel Cap)
                Thread thrd = new Thread(() =>
                {
                    while (ft.Minutes != -1)
                    {
                        Thread.Sleep(1000);
                        fixCrossMinuteThread();//Asssigning value from FuelTank class to labels


                        ft.Minutes -= 1;
                        fixCrossMinuteThread(); //Display values to the form

                    }

                 

                });

                thrd.Start(); //Needed to start thread
                

            }
            else
            {
                MessageBox.Show("Fuel amount can not be empty");
            }

        }


        public void fixCrossMinuteThread()
        {
            if (this.lblFuelTank.InvokeRequired)
            {
                Action ac = new Action(fixCrossMinuteThread);
                this.Invoke(ac);
            }
            else
            {
                lblFuelTank.Text = ft.Minutes + "";
            }
        }

    }
}
