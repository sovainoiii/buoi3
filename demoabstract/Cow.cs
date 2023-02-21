using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoabstract
{
    internal class Cow : Animal, ICanMove, ICanHuc
    {
        public override void Eat()
        {
            Console.WriteLine("Cow eats grass");
        }

        public void Huc()
        {
            Console.WriteLine("Huc nhau thanh bo huc");
        }

        public void Jump()
        {
            Console.WriteLine("Nhay cl");
        }

        public void Run()
        {
            Console.WriteLine("Chay thua tiger");
        }
    }
}
