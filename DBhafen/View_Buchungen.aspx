<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Buchungen.aspx.cs" Inherits="DBhafen.View_Buchungen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Buchungen<br />
    
    </div>
        <asp:Button ID="BtnBuchungenBuchungenAnzeigen" runat="server" OnClick="BtnBuchungenBuchungenAnzeigen_Click" Text="Buchungen anzeigen" Width="219px" />
        <p>
            <asp:Button ID="BtnBuchungenBuchungenStornieren" runat="server" OnClick="BtnBuchungenBuchungenStornieren_Click" Text="Buchungen stornieren" Width="219px" />
        </p>
    </form>
</body>
</html>
