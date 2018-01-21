using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class WoodenDuck: Duckbase
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Simple Duck");
        }
    }
}
