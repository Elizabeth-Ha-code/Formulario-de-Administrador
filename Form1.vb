Public Class Form1

    ' --- Instancias de los UserControls de contenido ---
    Private ucGestionar As New UserControlContenidoGestionarCatálogo1()
    Private ucPrestamo As New UserControlContenidoPrestamo1()
    Private ucReportes As New UserControlContenidoReportes1()
    Private ucSolicitud As New UserControlContenidoSolicitudDeLibro1()
    Private ucConsulta As New UserControlContenidoConsultas1()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conecta el evento del menú de navegación (UserControlNavegacion)
        AddHandler UserControlNavegacion1.ItemSeleccionado, AddressOf Navegacion_Click

        ' (Opcional) Muestra un mensaje inicial o pantalla vacía
        SplitContainer2.Panel2.Controls.Add(New Label With {
            .Text = "Seleccione una opción del menú.",
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 14, FontStyle.Italic),
            .ForeColor = Color.Gray,
            .TextAlign = ContentAlignment.MiddleCenter
        })
    End Sub

    ' --- Este método se ejecuta cuando se hace clic en un ítem del menú ---
    Private Sub Navegacion_Click(imagen As Image, texto As String)
        ' Actualiza encabezado
        UserControlEncabezado1.ActualizarEncabezado(imagen, texto)

        ' Carga el contenido adecuado
        MostrarUserControl(texto)
    End Sub

    ' --- Muestra el UserControl adecuado en Panel2 ---
    Private Sub MostrarUserControl(nombre As String)
        SplitContainer2.Panel2.Controls.Clear()

        Select Case nombre
            Case "Gestión de Catálogo"
                SplitContainer2.Panel2.Controls.Add(ucGestionar)
            Case "Préstamos"
                SplitContainer2.Panel2.Controls.Add(ucPrestamo)
            Case "Reportes"
                SplitContainer2.Panel2.Controls.Add(ucReportes)
            Case "Solicitud de Libro"
                SplitContainer2.Panel2.Controls.Add(ucSolicitud)
            Case "Consultas"
                SplitContainer2.Panel2.Controls.Add(ucConsulta)
            Case Else
                SplitContainer2.Panel2.Controls.Add(New Label With {
                    .Text = "Vista no disponible.",
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleCenter
                })
        End Select

        ' Asegura que el control agregado se ajuste al panel
        If SplitContainer2.Panel2.Controls.Count > 0 Then
            SplitContainer2.Panel2.Controls(0).Dock = DockStyle.Fill
        End If
    End Sub

End Class

