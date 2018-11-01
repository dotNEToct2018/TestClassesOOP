using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car : Vehicle
    {
        public bool hasRoof { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public Car()
        {
            hasRoof = true;
        }

        public override void Repair()
        {
            Console.WriteLine("Hello! Your car is a piece of shit!");
        }

        public virtual void PopTheTires()
        {
            wheels = 0;
        }
    }
}
