<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FriendsPage.aspx.vb" Inherits="WebApplication1.FriendsPage" %>

<%@ Register Assembly="ASP.Web.UI.PopupControl" Namespace="ASP.Web.UI.PopupControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>userpage</title>
    <style type="text/css">
        /*----------Text Styles----------*/
        .ws6 {
            font-size: 8px;
        }

        .ws7 {
            font-size: 9.3px;
        }

        .ws8 {
            font-size: 11px;
        }

        .ws9 {
            font-size: 12px;
        }

        .ws10 {
            font-size: 13px;
        }

        .ws11 {
            font-size: 15px;
        }

        .ws12 {
            font-size: 16px;
        }

        .ws14 {
            font-size: 19px;
        }

        .ws16 {
            font-size: 21px;
        }

        .ws18 {
            font-size: 24px;
        }

        .ws20 {
            font-size: 27px;
        }

        .ws22 {
            font-size: 29px;
        }

        .ws24 {
            font-size: 32px;
        }

        .ws26 {
            font-size: 35px;
        }

        .ws28 {
            font-size: 37px;
        }

        .ws36 {
            font-size: 48px;
        }

        .ws48 {
            font-size: 64px;
        }

        .ws72 {
            font-size: 96px;
        }

        .wpmd {
            font-size: 13px;
            font-family: 'Arial';
            font-style: normal;
            font-weight: normal;
        }
        /*----------Para Styles----------*/
        DIV, UL, OL /* Left */ {
            margin-top: 0px;
            margin-bottom: 0px;
            margin-left: 3px;
            margin: 0 auto 0 auto;
            padding: 10px;
            border: thin #000000 ridge;
            color: #FF0000;
            font-size: xx-large;
            font-style: italic;
            width: 90%;
        }
    </style>

    <style type="text/css">
        a.Logout:link {
            color: #000000;
        }

        a.Logout:hover {
            font-family: Arial,Unicode, MS;
            color: #000000;
        }

        #form1 {
            height: 17px;
        }
    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div id="text1" style="position: absolute; overflow: hidden; left: 59px; top: 0px; width: 1204px; height: 110px; z-index: 0; border: #808080 3px; background-color: #333399">
            <div align="center"><font class="ws36" color="#FFFFFF"><b>A SystemTo Filter unwanted Messages From OSN User walls and chat</b></font></div>
        </div>
        <script type="text/javascript" src="Scripts\customOperations.js"></script>

        <p>
            <asp:Label ID="lblFriend" runat="server" ForeColor="#003300" Style="top: 170px; left: 101px; position: absolute; height: 36px; width: 297px; font-size: xx-large; right: 672px" Text="Label"></asp:Label>
            <asp:Label ID="Label1" runat="server" ForeColor="#003300" Style="top: 127px; left: 666px; position: absolute; height: 36px; width: 297px; font-size: xx-large; right: 107px" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" Style="top: 134px; left: 971px; position: absolute; height: 19px; width: 67px; color: #003300">Home</asp:LinkButton>
            <asp:TextBox ID="TextBox1" runat="server" Style="top: 213px; left: 209px; position: absolute; height: 66px; width: 458px; font-weight: 700; right: 196px;" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton2" runat="server" Style="top: 133px; left: 1043px; position: absolute; height: 20px; width: 62px; color: #003300; right: 180px;">Profile</asp:LinkButton>
            <asp:LinkButton ID="LinkButton5" runat="server" Style="top: 135px; left: 1105px; position: absolute; height: 20px; width: 62px; color: #003300; right: 118px;">friends list</asp:LinkButton>
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" Style="top: 135px; left: 1176px; position: absolute; height: 19px; width: 67px; color: #003300">Log Out</asp:LinkButton>
        <asp:Button ID="Button1" runat="server" Style="top: 224px; left: 703px; position: absolute; height: 31px; width: 129px" Text="Post" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="btnSendRequest" runat="server" Style="position: absolute; top: 225px; left: 847px; width: 108px; height: 29px;" Text="Send Request" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
