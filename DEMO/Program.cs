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
            _instance.SetName("Tom");
            _instance.SetID("001");
            _instance.SetMarks("100");
            string idValue = _instance.GetId();
            string marksValue = _instance.GetMarks();
            string nameValue = _instance.GetName();

            System.Console.WriteLine(nameValue);
            System.Console.WriteLine(idValue);
            System.Console.WriteLine(marksValue);
           
        }
    }
}