<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_HafenplatzBuchen.aspx.cs" Inherits="DBhafen.View_HafenplatzBuchen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hafenplatz buchen<br />
        <br />
        Hafenplätze:<br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnect %>" SelectCommand="SELECT * FROM [Anlegeplatz]"></asp:SqlDataSource>
        <asp:CheckBoxList ID="CheckBoxAnlegeplätze" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="IdAnlegeplatz">
        </asp:CheckBoxList>
        <br />
        <br />
        Von:<br />
        <br />
        <asp:Label ID="Lbl_SelVon" runat="server" Text="Label"></asp:Label>
        <asp:Calendar ID="CalendarVon" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="CalendarVon_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
        Bis<br />
        <br />
        <asp:Label ID="Lbl_SelBis" runat="server" Text="Label"></asp:Label>
        <asp:Calendar ID="CalendarBis" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="CalendarBis_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Label ID="LblWarnung" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Schiffe:<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnect %>" SelectCommand="SELECT * FROM [Schiffe]"></asp:SqlDataSource>
        <asp:CheckBoxList ID="CheckBoxSchiffe" runat="server" DataSourceID="SqlDataSource1" DataTextField="NameSchiff" DataValueField="IdSchiff" OnSelectedIndexChanged="CheckBoxSchiffe_SelectedIndexChanged">
            <asp:ListItem></asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:TextBox ID="TxtBxBemerkung" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnHafenplatzBuchenBuchen" runat="server" OnClick="BtnHafenplatzBuchenBuchen_Click" Text="Buchen" Width="200px" />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
