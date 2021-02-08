<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryDetails.aspx.cs" Inherits="CountryAssignFeb5.CountryDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCountry" runat="server" Text="Country Id"></asp:Label>
&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCountry_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblStat" runat="server" Text="State Id"></asp:Label>
&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownState_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCity" runat="server" Text="City Id"></asp:Label>
&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownCity_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
