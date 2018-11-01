using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class ATV : Car
    {
        public bool canOffRoad { get; set; }

        public ATV()
        {
            canOffRoad = true;
        }

        public override void PopTheTires()
        {
            wheels = -1;
        }

        public void PopTheTires(int x)
        {
            wheels = x;
        }
    }
}
