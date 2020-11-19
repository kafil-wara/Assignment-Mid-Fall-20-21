using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Section : Course
    {
        private string sectionName;

        public string SectionName { get; set; }

        public Section() { }
        public Section(string sectionName, string courseName, int courseId, int courseCredit, double courseTeachingHours) : base(courseName, courseId, courseCredit, courseTeachingHours)
        {
            this.sectionName = sectionName;
        }
        virtual public void ShowSectionInfo()
        {
            Console.WriteLine("Section Name : " + sectionName);

        }
    }
}
