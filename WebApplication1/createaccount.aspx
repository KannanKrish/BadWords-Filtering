<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="createaccount.aspx.vb" Inherits="WebApplication1.Createaccount" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>create account</title>
</head>
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

<body>
    <form id="form1" runat="server">
        <div id="text1" style="position: absolute; overflow: hidden; left: 0px; top: 0px; width: 1146px; height: 117px; z-index: 0; border: #808080 3px; background-color: #333399">
            <div class="wpmd">
                <div align="center"><font class="ws36" color="#FFFFFF"><b>A SystemTo Filter unwanted Messages From OSN User walls and chats</b></font></div>
            </div>
        </div>
        <div id="image1" style="position: absolute; overflow: hidden; left: 0px; top: 118px; width: 1150px; height: 1045px; z-index: 1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server"
        Style="z-index: 1; left: 416px; top: 20px; position: absolute; font-size: large; width: 204px; height: 18px;"
        Text="Enter Your Informations"></asp:Label>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="style1"><strong>&nbsp;<span class="style2">Enter Your Information</span></strong></span>
        <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/Image6.jpg" Height="682px" Width="1201px" />
        <p>
            <asp:TextBox ID="dob" runat="server"
                Style="top: 486px; left: 458px; position: absolute; height: 18px; width: 151px"></asp:TextBox>
        </p>
        <p style="height: 427px">
            <asp:TextBox ID="firstname" runat="server"
                Style="z-index: 1; left: 453px; top: 196px; position: absolute; width: 151px"></asp:TextBox>
            <asp:TextBox ID="lastname" runat="server"
                Style="z-index: 1; left: 451px; top: 246px; position: absolute; width: 151px"></asp:TextBox>
            &nbsp;&nbsp;
        <asp:TextBox ID="emailid" runat="server"
            Style="z-index: 1; left: 452px; top: 295px; position: absolute; width: 151px"></asp:TextBox>
            <asp:TextBox ID="password" runat="server"
                Style="z-index: 1; left: 451px; top: 337px; position: absolute; width: 151px" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="cpassword" runat="server"
                Style="z-index: 1; left: 455px; top: 388px; position: absolute; width: 151px" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="mobileno" runat="server"
                Style="z-index: 1; left: 456px; top: 439px; position: absolute; width: 151px"></asp:TextBox>
            <asp:Button ID="cancel" runat="server"
                Style="z-index: 1; left: 543px; top: 611px; position: absolute; width: 102px; height: 24px;"
                Text="Cancel" />
            <asp:Label ID="sex" runat="server"
                Style="z-index: 1; left: 291px; top: 536px; position: absolute; right: 578px"
                Text="Sex"></asp:Label>
            <asp:Label ID="Label8" runat="server"
                Style="top: 485px; left: 285px; position: absolute; height: 36px; width: 101px; right: 521px; bottom: 123px;"
                Text="Date of Birth"></asp:Label>
            <asp:Button ID="signup" runat="server"
                Style="z-index: 1; left: 360px; top: 611px; position: absolute; width: 102px; right: 445px; height: 25px;"
                Text="Sign Up" />
            <asp:DropDownList ID="DropDownList1" runat="server" Style="top: 541px; position: absolute; height: 25px; width: 151px; right: 676px" AutoPostBack="True">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:Label ID="Label2" runat="server"
            Style="z-index: 1; left: 285px; top: 200px; position: absolute; font-size: large; width: 122px; height: 18px;"
            Text="First Name   " ForeColor="Black"></asp:Label>
        <asp:Label ID="Label3" runat="server"
            Style="z-index: 1; left: 286px; top: 246px; position: absolute; height: 23px; font-size: large"
            Text="Last Name"></asp:Label>
        <asp:Label ID="Label4" runat="server"
            Style="z-index: 1; left: 287px; top: 296px; position: absolute; height: 1px;"
            Text="E-Mail ID"></asp:Label>
        <p>
            &nbsp;
        </p>
        <asp:Label ID="Label5" runat="server"
            Style="z-index: 1; left: 286px; top: 343px; position: absolute; width: 108px"
            Text="Enter Password"></asp:Label>
        <asp:Label ID="Label6" runat="server"
            Style="z-index: 1; left: 284px; top: 389px; position: absolute"
            Text="Confirm Password"></asp:Label>
        <asp:Label ID="Label7" runat="server"
            Style="z-index: 1; left: 286px; top: 439px; position: absolute"
            Text="Mobile No"></asp:Label>
    </form>
</body>
</html>
