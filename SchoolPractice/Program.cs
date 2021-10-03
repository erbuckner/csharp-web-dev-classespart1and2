using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            //Test #1: exercises in Student class - toString(), GetGradeLevel(), and AddGrade()
           
            Student testStudent = new Student("Erin", 001, 29, 3.2);

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
            Course testCourse = new Course();
            testCourse.Topic = "Intro to Alchemy";
            testCourse.Instructor = new Teacher("James", "Anderson", "Introductory Topics", 7);
            testCourse.enrolledStudents = new List<Student>
                {
                    new Student("Jasper"),
                    new Student("Megan"),
                    new Student("Elliot")
                };


            Console.WriteLine(testCourse.ToString());

        }
    }
}
