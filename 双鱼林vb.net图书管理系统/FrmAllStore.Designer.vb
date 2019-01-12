<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGrid_store = New System.Windows.Forms.DataGridView()
        Me.Button_edit = New System.Windows.Forms.Button()
        CType(Me.DataGrid_store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid_store
        '
        Me.DataGrid_store.AllowUserToAddRows = False
        Me.DataGrid_store.AllowUserToDeleteRows = False
        Me.DataGrid_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_store.Location = New System.Drawing.Point(82, 69)
        Me.DataGrid_store.MultiSelect = False
        Me.DataGrid_store.Name = "DataGrid_store"
        Me.DataGrid_store.ReadOnly = True
        Me.DataGrid_store.RowTemplate.Height = 27
        Me.DataGrid_store.Size = New System.Drawing.Size(507, 240)
        Me.DataGrid_store.TabIndex = 0
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(233, 356)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(176, 44)
        Me.Button_edit.TabIndex = 1
        Me.Button_edit.Text = "修改"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'FrmAllStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(681, 450)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.DataGrid_store)
        Me.Name = "FrmAllStore"
        Me.Text = "所有店面"
        CType(Me.DataGrid_store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid_store As DataGridView
    Friend WithEvents Button_edit As Button
End Class
