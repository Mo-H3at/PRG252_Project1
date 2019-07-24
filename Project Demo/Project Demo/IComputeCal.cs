using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Demo
{
    interface IComputeCal
    {
         public interface ICalculateMaxWeight
         {
             double CalculateMaxWeight();
         }
        public interface  IFuelBurnt
        {
            double FuelBurnt();
        }

        public interface LivesAid // this method will compute points before the pilot and jet are distroyed by obstacles
        {
            int LivesAid();
        }
       
    }
}
