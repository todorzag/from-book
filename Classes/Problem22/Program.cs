namespace Problem22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            We have a school. In school we have classes and students. Each class
            has a number of teachers. Each teacher has a variety of disciplines
            taught. Students have a name and a unique number in the class. Classes
            have a unique text identifier. Disciplines have a name, number of lessons
            and number of exercises. The task is to shape a school with C# classes.
            You have to define classes with their fields, properties, methods and
            constructors.
            */

            List<Student> students = GetStudents();
            List<Teacher> teachers = GetTeachers();
            List<SchoolClass> schoolClasses = GetSchoolClasses(teachers);

            School school = new School(schoolClasses, students);

            school.PrintSchoolInfo();
        }

        public static void ValidateAndAddStudent(int studentNumber,
            string studentName,
            List<Student> students)
        {
            Student student = students
                .Find(student => student.NumberInClass == studentNumber);

            if (student == null)
            {
                students.Add(new Student(studentNumber, studentName));
            }
            else
            {
                Console.WriteLine("Number already taken!");
            }

        }

        public static void AddTeacherToClass
            (SchoolClass schoolClass,
            List<Teacher> teachers,
            string teacherName)
        {
            Teacher teacher = teachers
                       .Find(teacher => teacher.Name == teacherName);

            schoolClass.Teachers.Add(teacher);
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Please enter student name and number:");
            string line = Console.ReadLine();

            while (line != "End of students")
            {
                string[] split = line.Split(" ");
                string studentName = split[0];
                int studentNumber = int.Parse(split[1]);

                ValidateAndAddStudent(studentNumber, studentName, students);

                line = Console.ReadLine();
            }

            return students;
        }

        public static List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            Console.WriteLine("Please enter teacher name and afterwards his disciplines:");
            string line = Console.ReadLine();

            while (line != "End of teachers")
            {
                List<Discipline> disciplines = new List<Discipline>();
                string teacherName = line;

                line = Console.ReadLine();

                while (line != "End of disciplines")
                {
                    string[] split = line.Split(" ");
                    string disciplineName = split[0];
                    int numberOfLessons = int.Parse(split[1]);
                    int numberOfExercises = int.Parse(split[2]);

                    disciplines.Add(new Discipline
                        (disciplineName, numberOfLessons, numberOfExercises));

                    line = Console.ReadLine();
                }

                teachers.Add(new Teacher(teacherName, disciplines));

                line = Console.ReadLine();
            }

            return teachers;
        }

        public static List<SchoolClass> GetSchoolClasses(List<Teacher> teachers)
        {
            List<SchoolClass> schoolClasses = new List<SchoolClass>();

            Console.WriteLine("Please enter school classes and their teachers:");
            string line = Console.ReadLine();

            while (line != "End of school classes")
            {
                string schoolClassName = line;
                line = Console.ReadLine();

                SchoolClass schoolClass = new SchoolClass(schoolClassName);

                string teacherName = line;
                AddTeacherToClass(schoolClass, teachers, teacherName);

                schoolClasses.Add(schoolClass);

                line = Console.ReadLine();
            }

            return schoolClasses;
        }
    }
}