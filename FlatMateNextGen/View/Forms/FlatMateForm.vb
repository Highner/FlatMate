Public Class FlatMateForm
#Region "Properties"
    Private MainViewModel As New FlatMateMainVM
#End Region

#Region "Methods"
    Private Sub FlatMateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelStrip.BindToListViewModel(MainViewModel.FlatVM, "Header")

        FlatGrid.BindToListViewModel(MainViewModel.FlatVM)
        RoomGrid.BindToListViewModel(MainViewModel, "RoomVM")
        RentGrid.BindToListViewModel(MainViewModel, "RentVM")
        RunningCostGrid.BindToListViewModel(MainViewModel, "RunningCostVM")
        FlatIncomeGrid.BindToListViewModel(MainViewModel, "FlatIncomeVM")
        TennantGrid.BindToListViewModel(MainViewModel, "TennantVM")
        ContractGrid.BindToListViewModel(MainViewModel, "ContractVM")
        RentedRoomGrid.BindToListViewModel(MainViewModel, "RentedRoomVM")
        SharedRunningCostGrid.BindToListViewModel(MainViewModel, "SharedRunningCostVM")
        MainViewModel.GetData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
    End Sub
#End Region
End Class