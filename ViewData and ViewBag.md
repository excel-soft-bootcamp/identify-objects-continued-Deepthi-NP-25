# ViewData vs ViewBag

|ViewData|ViewBag|
|--------|-------|
|ViewData transfers data from Controller to View|ViewBag in ASP.NET MVC is used to transfer temporary data(which is not included in the model)from the controller to the view|
|ViewData is a dictionary, so it contains key-value pairs where each key must be a string|It is a dynamic type property of the ControllerBase class which is the base class of the Controller class|
|It transfers data from the Controller to View, not vice-versa|We can assign any number of properties and values to ViewBag|
|ViewData's life only lasts during the current HTTP request, ViewData values will be cleared if redirection occurs|If we assign the same property name multiple times to ViewBag, then it will only consider last value assigned to the property|

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
