Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Web
Public Class Chat
    Private ReadOnly mId As Guid
    Private ReadOnly mMessages As List(Of String) = New List(Of String)
    Private mChatters As List(Of Chatter) = New List(Of Chatter)
    Public Sub New()
        MyBase.New()
        mId = Guid.NewGuid
    End Sub
    Public ReadOnly Property Id() As Guid
        Get
            Return mId
        End Get
    End Property
    Public ReadOnly Property Messages() As List(Of String)
        Get
            Return mMessages
        End Get
    End Property
    Public Property Chatters() As List(Of Chatter)
        Get
            Return mChatters
        End Get
        Set(ByVal value As List(Of Chatter))
            mChatters = value
        End Set
    End Property
    Public Shared Function ActiveChats() As ReadOnlyCollection(Of Chat)
        If (Not (HttpContext.Current.Application("Chats")) Is Nothing) Then
            Dim chats As List(Of Chat) = CType(HttpContext.Current.Application("Chats"), List(Of Chat))
            Return New ReadOnlyCollection(Of Chat)(chats)
        Else
            Return New ReadOnlyCollection(Of Chat)(New List(Of Chat))
        End If
    End Function
    Public Function SendMessage(ByVal chatter As Chatter, ByVal message As String) As String
        Dim messageMask As String = "{0} @ {1} : {2}"
        message = String.Format(messageMask, chatter.Name, DateTime.Now.ToString, message)
        mMessages.Add(message)
        Return message
    End Function
End Class