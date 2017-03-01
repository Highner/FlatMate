<Serializable>
Public Class RoomItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of RoomData)

    Public Property Name() As String
        Get
            Return Data.Name
        End Get
        Set(ByVal value As String)
            Data.Name = value
        End Set
    End Property

    Public Property Size() As Decimal
        Get
            Return Data.Size
        End Get
        Set(ByVal value As Decimal)
            Data.Size = value
        End Set
    End Property

    Public Property CalculationSize() As Decimal
        Get
            Return Data.CalculationSize
        End Get
        Set(ByVal value As Decimal)
            Data.CalculationSize = value
        End Set
    End Property
End Class
