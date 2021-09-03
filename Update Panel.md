# Update Panel in asp.net
- The UpdatePanel control is a container control and derives from the Control class. 
- It acts as a container for the child controls within it and does not have its own interface.
- When a control inside it triggers a post back, the UpdatePanel intervenes to initiate the post asynchronously and update just that portion of the page.<br>
Syntax:-<br>
string time = DateTime.Now.ToLongTimeString();<br>
lblpartial.Text = "Showing time from panel" + time;<br>
lbltotal.Text = "Showing time from outside" + time;<br>
- Update panel control has the following properties:-<br>
ChildrenAsTriggers, ContentTemplate, ContentTemplateContainer, IsInPartialRendering, RenderMode, UpdateMode, Triggers<br>
- Methods of the UpdatePanel Control<br>
CreateContentTemplateContainer, CreateControlCollection, Initialize, Update<br>
The behavior of the update panel depends upon the values of the UpdateMode property and ChildrenAsTriggers property<br>

|UpdateMode|ChildrenAsTriggers|Effect|
|-----------|-----------------|-----------|
|Always|False|Illegal parameters|
|Always|True|UpdatePanel refreshes if whole page refreshes or a child control on it posts back|
|Conditional|False|UpdatePanel refreshes if whole page refreshes or a triggering control outside it initiates a refresh|
|Conditional|True|UpdatePanel refreshes if whole page refreshes or a child control on it posts back or a triggering control outside it initiates a refresh|

# The UpdateProgress Control
- The UpdateProgress control provides a sort of feedback on the browser while one or more update panel controls are being updated.
- For example, while a user logs in or waits for server response while performing some database oriented job.
- It provides a visual acknowledgement like "Loading page...", indicating the work is in progress.<br>
<asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true" AssociatedUpdatePanelID="UpdatePanel1" ><br>
   <ProgressTemplate>
      Loading...
   </ProgressTemplate><br>
</asp:UpdateProgress><br>
- The following table shows the properties of the update progress control:-<br>
AssociatedUpdatePanelID, Attributes, DisplayAfter, DynamicLayout, ProgressTemplate<br>
- Methods of the UpdateProgress Control:-<br>
GetScriptDescriptors, GetScriptReferences



   
