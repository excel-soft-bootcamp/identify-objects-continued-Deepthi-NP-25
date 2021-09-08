# Route Defaults
- When we define a route, we can assign a default value for a parameter. The defaults is an object that contains default route values. The three segments of a default route contain the Controller, Action and Id.<br>
Syntax:-<br>
name: "Default", url: "{controller}/{action}/{id}", <br>
defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }<br>
https://localhost:44368/home/Index  <br>
- In the above URL, the corresponding controller and action will be matched <br>

# Route Constraints
- We apply a set of constraints against the URL pattern to more narrowly define the URL that it matches.<br>
Syntax:-<br>
defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },<br>
          new { id = @"\d+"} <br>
 https://localhost:44368/Home/Index/100 <br>
- We have specified a pattern for the “id” entry, the pattern will only allow an integer parameter, not a string or other data type.
          

