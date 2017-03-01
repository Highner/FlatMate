Public Class PaymentListViewModel
    Inherits HynrFramework.ListViewModelBase(Of Payment, PaymentData, PaymentDataController, PaymentItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim data As New PaymentData
        data.Amount = 0
        data.PaymentDate = Date.Today
        data.TennantID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New PaymentDataController(parentid))
        Me.ParentID = parentid
    End Sub

    Private ParentID As Integer
End Class
