<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_BuchungenAnzeigen.aspx.cs" Inherits="DBhafen.View_BuchungenAnzeigen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Buchungen anzeigen<br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnect %>" SelectCommand="SELECT * FROM [AnlageTabelle] ORDER BY [FK_IDAnlegeplatz], [GebuchtBis]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdBuchung" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="IdBuchung" HeaderText="IdBuchung" InsertVisible="False" ReadOnly="True" SortExpression="IdBuchung" />
                <asp:BoundField DataField="GebuchtVon" HeaderText="GebuchtVon" SortExpression="GebuchtVon" />
                <asp:BoundField DataField="GebuchtBis" HeaderText="GebuchtBis" SortExpression="GebuchtBis" />
                <asp:BoundField DataField="Bemerkung" HeaderText="Bemerkung" SortExpression="Bemerkung" />
                <asp:BoundField DataField="FK_IDAnlegeplatz" HeaderText="FK_IDAnlegeplatz" SortExpression="FK_IDAnlegeplatz" />
                <asp:BoundField DataField="FK_IDSchiff" HeaderText="FK_IDSchiff" SortExpression="FK_IDSchiff" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
