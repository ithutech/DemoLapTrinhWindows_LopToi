using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    class Student : IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public float GPA { get; set; }
        public string Faculty { get; set; }

        public Student()
        {

        }
        public Student(int id, string fullName, float gpa, string faculty)
        {
            this.Id = id;
            this.FullName = fullName;
            this.GPA = gpa;
            this.Faculty = faculty;
        }
        //Input
        public void Input()
        {
            Console.Write("Student Id = ");
            this.Id = int.Parse(Console.ReadLine());
            Console.Write("Student Faculty = ");
            this.Faculty = Console.ReadLine();
            Console.Write("Student GPA = ");
            this.GPA = float.Parse(Console.ReadLine());
        }
        //output
        public void Output()
        {
            Console.WriteLine("ID = {0}", this.Id);
            Console.WriteLine("Faculty = {0}", this.Faculty);
            Console.WriteLine("GPA = {0}", this.GPA);
        }

        public int CompareTo(Object obj)
        {
            int iCompare = Convert.ToInt32(this.GPA - (obj as Student).GPA);
            return iCompare;
        }
    }
}
