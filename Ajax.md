# AJAX
- AJAX stands for Asynchronous JavaScript and XML.
- This is a cross platform technology which speeds up response time. 
- The AJAX server controls add script to the page which is executed and processed by the browser.
- The control toolbox in the Visual Studio IDE contains a group of controls called the 'AJAX Extensions':- 
- Among them are:-
- Update panel control
- Script manager control<br>
Syntax:-<br>
<form id="form1" runat="server">
        <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
   </div>
   
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate>
         <asp:Button ID="btnpartial" runat="server" onclick="btnpartial_Click" Text="Partial PostBack"/>
         <br />
         <br />
         <asp:Label ID="lblpartial" runat="server"></asp:Label>
      </ContentTemplate>
   </asp:UpdatePanel><br>
   
# Update Panel Control
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
# The ScriptManager Control
- The ScriptManager control is the most important control and must be present on the page for other controls to work.<br>
Syntax:-<br>
<asp:ScriptManager ID="ScriptManager1" runat="server"><br>
</asp:ScriptManager>




   
