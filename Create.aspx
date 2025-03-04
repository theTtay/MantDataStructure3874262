<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="MantDataStructure.CreateCategoryArray" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Create Category Array"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="btnCreateArray" runat="server" Text="Create Array" OnClick="btnCreateArray_Click" />
    </form>
</body>
</html>
