Imports System.Data.SqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page
    Public Con As SqlConnection
    Dim com As SqlCommand
    Dim path As String = Server.MapPath("~\")
    Dim ret As String
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("createaccount.aspx")
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        ret = "select * from userdata where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        Con.Open()
        com = New SqlCommand(ret, Con)
        Dim read As SqlDataReader = com.ExecuteReader()
        If read.HasRows Then
            Response.Redirect("userpage.aspx?name=" + TextBox1.Text)
            Con.Close()
        Else
            MsgBox("Please Enter Correct Data")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
End Class