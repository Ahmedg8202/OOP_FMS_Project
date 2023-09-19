using System;
using System.Collections.Generic;

namespace FMS
{
    abstract public class Staff: Person
    {
        private double salary;
        protected double Salary { 
            get 
            {
                return salary;
            } 
            set 
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }
            } 

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

                Console.Write("Salary: ");
                Salary=double.Parse(Console.ReadLine());
                if(Salary == 0)
                {
                    Console.WriteLine("Invalid Salary");
                    return false;
                }
                return true;
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public override string print()
        {
            return base.print() +
                $"\nSalary: ${Math.Round(Salary, 2):N2}";
        }
    }
}
