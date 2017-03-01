<Serializable>
Public Class TennantItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of TennantData)

    Public Property Settled As Boolean
        Get
            Return Data.Settled
        End Get
        Set(value As Boolean)
            Data.Settled = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return Data.Name
        End Get
        Set(value As String)
            Data.Name = value
        End Set
    End Property
End Class
