Imports System.Data.SqlClient
Public Class Searchfriends
    Inherits System.Web.UI.Page
    Public Con As SqlConnection
    Dim com As SqlCommand
    Dim path As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Server.MapPath("~\") + "userdata.mdf;Integrated Security=True"
    Dim ret As String
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddItem()
    End Sub
    Private Sub AddItem()
        Dim out As String = "select * from userdata where fname like'" & TextBox1.Text & "%'"
        DropDownList1.Items.Clear()
        Con = New SqlConnection(path)
        Con.Open()
        Dim read As SqlDataAdapter = New SqlDataAdapter(out, Con)
        Dim tab As New DataTable("userdata")
        read.Fill(tab)
        Dim n As Integer = tab.Rows.Count
        For i As Integer = 0 To n - 1
            DropDownList1.Items.Add(tab.Rows(i).Item("fname") + " " + tab.Rows(i).Item("lname"))
        Next
        If DropDownList1.Items.Count = 0 Then
            MsgBox("No Data.")
            TextBox1.Text = ""
        Else
            DropDownList1.Visible = True
            Button2.Visible = True
        End If
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txt() As String = DropDownList1.Text.Split(" ")
        Con = New SqlConnection(path)
        Con.Open()
        Dim qs As String = "select email from userdata where fname='" & txt(0) & "' and lname='" & txt(1) & "'"
        Dim read As SqlDataAdapter = New SqlDataAdapter(qs, Con)
        Dim tab As New DataTable("userdata")
        read.Fill(tab)
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "update userdata set RequestFriends='" + Session("name") + "|" + ReteriveMessage(tab.Rows(0).Item("email")) + "'" + " where email='" + tab.Rows(0).Item("email") + "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        com.ExecuteNonQuery()
        Con.Close()
        MsgBox("Requset send successfully.", MsgBoxStyle.OkOnly, "Message")
    End Sub
    Private Function ReteriveMessage(ByVal friendEmail As String) As String
        Dim myMessage As String = ""
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & friendEmail & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            read.Read()
            myMessage = read(8).ToString
            If myMessage.Contains(Session("name")) Then
                myMessage = myMessage.Replace(Session("name"), "")
            End If
        End If
        Con.Close()
        Return myMessage
    End Function
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ret = "select * from userdata where email='" & Session("name") & "'"
        Con = New SqlConnection(path)
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim tab As New DataTable("userdata")
        Dim read As SqlDataAdapter = New SqlDataAdapter(ret, Con)
        read.Fill(tab)
        LinkButton1.Text = tab.Rows(0).Item("fname") + "  " + tab.Rows(0).Item("lname")
        Con.Close()
    End Sub
    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("userpage.aspx?name=" + Session("name"))
    End Sub
End Class