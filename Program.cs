using System;

namespace University_Management_System
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("University Management System");
            Console.WriteLine("Course Offering Module");
            Console.WriteLine("Developed by Kuratoli Software Solutions" + Environment.NewLine + Environment.NewLine);

            Console.WriteLine("Creating New Courses..." + Environment.NewLine);
            Course c = new Course("HCI", 100, 3, 3.0, 1);
            Course c1 = new Course("ATP2", 200, 3, 3.0, 1);
            Console.WriteLine("Creating New Sections..." + Environment.NewLine);
            Section s = new Section("A", "HCI", 101, 3, 3.0);
            Section s1 = new Section("B", "Algorithms", 102, 3, 3.0);
            Section s2 = new Section("C", "SE", 103, 3, 3.0);
            Section s3 = new Section("D", "OOAD", 104, 3, 3.0);
            Section s4 = new Section("E", "OOP2", 105, 3, 3.0);
            Section s5 = new Section("M", "Data Structure", 201, 3, 3.0);
            Section s6 = new Section("N", "ATP2", 202, 3, 3.0);
            Section s7 = new Section("O", "Web Tech", 203, 3, 3.0);
            Section s8 = new Section("P", "PL1", 204, 3, 3.0);
            Section s9 = new Section("Q", "AI", 205, 3, 3.0);
                       
            Department d = new Department("FST");
            Department d1 = new Department("FE");
            Department d2 = new Department("FBA");
            d.AddCourse(c, c1);            
            Console.WriteLine("**********Adding Courses**********");
            d.AddCourse(s, s1, s2, s3, s4, s5, s6, s7, s8, s9);
            Console.WriteLine("Printing courselist after adding new sections to Department..." + Environment.NewLine);
            d.ShowAllCourses();
            Faculty f = new Faculty("Aminul Haque", "16-1");
            Faculty f1 = new Faculty("Ashikujjaman Khan", "12-3");
            
            Hours t = new Hours("HCI", 3, d);
            Hours t1 = new Hours("Algorithms", 3, d);
            Hours t2 = new Hours("Web Tech", 3, d);
            Hours t3 = new Hours("OOAD", 3, d);
            Hours t4 = new Hours("OOP2", 3, d);
            Hours t5 = new Hours("Data Structure", 3, d);
            Hours t6 = new Hours("ATP2", 3, d2);
            Hours t7 = new Hours("Web Tech", 3, d);
            Hours t8 = new Hours("PL1", 3, d1);
            Hours t9 = new Hours("AI", 3, d1);
            Hours t10 = new Hours("OOP2", 3, d1);
            Hours t11 = new Hours("OOP2", 3, d1);
            Hours t12 = new Hours("ATP2", 3, d2);
            Hours t13 = new Hours("Data Structure", 3, d2);
            Hours t14 = new Hours("Algorithms", 3, d2);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("*************Faculty Information*************" + Environment.NewLine);
            f.ShowInfo();
            f.AddCredit(t, t1, t2, t3, t4, t5, t6);
            f.ShowAllCredits();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("*************Faculty Information*************" + Environment.NewLine);
            f1.ShowInfo();
            f1.AddCredit(t7, t8, t9, t10, t11, t12, t13, t14);
            f1.ShowAllCredits();
        }
    }
}
