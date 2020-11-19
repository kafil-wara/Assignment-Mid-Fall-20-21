using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Hours
    {
        //private string courseName;
        public string CourseName { get; set; }
        //private int courseCredits;
        public int CourseCredits { get; set; }
        public Department Department { get; set; }
        Course[] courses;
        //private int credit;
        public int Credit { get; set; }
        public Hours()
        {
            courses = new Course[5];
        }
        public Hours(string courseName, int courseCredits, Department department)
        {
            CourseName = courseName;
            CourseCredits = courseCredits;
            Department = department;
            courses = new Course[5];
        }

        public void AddHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (Credit < 7)
                    this.courses[Credit++] = course;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name of the course: " + CourseName);
            Console.WriteLine("Total Hours: " + CourseCredits);

            for (int i = 0; i < Credit; i++)
                courses[i].ShowInfo();
        }

    }
}
