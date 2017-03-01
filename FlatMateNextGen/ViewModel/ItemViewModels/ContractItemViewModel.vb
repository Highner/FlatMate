Imports System.ComponentModel

<Serializable>
Public Class ContractItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of ContractData)

    <DisplayName("Valid from")>
    Public Property ValidFrom As Date
        Get
            Return Data.ValidFrom
        End Get
        Set(value As Date)
            Data.ValidFrom = value
        End Set
    End Property

    <DisplayName("Valid to")>
    Public Property ValidTo As Date
        Get
            Return Data.ValidTo
        End Get
        Set(value As Date)
            Data.ValidTo = value
        End Set
    End Property

    Public Property Amount As Decimal
        Get
            If Data.FixedRent Then
                Return Data.FixedRentAmount
            Else
                Return 0
            End If
        End Get
        Set(value As Decimal)
            If Data.FixedRent Then
                Data.FixedRentAmount = value
            End If
        End Set
    End Property

    <DisplayName("Fixed rent")>
    Public Property FixedRent As Boolean
        Get
            Return Data.FixedRent
        End Get
        Set(value As Boolean)
            Data.FixedRent = value
        End Set
    End Property

    <DisplayName("Rent modifier")>
    Public Property RentModifier As Decimal
        Get
            Return Data.RentModifier
        End Get
        Set(value As Decimal)
            Data.RentModifier = value
        End Set
    End Property
End Class
