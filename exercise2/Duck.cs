using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace exercise2
{
    internal class Duck : Animal
    {
        public string Name { get; set; }
        public Duck(TypeAnimal type)
        {
            this.type = type;
        }
        public Duck(TypeAnimal type, string name)
        {
            this.type = type;
            this.Name = name;
        }
        public void Swim(Swim st)
        {
            Console.WriteLine($"Duck swimming {st}");
        }
        public override void Info()
        {
            Console.WriteLine($"Type: {type}, name: {Name}");
        }

        public override void Sound()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
