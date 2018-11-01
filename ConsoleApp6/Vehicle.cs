using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Vehicle
    {
        public int wheels { get; set; }
        public int doors { get; set; }
        public bool canStart { get; set; }
        public int seats { get; set; }

        public Vehicle()
        {
            wheels = 3;
            doors = 1;
            canStart = false;
            seats = 2;
        }

        abstract public void Repair();

        public static bool IsVehicle(Vehicle x)
        {
            if (x.doors > 0 && x.seats > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
