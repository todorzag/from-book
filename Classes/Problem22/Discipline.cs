using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    internal class Discipline
    {
        public string Name { get; }
        public int NumberOfLessons { get; }
        public int NumberOfExercises { get; }

        public Discipline (string name, int lessons, int exercises)
        {
            Name = name;
            NumberOfLessons = lessons;
            NumberOfExercises = exercises;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($" Name: {Name}\n");
            sb.Append($" Number of Lessons: {NumberOfLessons}\n");
            sb.Append($" Number of Exercises: {NumberOfExercises}");

            return sb.ToString();
        }
    }
}
