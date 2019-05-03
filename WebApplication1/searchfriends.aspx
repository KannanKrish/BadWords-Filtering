<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="searchfriends.aspx.vb" Inherits="WebApplication1.Searchfriends" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .ws36 {
            font-size: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="text1" style="position: absolute; overflow: hidden; left: 59px; top: 0px; width: 1204px; height: 110px; z-index: 0; border: #808080 3px; background-color: #333399">
            &nbsp;&nbsp;
            <div id="text2" style="position: absolute; overflow: hidden; left: 1px; top: -2px; width: 1204px; height: 110px; z-index: 0; border: #808080 3px; background-color: #333399">
                <div align="center"><font class="ws36" color="#FFFFFF"><b>A SystemTo Filter unwanted Messages From OSN User walls and chat</b></font></div>
            </div>
        </div>
        <p>
            &nbsp;
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            &nbsp;
        </p>
        <asp:LinkButton ID="LinkButton1" runat="server" Style="margin-left: 0px; margin-top: 200px; position: absolute; width: 316px; top: -79px; left: 946px; height: 39px;" Font-Italic="True" Font-Size="XX-Large" ForeColor="#006699"></asp:LinkButton>
        <br />
        <br />
        <p style="margin-left: 560px">
            <asp:Label ID="Label1" runat="server" Style="position: absolute; margin-left: 0px; top: 150px; left: 650px; width: 220px;" Font-Size="XX-Large" Text="Search Friends"></asp:Label>
        </p>
        <p style="margin-left: 560px">
            &nbsp;
        </p>
        <p style="width: 428px; margin-left: 560px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 0px" Width="195px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Style="margin-left: 13px" Text="Search Friends" Width="100px" />
        </p>
        <p style="width: 428px; margin-left: 560px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Width="200px" Style="margin-left: 10px">
            </asp:DropDownList>
            <asp:Button ID="Button3" runat="server" Style="margin-left: 17px" Text="Send Request" Width="101px" />
        </p>
    </form>
</body>
</html>
