# Validation Controls
- ASP.NET validation controls validate the user input data to ensure that useless, unauthenticated, or contradictory data don't get stored.
- ASP.NET provides the following validation controls:
1. RequiredFieldValidator
2. RangeValidator
3. CompareValidator
4. RegularExpressionValidator
5. CustomValidator
6. ValidationSummary<br>
- RequiredFieldValidator:-The RequiredFieldValidator control ensures that the required field is not empty. It is generally tied to a text box to force input into the text box.<br>
 Syntax:-<br>
  <asp:RequiredFieldValidator ID="rfvcandidate"<br> 
    runat="server" ControlToValidate ="ddlcandidate"<br>
    ErrorMessage="Please choose a candidate"<br> 
    InitialValue="Please choose a candidate"><br>
  </asp:RequiredFieldValidator><br>
- RangeValidator Control:-The RangeValidator control verifies that the input value falls within a predetermined range. It has three specific properties: Type, MinimumValue, MaximumValue.<br>
Syntax:-<br>
<asp:RangeValidator ID="rvclass" runat="server" ControlToValidate="txtclass"<br> 
   ErrorMessage="Enter your class (6 - 12)" MaximumValue="12"<br>
   MinimumValue="6" Type="Integer"><br>
 </asp:RangeValidator><br>
 - CompareValidator Control:-The CompareValidator control compares a value in one control with a fixed value or a value in another control. It has the following specific properties: Type, ControlToCompare, ValueToCompare, Operator.<br>
 Syntax:-<br>
 <asp:CompareValidator ID="CompareValidator1" runat="server"<br>
   ErrorMessage="CompareValidator"><br>
 </asp:CompareValidator><br>
- RegularExpressionValidator:-The RegularExpressionValidator allows validating the input text by matching against a pattern of a regular expression. The regular expression is set in the ValidationExpression property.Classification in regular expressions:-<br>
1. Character escapes in regular expression:- \b, \t, \n, \
2. Metacharacters are a class of characters could be specified that can be matched:- [abcd], [^abcd], \W, \d, \D <br>
3. Quantifiers specify number of times a character could appear:- *, +, ?, <br>
The syntax of the control:-<br>
<asp:RegularExpressionValidator ID="string" runat="server" ErrorMessage="string"<br>
   ValidationExpression="string" ValidationGroup="string"><br>
</asp:RegularExpressionValidator> <br>
- CustomValidator:- The CustomValidator control allows writing application specific custom validation routines for both the client side and the server side validation.The client side validation is accomplished through the ClientValidationFunction property. The client side validation routine should be written in a scripting language, such as JavaScript or VBScript, which the browser can understand.The server side validation routine must be called from the control's ServerValidate event handler. The server side validation routine should be written in any .Net language, like C# or VB.Net.<br>
Syntax:-<br>
<asp:CustomValidator ID="CustomValidator1" runat="server"<br>
   ClientValidationFunction=.cvf_func. ErrorMessage="CustomValidator"><br>
</asp:CustomValidator> <br>
- ValidationSummary:-The ValidationSummary control does not perform any validation but shows a summary of all errors in the page. The summary displays the values of the ErrorMessage property of all validation controls that failed validation.The following two mutually inclusive properties list out the error message:-<br>
ShowSummary, ShowMessageBox <br>
Syntax:-<br>
<asp:ValidationSummary ID="ValidationSummary1" runat="server"<br> 
   DisplayMode = "BulletList" ShowSummary = "true" HeaderText="Errors:" />


