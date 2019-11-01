# VP-ASSIGNMENT-1
Repository No. 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp24
{
    class Student
    {
        public string stdId;
        public string stdName;
        public string stdSem;
        public string stdCgpa;
        public string stdDep;
        public string stdUni;
        public int n;
        public static void profile(Student prof)
        {
            //string stdId;
            //string stdName;
            //string stdSem;
            //string stdCgpa;
            //string stdDep;
            //string stdUni;
            //int n;
            Console.WriteLine("Enter Number of Students:");
            prof.n = Convert.ToInt32(Console.ReadLine());
            StreamWriter SW = new StreamWriter(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            for (int i = 0; i < prof.n; i++)
            {
                Console.WriteLine("Student {0}:", i + 1);
                Console.WriteLine("Enter Your id:");
                prof.stdId = Console.ReadLine();
                SW.WriteLine(prof.stdId);
                Console.WriteLine("Enter Your Name:");
                prof.stdName = Console.ReadLine();
                SW.WriteLine(prof.stdName);
                Console.WriteLine("Enter Your Semester:");
                prof.stdSem = Console.ReadLine();
                SW.WriteLine(prof.stdSem);
                Console.WriteLine("Enter Your CGPA:");
                prof.stdCgpa = Console.ReadLine();
                SW.WriteLine(prof.stdCgpa);
                Console.WriteLine("Enter Your Department:");
                prof.stdDep = Console.ReadLine();
                SW.WriteLine(prof.stdDep);
                Console.WriteLine("Enter Your University:");
                prof.stdUni = Console.ReadLine();
                SW.WriteLine(prof.stdUni);
            }
            SW.Flush();
            SW.Close();
        }

        public static void search(Student prof)
        {
            //StreamWriter SW = new StreamWriter(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
            string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split('');
            foreach (string line in lines)
            Console.WriteLine(line);
            Console.WriteLine("\tPress 1 to Search by Id\n\tPress 2 to Search by Name\n\tPress 3 to see List of all students\n");
            int choice1;
            choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Students:");
            prof.n = Convert.ToInt32(Console.ReadLine());
            if (choice1 == 1)
            {
                string std_Id;
                Console.WriteLine("Enter Student id:");
                std_Id = Console.ReadLine();
                bool condition = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(std_Id) == true)
                    {
                        Console.WriteLine(lines[i] + " ");
                        condition = true;
                        break;
                    }
                    else
                    {
                        condition = false;
                        break;
                    }
                }
                //foreach (string line in lines)
                //StreamReader SW = new StreamReader(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
                //for (int i=0; i<prof.n; i++)
                //{
                //    if (condition == true /*&& std_Id == prof.stdId*/)
                //    {
                //        string[] lines1 = File.ReadAllLines(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
                //        foreach (string line in lines)
                //        Console.WriteLine(prof.stdName);
                //        Console.WriteLine("Semester:" + prof.stdSem);
                        //Console.WriteLine("Name:" + prof.stdName);
                        ////Console.WriteLine(lines[i+1]+/*"prof.stdName"*/);
                        //prof.stdSem = Console.ReadLine();
                        //Console.WriteLine("Semester:" + prof.stdSem);
                        ////Console.WriteLine(prof.stdSem);
                        //prof.stdCgpa = Console.ReadLine();
                        //Console.WriteLine("CGPA:" + prof.stdCgpa);
                        ////Console.WriteLine(prof.stdCgpa);
                        //prof.stdDep = Console.ReadLine();
                        //Console.WriteLine("Department:" + prof.stdDep);
                        ////Console.WriteLine(prof.stdDep);
                        //prof.stdUni = Console.ReadLine();
                        //Console.WriteLine("University:" + prof.stdUni);
                        ////Console.WriteLine(prof.stdUni);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\tPress 1 to Create Student Profile\n\tPress 2 to Search Student\n\tPress 3 toDelete Student Record\n\tPress 4 to list top 03 of Class\n\tPress 5 to Mark Student Attendance\n\tPress 6 to View Attendance\n");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            //To Create Student Profile
            if (choice == 1)
            {
                Student prof1 = new Student();
                profile(prof1);
            }
            //To Search Student
            else if (choice == 2)
            {
                Student prof1 = new Student();
                search(prof1);
            }
            Console.Read();
        }
    }
}




       
