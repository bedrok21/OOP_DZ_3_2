using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            state += "good";
        }
        public override void Study()
        {
            Read(); Write(); Read(); Write(); Relax();
        }
    }
}
