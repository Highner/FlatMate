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

Partial Public Class Rent
    Public Property RentID As Integer
    Public Property FlatID As Nullable(Of Integer)
    Public Property ValidFrom As Nullable(Of Date)
    Public Property ValidTo As Nullable(Of Date)
    Public Property Amount As Nullable(Of Decimal)

    Public Overridable Property Flat As Flat

End Class
