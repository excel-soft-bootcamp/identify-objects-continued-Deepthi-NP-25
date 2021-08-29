  # Page life cycle in asp.net:
  - When an ASP.NET page runs, the page goes through a life cycle in which it performs a series of processing steps.These include:-
  - initialization, instantiating controls, restoring and maintaining state, running event handler code, and rendering.
  - The life cycle of an asp.net page also contains certain events those are:-
  
  |Page life cycle events|Description|
  |----------------------|-----------|
  |1.PreInit:-|raised after the start stage is complete and before the initialization stage begins, IsPostBack property is determined, creates dynamic controls, Set Master page    and theme dynamically, Set or Get profile property values|
  |2.Init:-|Raised when controls are initialized, Init event of control occurs before init event of page, This event is used to set or get control properties|
  |3.InitComplete:-|Raised at the end of the page initialization, View state is not yet loaded, This event can be used to make changes in view state, This event can be used for    processing tasks that require all initialization to be completed|
  |4.PreLoad:-|Is raised when page loads the ViewState, Loads the PostBack data|
  |5.Load:-|Firstly page calls the OnLoad method on page object, Then recursively OnLoad for each control is invoked|
  |6.Control Events:-|Use these events to handle specific control events|
  |7.LoadComplete:-|Raised at the end of the event handling stage, We use this event for tasks that require all other controls on the page to be loaded|
  |8.PreRender:-|Raised after the page object has created all the controls that are required in order to render the page, Page object raises the PreRender event on the Page        object, and then recursively does the same for each child control, We use this event to make final changes to the content of the page or its controls befpre the rendering        stage begins|
  |9.PreRenderComplete:-|It is raised after each data bound control whose DataSourceID property is set calls its DataBind method|
  |10.SaveStateComplete:-|It is raised after view state and control state have been saved for the page and for all controls|
  |11.Render:-|This is not an event at this stage of processing the Page object calls this method on each control|
  |12.Unload:-|This event is first raised for each control and then for the page|
  
