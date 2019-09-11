using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab2
{
    class Teacher : Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Teacher()
        {
        }

        public override void Input()
        {
            Console.Write("Teacher Id = ");
            this.Id = int.Parse(Console.ReadLine());
            Console.Write("Teacher Name = ");
            this.FullName = Console.ReadLine();
            Console.Write("Teacher Address = ");
            this.Address = Console.ReadLine();
        }

        public override void Output()
        {
            Console.WriteLine("Teacher Id = {0}", this.Id);
            Console.WriteLine("Teacher Name = {0}", this.FullName);
            Console.WriteLine("Teacher Address = {0}", this.Address);
        }
    }
}
