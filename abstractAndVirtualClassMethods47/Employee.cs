using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAndVirtualClassMethods47
{
    class Employee<T> : Person
    {
        public List<T> Things { get; set; }
        public override void SayName()
        {
            base.SayName();
        }

        public static bool operator ==(Employee<T> person, TeamRole role)
        {
            return person.Id == role.Id;
        }

        public static bool operator !=(Employee<T> person, TeamRole role)
        {
            return !(person.Id == role.Id);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
