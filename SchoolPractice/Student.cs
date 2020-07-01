using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            this.Name = name;
            this.StudentId = studentId;
            this.NumberOfCredits = numberOfCredits;
            this.Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.

       
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double currentQualityScore = Gpa * NumberOfCredits;
            double newQualityScore = courseCredits * grade;
            double totalQualityScore = currentQualityScore + newQualityScore;
            NumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits

            if (credits >= 90)
            {
                return "Senior";
            }

            else if (credits >= 60)
            {
                return "Junior";
            }

            else if (credits >= 30)
            {
                return "Sophomore";
            }

            else if (credits <=29)
            {
                return "Freshman";
            } 

            else
            {
                return "Invalid Credits!";
            }
            
          // return "grade level tbd";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        public override string ToString()
        {
            return "Name: " + Name  + "\nStudent ID: " + StudentId + "\nCredits: " + NumberOfCredits 
                + ", GPA: " + Gpa + ";" + "\nGrade Level: " + GetGradeLevel(NumberOfCredits);
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

       public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student toCompare = obj as Student;

            return this.Name == toCompare.Name && this.StudentId == toCompare.StudentId;
        }
    }
}
