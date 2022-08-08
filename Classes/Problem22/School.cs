using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    internal class School
    {
        public List<SchoolClass> SchoolClasses { get; }
        public List<Student> Students { get; }

        public School (List<SchoolClass> schoolClasses, List<Student> students)
        {
            SchoolClasses = schoolClasses;
            Students = students;
        }

        public void PrintSchoolInfo()
        {
            foreach (SchoolClass schoolClass in SchoolClasses)
            {
                Console.WriteLine(schoolClass.ToString());
            }
        }
    }
}
