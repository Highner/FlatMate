Public Class FlatMateMainVM
    Inherits HynrFramework.MainViewModelBase


    Public WithEvents FlatVM As New FlatListViewModel
    Public WithEvents RoomVM As New RoomListViewModel(0)
    Public WithEvents RentVM As New RentListViewModel(0)
    Public WithEvents RunningCostVM As New RunningCostListViewModel(0)
    Public WithEvents FlatIncomeVM As New FlatIncomeListViewModel(0)
    Public WithEvents TennantVM As New TennantListViewModel(0)
    Public WithEvents ContractVM As New ContractListViewModel(0)
    Public WithEvents RentedRoomVM As New RentedRoomListViewModel(0)
    Public WithEvents SharedRunningCostVM As New SharedRunningCostListViewModel(0)


    Private Sub LoadFlatChildren() Handles FlatVM.SelectedItemChanged
        RunningCostVM = New RunningCostListViewModel(FlatVM.SelectedItemID)
        RunningCostVM.GetData()
        RoomVM = New RoomListViewModel(FlatVM.SelectedItemID)
        RoomVM.GetData()
        RentVM = New RentListViewModel(FlatVM.SelectedItemID)
        RentVM.GetData()
        FlatIncomeVM = New FlatIncomeListViewModel(FlatVM.SelectedItemID)
        FlatIncomeVM.GetData()
        TennantVM = New TennantListViewModel(FlatVM.SelectedItemID)
        TennantVM.GetData()
        RaiseLoadingCompleted()
    End Sub

    Private Sub LoadTennantChildren() Handles TennantVM.SelectedItemChanged
        ContractVM = New ContractListViewModel(TennantVM.SelectedItemID)
        ContractVM.GetData()
        RaiseLoadingCompleted()
    End Sub

    Private Sub LoadContractChildren() Handles ContractVM.SelectedItemChanged
        RentedRoomVM = New RentedRoomListViewModel(ContractVM.SelectedItemID)
        RentedRoomVM.GetData()
        SharedRunningCostVM = New SharedRunningCostListViewModel(ContractVM.SelectedItemID)
        SharedRunningCostVM.GetData()
        RaiseLoadingCompleted()
    End Sub


    Protected Overrides Sub _GetData()
        FlatVM.GetData()
    End Sub

End Class
