Imports System
Imports System.Collections.Generic
Imports System.Web
Public Class Chatter
    Private ReadOnly mId As Guid
    Private ReadOnly mName As String
    Public Sub New(ByVal id As Guid, ByVal name As String)
        MyBase.New()
        mId = id
        mName = name
    End Sub
    Public ReadOnly Property Id() As Guid
        Get
            Return mId
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return mName
        End Get
    End Property
    Public Shared Function ActiveChatters() As Dictionary(Of Guid, Chatter)
        Dim retval As Dictionary(Of Guid, Chatter) = New Dictionary(Of Guid, Chatter)
        If (Not (HttpContext.Current.Application("Chatters")) Is Nothing) Then
            Dim chatters As List(Of Chatter) = CType(HttpContext.Current.Application("Chatters"), List(Of Chatter))
            For Each chatter As Chatter In chatters
                retval.Add(chatter.Id, chatter)
            Next
        End If
        Return retval
    End Function
    Public Sub Join(ByVal chat As Chat)
        chat.Chatters.Add(Me)
    End Sub
End Class