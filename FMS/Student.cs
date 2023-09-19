using System;
using System.Collections.Generic;

namespace FMS
{
    public class Student: Person
    {
        private decimal gpa;
        private string email;
        private byte level;
        List<string> courses = new List<string>();
        List<string> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }
        public string Depart { get; set; }
        protected string Email
        {
            get
            {
                return email;
            }
            private set
            {
                if (value.EndsWith("@compit.aun.edu.eg"))
                {
                    email = value;
                }
                else
                {
                    email = "InValid Email";
                }
            }
        }
        protected decimal GPA{
            get 
            {
                return gpa;
            } 
            private set
            {
                if (gpa < 0 || gpa > 4)
                {
                    gpa = -1;
                }
                else
                    gpa = value;
            }
        }
        protected byte Level {
            get
            {
                return level;
            }
            private set
            {
                if (value < 1 || value > 4)
                {
                    level = 0;
                }
                else
                { level = value; }
            }
        }

        public Student()
        {
            
        }
        public Student(int id, string fname, string lname, int age, string national, string phone, string address, decimal gpa, byte level, string dep, string email, List<string> c)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
            NationalNumber = national;
            Phone = phone;
            Address= address;
            GPA = gpa;
            Level = level;
            Depart = dep;
            Email = email;
            Courses = c;
        }
        public override bool add()
        {
            try
            {
                Console.WriteLine("Adding new student\n~~~~~~~~~~~~~~~~~~~~~");

                var ok = base.add();//name, age, phone, address, national
                if (!ok)
                {
                    return false;
                }
                Console.Write("Email: ");
                Email = Console.ReadLine();
                if (Email == "InValid Email")
                {
                    Console.WriteLine("InValid Email.");
                    return false;
                }

                Console.Write("level: ");
                Level = byte.Parse(Console.ReadLine());
                if (Level == 0)
                {
                    Console.WriteLine("InValid level.");
                    return false;
                }

                Console.Write("GPA: ");
                GPA = decimal.Parse(Console.ReadLine());
                if (GPA == -1)
                {
                    Console.WriteLine("InValid GPA.");
                    return false;
                }

                Console.Write("Department: ");
                Depart = Console.ReadLine();
                Courses = new List<string>();
                Console.Write("Courses: ");
                for (int i = 0; i < 6; i++)
                {
                    Courses.Add(Console.ReadLine());
                }

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public override string print()
        {
            return base.print()+
                $"\nDepartment: {Depart}\nLevel: {Level}\nGPA: {GPA}\n"+
                $"Courses: {string.Join(", ",Courses)}";
        }
    }

}
