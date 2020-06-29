using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
            public string ClassName { get; set; }
            public string Instructor { get; set; }
            public List<Student> Roster { get; set; }

            public Course(string classname, string instructor, List<Student> roster)
            {
                ClassName = classname;
                Instructor = instructor;
                Roster = roster;
            }
    
    }
}
