# ViewData vs ViewBag

|ViewData|ViewBag|
|--------|-------|
|ViewData transfers data from Controller to View|ViewBag in ASP.NET MVC is used to transfer temporary data(which is not included in the model)from the controller to the view page|
|It is a dictionary of objects and derived from ViewDataDictionary class|It is a dynamic property which is similar to ViewData|
|We can access value by using string as a key|ViewBag can get and set value dynamically that's why it is called dynamic property|
|It is type-safe and requires typecasting for data type|It does not require type conversion and convert type dynamically|

Syntax:-<br>
# Viewdata<br>
public ActionResult Index()  
        {  
            List<string> Courses = new List<string>();  
            Courses.Add("J2SE");  
            Courses.Add("J2EE");  
            Courses.Add("Spring");  
            Courses.Add("Hibernates");  
            ViewData["Courses"] = Courses;  
            return View();  
        }<br>
  
  # ViewBag<br>
  public ActionResult Index()  
        {  
            List<string> Courses = new List<string>();  
            Courses.Add("J2SE");  
            Courses.Add("J2EE");  
            Courses.Add("Spring");  
            Courses.Add("Hibernates");  
            ViewBag.Courses = Courses;  
            return View();  
        }
