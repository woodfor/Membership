Public Class FrmAllStore
    Private Sub FrmAllStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim storeDs As DataSet = DAL.dalStore.getAllStore
        DataGrid_store.AutoSize = True
        DataGrid_store.DataSource = storeDs.Tables(0)
        DataGrid_store.Show()

    End Sub

    Private Sub DataGrid_store_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_store.CellContentClick

    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        Dim id As String = DataGrid_store.CurrentRow.Cells(0).Value.ToString()
        Dim frm As FrmStore = New FrmStore(id)
        frm.Show()
        Me.Close()
    End Sub
End Class