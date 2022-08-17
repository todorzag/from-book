using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teacher
    {
        public string Name { get; }
        public List<Discipline> Disciplines { get; }

        public Teacher(string name, List<Discipline> disciplines)
        {
            Name = name;
            Disciplines = disciplines;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Name: {Name}\n");
            sb.Append($"Disciplines he teaches:\n");

            foreach (Discipline discipline in Disciplines)
            {
                sb.Append($"{discipline.ToString()}");
            }

            return sb.ToString();
        }
    }
}
