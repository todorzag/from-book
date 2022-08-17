using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Discipline
    {
        public string Name { get; }
        public int NumberOfLessons { get; }
        public int NumberOfExercises { get; }

        public Discipline(string name, int lessons, int exercises)
        {
            Name = name;
            NumberOfLessons = lessons;
            NumberOfExercises = exercises;
        }

        public override string ToString()
        {
            StringBuilder disciplineString = new StringBuilder();

            disciplineString.AppendLine($" Name: {Name}");
            disciplineString.AppendLine($" Number of Lessons: {NumberOfLessons}");
            disciplineString.AppendLine($" Number of Exercises: {NumberOfExercises}");

            return disciplineString.ToString();
        }
    }
}
