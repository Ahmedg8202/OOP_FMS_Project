using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FMS
{
    internal class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<Worker> workerList = new List<Worker>();
        static List<Technical> technicalList = new List<Technical>();
        static List<Instructor> instructorList = new List<Instructor>();
        static List<Administraitor> administraitorList = new List<Administraitor>();
        static void Main(string[] args)
        {
            while (true)
            {
                welcomeHeader();
                header();
                try
                {
                    byte option = byte.Parse(Console.ReadLine());
                    Console.WriteLine();
                    byte oldOption = option;
                    if (option == 1)//student section
                    {
                        while (true)
                        {
                            studentHeader();
                            option = byte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (option == 1)//add
                            {
                                add(oldOption);
                            }
                            else if (option == 2)//remove
                            {
                                Console.Write("Enter student ID: ");
                                int id = int.Parse(Console.ReadLine());
                                removeById(id,oldOption);
                            }
                            else if (option == 3)//edit
                            {
                                Console.Write("Enter student ID: ");
                                int id = int.Parse(Console.ReadLine());
                                editById(id, oldOption);
                            }
                            else if (option == 4)//showInfo
                            {
                                Console.Write("Enter student ID: ");
                                int id = int.Parse(Console.ReadLine());
                                showInfo(id, oldOption);
                            }
                            else if (option == 5)//showAll
                            {
                                showAll(oldOption);
                            }
                            else if(option == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("InValid Input");
                            }
                        }
                    }
                    else if (option == 2)//Worker section
                    {
                        while (option != 0)
                        {
                            workerHeader();
                            option = byte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (option == 1)//add
                            {
                                add(oldOption);
                            }
                            else if (option == 2)//remove
                            {
                                Console.Write("Enter Worker ID: ");
                                int id = int.Parse(Console.ReadLine());
                                removeById(id, oldOption);
                            }
                            else if (option == 3)//edit
                            {
                                Console.Write("Enter Worker ID: ");
                                int id = int.Parse(Console.ReadLine());
                                editById(id, oldOption);
                            }
                            else if (option == 4)//showInfo
                            {
                                Console.Write("Enter Worker ID: ");
                                int id = int.Parse(Console.ReadLine());
                                showInfo(id, oldOption);
                            }
                            else if (option == 5)//showAll
                            {
                                showAll(oldOption);
                            }
                            else if (option == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("InValid Input");
                            }
                        }
                    }
                    else if(option == 3)//Technical section
                    {
                        while (true)
                        {
                            techincalHeader();
                            option = byte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (option == 1)//add
                            {
                                add(oldOption);
                            }
                            else if (option == 2)//remove
                            {
                                Console.Write("Enter techincal ID: ");
                                int id = int.Parse(Console.ReadLine());
                                removeById(id, oldOption);
                            }
                            else if (option == 3)//edit
                            {
                                Console.Write("Enter techincal ID: ");
                                int id = int.Parse(Console.ReadLine());
                                editById(id, oldOption);
                            }
                            else if (option == 4)//showInfo
                            {
                                Console.Write("Enter techincal ID: ");
                                int id = int.Parse(Console.ReadLine());
                                showInfo(id, oldOption);
                            }
                            else if (option == 5)//showAll
                            {
                                showAll(oldOption);
                            }
                            else if (option == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("InValid Input");
                            }
                        }
                    }
                    else if(option == 4)//Instructor section
                    {
                        while (true)
                        {
                            instructorHeader();
                            option = byte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (option == 1)//add
                            {
                                add(oldOption);
                            }
                            else if (option == 2)//remove
                            {
                                Console.Write("Enter instructor ID: ");
                                int id = int.Parse(Console.ReadLine());
                                removeById(id, oldOption);
                            }
                            else if (option == 3)//edit
                            {
                                Console.Write("Enter instructor ID: ");
                                int id = int.Parse(Console.ReadLine());
                                editById(id, oldOption);
                            }
                            else if (option == 4)//showInfo
                            {
                                Console.Write("Enter instructor ID: ");
                                int id = int.Parse(Console.ReadLine());
                                showInfo(id, oldOption);
                            }
                            else if (option == 5)//showAll
                            {
                                showAll(oldOption);
                            }
                            else if (option == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("InValid Input");
                            }
                        }
                    }
                    else if (option == 5)//Administraitor section
                    {
                        while (true)
                        {
                            administraitorHeader();
                            option = byte.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (option == 1)//add
                            {
                                add(oldOption);
                            }
                            else if (option == 2)//remove
                            {
                                Console.Write("Enter administraitor ID: ");
                                int id = int.Parse(Console.ReadLine());
                                removeById(id, oldOption);
                            }
                            else if (option == 3)//edit
                            {
                                Console.Write("Enter administraitor ID: ");
                                int id = int.Parse(Console.ReadLine());
                                editById(id, oldOption);
                            }
                            else if (option == 4)//showInfo
                            {
                                Console.Write("Enter administraitor ID: ");
                                int id = int.Parse(Console.ReadLine());
                                showInfo(id, oldOption);
                            }
                            else if (option == 5)//showAll
                            {
                                showAll(oldOption);
                            }
                            else if (option == 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("InValid Input");
                            }
                        }
                    }
                    else if( option == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("InValid input");
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            Console.ReadLine();
        }
        static void welcomeHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("\tFCI Mangement System");
            Console.WriteLine("=========================================");
        }
        static void header()
        {
            Console.WriteLine("For students press -> 1\n" +
                "For Workers press -> 2\n" + "For Technicals press -> 3\n" +
                "For Instructors press -> 4\n" + "For Adminstraitors press -> 5"
                + "\nTo exit press -> 0");
            Console.Write("Enter your option: ");
        }
        static void studentHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Students Section");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("To add a new student press -> 1\n" +
                "To remove student press -> 2\n" + "To edit student info press -> 3\n" +
                "To see student info press -> 4\n" + "To see all students press -> 5\n"+
                "To go back -> 0");
            Console.Write("Enter your Option: ");
        }
        static void workerHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Workers Section");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("To add a new worker press -> 1\n" +
                "To remove worker press -> 2\n" + "To edit worker info press -> 3\n" +
                "To see worker info press -> 4\n" + "To see all workers press -> 5\n" +
                "To go back -> 0");
            Console.Write("Enter your Option: ");
        }
        static void techincalHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Techincals Section");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("To add a new techincal press -> 1\n" +
                "To remove techincal press -> 2\n" + "To edit techincal info press -> 3\n" +
                "To see techincal info press -> 4\n" + "To see all techincals press -> 5\n" +
                "To go back -> 0");
            Console.Write("Enter your Option: ");
        }
        static void instructorHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Instructors Section");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("To add a new instructor press -> 1\n" +
                "To remove worker press -> 2\n" + "To edit instructor info press -> 3\n" +
                "To see instructor info press -> 4\n" + "To see all instructors press -> 5\n" +
                "To go back -> 0");
            Console.Write("Enter your Option: ");
        }
        static void administraitorHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Administraitors Section");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("To add a new administraitor press -> 1\n" +
                "To remove administraitor press -> 2\n" + "To edit administraitor info press -> 3\n" +
                "To see administraitor info press -> 4\n" + "To see all administraitors press -> 5\n" +
                "To go back -> 0");
            Console.Write("Enter your Option: ");
        }
        static void add(byte option)
        {
            if (option == 1)//student section
            {
                Student s = new Student();
                var check = s.add();
                if (check)
                {
                    studentList.Add(s);
                    Console.WriteLine("Student is added successfully");
                }
                else
                    Console.WriteLine("Failed.");
            }
            else if (option == 2)//Worker section
            {
                Worker w = new Worker();
                var check = w.add();
                if (check)
                {
                    workerList.Add(w);
                    Console.WriteLine("Worker is added successfully");
                }
                else
                    Console.WriteLine("Failed.");
            }
            else if (option == 3)//Technical section
            {
                Technical t = new Technical();
                var check = t.add();
                if (check)
                {
                    technicalList.Add(t);
                    Console.WriteLine("Technical is added successfully");
                }
                else
                    Console.WriteLine("Failed.");
            }
            else if (option == 4)//Instructor section
            {
                Instructor i = new Instructor();
                var check = i.add();
                if (check)
                {
                    instructorList.Add(i);
                    Console.WriteLine("Instructor is added successfully");
                }
                else
                    Console.WriteLine("Failed.");
            }
            else if (option == 5)//Administraitor section
            {
                Administraitor a = new Administraitor();
                var check = a.add();
                if (check)
                {
                    administraitorList.Add(a);
                    Console.WriteLine("Administraitor is added successfully");
                }
                else
                    Console.WriteLine("Failed.");
            }
        }
        static void removeById(int id, byte option)
        {
            bool ok = false;
            try
            {
                if (option == 1)//student section
                {
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        if (studentList[i].Id == id)
                        {
                            studentList.RemoveAt(i);
                            ok = true;
                            Console.WriteLine("Student removed sucessfully");
                            break;
                        }
                    }
                }
                else if (option == 2)//Worker section
                {
                    for (int i = 0; i < workerList.Count; i++)
                    {
                        if (workerList[i].Id == id)
                        {
                            workerList.RemoveAt(i);
                            ok = true;
                            Console.WriteLine("Worker removed sucessfully");
                            break;
                        }
                    }
                }
                else if (option == 3)//Technical section
                {
                    for (int i = 0; i < technicalList.Count; i++)
                    {
                        if (technicalList[i].Id == id)
                        {
                            technicalList.RemoveAt(i);
                            ok = true;
                            Console.WriteLine("Technical removed sucessfully");
                            break;
                        }
                    }
                }
                else if (option == 4)//Instructor section
                {
                    for (int i = 0; i < instructorList.Count; i++)
                    {
                        if (instructorList[i].Id == id)
                        {
                            instructorList.RemoveAt(i);
                            ok = true;
                            Console.WriteLine("Instructor removed sucessfully");
                            break;
                        }
                    }
                }
                else if (option == 5)//Administraitor section
                {
                    for (int i = 0; i < administraitorList.Count; i++)
                    {
                        if (administraitorList[i].Id == id)
                        {
                            administraitorList.RemoveAt(i);
                            ok = true;
                            Console.WriteLine("Administraitor removed sucessfully");
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (!ok)
            {
                Console.WriteLine("Not exist");
            }
        }
        static void showInfo(int id, byte option)
        {
            bool ok = false;
            if (option == 1)//student section
            {
                foreach (var student in studentList)
                {
                    if (student.Id == id)
                    {
                        Console.WriteLine(student.print());
                        ok = true;
                        break;
                    }
                }
            }
            else if (option == 2)//Worker section
            {
                foreach (var worker in workerList)
                {
                    if (worker.Id == id)
                    {
                        Console.WriteLine(worker.print());
                        ok = true;
                        break;
                    }
                }
            }
            else if (option == 3)//Technical section
            {
                foreach (var technical in technicalList)
                {
                    if (technical.Id == id)
                    {
                        Console.WriteLine(technical.print());
                        ok = true;
                        break;
                    }
                }
            }
            else if (option == 4)//Instructor section
            {
                foreach (var instructor in instructorList)
                {
                    if (instructor.Id == id)
                    {
                        Console.WriteLine(instructor.print());
                        ok = true;
                        break;
                    }
                }
            }
            else if (option == 5)//Administraitor section
            {
                foreach (var dministraitor in administraitorList)
                {
                    if (dministraitor.Id == id)
                    {
                        Console.WriteLine(dministraitor.print());
                        ok = true;
                        break;
                    }
                }
            }
            if (!ok)
            {
                Console.WriteLine("Not exist");
            }
        }
        static void showAll(byte option)
        {
            if (option == 1)//student section
            {
                if (studentList.Count == 0)
                {
                    Console.WriteLine("There are not student");
                }
                else
                {
                    Console.WriteLine($"There is {studentList.Count()} student:");
                    string studentListString = string.Join("\n~~~~~~~~~~~~~~~~~~~~~~\n", studentList.Select(student => student.print()));
                    Console.WriteLine(studentListString);
                }
            }
            else if (option == 2)//Worker section
            {
                if (workerList.Count == 0)
                {
                    Console.WriteLine("There are not Worker");
                }
                else
                {
                    Console.WriteLine($"There is {workerList.Count()} student:");
                    string workerListString = string.Join("\n~~~~~~~~~~~~~~~~~~~~~~\n", workerList.Select(worker => worker.print()));
                    Console.WriteLine(workerListString);
                }
            }
            else if (option == 3)//Technical section
            {
                if (technicalList.Count == 0)
                {
                    Console.WriteLine("There are not Technical");
                }
                else
                {
                    Console.WriteLine($"There is {technicalList.Count()} student:");
                    string technicalListString = string.Join("\n~~~~~~~~~~~~~~~~~~~~~~\n", technicalList.Select(technical => technical.print()));
                    Console.WriteLine(technicalListString);
                }
            }
            else if (option == 4)//Instructor section
            {
                if (instructorList.Count == 0)
                {
                    Console.WriteLine("There are not Instructor");
                }
                else
                {
                    Console.WriteLine($"There is {instructorList.Count()} student:");
                    string instructorListString = string.Join("\n~~~~~~~~~~~~~~~~~~~~~~\n", instructorList.Select(instructor => instructor.print()));
                    Console.WriteLine(instructorListString);
                }
            }
            else if (option == 5)//Administraitor section
            {
                if (administraitorList.Count == 0)
                {
                    Console.WriteLine("There are not Administraitor");
                }
                else
                {
                    Console.WriteLine($"There is {administraitorList.Count()} student:");
                    string administraitorListString = string.Join("\n~~~~~~~~~~~~~~~~~~~~~~\n", administraitorList.Select(administraitor => administraitor.print()));
                    Console.WriteLine(administraitorListString);
                }
            }
        }
        static void editById(int id, byte option)
        {
            bool ok = false;
            try 
            {

                if (option == 1)//student section
                {
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        if (studentList[i].Id == id)
                        {
                            studentList[i].edit();
                            ok = true;
                            break;
                        }
                    }
                }
                else if (option == 2)//Worker section
                {
                    for (int i = 0; i < workerList.Count; i++)
                    {
                        if (workerList[i].Id == id)
                        {
                            workerList[i].edit();
                            ok = true;
                            break;
                        }
                    }
                }
                else if (option == 3)//Technical section
                {
                    for (int i = 0; i < technicalList.Count; i++)
                    {
                        if (technicalList[i].Id == id)
                        {
                            technicalList[i].edit();
                            ok = true;
                            break;
                        }
                    }
                }
                else if (option == 4)//Instructor section
                {
                    for (int i = 0; i < instructorList.Count; i++)
                    {
                        if (instructorList[i].Id == id)
                        {
                            instructorList[i].edit();
                            ok = true;
                            break;
                        }
                    }
                }
                else if (option == 5)//Administraitor section
                {
                    for (int i = 0; i < administraitorList.Count; i++)
                    {
                        if (administraitorList[i].Id == id)
                        {
                            administraitorList[i].edit();
                            ok = true;
                            break;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (!ok)
            {
                Console.WriteLine("Not exist");
            }
        }
    }

}
