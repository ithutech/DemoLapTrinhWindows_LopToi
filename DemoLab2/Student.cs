using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab2
{
    class Student : Person
    {
        public int Id { get; set; }
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
        public override void Input()
        {
            Console.Write("Student Id = ");
            this.Id = int.Parse(Console.ReadLine());
            Console.Write("Student Name = ");
            this.FullName = Console.ReadLine();
            Console.Write("Student Faculty = ");
            this.Faculty = Console.ReadLine();
            Console.Write("Student GPA = ");
            this.GPA = float.Parse(Console.ReadLine());
        }
        //output
        public override void Output()
        {
            Console.WriteLine("Student ID = {0}", this.Id);
            Console.WriteLine("Student Name = {0}", this.FullName);
            Console.WriteLine("Student Faculty = {0}", this.Faculty);
            Console.WriteLine("Student GPA = {0}", this.GPA);
        }
    }
}
