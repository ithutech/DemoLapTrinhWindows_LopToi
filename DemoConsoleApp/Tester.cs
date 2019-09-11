using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number of Student:");
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            Student student;
            //Input students
            for (int i = 0; i < n; i++)
            {
                student = new Student();
                Console.WriteLine("--- Input Student {0} --- ", i + 1);
                student.Input();
                students.Add(student);
            }
            //Output students
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Student {0}", i + 1);
            //    students[i].Output();
            //}
            ////Output student of CNTT's Faclty
            //Console.WriteLine("Student of CNTT's Faclty");
            //foreach (var item in students)
            //{
            //    if (item.Faculty == "CNTT")
            //    {
            //        item.Output();
            //    }
            //}
            ////Output student with GPA Accending
            //Console.WriteLine("Output student with GPA Accending");
            //students.Sort();
            //foreach (var item in students)
            //{
            //    item.Output();
            //}

            Console.WriteLine("Max Student's GPA");

            float maxGPA = students.Max(p => p.GPA);
            List<Student> listMaxGPA = students.Where(p => p.GPA == maxGPA).ToList();
            Console.WriteLine("Max GPA = {0}", maxGPA);
            //Stop to view result
            Console.ReadLine();
        }
    }
}
