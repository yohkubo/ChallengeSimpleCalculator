<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <br />
            First Value:
            <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
            <br />
            Second Value:
            <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" Width="30px" />
&nbsp;
            <asp:Button ID="subtractionButton" runat="server" OnClick="subtractionButton_Click" Text="-" Width="30px" />
&nbsp;
            <asp:Button ID="timesButton" runat="server" OnClick="timesButton_Click" Text="*" Width="30px" />
&nbsp;
            <asp:Button ID="divisionButton" runat="server" OnClick="divisionButton_Click" Text="/" Width="30px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; font-size: x-large; background-color: #3399FF"></asp:Label>
        </div>
    </form>
</body>
</html>
