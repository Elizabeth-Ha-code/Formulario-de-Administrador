Public Class UserControlContenidoReportes1
    ' Cambia el texto del Label1 por el título  de la pestaña seleccionada
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        lblTituloTabControl.Text = TabControl1.SelectedTab.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub lblTituloTabControl_Click(sender As Object, e As EventArgs) Handles lblTituloTabControl.Click

    End Sub
End Class
