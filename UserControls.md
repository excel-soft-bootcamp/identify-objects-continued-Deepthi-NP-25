# User Controls in asp.net
- Behaves like miniature ASP.NET pages or web forms, which could be used by many other pages.
- Have an .ascx creation
- Does not have standard html tags
- To understand the concept we need to create a simple user control, which will work as footer for the web pages.<br>
Syntax:-<br>
- Control directive:-
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="footer.ascx.cs" 
   Inherits="customcontroldemo.footer" %> <br>
- Register directive:-<br>
 <%@ Register Src="~/footer.ascx" TagName="footer" TagPrefix="Tfooter" %> <br>
- Tag name and prefix <br>
<Tfooter:footer ID="footer1" runat="server" />
   



