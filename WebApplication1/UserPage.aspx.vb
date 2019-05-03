Imports System.Data.SqlClient
Public Class UserPage
    Inherits System.Web.UI.Page
    Public Con As SqlConnection
    Dim com As SqlCommand
    Dim path As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Server.MapPath("~\") + "userdata.mdf;Integrated Security=True"
    Dim ret, out As String
    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Post()
        Dim txt As String = Request.QueryString("name")
        ret = "select * from userdata where email='" & txt & "'"
        Con = New SqlConnection(path)
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim tab As New DataTable("userdata")
        Dim read As SqlDataAdapter = New SqlDataAdapter(ret, Con)
        read.Fill(tab)
        Label1.Text = tab.Rows(0).Item("fname") + "  " + tab.Rows(0).Item("lname")
        Con.Close()
    End Sub
    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Server.Transfer("userpage.aspx")
    End Sub
    Protected Sub LinkButton3_Click(sender As Object, e As EventArgs) Handles LinkButton3.Click
        Server.Transfer("login.aspx")
    End Sub
    Protected Sub Post()
        Panel1.Controls.Clear()
        If TextBox1.Text <> "" Then
JumpPoint:
            Dim txt As String = Request.QueryString("name")
            Dim strtemp As String = TextBox1.Text
            If TextBox1.Text.Contains(vbNewLine) Then
                strtemp = TextBox1.Text.Replace(vbNewLine, "`")
            End If
            Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
            Con.Open()
            ret = "select * from userdata where email='" & Request.QueryString("name") & "'"
            com = New SqlCommand(ret, Con)
            Dim read As SqlDataReader = com.ExecuteReader()
            Dim friendRetrive As String = String.Empty
            If read.HasRows Then
                read.Read()
                friendRetrive = read(7).ToString()
            End If
            Dim friends As String() = friendRetrive.Split("|")
            For Each item As String In friends
                If item <> "" And item <> String.Empty Then
                    ret = "update userdata set MessageFriends='" + ReteriveMessage(item) + "|" + txt + "~" + strtemp + "'where email='" & item & "'"
                    Con.Open()
                    com = New SqlCommand(ret, Con)
                    com.ExecuteReader()
                    SplitMessage(ReteriveMessage(txt))
                    TextBox1.Text = ""
                End If
            Next
            ret = "update userdata set MessageFriends='" + ReteriveMessage(txt) + "|" + "Me~" + strtemp + "'where email='" & txt & "'"
            Con.Open()
            com = New SqlCommand(ret, Con)
            com.ExecuteReader()
            Con.Close()
            SplitMessage(ReteriveMessage(txt))
            TextBox1.Text = ""
        Else
            SplitMessage(ReteriveMessage(Request.QueryString("name")))
            TextBox1.Text = ""
        End If
    End Sub
    Private Function ReteriveMessage(ByVal email As String) As String
        Dim myMessage As String = ""
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & email & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            read.Read()
            myMessage = read(9).ToString
            Con.Close()
        End If
        Return myMessage
    End Function
    Private Sub AddControl(ByVal myMessage As String)
        If myMessage.Contains("#") Then
            Dim temp As New Label()
            If myMessage.Contains("`") Then
                myMessage = myMessage.Replace("`", "<br/>")
            End If
            Dim emailSpilt As String() = myMessage.Split("#")
            Dim style As String = "<div class=""PostMessage"">" + emailSpilt(0) + " : <br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + emailSpilt(1) + "<br/></div>"
            temp.Text = style
            Panel1.Controls.Add(temp)
        ElseIf myMessage <> "" And Not myMessage.Contains("§") Then
            Dim temp As New Label()
            If myMessage.Contains("`") Then
                myMessage = myMessage.Replace("`", "<br/>")
            End If
            Dim emailSpilt As String() = myMessage.Split("~")
            Dim style As String = "<div class=""PostMessage"">" + emailSpilt(0) + " : <br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + emailSpilt(1) + "<br/></div>"
            temp.Text = style
            Panel1.Controls.Add(temp)
        ElseIf myMessage.Contains("§") Then
            Dim tempMessage As String() = myMessage.Split("§")
            Dim tempLabel As New Label()
            Dim emailSpilt As String() = tempMessage(0).Split("~")
            Dim style As String = "<div class=""PostMessage"">" + "Your " + emailSpilt(0) + " friend entered a vulgar word. "
            tempLabel.Text = style
            Panel1.Controls.Add(tempLabel)
            Dim btnAllow As New Button()
            btnAllow.Text = "Allow"
            btnAllow.CommandArgument = emailSpilt(0) + "§" + emailSpilt(1)
            AddHandler btnAllow.Click, AddressOf AllowMessage
            Panel1.Controls.Add(btnAllow)
            Dim btnDeny As New Button()
            btnDeny.Text = "Deny"
            btnDeny.CommandArgument = emailSpilt(0) + "§" + emailSpilt(1)
            AddHandler btnDeny.Click, AddressOf DenyMessage
            Panel1.Controls.Add(btnDeny)
            Panel1.Controls.Add(New LiteralControl("</div>"))
        End If
    End Sub
    Private Sub DenyMessage(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim messages As String() = btn.CommandArgument.Split("§")
        MsgBox("Your friend enter vulgar word in : " + messages(1))
        Dim result As MsgBoxResult = MsgBox("Do you want to block this message.", MsgBoxStyle.YesNo, "Conformations")
        If result = MsgBoxResult.Yes Then
            Dim oldMsg As String = messages(0) + "~" + messages(1)
            Dim msg As String = ReteriveMessage(Request.QueryString("name"))
            msg = msg.Replace(oldMsg, "")
            ret = "update userdata set MessageFriends='" + msg + "'" + " where email='" + Request.QueryString("name") + "'"
            Con.Open()
            com = New SqlCommand(ret, Con)
            com.ExecuteReader()
            Con.Close()
            Response.Redirect("userpage.aspx?name=" + Request.QueryString("name"))
        End If
    End Sub
    Private Sub AllowMessage(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim messages As String() = btn.CommandArgument.Split("§")
        MsgBox("Your friend enter vulgar word in : " + messages(1))
        Dim result As MsgBoxResult = MsgBox("Do you want show it in wall.", MsgBoxStyle.YesNo, "Conformations")
        If result = MsgBoxResult.Yes Then
            Dim newMsg As String = messages(0) + "#" + messages(1)
            Dim oldMsg As String = messages(0) + "~" + messages(1)
            Dim msg As String = ReteriveMessage(Request.QueryString("name"))
            msg = msg.Replace(oldMsg, newMsg)
            ret = "update userdata set MessageFriends='" + msg + "'" + " where email='" + Request.QueryString("name") + "'"
            Con.Open()
            com = New SqlCommand(ret, Con)
            com.ExecuteReader()
            Con.Close()
            Response.Redirect("userpage.aspx?name=" + Request.QueryString("name"))
        End If
    End Sub
    Private Sub SplitMessage(ByVal myMessage As String)
        Dim dummy As String() = myMessage.Split("|")
        Dim messages As String() = myMessage.Split("|")
        Dim j As Integer = dummy.Length - 1
        For i As Integer = 0 To dummy.Length - 1 Step 1
            messages(i) = dummy(j)
            j -= 1
        Next
        For Each message As String In messages
            If message <> "" And message <> String.Empty And message.Contains("~") Then
                Dim tempStr As String() = message.Split("~")
                If tempStr(0) <> "Me" And CheckList(tempStr(1)) Then
                    AddControl(message + "§" + tempStr(0))
                Else
                    AddControl(message)
                End If
            ElseIf message.Contains("#") Then
                AddControl(message)
            End If
        Next
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Post()
    End Sub
    Protected Function CheckList(ByVal badword As String) As Boolean
        If badword.Contains(vbCrLf) Then
            badword = badword.Replace(vbCrLf, " ")
        End If
        Dim badwords As String() = badword.Split(" ")
        Dim content As String = ""
        If My.Computer.FileSystem.FileExists(Server.MapPath("Words.txt")) Then
            content = My.Computer.FileSystem.ReadAllText(Server.MapPath("Words.txt"))
        End If
        Dim words As String() = content.Split("|")
        For Each word As String In badwords
            If words.Contains(word) Then
                Return True
            End If
        Next
        Return False
    End Function
    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click
        Session("username") = Label1.Text
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & Request.QueryString("name") & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            read.Read()
            Session("email") = read(2).ToString()
            Session("dob") = read(5).ToString()
            Session("gender") = read(6).ToString()
            Session("mobile") = read(4).ToString()
            Response.Redirect("profile.aspx")
            Con.Close()
        End If
    End Sub
    Protected Sub LinkButton5_Click(sender As Object, e As EventArgs) Handles LinkButton5.Click
        Response.Redirect("friendslist.aspx")
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Session("name") = Request.QueryString("name")
        Response.Redirect("searchfriends.aspx")
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Response.Redirect("chatting.aspx")
    End Sub
End Class