using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAndVirtualClassMethods47
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit(string quit)
        {
            Console.WriteLine(quit);
        }
    }
}
