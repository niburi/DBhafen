<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_HafenplatzAnlegen.aspx.cs" Inherits="DBhafen.View_HafenplatzAnlegen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hafenplatz anlegen<br />
        <br />
        Name des hafenplatzes:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtBxHafenplatzName" runat="server" OnTextChanged="TxtBxHafenplatzName_TextChanged"></asp:TextBox>
        <br />
        <br />
        Bemerkung:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtBxHafenplatzBemerkung" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="BtnHafenplazAnlegenHafenplatzAnlegen" runat="server" OnClick="BtnHafenplazAnlegenHafenplatzAnlegen_Click" Text="Hafenplatz anlegen" />
        <br />
    
    </div>
    </form>
</body>
</html>
