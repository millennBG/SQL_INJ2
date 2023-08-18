<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQL_INJ.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblLoggedUser" runat="server" Text="User:"></asp:Label>
            <br />
        </p>
        <p>
            User Name: <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
