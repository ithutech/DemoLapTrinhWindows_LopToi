using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab2
{
    class Person
    {
        public string FullName { get; set; }
        public virtual void Input()
        {
            Console.Write("Name = ");
            this.FullName = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine("Name = {0}", this.FullName);
        }
    }
}
