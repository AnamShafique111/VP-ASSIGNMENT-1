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
                Console.WriteLine("\n\nStudent {0}:", i + 1);
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
                SW.WriteLine(" ");
            }
            SW.Flush();
            SW.Close();
        }

        public static void search(Student prof)
        {
            Console.WriteLine("\tPress 1 to Search by Id\n\tPress 2 to Search by Name\n\tPress 3 to see List of all students\n");
            int choice1;
            choice1 = Convert.ToInt32(Console.ReadLine());
            //To Search Student By Id
            if (choice1 == 1)
            {
                string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
                string std_Id;
                Console.WriteLine("Enter Student id:");
                std_Id = Console.ReadLine();
                bool condition = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(std_Id) == true)
                    {
                        Console.WriteLine(words[i] + " ");
                        condition = true;
                        break;
                    }
                    else
                    {
                        condition = false;
                        break;
                    }
                }
            }
            //To Search Student By Name
            if (choice1 == 2)
            {
                string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
                string std_Name;
                Console.WriteLine("Enter Student Name:");
                std_Name = Console.ReadLine();
                bool condition = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(std_Name) == true)
                    {
                        Console.WriteLine(words[i] + " ");
                        condition = true;
                        break;
                    }
                    else
                    {
                        condition = false;
                        break;
                    }
                }
            }
            //To See List of All Students
            if (choice1 == 3)
            {
                string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
                foreach (string word in words)
                    Console.WriteLine(word);
            }
        }
        public static void delete(Student prof)
        {
            //string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
            //string std_Id;
            //string toDelete;
            //bool condition = false;
            //Console.WriteLine("Enter Student Id:");
            //std_Id = Console.ReadLine();
            //Console.WriteLine("Enter number of lines you want to Delete:");
            //toDelete= Console.ReadLine();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Contains(std_Id) == true)
            //    {
            //        Console.WriteLine(std_Id.Remove(toDelete) == true);
            //        break;
            //    }
                //    string[] lines;
                //    List<string> lineslist= File.ReadAllLines(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt");
                //    string std_Id;
                //    Console.WriteLine("Enter Student id:");
                //    std_Id = Console.ReadLine();
                //    for (int i = 0; i < lineslist.Count-1; i++)
                //    {
                //        if (lineslist[i] == std_Id)
                //        {
                //            lineslist.RemoveAt(0);
                //        }
                //    }
                //    File.WriteAllLines(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt", lineslist.ToArray());
            }
        public static void markAttendance(Student prof)
        {
            string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\Student.txt").Split(' ');
            foreach (string word in words)
            Console.WriteLine(word);
            Console.WriteLine("Enter Number of Students to Mark Attendance:");
            prof.n = Convert.ToInt32(Console.ReadLine());
            StreamWriter SW = new StreamWriter(@"C:\\Users\\Anam Shafique\\Desktop\\PresentStudent.txt");
            for (int i = 0; i < prof.n; i++)
            {
                //Console.WriteLine("Attendan:");
                SW.WriteLine("Attendance:");
                Console.WriteLine("Present Student ID:");
                prof.stdId = Console.ReadLine();
                Console.WriteLine("Present Student Name:");
                prof.stdName= Console.ReadLine();
                SW.WriteLine("Present Students:");
                SW.WriteLine(prof.stdId);
                SW.WriteLine(prof.stdName);
                SW.WriteLine(" ");
                Console.WriteLine("Absent Student ID:");
                prof.stdId = Console.ReadLine();
                Console.WriteLine("Absent Student Name:");
                prof.stdName = Console.ReadLine();
                SW.WriteLine("Absent Students:");
                SW.WriteLine(prof.stdId);
                SW.WriteLine(prof.stdName);
                SW.WriteLine(" ");
            }
            SW.Flush();
            SW.Close();
        }
        public static void viewAttendance(Student prof)
        {
            string[] words = File.ReadAllText(@"C:\\Users\\Anam Shafique\\Desktop\\PresentStudent.txt").Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\tPress 1 to Create Student Profile\n\tPress 2 to Search Student\n\tPress 3 to Delete Student Record\n\tPress 4 to list top 03 of Class\n\tPress 5 to Mark Student Attendance\n\tPress 6 to View Attendance\n");
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
            //To Delete Student
            else if (choice == 3)
            {
                Student prof1 = new Student();
                delete(prof1);
            }
            else if (choice == 4)
            {
              
            }
            else if (choice == 5)
            {
                Student prof1 = new Student();
                markAttendance(prof1);
            }
            else if (choice == 6)
            {
                Student prof1 = new Student();
                viewAttendance(prof1);
            }
            Console.Read();
        }
    }
}







       