<Serializable>
Public Class SharedRunningCostsItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of RunningCostData)

    Public ReadOnly Property Name As String
        Get
            Return Data.Name
        End Get
    End Property
End Class
