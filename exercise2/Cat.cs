using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace exercise2
{
    internal class Cat: Animal
    {
        public string Name { get; set; }
        public Cat(TypeAnimal type)
        {
            this.type = type;
        }
        public Cat(TypeAnimal type, string name)
        {
            this.type = type;
            this.Name = name;
        }
        public void Climb(Climb st)
        {
            Console.WriteLine($"Cat climbing {st}");
        }
        public override void Info()
        {
            Console.WriteLine($"Type: {type}, name: {Name}");
        }

        public override void Sound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
