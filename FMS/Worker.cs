using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace FMS
{
    public class Worker : Staff
    {
        protected string Resposibility { get; set; }
        public Worker()
        {
            
        }
        public Worker(int id, string fname, string lname, int age, string national, string phone
            , string address, string res, double salary) {
            Id =id;
            Fname = fname;
            Lname = lname;
            Age = age;
            NationalNumber = national;
            Phone = phone;
            Address = address;
            Salary = salary;
            Resposibility = res;
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

                Console.WriteLine("Responsibility: ");
                Resposibility = Console.ReadLine();

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
            return base.print() +
                $"\nRole: {Resposibility}";
        }
    }
}
