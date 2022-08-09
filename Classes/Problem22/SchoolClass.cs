using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    internal class SchoolClass
    {
        public List<Teacher> Teachers { get; set; }
        public string Name { get; set; }

        public SchoolClass(string name)
        {
            Name = name;
            Teachers = new List<Teacher>();
        }

        public SchoolClass (string name, List<Teacher> teachers)
        {
            Name = name;
            Teachers = teachers; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Teachers in {Name} class:\n");

            foreach (Teacher teacher in Teachers)
            {
                sb.Append($" {teacher.ToString()}\n");
            }

            return sb.ToString();
        }
    }
}
