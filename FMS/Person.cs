using System;

namespace FMS
{
    /*interface IloopHelper{
        void loopOverCourses(string[] s)
        {
            for(int i=0; i<s.Length; i++)
            {
                Console.Write(s[i]+" ");
            }
        }
    }
    default implementation not aviliable with this version*/
    public interface IRole
    {
        int Id { get; }
    }

    abstract public class Person
    {
        private string phone,
                       national;
        private int age;

        public int Id { get; set; }
        protected string Fname { get; set; }
        protected string Lname { get; set; }
        protected string NationalNumber
        {
            get
            {
                return national;
            }
            set
            {
                if(value.Length==14&&long.TryParse(value,out long x))
                {
                    national = value;
                }
                else
                {
                    national = "InValid National number";
                }
            }
        }
        protected int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 17 && value <= 70)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if(value.Length ==13 && value.StartsWith("+201"))
                {
                    bool ok = true;
                    for(int i=4; i < value.Length; i++)
                    {
                        if (value[i] < '0' || value[i] > '9')
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        phone = value;
                    }
                    else
                    {
                        phone = "InValid phone number";
                    }
                }
                else
                {
                    phone = "InValid phone number";
                }
            }
        }
        public string Address { get; set; }
        public virtual bool add()
        {
            try
            {

                Console.Write("ID: ");
                Id = int.Parse(Console.ReadLine());

                Console.Write("First name: ");
                Fname = Console.ReadLine();

                Console.Write("Last name: ");
                Lname = Console.ReadLine();

                Console.Write("Age: ");
                Age = int.Parse(Console.ReadLine());
                if(Age == 0)
                {
                    Console.WriteLine("Age must be from 17 to 70");
                    return false;
                }

                Console.Write("Phone: ");
                Phone = Console.ReadLine();
                if(Phone == "InValid phone number")
                {
                    Console.WriteLine("InValid phone number. It must be like +201000000000");
                    return false;
                }

                Console.Write("National ID: ");
                NationalNumber = Console.ReadLine();
                if (NationalNumber == "InValid National number")
                {
                    Console.WriteLine("InValid National number. It must be exactly 14 number");
                    return false;
                }

                Console.Write("Address: ");
                Address = Console.ReadLine();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void edit()
        {
            try
            {
                Console.WriteLine("You can only edit address and phone\n"+
                    "To edit your phone press -> 1\nTo edit your address press -> 2\n" +
                    "To exit press 0");
                if(byte.TryParse(Console.ReadLine(),out byte number))
                {
                    if(number == 1)
                    {
                        Console.Write("Enter the new phone: ");
                        string oldPhone = Phone;
                        Phone = Console.ReadLine();
                        if(Phone == "InValid phone number")
                        {
                            Console.WriteLine("InValid phone number");
                            Phone = oldPhone;
                            edit();
                        }
                        else
                        {
                            Console.WriteLine("Sucess!");
                            edit();
                        }
                    }
                    else if(number == 2)
                    {
                        Console.Write("Enter the new address: ");
                        Address = Console.ReadLine();
                        Console.WriteLine("Sucess!");
                        edit();
                    }
                    else if(number == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("InValid input");
                        edit();
                    }
                }
                else
                {
                    Console.WriteLine("InValid input");
                    edit();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public virtual string print()
        {
            return $"ID: {Id}\nName:{Fname} {Lname}\nAge: {Age} years old\nphone: {Phone}" +
                $"\nNational ID: {NationalNumber}\nAddress: {Address}";
        }
    }
}
