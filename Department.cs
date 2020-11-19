using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Department
    {
        public string DepartmentName { get; set; }
        Course[] courseList;
        private int totalCourse;
        public int TotalCourse { get; set; }
        public Section Section { get; set; }
        Hours[] hours;
        public int CreditCount { get; set; }
        public Department()
        {
            courseList = new Course[50];
            hours = new Hours[150];
        }

        public Department(string name)
        {
            DepartmentName = name;
            courseList = new Course[50];
            hours = new Hours[100];
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name of Department: " + DepartmentName);
            Console.WriteLine("Total No. of Courses: " + totalCourse);

        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 50)
                    courseList[totalCourse++] = course;
            }
        }


        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                courseList[i].ShowInfo();
                Console.WriteLine("------------------------");
            }
        }
    }
}
