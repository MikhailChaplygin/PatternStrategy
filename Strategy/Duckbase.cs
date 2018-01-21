using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class Duckbase : Iflyable, Iquackable
    {
        public virtual void Fly()
        {
            Console.WriteLine("I'm Flying");
        }
        public virtual void Quack()
        {
            Console.WriteLine("Quack!!!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public abstract void Display();
    }
}
