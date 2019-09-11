using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab2
{
    abstract class Person
    {
        public string FullName { get; set; }
        public abstract void Input();
        public abstract void Output();
    }
}
