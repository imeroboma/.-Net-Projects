using System;
using System.Collections.Generic;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.WriteLine("Student Name:");
                newStudent.Name = Console.ReadLine();

                Console.WriteLine("Student Grade:");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Student Birthday:");
                newStudent.Birthday = Console.ReadLine();

                Console.WriteLine("Student Address:");
                newStudent.Address = Console.ReadLine();

                Console.WriteLine("Student Phone:");
                newStudent.SetPhone(int.Parse(Console.ReadLine()));

                students.Add(newStudent);
                Console.WriteLine("Add another Student? y/n");

                if (Console.ReadLine() != "y") ;
                adding = false;

            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1} , Birthday: {2}, Address: {3}, Phone: {4},",
                    student.Name, student.Grade, student.Birthday, student.Address, student);
            }

        }
    
        class Student
        {
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int phone;

            public void SetPhone(int number) 
            {
                phone = number;
            } 

        }
    }
    
}
