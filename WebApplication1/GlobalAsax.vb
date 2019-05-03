Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        Dim chatters As List(Of Chatter) = New List(Of Chatter)
        chatters.Add(New Chatter(New Guid("CD863C27-2CEE-45fd-A2E0-A69E62B816B9"), "Me"))
        chatters.Add(New Chatter(Guid.NewGuid, "Juan"))
        chatters.Add(New Chatter(Guid.NewGuid, "Joe"))
        chatters.Add(New Chatter(Guid.NewGuid, "Eric"))
        chatters.Add(New Chatter(Guid.NewGuid, "Brian"))
        chatters.Add(New Chatter(Guid.NewGuid, "Kim"))
        chatters.Add(New Chatter(Guid.NewGuid, "Victor"))
        Application.Add("Chatters", chatters)
        Dim chats As List(Of Chat) = New List(Of Chat)
        chats.Add(New Chat)
        Application.Add("Chats", chats)
        For Each c As KeyValuePair(Of Guid, Chatter) In Chatter.ActiveChatters
            c.Value.Join(Chat.ActiveChats(0))
        Next
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class