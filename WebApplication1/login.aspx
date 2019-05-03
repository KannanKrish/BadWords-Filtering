<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <meta http-equiv="content-type" content="text/html; charset=iso-8859-1">
    <meta name="generator" content="Web Page Maker V2">
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
        }
    </style>

    <style type="text/css">
        a.Logout:link {
            color: #000000;
        }

        a.Logout:hover {
            font-family: Arial, Unicode, MS;
            color: #000000;
        }
    </style>
</head>
<body>
    <div id="text1" style="position: absolute; overflow: hidden; left: 0px; top: 0px; width: 1146px; height: 117px; z-index: 0; border: #808080 3px window-inset; background-color: #333399">
        <div class="wpmd">
            <div align="center"><font class="ws36" color="#FFFFFF"><b>A SystemTo Filter unwanted Messages From OSN User walls and chats</b></font></div>
        </div>
    </div>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="height: 411px; width: 1126px">
            <asp:Button ID="Button1" runat="server"
                Style="z-index: 1; left: 889px; top: 359px; position: absolute; width: 82px"
                Text="Sign in" />
            <br />
            <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Image4.jpg" Height="682px" Width="1201px" />
            <asp:Label ID="Label1" runat="server" ForeColor="#333333"
                Style="float: right; top: 233px; left: 699px; position: absolute; height: 19px; width: 143px; font-family: Arial, Helvetica, sans-serif; font-size: large"
                Text="Email-ID"></asp:Label>
            <asp:Label ID="Label2" runat="server" ForeColor="#333333"
                Style="float: right; top: 295px; left: 698px; position: absolute; height: 18px; width: 147px; font-family: Arial, Helvetica, sans-serif; font-size: large"
                Text="Password"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server" ForeColor="Black"
                Style="top: 240px; left: 842px; float: right; height: 22px; width: 213px; position: absolute; right: 68px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"
                Style="z-index: 1; left: 843px; top: 299px; position: absolute; width: 213px" TextMode="Password"></asp:TextBox>
            <asp:LinkButton ID="LinkButton1" runat="server"
                Style="z-index: 1; left: 863px; top: 408px; position: absolute; width: 191px">Create New Account</asp:LinkButton>
        </p>
    </form>
</body>
</html>

