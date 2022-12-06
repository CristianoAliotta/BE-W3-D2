<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE_W3_D2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Username: <asp:TextBox ID="Username"  runat="server"></asp:TextBox>
           Password: <asp:TextBox ID="Password"  TextMode="Password" runat="server"></asp:TextBox>
           <asp:Button ID="Btn"  runat="server" Text="Login" OnClick="Log" />
        </div>
    </form>
</body>
</html>
