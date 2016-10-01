<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NSC.aspx.cs" Inherits="WNG_Test.NSC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li>Instructions</li>
                <li>Please enter a number below to initiate calculation of numeric sequences.</li>
                <li>Number should be positive, whole numbers only.</li>                
            </ul>
        </div>
    <div>
        <asp:Literal ID="ltNumber" Text="Enter a Number" runat="server"></asp:Literal>
        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator EnableClientScript="false" ControlToValidate="txtNumber" ID="rfvNumber" runat="server" ErrorMessage="Please enter a value."></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator  ControlToValidate="txtNumber" ValidationExpression="\d+" ID="revNumber" ErrorMessage="Please enter +ve or whole number." runat="server"></asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
        <div>
            <div><asp:Literal ID="ltResultNumbers" runat="server"></asp:Literal></div>
            <div><asp:Literal ID="ltResultEvenNumbers" runat="server"></asp:Literal></div>
            <div><asp:Literal ID="ltResultOddNumbers" runat="server"></asp:Literal></div>
            <div><asp:Literal ID="ltResultNumbersWithCharacters" runat="server"></asp:Literal></div>
            <div><asp:Literal ID="ltResultFibonacciNumbers" runat="server"></asp:Literal></div>
        </div>
    </form>
</body>
</html>
