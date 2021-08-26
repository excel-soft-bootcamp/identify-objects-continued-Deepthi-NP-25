State Managemnet in asp.net

A)Client Side State management

1)ViewState:- is an approach to saving data for the user.
Because of the stateless nature of web pages, regular page member variables will not maintain their values across postbacks. 

2)Control State:-The purpose of the control state repository is to cache data necessary for a control to properly function. ControlState is essentially a private ViewState for your control only, and it is not affected when ViewState is turned off. 

3)Hidden Fields:-A Hidden control is the control which does not render anything on the web page at client browser but can be used to store some information on the web page which can be used on the page.  

4)Cookies:-A cookie is a small amount of data which is either stored at client side in text file or in memory of the client browser session. Cookies are always sent with the request to the web server and information can be retrieved from the cookies at the web server. Every time a user visits a website, cookies are retrieved from the user machine and help identify the user.

5)Query String:-A Query string is used to pass the values or information form one page to another page. They are passed along with URL in clear text. Query strings provide a simple but limited way of maintaining some state information.

B)Server Side State management

1)Application State:-Application State is used to store information which is shared among users of the ASP.Net web application. 

2)Session State:-Session state provides a place to store values that will persist across page requests. Values stored in Session are stored on the server and will remain in memory until they are explicitly removed or until the Session expires. th a Web application. 

3)Profile Properties:-ASP.NET provides a feature called profile properties, which allows you to store user-specific data.    
