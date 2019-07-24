using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Demo
{
    public delegate void delEventHandler();

    class FuelTank
    {
       
        
        
            public event delEventHandler onTimeChange;

            private int fuel;

            public int Minutes
            {
                get { return fuel; }
                set
                {
                    if (onTimeChange != null)
                    {
                        onTimeChange();
                    }
                    fuel = value;
                }

            }

            public FuelTank(int minutes)
            {
                this.Minutes = minutes;
            }
    }
}
