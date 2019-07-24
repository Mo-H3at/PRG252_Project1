using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Demo
{
    class Inventory
    {
        private int inventoryID;

        public int InventoryID
        {
            get { return inventoryID; }
            set { inventoryID = value; }
        }
        private string item;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
