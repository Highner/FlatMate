<Serializable>
Public Class FlatIncomeItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of FlatIncomeData)

    Public Property Name As String
        Get
            Return Data.Name
        End Get
        Set(value As String)
            Data.Name = value
        End Set
    End Property

    Public Property [Date] As Date
        Get
            Return Data.Date
        End Get
        Set(value As Date)
            Data.Date = value
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

    Public Property Remarks As String
        Get
            Return Data.Remarks
        End Get
        Set(value As String)
            Data.Remarks = value
        End Set
    End Property
End Class
