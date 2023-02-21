using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoabstract
{
    abstract class Animal
    {
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Animal sleep");
        }
        public abstract void Eat();
    }
}
