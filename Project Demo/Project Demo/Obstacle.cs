using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Demo
{
    class Obstacle
    {
        private int obstacleID;

        public int ObstacleID
        {
            get { return obstacleID; }
            set { obstacleID = value; }
        }
        private string description;

        public string Description1
        {
            get { return description; }
            set { description = value; }
        }
        private string range;

        public string Range
        {
            get { return range; }
            set { range = value; }
        }

        public Obstacle(int obstacleID, string description, string range)
        {
            this.obstacleID = obstacleID;
            this.description = description;
            this.range = range;
        }
    }
}
