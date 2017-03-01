Public Class FlatIncomeListViewModel
    Inherits HynrFramework.ListViewModelBase(Of FlatIncome, FlatIncomeData, FlatIncomeDataController, FlatIncomeItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim data As New FlatIncomeData
        data.Name = "New income"
        data.Date = Date.Today
        data.Amount = 0
        data.Remarks = ""
        data.FlatID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New FlatIncomeDataController(parentid))
        Me.ParentID = parentid
    End Sub



    Private ParentID As Integer
End Class
