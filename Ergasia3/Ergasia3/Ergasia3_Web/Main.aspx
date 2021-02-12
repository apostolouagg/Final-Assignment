<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Ergasia3_Web.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 638px; background-color:lightskyblue">
    <form id="form1" runat="server">
        <div style="height: 582px;">
            <br />
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="TimerUpdate" runat="server" Interval="200" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:Panel ID="PanelUpdate" runat="server" Height="191px" HorizontalAlign="Center">
                        <asp:Label ID="LabelTitle2" runat="server" Font-Names="Tahoma" Font-Size="XX-Large" Font-Underline="true" Text="Covid-19 Statistics"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="LabelTotalCases" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Total Cases: "></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="LabelAge" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Average Age: "></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="LabelMale" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Male:"></asp:Label>
                        <asp:Label ID="LabelFemale" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Female:"></asp:Label>
                    </asp:Panel>
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
