using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptrenlop
{
    internal class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public People() { }
        //public virtual void Print()
        //{
        //    Console.WriteLine($"Ten: {Name}, age: {Age}");
        //}
        public void Print()
        {
            Console.WriteLine($"Ten: {Name}, age: {Age}");
        }
        public override string ToString()
        {
            return $"Ten: {Name}, tuoi: {Age}";
        }

    }
}
