using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Course
    {
        public int Number { get; set; }
        private int courseId;

        public int CourseId { get; set; }
        private string courseName;

        public string CourseName { get; set; }
        
        private int courseCredit;

        public int CourseCredit { get; set; }
        private double courseTeachingHours;

        public double CourseTeachingHours { get; set; }



        private Section[] sections;
        private int sectionCount;

        public int SectionCount { get; set; }


        public Course()
        {
            sections = new Section[10];
            sectionCount = 0;
        }
        public Course(string courseName, int courseId, int courseCredit, double courseTeachingHours)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;

            sections = new Section[10];
            sectionCount = 0;
        }
        public Course(string courseName, int courseId, int courseCredit, double courseTeachingHours, int Number)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;
            this.Number = Number;
            sections = new Section[10];
            sectionCount = 0;
        }
        public void AddScetion(params Section[] sections)
        {
            foreach (var a in sections)
            {
                if (sectionCount < 20)
                {
                    this.sections[sectionCount++] = a;
                }
                else
                {
                    Console.WriteLine("Cannot Add Any More Section For The Course : " + a.CourseId);
                }
            }
        }
        public void ShowAllTheSections()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                sections[i].ShowInfo();
            }
        }
        public Section SearchSection(int sectionNumber)
        {
            Section a = null;
            for (int i = 0; i < sectionCount; i++)
            {
                if (sections[i].CourseId.Equals(sectionNumber))
                {
                    a = sections[i];
                    break;
                }
            }
            return a;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name of Course : " + courseName);
            Console.WriteLine("Section ID : " + courseId);
            Console.WriteLine("Course Credits : " + courseCredit);
            Console.WriteLine("Weekly Teaching Hours : " + courseTeachingHours);

        }
        public void AddCourseNumber(int x)
        {
            Number += x;
        }

    }
}
