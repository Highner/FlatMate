Public Class TennantListViewModel
    Inherits HynrFramework.ListViewModelBase(Of Tennant, TennantData, TennantDataController, TennantItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim data As New TennantData
        data.Name = "New tennant"
        data.Settled = False
        data.FlatID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New TennantDataController(parentid))
        Me.ParentID = parentid
    End Sub



    Private ParentID As Integer
End Class
