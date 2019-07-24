using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Demo
{
    class Jets
    {
        private int jetID;

        public int JetID
        {
            get { return jetID; }
            set { jetID = value; }
        }
        private string jetModel;

        public string JetModel
        {
            get { return jetModel; }
            set { jetModel = value; }
        }
        private int fuelTankCapacity;

        public int FuelTankCapacity
        {
            get { return fuelTankCapacity; }
            set { fuelTankCapacity = value; }
        }

        private int fuelLevel;

        public int FuelLevel
        {
            get { return fuelLevel; }
            set { fuelLevel = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double maxWeight;

        public double MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }


        public Jets(int jetID, string jetModel, int fuelTankCapacity, int fuelLevel, double height, double maxWeight)
        {
            this.jetID = jetID;
            this.jetModel = jetModel;
            this.fuelTankCapacity = fuelTankCapacity;
            this.height = height;
            this.maxWeight = maxWeight;
            this.fuelLevel = fuelLevel;
            // I changed weight to max weight because we already getting weight from inventory class, so we will compute using the one in Inventory 
            //Then compare to see if it is bigger or smaller than max weight 
        }

        public Jets()
        {
                
        }




    }
}
