using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab2
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number of Person:");
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            Person person;
            //Input students or teacher
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1: Input Student; 2: Input Teacher");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        person = new Student();
                        person.Input();
                        persons.Add(person);
                        break;
                    case 2:
                        person = new Teacher();
                        person.Input();
                        persons.Add(person);
                        break;
                    default:
                        break;
                }
                
            }
            //Output students or teacher
            foreach (var item in persons)
            {
                item.Output();
            }
            //Search by Name
            Console.WriteLine("Input Search Name = ");
            string searchName = Console.ReadLine();
            foreach (var item in persons)
            {
                if(string.Compare(searchName, item.FullName) == 0)
                {
                    item.Output();
                }
            }
            
            
            Console.ReadLine();
        }
    }
}
