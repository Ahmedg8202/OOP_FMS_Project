using System;
using System.Collections.Generic;

namespace FMS
{
    public class Instructor: Staff
    {
        private string email;
        protected string Email
        {
            get
            {
                return email;
            }
            private set
            {
                if (value.EndsWith("@aun.edu.eg"))
                {
                    email = value;
                }
                else
                {
                    email = "InValid Email";
                }
            }
        }
        protected string Depart { get; set; }
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

        public Instructor()
        {

        }
        public Instructor(int id,string fname, string lname, int age, string national,string phone,
            string address,string dep, string email, List<string> c, double salary)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
            NationalNumber = national;
            Phone = phone;
            Address = address;
            Depart = dep;
            Email = email;
            Courses = c;
            Salary = salary;
        }
        public override bool add()
        {
            try
            {
                var ok = base.add();
                if (!ok)
                {
                    return false;
                }   

                Console.WriteLine("Email: ");
                Email = Console.ReadLine();
                if(Email == "InValid Email")
                {
                    Console.WriteLine("InValid Email");
                    return false;
                }

                Console.Write("Department: ");
                Depart = Console.ReadLine();

                Console.Write("Courses: ");
                for (int i = 0; i < 6; i++)
                {
                    var c = Console.ReadLine();
                    Courses.Add(c);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public override string print()
        {
            return base.print()+
                $"\nE-mail: {Email}\nDeprtment: {Depart}\nCourses Tought: {string.Join(", ", Courses)}";
        }

    }
}
