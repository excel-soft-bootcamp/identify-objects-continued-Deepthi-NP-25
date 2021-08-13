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
        public void Setname(string value)
        {
            this.name = value;
        }
        public void SetID(string value) { this.id = value; }
        public void SetMarks(string value) { this.marks = value; }
    }
}
