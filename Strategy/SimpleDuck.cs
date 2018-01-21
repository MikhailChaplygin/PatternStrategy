using System;

namespace Strategy
{
    class SimpleDuck : Duckbase
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Simple Duck");
        }

        public override void Fly()
        {

        }
    }
}
