'------------------------------------------------------------------------------
' <auto-generated>
'     Der Code wurde von einer Vorlage generiert.
'
'     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
'     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Flat
    Public Property FlatID As Integer
    Public Property FlatName As String

    Public Overridable Property FlatIncomes As ICollection(Of FlatIncome) = New HashSet(Of FlatIncome)
    Public Overridable Property Rents As ICollection(Of Rent) = New HashSet(Of Rent)
    Public Overridable Property Rooms As ICollection(Of Room) = New HashSet(Of Room)
    Public Overridable Property RunningCosts As ICollection(Of RunningCost) = New HashSet(Of RunningCost)
    Public Overridable Property Tennants As ICollection(Of Tennant) = New HashSet(Of Tennant)

End Class
