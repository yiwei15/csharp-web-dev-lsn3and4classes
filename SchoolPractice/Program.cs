using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            //Student me = new Student ("Yiwei Zhao", 1, 1, 4.0);

            //default student
            Student student1 = new Student();
            student1.Name = "Yiwei";
            student1.NumberOfCredits = 1;
            student1.Gpa = 4.0;

            Student student2 = new Student();
            student2.Name = "Chris";
            student2.NumberOfCredits = 1;
            student2.Gpa = 3.8;

            List<Student> roster = new List<Student>();
            roster.Add(student1);
            roster.Add(student2);

            Course course1 = new Course("Codecamp", "Ben", roster);

            //Console.WriteLine(course1.Roster[1].Name);

            Teacher teacher1 = new Teacher("Ben", "Clark", "Codecamp", 5);

            //Console.WriteLine(teacher1.YearsTeaching);
        }
    }
}
