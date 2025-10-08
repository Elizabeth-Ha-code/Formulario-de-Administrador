Public Class UserControlEncabezado

    Public Sub ActualizarEncabezado(ByVal nuevaImagen As Image, ByVal nuevoTexto As String)
        PictureBox2.Image = nuevaImagen
        lblTituloEncabezadoMenu.Text = nuevoTexto
    End Sub

    Private Sub UserControlEncabezado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
