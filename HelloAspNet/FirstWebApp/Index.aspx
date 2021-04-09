<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FirstWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ASP.NET 웹페이지</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HEllo ASP.NET!</h1>
        </div>
        <input type="text" name="TxtOther" id="TxtOther" />
        <p>

        <asp:TextBox ID="TxtDisplay" runat="server" Height="16px"></asp:TextBox>
        <asp:Button ID="BtnClick" runat="server" OnClick="BtnClick_Click" Text="클릭" />
        </p>
        <p>
            <asp:Label ID="LblResult" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
