using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Group
    {
        private string name;
        private List<Student> students;
        public Group(string name)
        {
            this.name = name;
            students = new List<Student>();
        }
        public void AddStudent(Student st)
        {
            students.Add(st);   
        }
        public string GetName() { return name; }
        public string GetInfo()
        {
            string result=name+" ";
            foreach(Student st in students)
            {
                result += st.getName();
            }
            return result;
        }
        public string GetFullInfo()
        {
            string result = name+" ";
            foreach (Student st in students)
            {
                result += st.getName() + st.getState();
                
            }
            return result;
        }
    }
}
