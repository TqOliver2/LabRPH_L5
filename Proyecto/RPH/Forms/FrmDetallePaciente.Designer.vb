Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmDetallePaciente
        Inherits System.Windows.Forms.Form

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
        Friend WithEvents picDetalleMedico As System.Windows.Forms.PictureBox
        Friend WithEvents grpDetalles As System.Windows.Forms.GroupBox
        Friend WithEvents lblEtiquetaId As System.Windows.Forms.Label
        Friend WithEvents lblValorId As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaNombre As System.Windows.Forms.Label
        Friend WithEvents lblValorNombre As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaCedula As System.Windows.Forms.Label
        Friend WithEvents lblValorCedula As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaNacimiento As System.Windows.Forms.Label
        Friend WithEvents lblValorNacimiento As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaFechaCita As System.Windows.Forms.Label
        Friend WithEvents lblValorFechaCita As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaTipoConsulta As System.Windows.Forms.Label
        Friend WithEvents lblValorTipoConsulta As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaSintomas As System.Windows.Forms.Label
        Friend WithEvents txtValorSintomas As System.Windows.Forms.TextBox
        Friend WithEvents btnCerrar As System.Windows.Forms.Button

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlEncabezado = New System.Windows.Forms.Panel()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.lblSubtitulo = New System.Windows.Forms.Label()
            Me.picDetalleMedico = New System.Windows.Forms.PictureBox()
            Me.grpDetalles = New System.Windows.Forms.GroupBox()
            Me.lblValorFechaCita = New System.Windows.Forms.Label()
            Me.lblEtiquetaFechaCita = New System.Windows.Forms.Label()
            Me.lblValorNacimiento = New System.Windows.Forms.Label()
            Me.lblEtiquetaNacimiento = New System.Windows.Forms.Label()
            Me.lblValorCedula = New System.Windows.Forms.Label()
            Me.lblEtiquetaCedula = New System.Windows.Forms.Label()
            Me.txtValorSintomas = New System.Windows.Forms.TextBox()
            Me.lblEtiquetaSintomas = New System.Windows.Forms.Label()
            Me.lblValorTipoConsulta = New System.Windows.Forms.Label()
            Me.lblEtiquetaTipoConsulta = New System.Windows.Forms.Label()
            Me.lblValorNombre = New System.Windows.Forms.Label()
            Me.lblEtiquetaNombre = New System.Windows.Forms.Label()
            Me.lblValorId = New System.Windows.Forms.Label()
            Me.lblEtiquetaId = New System.Windows.Forms.Label()
            Me.btnCerrar = New System.Windows.Forms.Button()
            Me.pnlEncabezado.SuspendLayout()
            CType(Me.picDetalleMedico, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpDetalles.SuspendLayout()
            Me.SuspendLayout()
            '
            ' pnlEncabezado
            '
            Me.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.pnlEncabezado.Controls.Add(Me.lblSubtitulo)
            Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
            Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
            Me.pnlEncabezado.Name = "pnlEncabezado"
            Me.pnlEncabezado.Size = New System.Drawing.Size(660, 75)
            Me.pnlEncabezado.TabIndex = 0
            '
            ' lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblTitulo.ForeColor = System.Drawing.Color.White
            Me.lblTitulo.Location = New System.Drawing.Point(20, 15)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(325, 25)
            Me.lblTitulo.TabIndex = 0
            Me.lblTitulo.Text = "DETALLES CLÍNICOS DEL PACIENTE"
            '
            ' lblSubtitulo
            '
            Me.lblSubtitulo.AutoSize = True
            Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblSubtitulo.Location = New System.Drawing.Point(22, 43)
            Me.lblSubtitulo.Name = "lblSubtitulo"
            Me.lblSubtitulo.Size = New System.Drawing.Size(306, 15)
            Me.lblSubtitulo.TabIndex = 1
            Me.lblSubtitulo.Text = "Información consolidada de tablas pacientes y citas (Hospital)"
            '
            ' picDetalleMedico
            '
            Me.picDetalleMedico.BackColor = System.Drawing.Color.White
            Me.picDetalleMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picDetalleMedico.Location = New System.Drawing.Point(20, 95)
            Me.picDetalleMedico.Name = "picDetalleMedico"
            Me.picDetalleMedico.Size = New System.Drawing.Size(150, 160)
            Me.picDetalleMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picDetalleMedico.TabIndex = 1
            Me.picDetalleMedico.TabStop = False
            '
            ' grpDetalles
            '
            Me.grpDetalles.BackColor = System.Drawing.Color.White
            Me.grpDetalles.Controls.Add(Me.lblValorFechaCita)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaFechaCita)
            Me.grpDetalles.Controls.Add(Me.lblValorNacimiento)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaNacimiento)
            Me.grpDetalles.Controls.Add(Me.lblValorCedula)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaCedula)
            Me.grpDetalles.Controls.Add(Me.txtValorSintomas)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaSintomas)
            Me.grpDetalles.Controls.Add(Me.lblValorTipoConsulta)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaTipoConsulta)
            Me.grpDetalles.Controls.Add(Me.lblValorNombre)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaNombre)
            Me.grpDetalles.Controls.Add(Me.lblValorId)
            Me.grpDetalles.Controls.Add(Me.lblEtiquetaId)
            Me.grpDetalles.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.grpDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.grpDetalles.Location = New System.Drawing.Point(185, 90)
            Me.grpDetalles.Name = "grpDetalles"
            Me.grpDetalles.Size = New System.Drawing.Size(455, 435)
            Me.grpDetalles.TabIndex = 2
            Me.grpDetalles.TabStop = False
            Me.grpDetalles.Text = " Expediente del Paciente y Cita "
            '
            ' lblValorFechaCita
            '
            Me.lblValorFechaCita.AutoSize = True
            Me.lblValorFechaCita.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblValorFechaCita.ForeColor = System.Drawing.Color.Black
            Me.lblValorFechaCita.Location = New System.Drawing.Point(235, 185)
            Me.lblValorFechaCita.Name = "lblValorFechaCita"
            Me.lblValorFechaCita.Size = New System.Drawing.Size(79, 19)
            Me.lblValorFechaCita.TabIndex = 13
            Me.lblValorFechaCita.Text = "06/10/2026"
            '
            ' lblEtiquetaFechaCita
            '
            Me.lblEtiquetaFechaCita.AutoSize = True
            Me.lblEtiquetaFechaCita.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaFechaCita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaFechaCita.Location = New System.Drawing.Point(235, 168)
            Me.lblEtiquetaFechaCita.Name = "lblEtiquetaFechaCita"
            Me.lblEtiquetaFechaCita.Size = New System.Drawing.Size(95, 15)
            Me.lblEtiquetaFechaCita.TabIndex = 12
            Me.lblEtiquetaFechaCita.Text = "FECHA DE CITA:"
            '
            ' lblValorNacimiento
            '
            Me.lblValorNacimiento.AutoSize = True
            Me.lblValorNacimiento.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblValorNacimiento.ForeColor = System.Drawing.Color.Black
            Me.lblValorNacimiento.Location = New System.Drawing.Point(235, 133)
            Me.lblValorNacimiento.Name = "lblValorNacimiento"
            Me.lblValorNacimiento.Size = New System.Drawing.Size(134, 19)
            Me.lblValorNacimiento.TabIndex = 11
            Me.lblValorNacimiento.Text = "15/04/1990 (36 años)"
            '
            ' lblEtiquetaNacimiento
            '
            Me.lblEtiquetaNacimiento.AutoSize = True
            Me.lblEtiquetaNacimiento.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaNacimiento.Location = New System.Drawing.Point(235, 116)
            Me.lblEtiquetaNacimiento.Name = "lblEtiquetaNacimiento"
            Me.lblEtiquetaNacimiento.Size = New System.Drawing.Size(147, 15)
            Me.lblEtiquetaNacimiento.TabIndex = 10
            Me.lblEtiquetaNacimiento.Text = "NACIMIENTO Y EDAD:"
            '
            ' lblValorCedula
            '
            Me.lblValorCedula.AutoSize = True
            Me.lblValorCedula.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblValorCedula.ForeColor = System.Drawing.Color.Black
            Me.lblValorCedula.Location = New System.Drawing.Point(20, 133)
            Me.lblValorCedula.Name = "lblValorCedula"
            Me.lblValorCedula.Size = New System.Drawing.Size(73, 19)
            Me.lblValorCedula.TabIndex = 9
            Me.lblValorCedula.Text = "8-745-1234"
            '
            ' lblEtiquetaCedula
            '
            Me.lblEtiquetaCedula.AutoSize = True
            Me.lblEtiquetaCedula.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaCedula.Location = New System.Drawing.Point(20, 116)
            Me.lblEtiquetaCedula.Name = "lblEtiquetaCedula"
            Me.lblEtiquetaCedula.Size = New System.Drawing.Size(57, 15)
            Me.lblEtiquetaCedula.TabIndex = 8
            Me.lblEtiquetaCedula.Text = "CÉDULA:"
            '
            ' txtValorSintomas
            '
            Me.txtValorSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.txtValorSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtValorSintomas.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtValorSintomas.Location = New System.Drawing.Point(20, 245)
            Me.txtValorSintomas.Multiline = True
            Me.txtValorSintomas.Name = "txtValorSintomas"
            Me.txtValorSintomas.ReadOnly = True
            Me.txtValorSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtValorSintomas.Size = New System.Drawing.Size(415, 170)
            Me.txtValorSintomas.TabIndex = 7
            '
            ' lblEtiquetaSintomas
            '
            Me.lblEtiquetaSintomas.AutoSize = True
            Me.lblEtiquetaSintomas.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaSintomas.Location = New System.Drawing.Point(20, 225)
            Me.lblEtiquetaSintomas.Name = "lblEtiquetaSintomas"
            Me.lblEtiquetaSintomas.Size = New System.Drawing.Size(248, 15)
            Me.lblEtiquetaSintomas.TabIndex = 6
            Me.lblEtiquetaSintomas.Text = "SÍNTOMAS REPORTADOS / MOTIVO CITA:"
            '
            ' lblValorTipoConsulta
            '
            Me.lblValorTipoConsulta.AutoSize = True
            Me.lblValorTipoConsulta.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblValorTipoConsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.lblValorTipoConsulta.Location = New System.Drawing.Point(20, 185)
            Me.lblValorTipoConsulta.Name = "lblValorTipoConsulta"
            Me.lblValorTipoConsulta.Size = New System.Drawing.Size(126, 19)
            Me.lblValorTipoConsulta.TabIndex = 5
            Me.lblValorTipoConsulta.Text = "Medicina General"
            '
            ' lblEtiquetaTipoConsulta
            '
            Me.lblEtiquetaTipoConsulta.AutoSize = True
            Me.lblEtiquetaTipoConsulta.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaTipoConsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaTipoConsulta.Location = New System.Drawing.Point(20, 168)
            Me.lblEtiquetaTipoConsulta.Name = "lblEtiquetaTipoConsulta"
            Me.lblEtiquetaTipoConsulta.Size = New System.Drawing.Size(121, 15)
            Me.lblEtiquetaTipoConsulta.TabIndex = 4
            Me.lblEtiquetaTipoConsulta.Text = "TIPO DE CONSULTA:"
            '
            ' lblValorNombre
            '
            Me.lblValorNombre.AutoSize = True
            Me.lblValorNombre.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblValorNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.lblValorNombre.Location = New System.Drawing.Point(20, 85)
            Me.lblValorNombre.Name = "lblValorNombre"
            Me.lblValorNombre.Size = New System.Drawing.Size(161, 19)
            Me.lblValorNombre.TabIndex = 3
            Me.lblValorNombre.Text = "Carlos Mendoza Soto"
            '
            ' lblEtiquetaNombre
            '
            Me.lblEtiquetaNombre.AutoSize = True
            Me.lblEtiquetaNombre.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaNombre.Location = New System.Drawing.Point(20, 68)
            Me.lblEtiquetaNombre.Name = "lblEtiquetaNombre"
            Me.lblEtiquetaNombre.Size = New System.Drawing.Size(147, 15)
            Me.lblEtiquetaNombre.TabIndex = 2
            Me.lblEtiquetaNombre.Text = "NOMBRE DEL PACIENTE:"
            '
            ' lblValorId
            '
            Me.lblValorId.AutoSize = True
            Me.lblValorId.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.lblValorId.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblValorId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.lblValorId.Location = New System.Drawing.Point(170, 24)
            Me.lblValorId.Name = "lblValorId"
            Me.lblValorId.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
            Me.lblValorId.Size = New System.Drawing.Size(109, 24)
            Me.lblValorId.TabIndex = 1
            Me.lblValorId.Text = "#1 - PAC001"
            '
            ' lblEtiquetaId
            '
            Me.lblEtiquetaId.AutoSize = True
            Me.lblEtiquetaId.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEtiquetaId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEtiquetaId.Location = New System.Drawing.Point(20, 28)
            Me.lblEtiquetaId.Name = "lblEtiquetaId"
            Me.lblEtiquetaId.Size = New System.Drawing.Size(141, 15)
            Me.lblEtiquetaId.TabIndex = 0
            Me.lblEtiquetaId.Text = "ID Y CÓDIGO PACIENTE:"
            '
            ' btnCerrar
            '
            Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCerrar.FlatAppearance.BorderSize = 0
            Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnCerrar.ForeColor = System.Drawing.Color.White
            Me.btnCerrar.Location = New System.Drawing.Point(20, 485)
            Me.btnCerrar.Name = "btnCerrar"
            Me.btnCerrar.Size = New System.Drawing.Size(150, 40)
            Me.btnCerrar.TabIndex = 3
            Me.btnCerrar.Text = "Regresar"
            Me.btnCerrar.UseVisualStyleBackColor = False
            '
            ' FrmDetallePaciente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(660, 545)
            Me.Controls.Add(Me.btnCerrar)
            Me.Controls.Add(Me.grpDetalles)
            Me.Controls.Add(Me.picDetalleMedico)
            Me.Controls.Add(Me.pnlEncabezado)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmDetallePaciente"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Detalles del Paciente y Cita - Hospital"
            Me.pnlEncabezado.ResumeLayout(False)
            Me.pnlEncabezado.PerformLayout()
            CType(Me.picDetalleMedico, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpDetalles.ResumeLayout(False)
            Me.grpDetalles.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
