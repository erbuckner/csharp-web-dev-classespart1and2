using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            //Test #1: exercises in Student class - toString(), GetGradeLevel(), and AddGrade()
           
            Student testStudent = new Student("Erin");

            testStudent.NumberOfCredits = 52;
            string gradeLevel = testStudent.GetGradeLevel(testStudent.NumberOfCredits);

            //toString()
            Console.WriteLine(testStudent.ToString());
            //GetGradeLevel()
            Console.WriteLine(gradeLevel);
            //AddGrade()
            testStudent.AddGrade(9, 3.5);
            Console.WriteLine(testStudent.ToString());
            gradeLevel = testStudent.GetGradeLevel(testStudent.NumberOfCredits);
            Console.WriteLine(gradeLevel);

            //Test #2: exercises in Course class

        }
    }
}
