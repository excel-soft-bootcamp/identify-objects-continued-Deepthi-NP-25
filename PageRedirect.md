|Response.Redirect()|Server.Transfer()|Server.Execute()|
|-------------------|-----------------|----------------|
|Used to transfer the page from one page to another|Stops rendering the current page and starts rendering another one|Is used, when a URL is passed to it as a parameter and the control moves to this new page|
|Sends a redirection header to the client, and the client itself requests the new page|Executes a new page and returns it's results to the browser but does not inform the browser that it returned a different page|Execution of code happens on the new page. Once code execution gets over, the control returns to the initial page, just after where it was called|
|Response.Redirect method takes two parameters URL and endResponse|As it returns the result of a new page the browser url will show the original url requested but the contents will come from some other page|It is also used to begin execution of a new webform while still displaying the current web form|
|In Response.Redirect the URL is the mandatory parameter but the endResponse is optional parameter|Server.Transfer happens without the browser knowing anything, the browser request a page, but the server returns the content of another|The contents of both forms are combined|





