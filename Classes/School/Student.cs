using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student
    {
        public int NumberInClass { get; }
        public string Name { get; }

        public Student(int numberInClass, string name)
        {
            NumberInClass = numberInClass;
            Name = name;
        }

        public override string ToString()
        {
            return $"Student name: {Name}\n" +
                $"Student number in class: {NumberInClass}";
        }
    }
}
