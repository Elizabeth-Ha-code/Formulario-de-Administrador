Public Class UserControlNavegacion
    ' --- Declaramos un evento público ---
    Public Event ItemSeleccionado(ByVal imagen As Image, ByVal texto As String)

    ' --- Método único para todos los ToolStripMenuItem ---
    Private Sub MenuStripMenuNavegacion_Click(sender As Object, e As EventArgs) _
        Handles btn_NavInicioToolStripMenuItem.Click,
                btn_NavLIBROSToolStripMenuItem.Click,
                btn_NavPRESTAMOSToolStripMenuItem.Click,
                btn_NavMENSAJERÍAToolStripMenuItem.Click,
                btn_NavCLIENTESToolStripMenuItem.Click,
                btn_NavVISTASToolStripMenuItem.Click,
                btn_NavREPORTESToolStripMenuItem.Click,
                btn_NavSOLICITUDToolStripMenuItem.Click,
                btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Click,
                btn_NavCONSULTASToolStripMenuItem.Click

        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        ' Según el nombre del ítem o Tag, se asigna imagen y texto
        Select Case item.Name
            Case "btn_NavInicioToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoInicio, "Inicio")
            Case "btn_NavLIBROSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoLibros, "Libros")
            Case "btn_NavPRESTAMOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoPrestamos, "Préstamos")
            Case "btn_NavMENSAJERÍAToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icomensajería, "Mensajería")
            Case "btn_NavCLIENTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoClientes, "Clientes")
            Case "btn_NavVISTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoVista, "Vistas")
            Case "btn_NavREPORTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoReportes, "Reportes")
            Case "btn_NavSOLICITUDToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoSolicitud, "Solicitud")
            Case "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoGestionarCatálogo, "Gestión de catálogos")
            Case "btn_NavCONSULTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.icoPreguntas, "Consultas")
        End Select

    End Sub

End Class
