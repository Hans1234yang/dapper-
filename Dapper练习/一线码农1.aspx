<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="一线码农1.aspx.cs" Inherits="Dapper练习.一线码农" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="增加" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="批量插入" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="查询" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="修改" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="删除" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
