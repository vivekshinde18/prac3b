<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pract3b" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<style type="text/css">
#form1 {
height: 407px;
}
</style></head>
<body>
<form id="form1" runat="server">
<div style="height: 585px">
<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC"
BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest"
FirstDayOfWeek="Sunday" Font-Names="Verdana" Font-Size="8pt"
ForeColor="#663399" Height="400px" NextPrevFormat="ShortMonth"
OnDayRender="Calendar1_DayRender" ShowGridLines="True"
Width="1000px">
<DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
<NextPrevStyle BorderStyle="Solid" BorderWidth="2px" Font-Size="9pt"
ForeColor="#FFFFCC" />
<OtherMonthDayStyle BackColor="#FFCC99" BorderStyle="Solid"
ForeColor="#CC9966" />
<SelectedDayStyle BackColor="Red" Font-Bold="True" />
<SelectorStyle BackColor="#FFCC66" />
<TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt"
ForeColor="#FFFFCC" />
<TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
<WeekendDayStyle Height="50px" />
</asp:Calendar><br />
<asp:Label ID="Label1" runat="server"></asp:Label><br />
<asp:Label ID="Label2" runat="server"></asp:Label><br />
<asp:Label ID="Label3" runat="server"></asp:Label><br />
<asp:Label ID="Label4" runat="server"></asp:Label><br />
<asp:Label ID="Label5" runat="server"></asp:Label><br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
style="margin-top: 0px" Text="RESULT" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click"
Text="RESET" />
<br />
</div>
</form>
</body>
</html>

