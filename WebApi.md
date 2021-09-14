# WEB API in asp.net mvc
- API stands for the Application Programming Interface.
- ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browsers and mobile devices.
- ASP.NET Web API is an ideal platform for building RESTful applications on the .NET Framework.
- When we are building APIs on the Web, there are several ways we can build APIs on the Web.
- One of them is HTTP/RPC, and what this means is using HTTP in Remote Procedure Call to call into things, like Methods, across the Web.
- The verbs themselves are included in the APIs, like Get Customers, Insert Invoice, Delete Customer, and that each of these endpoints end up being a separate URI.

Syntax:-<br>
using System;<br>
using System.Collections.Generic;<br>
using System.Linq;<br>
using System.Web;<br>

namespace WebAPIDemo.Models {<br>
   public class Employee{<br>
      public int ID { get; set; }<br>
      public string Name { get; set; }<br>
      public DateTime JoiningDate { get; set; }<br>
      public int Age { get; set; }<br>
   }<br>
}

Syntax:-<br>
using System;<br>
using System.Collections.Generic;<br>
using System.Linq;<br>

using System.Web.Http;<br>
using WebAPIDemo.Models;<br>

namespace WebAPIDemo.Controllers{<br>
   public class EmployeesController : ApiController{<br>
      Employee[] employees = new Employee[]{<br>
         new Employee { ID = 1, Name = "Mark", JoiningDate =
            DateTime.Parse(DateTime.Today.ToString()), Age = 30 },<br>
         new Employee { ID = 2, Name = "Allan", JoiningDate =
            DateTime.Parse(DateTime.Today.ToString()), Age = 35 },<br>
         new Employee { ID = 3, Name = "Johny", JoiningDate =
            DateTime.Parse(DateTime.Today.ToString()), Age = 21 }<br>
      };<br>
		
      public IEnumerable<Employee> GetAllEmployees(){
         return employees;
      }<br>
		
      public IHttpActionResult GetEmployee(int id){
         var employee = employees.FirstOrDefault((p) => p.ID == id);
         if (employee == null){
            return NotFound();
         }
         return Ok(employee);
      }
   }<br>
}
