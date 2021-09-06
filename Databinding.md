# Databinding in asp.net
- ASP.NET web form control inherits the DataBind method from its parent Control class, which gives it an inherent capability to bind data to at least one of its properties.
- This is known as simple data binding or inline data binding.

# Simple or inline databinding
- Simple data binding involves attaching any collection (item collection) which implements the IEnumerable interface, or the DataSet and DataTable classes to the DataSource property of the control.
- These controls can bind to an array list or fields from a database. 
- Selection lists takes two values from the database or the data source; one value is displayed by the list and the other is considered as the value corresponding to the display.
- The controls simple databinding contains are contains are:-
- BulletedList
- CheckBoxList
- DropDownList
- ListBox
- RadioButtonList

# Declarative databinding
- Some controls can bind records, lists, or columns of data into their structure through a DataSource control. These controls derive from the BaseDataBoundControl class. This is called declarative data binding.
- The controls declarative databinding contains are:-
- DetailsView
- FormView
- GridView
- Repeater



