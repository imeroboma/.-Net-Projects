using System;

namespace StudentCounterAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Name = "Jim";
            Console.Write(student.Name);
            Console.WriteLine("How many students are in your class?");
            var studentCount = int.Parse(Console.ReadLine());
            var studentNames = new string[studentCount] ;
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name:");
                studentNames[i] = Console.ReadLine();

                Console.Write("Student Grade:");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
            
        }
          class Student
        {
            public string Name;
            public string Grade;
            public string Birthday;
            public string Address;
            public string Phone;

        }
    }
}

