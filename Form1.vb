Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Suscribirse al evento del menú
        AddHandler UserControl1.ItemSeleccionado, AddressOf CambiarEncabezado
    End Sub

    ' Este método se ejecuta cuando se dispara el evento desde UserControl1
    Private Sub CambiarEncabezado(ByVal imagen As Image, ByVal texto As String)
        UserControl2.ActualizarEncabezado(imagen, texto)
    End Sub


End Class
