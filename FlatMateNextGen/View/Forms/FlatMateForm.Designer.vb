<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlatMateForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlatMateForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerLeft = New System.Windows.Forms.SplitContainer()
        Me.FlatGrid = New FlatMateNextGen.FlatGrid()
        Me.TennantGrid = New FlatMateNextGen.TennantGrid()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.FlatDetailsTabPage = New System.Windows.Forms.TabPage()
        Me.TabControlDetails = New System.Windows.Forms.TabControl()
        Me.RoomsTabPage = New System.Windows.Forms.TabPage()
        Me.RoomGrid = New FlatMateNextGen.RoomGrid()
        Me.RentTabPage = New System.Windows.Forms.TabPage()
        Me.RentGrid = New FlatMateNextGen.RentGrid()
        Me.RunningCostsTabPage = New System.Windows.Forms.TabPage()
        Me.RunningCostGrid = New FlatMateNextGen.RunningCostGrid()
        Me.IncomeTabPage = New System.Windows.Forms.TabPage()
        Me.FlatIncomeGrid = New FlatMateNextGen.FlatIncomeGrid()
        Me.RentOverviewTabPage = New System.Windows.Forms.TabPage()
        Me.ChartTabPage = New System.Windows.Forms.TabPage()
        Me.TennantsTabPage = New System.Windows.Forms.TabPage()
        Me.TabControlTennants = New System.Windows.Forms.TabControl()
        Me.ContractsTabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainerContracts = New System.Windows.Forms.SplitContainer()
        Me.ContractGrid = New FlatMateNextGen.ContractGrid()
        Me.SplitContainerContractDetails = New System.Windows.Forms.SplitContainer()
        Me.RentedRoomGrid = New FlatMateNextGen.RentedRoomGrid()
        Me.PaymentsTabPage = New System.Windows.Forms.TabPage()
        Me.TennantRentTabPage = New System.Windows.Forms.TabPage()
        Me.LabelStrip = New HynrFramework.HynrLabelStrip()
        Me.SharedRunningCostGrid = New FlatMateNextGen.SharedRunningCostGrid()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        CType(Me.SplitContainerLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerLeft.Panel1.SuspendLayout()
        Me.SplitContainerLeft.Panel2.SuspendLayout()
        Me.SplitContainerLeft.SuspendLayout()
        CType(Me.FlatGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TennantGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlMain.SuspendLayout()
        Me.FlatDetailsTabPage.SuspendLayout()
        Me.TabControlDetails.SuspendLayout()
        Me.RoomsTabPage.SuspendLayout()
        CType(Me.RoomGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentTabPage.SuspendLayout()
        CType(Me.RentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RunningCostsTabPage.SuspendLayout()
        CType(Me.RunningCostGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IncomeTabPage.SuspendLayout()
        CType(Me.FlatIncomeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TennantsTabPage.SuspendLayout()
        Me.TabControlTennants.SuspendLayout()
        Me.ContractsTabPage.SuspendLayout()
        CType(Me.SplitContainerContracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerContracts.Panel1.SuspendLayout()
        Me.SplitContainerContracts.Panel2.SuspendLayout()
        Me.SplitContainerContracts.SuspendLayout()
        CType(Me.ContractGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerContractDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerContractDetails.Panel1.SuspendLayout()
        Me.SplitContainerContractDetails.Panel2.SuspendLayout()
        Me.SplitContainerContractDetails.SuspendLayout()
        CType(Me.RentedRoomGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharedRunningCostGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1069, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerMain.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.SplitContainerLeft)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.TabControlMain)
        Me.SplitContainerMain.Size = New System.Drawing.Size(1069, 527)
        Me.SplitContainerMain.SplitterDistance = 158
        Me.SplitContainerMain.TabIndex = 3
        '
        'SplitContainerLeft
        '
        Me.SplitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerLeft.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerLeft.Name = "SplitContainerLeft"
        Me.SplitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerLeft.Panel1
        '
        Me.SplitContainerLeft.Panel1.Controls.Add(Me.FlatGrid)
        '
        'SplitContainerLeft.Panel2
        '
        Me.SplitContainerLeft.Panel2.Controls.Add(Me.TennantGrid)
        Me.SplitContainerLeft.Size = New System.Drawing.Size(158, 527)
        Me.SplitContainerLeft.SplitterDistance = 178
        Me.SplitContainerLeft.TabIndex = 3
        '
        'FlatGrid
        '
        Me.FlatGrid.AllowUserToAddRows = False
        Me.FlatGrid.AllowUserToDeleteRows = False
        Me.FlatGrid.BindingSourceDataSource = Nothing
        Me.FlatGrid.CancellationSource = Nothing
        Me.FlatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlatGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatGrid.HynrSettings = Nothing
        Me.FlatGrid.IsBusy = False
        Me.FlatGrid.Location = New System.Drawing.Point(0, 0)
        Me.FlatGrid.Name = "FlatGrid"
        Me.FlatGrid.SelectedItem = Nothing
        Me.FlatGrid.SelectedItems = Nothing
        Me.FlatGrid.Size = New System.Drawing.Size(158, 178)
        Me.FlatGrid.TabIndex = 2
        '
        'TennantGrid
        '
        Me.TennantGrid.AllowUserToAddRows = False
        Me.TennantGrid.AllowUserToDeleteRows = False
        Me.TennantGrid.BindingSourceDataSource = Nothing
        Me.TennantGrid.CancellationSource = Nothing
        Me.TennantGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TennantGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TennantGrid.HynrSettings = Nothing
        Me.TennantGrid.IsBusy = False
        Me.TennantGrid.Location = New System.Drawing.Point(0, 0)
        Me.TennantGrid.Name = "TennantGrid"
        Me.TennantGrid.SelectedItem = Nothing
        Me.TennantGrid.SelectedItems = Nothing
        Me.TennantGrid.Size = New System.Drawing.Size(158, 345)
        Me.TennantGrid.TabIndex = 0
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.FlatDetailsTabPage)
        Me.TabControlMain.Controls.Add(Me.TennantsTabPage)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 0)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(907, 527)
        Me.TabControlMain.TabIndex = 0
        '
        'FlatDetailsTabPage
        '
        Me.FlatDetailsTabPage.Controls.Add(Me.TabControlDetails)
        Me.FlatDetailsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.FlatDetailsTabPage.Name = "FlatDetailsTabPage"
        Me.FlatDetailsTabPage.Size = New System.Drawing.Size(899, 501)
        Me.FlatDetailsTabPage.TabIndex = 0
        Me.FlatDetailsTabPage.Text = "Flat Details"
        Me.FlatDetailsTabPage.UseVisualStyleBackColor = True
        '
        'TabControlDetails
        '
        Me.TabControlDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlDetails.Controls.Add(Me.RoomsTabPage)
        Me.TabControlDetails.Controls.Add(Me.RentTabPage)
        Me.TabControlDetails.Controls.Add(Me.RunningCostsTabPage)
        Me.TabControlDetails.Controls.Add(Me.IncomeTabPage)
        Me.TabControlDetails.Controls.Add(Me.RentOverviewTabPage)
        Me.TabControlDetails.Controls.Add(Me.ChartTabPage)
        Me.TabControlDetails.Location = New System.Drawing.Point(-3, 97)
        Me.TabControlDetails.Name = "TabControlDetails"
        Me.TabControlDetails.SelectedIndex = 0
        Me.TabControlDetails.Size = New System.Drawing.Size(906, 411)
        Me.TabControlDetails.TabIndex = 0
        '
        'RoomsTabPage
        '
        Me.RoomsTabPage.Controls.Add(Me.RoomGrid)
        Me.RoomsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.RoomsTabPage.Name = "RoomsTabPage"
        Me.RoomsTabPage.Size = New System.Drawing.Size(898, 385)
        Me.RoomsTabPage.TabIndex = 0
        Me.RoomsTabPage.Text = "Rooms"
        Me.RoomsTabPage.UseVisualStyleBackColor = True
        '
        'RoomGrid
        '
        Me.RoomGrid.AllowUserToAddRows = False
        Me.RoomGrid.AllowUserToDeleteRows = False
        Me.RoomGrid.BindingSourceDataSource = Nothing
        Me.RoomGrid.CancellationSource = Nothing
        Me.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomGrid.HynrSettings = Nothing
        Me.RoomGrid.IsBusy = False
        Me.RoomGrid.Location = New System.Drawing.Point(0, 0)
        Me.RoomGrid.Name = "RoomGrid"
        Me.RoomGrid.SelectedItem = Nothing
        Me.RoomGrid.SelectedItems = Nothing
        Me.RoomGrid.Size = New System.Drawing.Size(898, 385)
        Me.RoomGrid.TabIndex = 0
        '
        'RentTabPage
        '
        Me.RentTabPage.Controls.Add(Me.RentGrid)
        Me.RentTabPage.Location = New System.Drawing.Point(4, 22)
        Me.RentTabPage.Name = "RentTabPage"
        Me.RentTabPage.Size = New System.Drawing.Size(898, 385)
        Me.RentTabPage.TabIndex = 1
        Me.RentTabPage.Text = "Rent"
        Me.RentTabPage.UseVisualStyleBackColor = True
        '
        'RentGrid
        '
        Me.RentGrid.AllowUserToAddRows = False
        Me.RentGrid.AllowUserToDeleteRows = False
        Me.RentGrid.BindingSourceDataSource = Nothing
        Me.RentGrid.CancellationSource = Nothing
        Me.RentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentGrid.HynrSettings = Nothing
        Me.RentGrid.IsBusy = False
        Me.RentGrid.Location = New System.Drawing.Point(0, 0)
        Me.RentGrid.Name = "RentGrid"
        Me.RentGrid.SelectedItem = Nothing
        Me.RentGrid.SelectedItems = Nothing
        Me.RentGrid.Size = New System.Drawing.Size(898, 385)
        Me.RentGrid.TabIndex = 0
        '
        'RunningCostsTabPage
        '
        Me.RunningCostsTabPage.Controls.Add(Me.RunningCostGrid)
        Me.RunningCostsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.RunningCostsTabPage.Name = "RunningCostsTabPage"
        Me.RunningCostsTabPage.Size = New System.Drawing.Size(898, 385)
        Me.RunningCostsTabPage.TabIndex = 2
        Me.RunningCostsTabPage.Text = "Running Costs"
        Me.RunningCostsTabPage.UseVisualStyleBackColor = True
        '
        'RunningCostGrid
        '
        Me.RunningCostGrid.AllowUserToAddRows = False
        Me.RunningCostGrid.AllowUserToDeleteRows = False
        Me.RunningCostGrid.BindingSourceDataSource = Nothing
        Me.RunningCostGrid.CancellationSource = Nothing
        Me.RunningCostGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RunningCostGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RunningCostGrid.HynrSettings = Nothing
        Me.RunningCostGrid.IsBusy = False
        Me.RunningCostGrid.Location = New System.Drawing.Point(0, 0)
        Me.RunningCostGrid.Name = "RunningCostGrid"
        Me.RunningCostGrid.SelectedItem = Nothing
        Me.RunningCostGrid.SelectedItems = Nothing
        Me.RunningCostGrid.Size = New System.Drawing.Size(898, 385)
        Me.RunningCostGrid.TabIndex = 0
        '
        'IncomeTabPage
        '
        Me.IncomeTabPage.Controls.Add(Me.FlatIncomeGrid)
        Me.IncomeTabPage.Location = New System.Drawing.Point(4, 22)
        Me.IncomeTabPage.Name = "IncomeTabPage"
        Me.IncomeTabPage.Size = New System.Drawing.Size(898, 385)
        Me.IncomeTabPage.TabIndex = 3
        Me.IncomeTabPage.Text = "Income"
        Me.IncomeTabPage.UseVisualStyleBackColor = True
        '
        'FlatIncomeGrid
        '
        Me.FlatIncomeGrid.AllowUserToAddRows = False
        Me.FlatIncomeGrid.AllowUserToDeleteRows = False
        Me.FlatIncomeGrid.BindingSourceDataSource = Nothing
        Me.FlatIncomeGrid.CancellationSource = Nothing
        Me.FlatIncomeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlatIncomeGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatIncomeGrid.HynrSettings = Nothing
        Me.FlatIncomeGrid.IsBusy = False
        Me.FlatIncomeGrid.Location = New System.Drawing.Point(0, 0)
        Me.FlatIncomeGrid.Name = "FlatIncomeGrid"
        Me.FlatIncomeGrid.SelectedItem = Nothing
        Me.FlatIncomeGrid.SelectedItems = Nothing
        Me.FlatIncomeGrid.Size = New System.Drawing.Size(898, 385)
        Me.FlatIncomeGrid.TabIndex = 0
        '
        'RentOverviewTabPage
        '
        Me.RentOverviewTabPage.Location = New System.Drawing.Point(4, 22)
        Me.RentOverviewTabPage.Name = "RentOverviewTabPage"
        Me.RentOverviewTabPage.Size = New System.Drawing.Size(898, 385)
        Me.RentOverviewTabPage.TabIndex = 4
        Me.RentOverviewTabPage.Text = "Rent Overview"
        Me.RentOverviewTabPage.UseVisualStyleBackColor = True
        '
        'ChartTabPage
        '
        Me.ChartTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ChartTabPage.Name = "ChartTabPage"
        Me.ChartTabPage.Size = New System.Drawing.Size(898, 385)
        Me.ChartTabPage.TabIndex = 5
        Me.ChartTabPage.Text = "Chart"
        Me.ChartTabPage.UseVisualStyleBackColor = True
        '
        'TennantsTabPage
        '
        Me.TennantsTabPage.Controls.Add(Me.TabControlTennants)
        Me.TennantsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.TennantsTabPage.Name = "TennantsTabPage"
        Me.TennantsTabPage.Size = New System.Drawing.Size(899, 501)
        Me.TennantsTabPage.TabIndex = 1
        Me.TennantsTabPage.Text = "Flat Tennants"
        Me.TennantsTabPage.UseVisualStyleBackColor = True
        '
        'TabControlTennants
        '
        Me.TabControlTennants.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlTennants.Controls.Add(Me.ContractsTabPage)
        Me.TabControlTennants.Controls.Add(Me.PaymentsTabPage)
        Me.TabControlTennants.Controls.Add(Me.TennantRentTabPage)
        Me.TabControlTennants.Location = New System.Drawing.Point(-3, 136)
        Me.TabControlTennants.Name = "TabControlTennants"
        Me.TabControlTennants.SelectedIndex = 0
        Me.TabControlTennants.Size = New System.Drawing.Size(906, 369)
        Me.TabControlTennants.TabIndex = 0
        '
        'ContractsTabPage
        '
        Me.ContractsTabPage.Controls.Add(Me.SplitContainerContracts)
        Me.ContractsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ContractsTabPage.Name = "ContractsTabPage"
        Me.ContractsTabPage.Size = New System.Drawing.Size(898, 343)
        Me.ContractsTabPage.TabIndex = 1
        Me.ContractsTabPage.Text = "Contracts"
        Me.ContractsTabPage.UseVisualStyleBackColor = True
        '
        'SplitContainerContracts
        '
        Me.SplitContainerContracts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerContracts.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerContracts.Name = "SplitContainerContracts"
        '
        'SplitContainerContracts.Panel1
        '
        Me.SplitContainerContracts.Panel1.Controls.Add(Me.ContractGrid)
        '
        'SplitContainerContracts.Panel2
        '
        Me.SplitContainerContracts.Panel2.Controls.Add(Me.SplitContainerContractDetails)
        Me.SplitContainerContracts.Size = New System.Drawing.Size(898, 343)
        Me.SplitContainerContracts.SplitterDistance = 299
        Me.SplitContainerContracts.TabIndex = 0
        '
        'ContractGrid
        '
        Me.ContractGrid.AllowUserToAddRows = False
        Me.ContractGrid.AllowUserToDeleteRows = False
        Me.ContractGrid.BindingSourceDataSource = Nothing
        Me.ContractGrid.CancellationSource = Nothing
        Me.ContractGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContractGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContractGrid.HynrSettings = Nothing
        Me.ContractGrid.IsBusy = False
        Me.ContractGrid.Location = New System.Drawing.Point(0, 0)
        Me.ContractGrid.Name = "ContractGrid"
        Me.ContractGrid.SelectedItem = Nothing
        Me.ContractGrid.SelectedItems = Nothing
        Me.ContractGrid.Size = New System.Drawing.Size(299, 343)
        Me.ContractGrid.TabIndex = 0
        '
        'SplitContainerContractDetails
        '
        Me.SplitContainerContractDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerContractDetails.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerContractDetails.Name = "SplitContainerContractDetails"
        Me.SplitContainerContractDetails.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerContractDetails.Panel1
        '
        Me.SplitContainerContractDetails.Panel1.Controls.Add(Me.RentedRoomGrid)
        '
        'SplitContainerContractDetails.Panel2
        '
        Me.SplitContainerContractDetails.Panel2.Controls.Add(Me.SharedRunningCostGrid)
        Me.SplitContainerContractDetails.Size = New System.Drawing.Size(595, 343)
        Me.SplitContainerContractDetails.SplitterDistance = 177
        Me.SplitContainerContractDetails.TabIndex = 0
        '
        'RentedRoomGrid
        '
        Me.RentedRoomGrid.AllowUserToAddRows = False
        Me.RentedRoomGrid.AllowUserToDeleteRows = False
        Me.RentedRoomGrid.BindingSourceDataSource = Nothing
        Me.RentedRoomGrid.CancellationSource = Nothing
        Me.RentedRoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentedRoomGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentedRoomGrid.HynrSettings = Nothing
        Me.RentedRoomGrid.IsBusy = False
        Me.RentedRoomGrid.Location = New System.Drawing.Point(0, 0)
        Me.RentedRoomGrid.Name = "RentedRoomGrid"
        Me.RentedRoomGrid.SelectedItem = Nothing
        Me.RentedRoomGrid.SelectedItems = Nothing
        Me.RentedRoomGrid.Size = New System.Drawing.Size(595, 177)
        Me.RentedRoomGrid.TabIndex = 0
        '
        'PaymentsTabPage
        '
        Me.PaymentsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PaymentsTabPage.Name = "PaymentsTabPage"
        Me.PaymentsTabPage.Size = New System.Drawing.Size(898, 343)
        Me.PaymentsTabPage.TabIndex = 0
        Me.PaymentsTabPage.Text = "Payments"
        Me.PaymentsTabPage.UseVisualStyleBackColor = True
        '
        'TennantRentTabPage
        '
        Me.TennantRentTabPage.Location = New System.Drawing.Point(4, 22)
        Me.TennantRentTabPage.Name = "TennantRentTabPage"
        Me.TennantRentTabPage.Size = New System.Drawing.Size(898, 343)
        Me.TennantRentTabPage.TabIndex = 2
        Me.TennantRentTabPage.Text = "Rent"
        Me.TennantRentTabPage.UseVisualStyleBackColor = True
        '
        'LabelStrip
        '
        Me.LabelStrip.HynrSettings = Nothing
        Me.LabelStrip.LabelText = ""
        Me.LabelStrip.Location = New System.Drawing.Point(0, 25)
        Me.LabelStrip.Name = "LabelStrip"
        Me.LabelStrip.Size = New System.Drawing.Size(1069, 25)
        Me.LabelStrip.TabIndex = 1
        Me.LabelStrip.Text = "HynrLabelStrip1"
        '
        'SharedRunningCostGrid
        '
        Me.SharedRunningCostGrid.AllowUserToAddRows = False
        Me.SharedRunningCostGrid.AllowUserToDeleteRows = False
        Me.SharedRunningCostGrid.BindingSourceDataSource = Nothing
        Me.SharedRunningCostGrid.CancellationSource = Nothing
        Me.SharedRunningCostGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SharedRunningCostGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SharedRunningCostGrid.HynrSettings = Nothing
        Me.SharedRunningCostGrid.IsBusy = False
        Me.SharedRunningCostGrid.Location = New System.Drawing.Point(0, 0)
        Me.SharedRunningCostGrid.Name = "SharedRunningCostGrid"
        Me.SharedRunningCostGrid.SelectedItem = Nothing
        Me.SharedRunningCostGrid.SelectedItems = CType(resources.GetObject("SharedRunningCostGrid.SelectedItems"), System.Collections.Generic.List(Of FlatMateNextGen.SharedRunningCostsItemViewModel))
        Me.SharedRunningCostGrid.Size = New System.Drawing.Size(595, 162)
        Me.SharedRunningCostGrid.TabIndex = 0
        '
        'FlatMateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 577)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Controls.Add(Me.LabelStrip)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FlatMateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flatmate"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        Me.SplitContainerLeft.Panel1.ResumeLayout(False)
        Me.SplitContainerLeft.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerLeft.ResumeLayout(False)
        CType(Me.FlatGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TennantGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlMain.ResumeLayout(False)
        Me.FlatDetailsTabPage.ResumeLayout(False)
        Me.TabControlDetails.ResumeLayout(False)
        Me.RoomsTabPage.ResumeLayout(False)
        CType(Me.RoomGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentTabPage.ResumeLayout(False)
        CType(Me.RentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RunningCostsTabPage.ResumeLayout(False)
        CType(Me.RunningCostGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IncomeTabPage.ResumeLayout(False)
        CType(Me.FlatIncomeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TennantsTabPage.ResumeLayout(False)
        Me.TabControlTennants.ResumeLayout(False)
        Me.ContractsTabPage.ResumeLayout(False)
        Me.SplitContainerContracts.Panel1.ResumeLayout(False)
        Me.SplitContainerContracts.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerContracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerContracts.ResumeLayout(False)
        CType(Me.ContractGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerContractDetails.Panel1.ResumeLayout(False)
        Me.SplitContainerContractDetails.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerContractDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerContractDetails.ResumeLayout(False)
        CType(Me.RentedRoomGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharedRunningCostGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LabelStrip As HynrFramework.HynrLabelStrip
    Friend WithEvents FlatGrid As FlatGrid
    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents FlatDetailsTabPage As TabPage
    Friend WithEvents TabControlDetails As TabControl
    Friend WithEvents RoomsTabPage As TabPage
    Friend WithEvents RentTabPage As TabPage
    Friend WithEvents RunningCostsTabPage As TabPage
    Friend WithEvents IncomeTabPage As TabPage
    Friend WithEvents RentOverviewTabPage As TabPage
    Friend WithEvents ChartTabPage As TabPage
    Friend WithEvents TennantsTabPage As TabPage
    Friend WithEvents RoomGrid As RoomGrid
    Friend WithEvents RentGrid As RentGrid
    Friend WithEvents RunningCostGrid As RunningCostGrid
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents FlatIncomeGrid As FlatIncomeGrid
    Friend WithEvents TabControlTennants As TabControl
    Friend WithEvents PaymentsTabPage As TabPage
    Friend WithEvents ContractsTabPage As TabPage
    Friend WithEvents TennantGrid As TennantGrid
    Friend WithEvents SplitContainerLeft As SplitContainer
    Friend WithEvents TennantRentTabPage As TabPage
    Friend WithEvents SplitContainerContracts As SplitContainer
    Friend WithEvents ContractGrid As ContractGrid
    Friend WithEvents SplitContainerContractDetails As SplitContainer
    Friend WithEvents RentedRoomGrid As RentedRoomGrid
    Friend WithEvents SharedRunningCostGrid As SharedRunningCostGrid
End Class
