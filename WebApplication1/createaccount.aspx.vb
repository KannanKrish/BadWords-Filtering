Imports System.Data.SqlClient
Public Class Createaccount
    Inherits System.Web.UI.Page
    Dim loc As String
    Public Con As SqlConnection
    Dim com As SqlCommand
    Dim path As String = Server.MapPath("~\")
    Public Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles signup.Click
        Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + "userdata.mdf;Integrated Security=True")
        If firstname.Text <> "" And emailid.Text <> "" And password.Text = cpassword.Text And mobileno.Text <> "" And dob.Text <> "" Then
            Con.Open()
            loc = "INSERT INTO userdata (fname,lname,email,password,mobileno,dob,sex)VALUES('" & firstname.Text & "', '" & lastname.Text & "','" & emailid.Text & "','" & password.Text & "','" & mobileno.Text & "','" & dob.Text & "','" & DropDownList1.Text & "')"
            com = New SqlCommand(loc, Con)
            com.ExecuteNonQuery()
            Con.Close()
            Session("dob") = dob.Text
            Response.Redirect("login.aspx")
        Else
            MsgBox("Please Enter all the Details")
        End If
    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancel.Click
        Response.Redirect("login.aspx")
    End Sub
End Class