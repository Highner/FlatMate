Imports System.ComponentModel

<Serializable>
Public Class RentItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of RentData)

    Public Property Amount As Decimal
        Get
            Return Data.Amount
        End Get
        Set(value As Decimal)
            Data.Amount = value
        End Set
    End Property

    <DisplayName("Valid From")>
    Public Property ValidFrom As Date
        Get
            Return Data.ValidFrom
        End Get
        Set(value As Date)
            Data.ValidFrom = value
        End Set
    End Property

    <DisplayName("Valid To")>
    Public Property ValidTo As Date
        Get
            Return Data.ValidTo
        End Get
        Set(value As Date)
            Data.ValidTo = value
        End Set
    End Property

End Class
