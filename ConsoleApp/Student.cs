using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract internal class Student
    {
        protected string name, state;
        public Student(string name)
        {
            this.name = name;
            state = "";
        }
        public void Relax() => state += "Relax";
        public void Read() => state += "Read";
        public void Write() => state += "Write";
        public string getName() => name;
        public string getState() => state;
        abstract public void Study();
    }
}
