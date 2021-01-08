<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_MainWindow.aspx.cs" Inherits="DBhafen.View_MainWindow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hauptmenü<br />
        </div>
        <asp:Button ID="BtnMenueSchiffAnlegen" runat="server" OnClick="BtnMenueSchiffAnlegen_Click" Text="Schiff anlegen" Width="200px" />
        <p>
            <asp:Button ID="BtnMenueHafenplatzAnlegen" runat="server" OnClick="BtnMenueHafenplatzAnlegen_Click" Text="Hafenplatz anlegen" Width="200px" />
        </p>
        <asp:Button ID="BtnMenueHafenplatzBuchen" runat="server" OnClick="BtnMenueHafenplatzBuchen_Click" Text="Hafenplatz buchen" Width="200px" />
        <p>
            <asp:Button ID="BtnMenueBuchungen" runat="server" OnClick="BtnMenueBuchungen_Click" Text="Buchungen" Width="200px" />
        </p>
        <p>
            <asp:Button ID="BtnMenueSchiffeAnzeigen" runat="server" OnClick="BtnMenueSchiffeAnzeigen_Click" Text="Schiffe anzeigen" Width="200px" />
        </p>
        <p>
            <asp:Button ID="BtnMenueSchiffeDel" runat="server" OnClick="BtnMenueSchiffeDel_Click" Text="Schiffe löschen" Width="200px" />
        </p>
        <p>
            <asp:Button ID="BtnMenueHafenplätzeDel" runat="server" OnClick="BtnMenueHafenplätzeDel_Click" Text="Hafenplätze lösche" Width="200px" />
        </p>
        <p>
            <asp:Button ID="BtnMenueBuchungenDel" runat="server" OnClick="BtnMenueBuchungenDel_Click" Text="Buchungen löschen" Width="200px" />
        </p>
    </form>
</body>
</html>
