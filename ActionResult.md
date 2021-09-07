# ActionResult in asp.net MVC
- ASP.NET MVC Action Methods are responsible to execute requests and generate responses to it. 
- By default, it generates a response in the form of ActionResult.
- Actions typically have a one-to-one mapping with user interactions.
- The one restriction on action method is that they have to be instance method, so they cannot be static methods.
- Also there is no return value restrictions. So you can return the string, integer, etc.
# Request Processing
- Actions are the ultimate request destination in an MVC application and it uses the controller base class. 
- When a URL arrives, like /Home/index, it is the UrlRoutingModule that inspects and understands that something configured within the routing table knows how to handle that URL.
- The UrlRoutingModule puts together the information we've configured in the routing table and hands over control to the MVC route handler.
- The MVC route handler passes the controller over to the MvcHandler which is an HTTP handler.
- MvcHandler uses a controller factory to instantiate the controller and it knows what controller to instantiate because it looks in the RouteData for that controller value.
- Once the MvcHandler has a controller, the only thing that MvcHandler knows about is IController Interface, so it simply tells the controller to execute.
- When it tells the controller to execute, that's been derived from the MVC's controller base class. The Execute method creates an action invoker and tells that action invoker to go and find a method to invoke, find an action to invoke.
- The action invoker, again, looks in the RouteData and finds that action parameter that's been passed along from the routing engine.
