using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoabstract
{
    internal class Tiger : Animal, ICanMove
    {
        public override void Eat()
        {
            Console.WriteLine("Tiger eats meat");
        }

        public void Jump()
        {
            Console.WriteLine("Nhay cao vl");
        }

        public void Run()
        {
            Console.WriteLine("Chay nhanh vailon");
        }
    }
}
