using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_info _instance = new Student_info();
            _instance.SetID("100");
            _instance.SetMarks("30");
            string idValue = _instance.GetId();

            System.Console.WriteLine(idValue);
        }
    }
}