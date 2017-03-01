Public Class ContractListViewModel
    Inherits HynrFramework.ListViewModelBase(Of Contract, ContractData, ContractDataController, ContractItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim data As New ContractData
        data.FixedRent = False
        data.ValidTo = Date.Today
        data.ValidFrom = Date.Today
        data.Settled = False
        data.FixedRentAmount = 0
        data.RentModifier = 1
        data.TennantID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New ContractDataController(parentid))
        Me.ParentID = parentid
    End Sub

    Private ParentID As Integer
End Class
