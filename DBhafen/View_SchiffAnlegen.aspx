<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_SchiffAnlegen.aspx.cs" Inherits="DBhafen.WebViewFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Schiff anlegen<br />
        </div>
        Name des schiffes:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtBxNameSchiff" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <p>
            Bemerkung:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtBxBemerkung" runat="server" OnTextChanged="TxtBxBemerkung_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Kapitän:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtBxKapitän" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnSchiffAnlegen" runat="server" OnClick="BtnSchiffAnlegen_Click" Text="Anlegen" />
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnect %>" SelectCommand="SELECT * FROM [Schiffe]"></asp:SqlDataSource>
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdSchiff" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="IdSchiff" HeaderText="IdSchiff" InsertVisible="False" ReadOnly="True" SortExpression="IdSchiff" />
                <asp:BoundField DataField="NameSchiff" HeaderText="NameSchiff" SortExpression="NameSchiff" />
                <asp:BoundField DataField="Bemerkung" HeaderText="Bemerkung" SortExpression="Bemerkung" />
                <asp:BoundField DataField="Kapitän" HeaderText="Kapitän" SortExpression="Kapitän" />
                <asp:CommandField ShowSelectButton="True" />
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
        <br />
        <br />
        <br />
        <asp:Label ID="LblIndex" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TxtBxNamSchif" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtBxBemer" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtBxKptn" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="BtnChange" runat="server" OnClick="BtnChange_Click" Text="Ändern" Width="276px" />
    </form>
</body>
</html>
