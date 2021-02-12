<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Ergasia3_Web.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1038px; background-color:lightskyblue">
    <form id="form1" runat="server">
        <div style="height: 1054px;">
            <br />
            <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
                <asp:Image ID="Image1" runat="server" BorderStyle="Solid" ImageUrl="~/Content/people.jpg" />
            </asp:Panel>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="TimerUpdate" runat="server" Interval="500" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:Panel ID="PanelUpdate" runat="server" Height="203px" HorizontalAlign="Center">
                        <asp:Label ID="LabelTitle2" runat="server" Font-Names="Tahoma" Font-Size="XX-Large" Font-Underline="true" Text="Covid-19 Statistics"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="LabelTotalCases" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Total Cases: "></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="LabelAge" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Average Age: "></asp:Label>
                        <br />
                        <br />
                        <asp:Image ID="Image2" runat="server" Height="40px" ImageUrl="~/Content/man.png" Width="30px" />
                        <asp:Label ID="LabelMale" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Male:"></asp:Label>
                        &nbsp;
                        &nbsp;
                        &nbsp;
                        &nbsp;
                        <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/Content/woman.png" Width="30px" />
                        <asp:Label ID="LabelFemale" runat="server" Font-Names="Tahoma" Font-Size="X-Large" Text="Female:"></asp:Label>
                        <div style="height: 228px; margin-top: 28px">
                            <asp:Image ID="Image9" runat="server" BorderStyle="Solid" BorderWidth="2px" Height="100px" ImageAlign="Middle" ImageUrl="~/Content/menoumeAsfalis.png" Width="100px" />
                            &nbsp;
                            &nbsp;
                            &nbsp;
                            &nbsp;
                            &nbsp;
                            &nbsp;
                            &nbsp;
                            <asp:Image ID="Image10" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="~/Content/menoumeSpiti.png" Width="100px" />
                        </div>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
