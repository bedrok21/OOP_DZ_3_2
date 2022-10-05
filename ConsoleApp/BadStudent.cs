using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state += "bad";
        }
        public override void Study()
        {
            Relax(); Relax(); Relax(); Relax(); Read();
        }
    }
}
