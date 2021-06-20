using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    class Student_info
    {
        private string id;
        private string name;
        private string marks;
        public string GetId()
        {
            return this.id;
        }
        public string Getname()
        {
            return this.name;  
        }
        public string GetMarks()
        {
            return this.marks;
        }
        public void SetID(string value) { this.id = value; }
        public void SetMarks(string value) { this.marks = value; }
    }
}
namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_info _instance = new Student_info();
            _instance.SetID("100");
            _instance.SetMarks("30");
        }
    }
}
