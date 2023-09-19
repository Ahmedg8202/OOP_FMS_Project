using System;

namespace FMS
{
    public class Administraitor: Staff
    {
        private string email;
        public string Email
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
        protected string Resposibility { get; set; }
        public Administraitor()
        {
            
        }
        public Administraitor(int id,string fname, string lname, int age, string national, string phone,
            string address, string dep, string email, double salary, string resposibility)
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
            Salary = salary;
            Resposibility = resposibility;
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
                if (Email == "InValid Email")
                {
                    Console.WriteLine("InValid Email");
                    return false;
                }

                Console.Write("Department: ");
                Depart = Console.ReadLine();

                Console.WriteLine("Responsibility: ");
                Resposibility = Console.ReadLine();

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
            return base.print() +
                $"\nE-mail: {Email}\nDeprtment: {Depart}\nPosition: {Resposibility}";
        }
    }
}
