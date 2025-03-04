<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Use.aspx.cs" Inherits="MantDataStructure.Use" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Use Category Array"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtIndex" runat="server" Width="209px"></asp:TextBox>
        </div>
        <asp:Button ID="btnLookUp" runat="server" Text="LookUp" OnClick="btnLookUp_Click" Width="86px" />
    &nbsp;<asp:Button ID="txtCategory" runat="server" Text="----" BackColor="White" BorderStyle="None" OnClick="Button1_Click" Width="86px" />
    </form>
</body>
</html>
