<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FlatGrid = New FlatMateNextGen.FlatGrid()
        CType(Me.FlatGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlatGrid
        '
        Me.FlatGrid.AllowUserToAddRows = False
        Me.FlatGrid.AllowUserToDeleteRows = False
        Me.FlatGrid.BindingSourceDataSource = Nothing
        Me.FlatGrid.CancellationSource = Nothing
        Me.FlatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlatGrid.HynrSettings = Nothing
        Me.FlatGrid.IsBusy = False
        Me.FlatGrid.Location = New System.Drawing.Point(12, 61)
        Me.FlatGrid.Name = "FlatGrid"
        Me.FlatGrid.SelectedItem = Nothing
        Me.FlatGrid.SelectedItems = Nothing
        Me.FlatGrid.Size = New System.Drawing.Size(307, 315)
        Me.FlatGrid.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 502)
        Me.Controls.Add(Me.FlatGrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FlatGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlatGrid As FlatGrid
End Class
