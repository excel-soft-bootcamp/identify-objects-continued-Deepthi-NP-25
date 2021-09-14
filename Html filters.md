# HTML helper tags
- HtmlHelper is a class which contains different methods that helps to create HTML controls programmatically.
- It provides built-in methods to generate controls on the view page.
- Constructors in html helper class

|Constructor Name|Description|
|----------------|-----------|
|HtmlHelper(ViewContext, IViewDataContainer)|It Initializes a new instance of the HtmlHelper class by using the specified view context and view data container|
|HtmlHelper(ViewContext, IViewDataContainer, RouteCollection)|It Initializes a new instance of the HtmlHelper class by using the specified view context, view data container, and route collection|
- Html helper extension methods

|Name|Description|
|----|-----------|
|Action(String)|It is used to invoke the specified child action method and returns the result as an HTML string|
|BeginForm()|It is used to generate an opening <form> tag. The form uses the POST method|
|CheckBox(String)|It is used to generate a check box input element by using the specified HTML helper and the name of the form field|
|DropDownList(String)|It generates a single-selection select element using the specified HTML helper and the name of the form field|
|Editor(String)|It generates an HTML input element for each property in the object that is represented by the expression|
|EndForm()|It renders the closing </form> tag|
|Label(String)|It generates an HTML label element|
|ListBox(String)|It returns a multi-select select element using the specified HTML helper|
|Password(String)|It is used to generate a password input element by using the specified HTML helper|
|RadioButton(String, Object)|It returns a radio button input element|
|TextArea(String)|It is used to create a text area to the web page|
|TextBox(String)|It is used to return a text input element by using the specified HTML helper|

