using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// bai lam cua Pham Duc Minh
namespace exercise2
{
    internal class Dog : Animal
    {
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public Dog(TypeAnimal type)
        {
            this.type = type;
        }
        public Dog(TypeAnimal type, string name, Breed breed) {
            this.type = type;
            this.Name = name;
            this.Breed = breed;
        }
        public override void Info()
        {
            Console.WriteLine($"Type: {type}, name: {Name}, breed: {Breed}");
        }

        public override void Sound()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
