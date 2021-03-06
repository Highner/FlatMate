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

Partial Public Class Contract
    Public Property ContractID As Integer
    Public Property TennantID As Nullable(Of Integer)
    Public Property ValidFrom As Nullable(Of Date)
    Public Property ValidTo As Nullable(Of Date)
    Public Property RentModifier As Nullable(Of Decimal)
    Public Property FixedRent As Nullable(Of Boolean)
    Public Property FixedRentAmount As Nullable(Of Decimal)
    Public Property Settled As Nullable(Of Boolean)

    Public Overridable Property Tennant As Tennant
    Public Overridable Property Rooms As ICollection(Of Room) = New HashSet(Of Room)
    Public Overridable Property RunningCosts As ICollection(Of RunningCost) = New HashSet(Of RunningCost)

End Class
