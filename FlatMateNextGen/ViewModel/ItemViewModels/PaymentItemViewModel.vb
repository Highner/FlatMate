Imports System.ComponentModel

<Serializable>
Public Class PaymentItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of PaymentData)

    Public Property Amount As Decimal
        Get
            Return Data.Amount
        End Get
        Set(value As Decimal)
            Data.Amount = value
        End Set
    End Property

    <DisplayName("Payment Date")>
    Public Property PaymentDate As Date
        Get
            Return Data.PaymentDate
        End Get
        Set(value As Date)
            Data.PaymentDate = value
        End Set
    End Property
End Class
