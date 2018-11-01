using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car dansShittyCar = new Car();
            //Console.WriteLine(dansShittyCar.canStart);

            //Vehicle.IsVehicle(dansShittyCar);

            ATV evansFarmATV = new ATV();
            //Console.WriteLine("Info about Evan's ATV:");
            //Console.WriteLine("Can Start: " + evansFarmATV.canStart);
            //Console.WriteLine("# of doors: " + evansFarmATV.doors);
            //Console.WriteLine("# of wheels: " + evansFarmATV.wheels);
            //Console.WriteLine("Has roof: " + evansFarmATV.hasRoof);
            //Console.WriteLine("Can Offroad: " + evansFarmATV.canOffRoad);
            Console.WriteLine($"before: {evansFarmATV.wheels}");
            evansFarmATV.PopTheTires();
            Console.WriteLine($"after: {evansFarmATV.wheels}");
            evansFarmATV.PopTheTires(9);
            Console.WriteLine($"after again: {evansFarmATV.wheels}");
        }
    }
}
