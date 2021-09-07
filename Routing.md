# Asp.net Routing 
- In MVC, routing is a process of mapping the browser request to the controller action and return response back.
- Each MVC application has default routing for the default HomeController. We can set custom routing for newly created controller.<br>
Syntax:-<br>
- RouteConfig.cs<br>
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
using System.Web.Mvc;  
using System.Web.Routing;  
namespace MvcApplicationDemo  
{  
public class RouteConfig  
    {  
public static void RegisterRoutes(RouteCollection routes)  
        {  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  
            routes.MapRoute(  
                name: "Default",  
                url: "{controller}/{action}/{id}",  
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
            );  
        }  
    }  
}  
- StudentsControllers.cs<br>
using System.Web.Mvc;  
namespace MvcApplicationDemo.Controllers  
{  
public class StudentsController : Controller  
    {  
public ContentResult Index()  
        {  
return Content("This is default student page");  
        }  
    }  
}  
- Altered RouteConfig.cs file<br>
public static void RegisterRoutes(RouteCollection routes)  
        {  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  
            routes.MapRoute(  
                name: "Students",  
                url: "{controller}/{action}/{id}",  
                defaults: new { controller = "Students", action = "Index", id = UrlParameter.Optional }  
            );  
