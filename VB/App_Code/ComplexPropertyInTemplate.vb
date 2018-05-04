Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic

Public Class Person

    Private id_Renamed As Integer

    Private name_Renamed As String

    Private address_Renamed As Address

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal address As Address)
        Me.id_Renamed = id
        Me.name_Renamed = name
        Me.address_Renamed = address
    End Sub

    Public ReadOnly Property Id() As Integer
        Get
            Return id_Renamed
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return name_Renamed
        End Get
    End Property
    Public ReadOnly Property Address() As Address
        Get
            Return address_Renamed
        End Get
    End Property

    Public Function SelectData() As List(Of Person)
        Dim persons As New List(Of Person)()
        persons.Add(New Person(0, "John", New Address("Home Lane", "Homesville")))
        persons.Add(New Person(1, "Henry", New Address("436 1st Ave", "Cleveland")))
        Return persons
    End Function
End Class

Public Class Address

    Private street_Renamed As String

    Private city_Renamed As String
    Public Sub New(ByVal street As String, ByVal city As String)
        Me.street_Renamed = street
        Me.city_Renamed = city
    End Sub

    Public ReadOnly Property Street() As String
        Get
            Return street_Renamed
        End Get
    End Property
    Public ReadOnly Property City() As String
        Get
            Return city_Renamed
        End Get
    End Property
End Class