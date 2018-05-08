using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAndVirtualClassMethods47
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //employee.SayName();

            //// INTERFACES //
            //IQuittable quitting = new Employee();
            //string quit = "Now quitting program....";
            //quitting.Quit(quit);
            //Console.ReadLine();

            //// OPERATOR OVERLOADING //
            //Person person = new Employee<Person>();
            //person.Id = 123;
            //TeamRole role = new TeamRole();
            //role.Id = 1234;

            //bool equalIds = person.Id == role.Id;
            //Console.WriteLine(equalIds);
            //Console.ReadLine();

            // GENERICS //
            Employee<string> stringThings = new Employee<string>();
            stringThings.Things.Add("thing1");
            stringThings.Things.Add("thing2");

            Employee<int> intThings = new Employee<int>();
            intThings.Things.Add(1);
            intThings.Things.Add(2);
        }
    }
}
