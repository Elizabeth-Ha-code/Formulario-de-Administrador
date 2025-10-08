'FOMULARIO DE CONTENIDO
Public Class UserControlContenidoReportes
    ' Cambia el texto del Label1 por el título  de la pestaña seleccionada
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Label1.Text = TabControl1.SelectedTab.Text
    End Sub


    Private tamañoOriginal As Single
    Private tamañoOriginalPanel As Size
    ' Guardamos tamaño original de la fuente
    ' Guardamos tamaño original del panel donde está el Label
    ' Suscribirse al evento Resize del panel contenedor
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tamañoOriginal = Label1.Font.Size

        tamañoOriginalPanel = Label1.Parent.ClientSize


        AddHandler Label1.Parent.Resize, AddressOf AjustarLabel
    End Sub
    ' Calculamos el factor de escalado basado en el ancho del panel

    Private Sub AjustarLabel(sender As Object, e As EventArgs)

        Dim factorAncho As Single = Label1.Parent.ClientSize.Width / tamañoOriginalPanel.Width
        Dim factorAlto As Single = Label1.Parent.ClientSize.Height / tamañoOriginalPanel.Height

        Dim factor As Single = Math.Min(factorAncho, factorAlto)

        Label1.Font = New Font(Label1.Font.FontFamily, Math.Max(6, tamañoOriginal * factor), Label1.Font.Style)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class



