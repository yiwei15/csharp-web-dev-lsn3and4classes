using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student testStudent= new Student("Test");
            testStudent.NumberOfCredits = 3;
            testStudent.Gpa = 3.0;
            Student extraStudent = testStudent;
            //testStudent.ToString();
            Student otherStudent = new Student("Other");
            Console.WriteLine(testStudent);
            Console.WriteLine(otherStudent);

            Console.WriteLine(testStudent.Equals(otherStudent));
            Console.WriteLine(testStudent.Equals(extraStudent));

            Course newCourse = new Course();
            Console.WriteLine(testStudent.Equals(newCourse));


            //Test AddGrade method
            int newCourseCredit;
            double newGrade;

            newCourseCredit = 3;
            newGrade = 4.0;

            testStudent.AddGrade(newCourseCredit, newGrade);
            Console.WriteLine(testStudent);

        }
    }
}
