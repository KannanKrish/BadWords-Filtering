Public Class Chatting
    Inherits System.Web.UI.Page
    Private mChat As Chat = Chat.ActiveChats(0)
    Private mChatter As Chatter = Chatter.ActiveChatters(New Guid("CD863C27-2CEE-45fd-A2E0-A69E62B816B9"))
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        UpdateChatterList()
        UpdateChatMessageList()
    End Sub
    Private Sub UpdateChatMessageList()
        ChatMessageList.DataSource = mChat.Messages
        ChatMessageList.DataBind()
    End Sub
    Private Sub UpdateChatterList()
        ChattersBulletedList.DataSource = mChat.Chatters
        ChattersBulletedList.DataTextField = "Name"
        ChattersBulletedList.DataBind()
    End Sub
    Protected Sub SendButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Not String.IsNullOrEmpty(NewMessageTextBox.Text) Then
            If Not CheckList(NewMessageTextBox.Text) Then
JumpPoint:
                Dim messageSent As String = mChat.SendMessage(mChatter, NewMessageTextBox.Text)
                NewMessageTextBox.Text = ""
            Else
                Dim temp As MsgBoxResult = MsgBox("Your friend entered a vulgar word. You want allow this", MsgBoxStyle.YesNo, "Warning")
                If (temp = MsgBoxResult.Yes) Then
                    GoTo JumpPoint
                Else
                    NewMessageTextBox.Text = ""
                End If
            End If
        End If
        UpdateChatterList()
        UpdateChatMessageList()
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
End Class