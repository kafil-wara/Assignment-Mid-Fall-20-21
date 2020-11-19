using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Faculty
    {
        public string FacultyName { get; set; }
        public string FacultyId { get; set; }
        Hours[] hours;
        public int NoOfCourse { get; set; }

        public Faculty()
        {
            hours = new Hours[100];
        }
            public Department department { get; set; }
        public Faculty(string facultyName, string facultyId)
        {
            this.FacultyName = facultyName;
            this.FacultyId = facultyId;
            hours = new Hours[100];
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FacultyName);
            Console.WriteLine("ID: " + FacultyId + Environment.NewLine);
            Console.WriteLine("List of Current Sections:");

        }

        public void AddCredit(params Hours[] hours)
        {
            foreach (var x in hours)
            {
                if (NoOfCourse < 7)
                    this.hours[NoOfCourse++] = x;
                else
                    Console.WriteLine("Can not take any more courses. Max teaching hours reached.");

            }

        }

        public void ShowAllCredits()
        {
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < NoOfCourse; i++) 
                hours[i].ShowInfo();
            Console.WriteLine("---------------------------------------");
        }
    }
}
