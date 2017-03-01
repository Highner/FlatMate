Imports System.ComponentModel

<Serializable>
Public Class RunningCostItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of RunningCostData)

    Public Property Name As String
        Get
            Return Data.Name
        End Get
        Set(value As String)
            Data.Name = value
        End Set
    End Property

    Public Property Amount As Decimal
        Get
            Return Data.Amount
        End Get
        Set(value As Decimal)
            Data.Amount = value
        End Set
    End Property

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
End Class
