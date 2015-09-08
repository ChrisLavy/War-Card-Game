<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaWarCardGame.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="warButton" runat="server" Height="30px" OnClick="warButton_Click" Text="COMMENCE COMBAT!!" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
