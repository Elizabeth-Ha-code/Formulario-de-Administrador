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
        Me.Inicio = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIBROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRESTAMOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENSAJERÍAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VISTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOLICITUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Inicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inicio
        '
        Me.Inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Inicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Inicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.LIBROSToolStripMenuItem, Me.PRESTAMOSToolStripMenuItem, Me.MENSAJERÍAToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.VISTASToolStripMenuItem, Me.REPORTESToolStripMenuItem, Me.SOLICITUDToolStripMenuItem, Me.GESTIÓNDECATÁLOGOSToolStripMenuItem, Me.CONSULTASToolStripMenuItem})
        Me.Inicio.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.Inicio.Location = New System.Drawing.Point(10, 30)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.Inicio.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Inicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Inicio.ShowItemToolTips = True
        Me.Inicio.Size = New System.Drawing.Size(212, 467)
        Me.Inicio.TabIndex = 3
        Me.Inicio.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoInicio
        Me.InicioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.InicioToolStripMenuItem.Text = "INICO"
        Me.InicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InicioToolStripMenuItem.ToolTipText = "Ir a inicio de página " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LIBROSToolStripMenuItem
        '
        Me.LIBROSToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoLibros
        Me.LIBROSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LIBROSToolStripMenuItem.Name = "LIBROSToolStripMenuItem"
        Me.LIBROSToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.LIBROSToolStripMenuItem.Text = "LIBROS "
        Me.LIBROSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LIBROSToolStripMenuItem.ToolTipText = "Ver Libros disponibles "
        '
        'PRESTAMOSToolStripMenuItem
        '
        Me.PRESTAMOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PRESTAMOSToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoSolicitud
        Me.PRESTAMOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PRESTAMOSToolStripMenuItem.Name = "PRESTAMOSToolStripMenuItem"
        Me.PRESTAMOSToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.PRESTAMOSToolStripMenuItem.Text = "PRESTAMOS "
        Me.PRESTAMOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PRESTAMOSToolStripMenuItem.ToolTipText = "Ver prestamos realizados "
        '
        'MENSAJERÍAToolStripMenuItem
        '
        Me.MENSAJERÍAToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icomensajería
        Me.MENSAJERÍAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MENSAJERÍAToolStripMenuItem.Name = "MENSAJERÍAToolStripMenuItem"
        Me.MENSAJERÍAToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.MENSAJERÍAToolStripMenuItem.Text = "MENSAJERÍA "
        Me.MENSAJERÍAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MENSAJERÍAToolStripMenuItem.ToolTipText = "Ver mensajes "
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoClientes
        Me.CLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        Me.CLIENTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CLIENTESToolStripMenuItem.ToolTipText = "Ver Clientes "
        '
        'VISTASToolStripMenuItem
        '
        Me.VISTASToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoVista
        Me.VISTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VISTASToolStripMenuItem.Name = "VISTASToolStripMenuItem"
        Me.VISTASToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.VISTASToolStripMenuItem.Text = "VISTAS"
        Me.VISTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoReportes
        Me.REPORTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        Me.REPORTESToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SOLICITUDToolStripMenuItem
        '
        Me.SOLICITUDToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoSolicitud
        Me.SOLICITUDToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SOLICITUDToolStripMenuItem.Name = "SOLICITUDToolStripMenuItem"
        Me.SOLICITUDToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.SOLICITUDToolStripMenuItem.Text = "SOLICITUD DE LIBROS "
        Me.SOLICITUDToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SOLICITUDToolStripMenuItem.ToolTipText = "Ver Solisitudes de los Clientes"
        '
        'GESTIÓNDECATÁLOGOSToolStripMenuItem
        '
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoLibro
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.Name = "GESTIÓNDECATÁLOGOSToolStripMenuItem"
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.Text = "GESTIÓN DE CATÁLOGOS"
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GESTIÓNDECATÁLOGOSToolStripMenuItem.ToolTipText = "Ver Catálogos disponibles"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.Image = Global.Formulario_de_Administrador.My.Resources.Resources.icoPreguntas
        Me.CONSULTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(199, 28)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        Me.CONSULTASToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserControlNavegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Controls.Add(Me.Inicio)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "UserControlNavegacion"
        Me.Padding = New System.Windows.Forms.Padding(10, 30, 10, 30)
        Me.Size = New System.Drawing.Size(232, 527)
        Me.Inicio.ResumeLayout(False)
        Me.Inicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Inicio As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIBROSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRESTAMOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENSAJERÍAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VISTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SOLICITUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GESTIÓNDECATÁLOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As ToolStripMenuItem
End Class
