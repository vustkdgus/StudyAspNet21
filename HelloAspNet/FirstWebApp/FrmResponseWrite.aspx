﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmResponseWrite.aspx.cs" Inherits="FirstWebApp.FrmResponseWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnMsg" runat="server" Text="클릭" OnClick="BtnMsg_Click" />
            <br />
            <%="또 만나요< br/>"%>
            <asp:Button ID="bBtnJs" runat="server" 
                 Text="JS Greeting" OnClick="bBtnJs_Click" />
            <br />
            <asp:LinkButton ID="BtnLink" Text="Naver" runat="server" 
                OnClick="BtnLink_Click" />
        </div>
    </form>
</body>
</html>
