using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            Console.WriteLine("How many students are in your class?");
            var StudentCount = int.Parse(Console.ReadLine());
            var studentGrades = new int[] { 80, 78, 56, 79, 67, 23, 79, 98, 85, 100 };
            //studentGrades[0] = 80;
            //studentGrades[1] = 55;
            //studentGrades[2] = 80;
            //studentGrades[3] = 80;
            //studentGrades[4] = 80;
            //studentGrades[5] = 80;
            //studentGrades[6] = 80;
            //studentGrades[7] = 80;
            //studentGrades[8] = 80;
            //studentGrades[9] = 80;
            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
        }
    }
}
