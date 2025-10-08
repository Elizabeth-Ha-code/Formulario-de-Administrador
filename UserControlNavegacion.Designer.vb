<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlNavegacion
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStripMenuNavegacion = New System.Windows.Forms.MenuStrip()
        Me.btn_NavInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavLIBROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavPRESTAMOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavMENSAJERÍAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavVISTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavREPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavSOLICITUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_NavCONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripMenuNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMenuNavegacion
        '
        Me.MenuStripMenuNavegacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MenuStripMenuNavegacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStripMenuNavegacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripMenuNavegacion.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStripMenuNavegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_NavInicioToolStripMenuItem, Me.btn_NavLIBROSToolStripMenuItem, Me.btn_NavPRESTAMOSToolStripMenuItem, Me.btn_NavMENSAJERÍAToolStripMenuItem, Me.btn_NavCLIENTESToolStripMenuItem, Me.btn_NavVISTASToolStripMenuItem, Me.btn_NavREPORTESToolStripMenuItem, Me.btn_NavSOLICITUDToolStripMenuItem, Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem, Me.btn_NavCONSULTASToolStripMenuItem})
        Me.MenuStripMenuNavegacion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStripMenuNavegacion.Location = New System.Drawing.Point(10, 30)
        Me.MenuStripMenuNavegacion.Name = "MenuStripMenuNavegacion"
        Me.MenuStripMenuNavegacion.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStripMenuNavegacion.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripMenuNavegacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStripMenuNavegacion.ShowItemToolTips = True
        Me.MenuStripMenuNavegacion.Size = New System.Drawing.Size(212, 467)
        Me.MenuStripMenuNavegacion.TabIndex = 3
        Me.MenuStripMenuNavegacion.Text = "MenuStrip1"
        '
        'btn_NavInicioToolStripMenuItem
        '
        Me.btn_NavInicioToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoInicio
        Me.btn_NavInicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.Name = "btn_NavInicioToolStripMenuItem"
        Me.btn_NavInicioToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavInicioToolStripMenuItem.Text = "INICO"
        Me.btn_NavInicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavInicioToolStripMenuItem.ToolTipText = "Ir a inicio de página " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_NavLIBROSToolStripMenuItem
        '
        Me.btn_NavLIBROSToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoLibros
        Me.btn_NavLIBROSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.Name = "btn_NavLIBROSToolStripMenuItem"
        Me.btn_NavLIBROSToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavLIBROSToolStripMenuItem.Text = "LIBROS "
        Me.btn_NavLIBROSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavLIBROSToolStripMenuItem.ToolTipText = "Ver Libros disponibles "
        '
        'btn_NavPRESTAMOSToolStripMenuItem
        '
        Me.btn_NavPRESTAMOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.btn_NavPRESTAMOSToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoSolicitud
        Me.btn_NavPRESTAMOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.Name = "btn_NavPRESTAMOSToolStripMenuItem"
        Me.btn_NavPRESTAMOSToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavPRESTAMOSToolStripMenuItem.Text = "PRESTAMOS "
        Me.btn_NavPRESTAMOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavPRESTAMOSToolStripMenuItem.ToolTipText = "Ver prestamos realizados "
        '
        'btn_NavMENSAJERÍAToolStripMenuItem
        '
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icomensajería
        Me.btn_NavMENSAJERÍAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Name = "btn_NavMENSAJERÍAToolStripMenuItem"
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavMENSAJERÍAToolStripMenuItem.Text = "MENSAJERÍA "
        Me.btn_NavMENSAJERÍAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavMENSAJERÍAToolStripMenuItem.ToolTipText = "Ver mensajes "
        '
        'btn_NavCLIENTESToolStripMenuItem
        '
        Me.btn_NavCLIENTESToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoClientes
        Me.btn_NavCLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.Name = "btn_NavCLIENTESToolStripMenuItem"
        Me.btn_NavCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavCLIENTESToolStripMenuItem.Text = "CLIENTES"
        Me.btn_NavCLIENTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCLIENTESToolStripMenuItem.ToolTipText = "Ver Clientes "
        '
        'btn_NavVISTASToolStripMenuItem
        '
        Me.btn_NavVISTASToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoVista
        Me.btn_NavVISTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavVISTASToolStripMenuItem.Name = "btn_NavVISTASToolStripMenuItem"
        Me.btn_NavVISTASToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavVISTASToolStripMenuItem.Text = "VISTAS"
        Me.btn_NavVISTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavREPORTESToolStripMenuItem
        '
        Me.btn_NavREPORTESToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoReportes
        Me.btn_NavREPORTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavREPORTESToolStripMenuItem.Name = "btn_NavREPORTESToolStripMenuItem"
        Me.btn_NavREPORTESToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavREPORTESToolStripMenuItem.Text = "REPORTES"
        Me.btn_NavREPORTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_NavSOLICITUDToolStripMenuItem
        '
        Me.btn_NavSOLICITUDToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoPrestamos
        Me.btn_NavSOLICITUDToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.Name = "btn_NavSOLICITUDToolStripMenuItem"
        Me.btn_NavSOLICITUDToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavSOLICITUDToolStripMenuItem.Text = "SOLICITUD DE LIBROS "
        Me.btn_NavSOLICITUDToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavSOLICITUDToolStripMenuItem.ToolTipText = "Ver Solisitudes de los Clientes"
        '
        'btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem
        '
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoLibro
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Name = "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Text = "GESTIÓN DE CATÁLOGOS"
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.ToolTipText = "Ver Catálogos disponibles"
        '
        'btn_NavCONSULTASToolStripMenuItem
        '
        Me.btn_NavCONSULTASToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoPreguntas
        Me.btn_NavCONSULTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NavCONSULTASToolStripMenuItem.Name = "btn_NavCONSULTASToolStripMenuItem"
        Me.btn_NavCONSULTASToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.btn_NavCONSULTASToolStripMenuItem.Text = "CONSULTAS"
        Me.btn_NavCONSULTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserControlNavegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Controls.Add(Me.MenuStripMenuNavegacion)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "UserControlNavegacion"
        Me.Padding = New System.Windows.Forms.Padding(10, 30, 10, 30)
        Me.Size = New System.Drawing.Size(232, 527)
        Me.MenuStripMenuNavegacion.ResumeLayout(False)
        Me.MenuStripMenuNavegacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripMenuNavegacion As MenuStrip
    Friend WithEvents btn_NavInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavLIBROSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavPRESTAMOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavMENSAJERÍAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavVISTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavREPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavSOLICITUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NavCONSULTASToolStripMenuItem As ToolStripMenuItem
End Class
