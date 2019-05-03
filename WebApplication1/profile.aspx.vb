Imports System.Data.SqlClient
Public Class WebForm2
    Inherits System.Web.UI.Page
    Public Con As SqlConnection
    Dim com As SqlCommand
    Dim path As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Server.MapPath("~\") + "userdata.mdf;Integrated Security=True"
    Dim ret, out As String
    Private Sub Refresh()
        Panel1.Controls.Clear()
        LinkButton1.Text = Session("username").ToString()
        Label2.Text = Session("email").ToString()
        Label3.Text = Session("dob").ToString()
        Label4.Text = Session("gender").ToString()
        Label5.Text = Session("mobile").ToString()
        FindRequset()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Refresh()
    End Sub
    Private Sub FindRequset()
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & Session("email") & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            read.Read()
            FriendRequestSplitter(read(8).ToString)
            Con.Close()
        End If
    End Sub
    Private Sub FriendRequestSplitter(ByVal totalList As String)
        Dim requests As String() = totalList.Split("|")
        For Each request As String In requests
            If request <> "" Then
                Dim labelDisplay As New Label()
                labelDisplay.Text = "<br/>" + request + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                Panel1.Controls.Add(labelDisplay)
                Dim acceptButton As New Button()
                acceptButton.Text = "Accept Request"
                acceptButton.ID = request
                AddHandler acceptButton.Click, AddressOf AcceptFriendRequest
                Panel1.Controls.Add(acceptButton)
                Dim denyButton As New Button()
                denyButton.Text = "Not Now"
                denyButton.ID = request + "~"
                AddHandler denyButton.Click, AddressOf Deny
                Panel1.Controls.Add(denyButton)
            End If
        Next
    End Sub
    Private Sub RemoveFriends(ByVal email As String, Optional ByVal index As Integer = 7)
        Dim emails As String = ReteriveMessage(index)
        emails = emails.Replace(email, "")
        Update(emails)
    End Sub
    Private Sub AcceptFriendRequest(sender As Object, e As EventArgs)
        Dim accept As Button = CType(sender, Button)
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "update userdata set Friends='" & accept.ID & "|" & ReteriveMessage(7) & "'" & " where email='" & Session("email") & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        com.ExecuteNonQuery()
        Con.Close()
        RemoveFriends(accept.ID, 8)
        MsgBox("Now your friend with " + accept.ID, MsgBoxStyle.Information, "Success")
        Refresh()
    End Sub
    Private Sub Deny(sender As Object, e As EventArgs)
        Dim deny As Button = CType(sender, Button)
        deny.ID = deny.ID.Replace("~", "")
        RemoveFriends(deny.ID, 8)
        Refresh()
    End Sub
    Private Function ReteriveMessage(Optional ByVal index As Integer = 8) As String
        Dim myMessage As String = ""
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & Session("email") & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            read.Read()
            myMessage = read(index).ToString
            Con.Close()
        End If
        Return myMessage
    End Function
    Private Sub Update(emails As String)
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "update userdata set RequestFriends='" & emails & "'" & " where email='" & Session("email") & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        com.ExecuteNonQuery()
        Con.Close()
    End Sub
    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("userpage.aspx?name=" + Session("email"))
    End Sub
End Class