namespace School
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

            List<Student> students = GenerateStudents();
            List<Teacher> teachers = GetTeachers();
            List<SchoolClass> schoolClasses = GetSchoolClasses(teachers);

            School school = new School(schoolClasses, students);

            school.PrintSchoolInfo();
        }

        public static bool Validate(Student student, List<Student> students)
        {
            Student toCheck = students
                .Find(x => x.NumberInClass == student.NumberInClass);

            if (student != null)
            {
                Console.WriteLine("Number already taken!");
                return false;
            }

            return true;
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

        /* List<Tuple> inputStudents = GetInputStudents();
         * List<Student> students = GenerateStudents(inputStudents) =>
         *   - Validate(student, students)
         */
        public static List<Student> GenerateStudents()
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Please enter student name and number:");
            string input = Console.ReadLine();

            while (input != "End of students")
            {
                string[] inputSplit = input.Split(" ");

                Student student = CreateStudent(inputSplit);

                if (Validate(student, students))
                {
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            return students;
        }

        public static Student CreateStudent(string[] inputSplit)
        {
            string studentName = inputSplit[0];
            int studentNumber = int.Parse(inputSplit[1]);

            return new Student(studentNumber, studentName);
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