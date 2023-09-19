
using System;

namespace FMS
{
    public class Technical: Staff
    {
        protected int FloorNumber { get; set; }
        protected int NoLabs { get; set; }
        public Technical()
        {
            
        }
        public Technical(int id,string fname, string lname, int age, string national,
            string phone, string address, double salary, int floor, int labs)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
            NationalNumber = national;
            Phone = phone;
            Address = address;
            Salary = salary;
            FloorNumber = floor;
            NoLabs = labs;
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

                Console.WriteLine("Floor number: ");
                FloorNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Number of Labs: ");
                NoLabs = int.Parse(Console.ReadLine());

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
                $"\nFloor number: {FloorNumber}\nnumber of Labs: {NoLabs}";
        }
    }
}
