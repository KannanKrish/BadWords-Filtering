Imports System.Data.SqlClient
Public Class FriendsPage
    Inherits System.Web.UI.Page
    Public Con As SqlConnection
    Dim com As SqlCommand
    Dim path As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Server.MapPath("~\") + "userdata.mdf;Integrated Security=True"
    Dim ret, out As String
    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox(Session("friendEmail"))
        MsgBox(Session("name"))
        Post()
        Dim txt As String = Session("friendEmail")
        ret = "select * from userdata where email='" & txt & "'"
        Con = New SqlConnection(path)
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim tab As New DataTable("userdata")
        Dim read As SqlDataAdapter = New SqlDataAdapter(ret, Con)
        read.Fill(tab)
        lblFriend.Text = tab.Rows(0).Item("fname") + "  " + tab.Rows(0).Item("lname")
        txt = Session("name")
        ret = "select * from userdata where email='" & txt & "'"
        com = New SqlCommand(ret, Con)
        Dim tab1 As New DataTable("userdata")
        Dim read1 As SqlDataAdapter = New SqlDataAdapter(ret, Con)
        read1.Fill(tab1)
        Label1.Text = tab1.Rows(0).Item("fname") + "  " + tab1.Rows(0).Item("lname")
        Con.Close()
    End Sub
    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("userpage.aspx?name=" + Session("name"))
    End Sub
    Protected Sub LinkButton3_Click(sender As Object, e As EventArgs) Handles LinkButton3.Click
        Server.Transfer("login.aspx")
    End Sub
    Protected Sub Post()
        Panel1.Controls.Clear()
        If TextBox1.Text <> "" And Not CheckList(TextBox1.Text) Then
JumpPoint:
            Dim txt As String = Session("name")
            Dim strtemp As String = TextBox1.Text
            If TextBox1.Text.Contains(vbNewLine) Then
                strtemp = TextBox1.Text.Replace(vbNewLine, "~")
            End If
            Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
            ret = "update userdata set MessageFriends='" + Session("name") + "~" + ReteriveMessage() + "|" + strtemp + "'where email='" & txt & "'"
            Con.Close()
            Con.Open()
            com = New SqlCommand(ret, Con)
            com.ExecuteReader()
            Con.Close()
            SplitMessage(ReteriveMessage())
            TextBox1.Text = ""
        ElseIf CheckList(TextBox1.Text) Then
            Dim temp As MsgBoxResult = MsgBox("Your friend entered a vulgar word. You want allow this", MsgBoxStyle.YesNo, "Warning")
            If (temp = MsgBoxResult.Yes) Then
                GoTo JumpPoint
            Else
                TextBox1.Text = ""
            End If
        Else
            Dim txt As String = Session("name")
            Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
            ret = "update userdata set MessageFriends='" + ReteriveMessage() + "'where email='" & txt & "'"
            Con.Close()
            Con.Open()
            com = New SqlCommand(ret, Con)
            com.ExecuteReader()
            Con.Close()
            SplitMessage(ReteriveMessage())
            TextBox1.Text = ""
        End If
    End Sub
    Private Function ReteriveMessage() As String
        Dim myMessage As String = ""
        Dim txt As String = Session("name")
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & txt & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            read.Read()
            myMessage = read(7).ToString
            Con.Close()
        End If
        Return myMessage
    End Function
    Private Sub AddControl(ByVal myMessage As String)
        If myMessage <> "" Then
            Dim temp As New Label()
            If myMessage.Contains("~") Then
                myMessage = myMessage.Replace("~", "<br/>")
            End If
            Dim style As String = "<div class=""PostMessage"">" + myMessage + "<br/></div>"
            temp.Text = style
            Panel1.Controls.Add(temp)
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
            AddControl(message)
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
        Session("name") = lblFriend.Text

        Dim txt As String = Session("name")
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & txt & "'"
        'ret = "select * from userdata where email='" & txt & "' and dob='" & txt1 & "'"
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
    Protected Sub BtnSendRequestClick(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        Con.Open()
        com = New SqlCommand(ret, Con)
    End Sub
End Class