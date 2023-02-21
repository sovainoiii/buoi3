using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptrenlop
{
    internal class Student : People
    {
        public string University { get; set; }

        public Student(string university)
        {
            University = university;
        }
        public Student(string name, int age) : base(name, age) { }
        public Student(string name, int age, string university) : base(name, age)
        {
            University = university;
        }
        public new void Print()
        {
            Console.WriteLine($"Ten: {Name}, age: {Age}, university: {University}");
        }
        //public override void Print()
        //{
        //    Console.WriteLine($"Ten: {Name}, age: {Age}, university: {University}");
        //}
    }
}
