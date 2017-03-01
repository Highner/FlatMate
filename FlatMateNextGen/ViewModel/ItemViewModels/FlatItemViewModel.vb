<Serializable>
Public Class FlatItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of FlatData)

    Public Property Name As String
        Get
            Return Data.FlatName
        End Get
        Set(value As String)
            Data.FlatName = value
        End Set
    End Property
End Class