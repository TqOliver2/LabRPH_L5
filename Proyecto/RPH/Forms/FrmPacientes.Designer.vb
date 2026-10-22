Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmPacientes
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

        ' Encabezado y Logo
        Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
        Friend WithEvents picLogo As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
        Friend WithEvents picHeaderMed As System.Windows.Forms.PictureBox
        Friend WithEvents btnProbarConexion As System.Windows.Forms.Button

        ' Panel Izquierdo: Formularios de Entrada
        Friend WithEvents pnlIzquierdo As System.Windows.Forms.Panel
        Friend WithEvents grpDatosPaciente As System.Windows.Forms.GroupBox
        Friend WithEvents lblId As System.Windows.Forms.Label
        Friend WithEvents txtId As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaNac As System.Windows.Forms.Label
        Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblEdad As System.Windows.Forms.Label
        Friend WithEvents lblEdadValor As System.Windows.Forms.Label

        ' Grupo de Cita y Síntomas (TextBox en vez de CheckBoxes)
        Friend WithEvents grpCita As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaCita As System.Windows.Forms.Label
        Friend WithEvents dtpFechaCita As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblTipoConsulta As System.Windows.Forms.Label
        Friend WithEvents cboTipoConsulta As System.Windows.Forms.ComboBox
        Friend WithEvents lblSintomas As System.Windows.Forms.Label
        Friend WithEvents txtSintomas As System.Windows.Forms.TextBox

        ' Botones de Operación
        Friend WithEvents grpOperaciones As System.Windows.Forms.GroupBox
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnVerDetalle As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button

        ' Área Médica Informativa (PictureBox con imagen médica)
        Friend WithEvents pnlInfoMedica As System.Windows.Forms.Panel
        Friend WithEvents picAreaMedica As System.Windows.Forms.PictureBox
        Friend WithEvents lblInfoMedica As System.Windows.Forms.Label

        ' Panel Derecho: Búsqueda y DataGridView
        Friend WithEvents pnlDerecho As System.Windows.Forms.Panel
        Friend WithEvents grpBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents lblBuscar As System.Windows.Forms.Label
        Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents btnMostrarTodo As System.Windows.Forms.Button
        Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
        Friend WithEvents lblEstado As System.Windows.Forms.Label

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlEncabezado = New System.Windows.Forms.Panel()
            Me.btnProbarConexion = New System.Windows.Forms.Button()
            Me.picHeaderMed = New System.Windows.Forms.PictureBox()
            Me.lblSubtitulo = New System.Windows.Forms.Label()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.picLogo = New System.Windows.Forms.PictureBox()
            Me.pnlIzquierdo = New System.Windows.Forms.Panel()
            Me.pnlInfoMedica = New System.Windows.Forms.Panel()
            Me.lblInfoMedica = New System.Windows.Forms.Label()
            Me.picAreaMedica = New System.Windows.Forms.PictureBox()
            Me.grpOperaciones = New System.Windows.Forms.GroupBox()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnVerDetalle = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.grpCita = New System.Windows.Forms.GroupBox()
            Me.txtSintomas = New System.Windows.Forms.TextBox()
            Me.lblSintomas = New System.Windows.Forms.Label()
            Me.cboTipoConsulta = New System.Windows.Forms.ComboBox()
            Me.lblTipoConsulta = New System.Windows.Forms.Label()
            Me.dtpFechaCita = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaCita = New System.Windows.Forms.Label()
            Me.grpDatosPaciente = New System.Windows.Forms.GroupBox()
            Me.lblEdadValor = New System.Windows.Forms.Label()
            Me.lblEdad = New System.Windows.Forms.Label()
            Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaNac = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.lblId = New System.Windows.Forms.Label()
            Me.pnlDerecho = New System.Windows.Forms.Panel()
            Me.lblEstado = New System.Windows.Forms.Label()
            Me.dgvPacientes = New System.Windows.Forms.DataGridView()
            Me.grpBusqueda = New System.Windows.Forms.GroupBox()
            Me.btnMostrarTodo = New System.Windows.Forms.Button()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtBuscar = New System.Windows.Forms.TextBox()
            Me.lblBuscar = New System.Windows.Forms.Label()
            Me.pnlEncabezado.SuspendLayout()
            CType(Me.picHeaderMed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlIzquierdo.SuspendLayout()
            Me.pnlInfoMedica.SuspendLayout()
            CType(Me.picAreaMedica, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpOperaciones.SuspendLayout()
            Me.grpCita.SuspendLayout()
            Me.grpDatosPaciente.SuspendLayout()
            Me.pnlDerecho.SuspendLayout()
            CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpBusqueda.SuspendLayout()
            Me.SuspendLayout()
            '
            ' pnlEncabezado
            '
            Me.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.pnlEncabezado.Controls.Add(Me.btnProbarConexion)
            Me.pnlEncabezado.Controls.Add(Me.picHeaderMed)
            Me.pnlEncabezado.Controls.Add(Me.lblSubtitulo)
            Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
            Me.pnlEncabezado.Controls.Add(Me.picLogo)
            Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
            Me.pnlEncabezado.Name = "pnlEncabezado"
            Me.pnlEncabezado.Size = New System.Drawing.Size(1174, 85)
            Me.pnlEncabezado.TabIndex = 0
            '
            ' btnProbarConexion
            '
            Me.btnProbarConexion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnProbarConexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnProbarConexion.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnProbarConexion.FlatAppearance.BorderSize = 0
            Me.btnProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProbarConexion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnProbarConexion.ForeColor = System.Drawing.Color.White
            Me.btnProbarConexion.Location = New System.Drawing.Point(920, 24)
            Me.btnProbarConexion.Name = "btnProbarConexion"
            Me.btnProbarConexion.Size = New System.Drawing.Size(155, 36)
            Me.btnProbarConexion.TabIndex = 4
            Me.btnProbarConexion.Text = "🔌 Probar Conexión"
            Me.btnProbarConexion.UseVisualStyleBackColor = False
            '
            ' picHeaderMed
            '
            Me.picHeaderMed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picHeaderMed.BackColor = System.Drawing.Color.Transparent
            Me.picHeaderMed.Location = New System.Drawing.Point(1088, 12)
            Me.picHeaderMed.Name = "picHeaderMed"
            Me.picHeaderMed.Size = New System.Drawing.Size(64, 60)
            Me.picHeaderMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picHeaderMed.TabIndex = 3
            Me.picHeaderMed.TabStop = False
            '
            ' lblSubtitulo
            '
            Me.lblSubtitulo.AutoSize = True
            Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblSubtitulo.Location = New System.Drawing.Point(195, 48)
            Me.lblSubtitulo.Name = "lblSubtitulo"
            Me.lblSubtitulo.Size = New System.Drawing.Size(437, 17)
            Me.lblSubtitulo.TabIndex = 2
            Me.lblSubtitulo.Text = "Sistema de Gestión y Registro Clínico  |  Base de Datos: Hospital (SQL Server)"
            '
            ' lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblTitulo.ForeColor = System.Drawing.Color.White
            Me.lblTitulo.Location = New System.Drawing.Point(193, 14)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(465, 30)
            Me.lblTitulo.TabIndex = 1
            Me.lblTitulo.Text = "REGISTRO DE PACIENTES EN UN HOSPITAL"
            '
            ' picLogo
            '
            Me.picLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picLogo.Location = New System.Drawing.Point(18, 12)
            Me.picLogo.Name = "picLogo"
            Me.picLogo.Size = New System.Drawing.Size(160, 60)
            Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.picLogo.TabIndex = 0
            Me.picLogo.TabStop = False
            '
            ' pnlIzquierdo
            '
            Me.pnlIzquierdo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlIzquierdo.BackColor = System.Drawing.Color.White
            Me.pnlIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlIzquierdo.Controls.Add(Me.pnlInfoMedica)
            Me.pnlIzquierdo.Controls.Add(Me.grpOperaciones)
            Me.pnlIzquierdo.Controls.Add(Me.grpCita)
            Me.pnlIzquierdo.Controls.Add(Me.grpDatosPaciente)
            Me.pnlIzquierdo.Location = New System.Drawing.Point(18, 98)
            Me.pnlIzquierdo.Name = "pnlIzquierdo"
            Me.pnlIzquierdo.Size = New System.Drawing.Size(440, 620)
            Me.pnlIzquierdo.TabIndex = 1
            '
            ' pnlInfoMedica
            '
            Me.pnlInfoMedica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.pnlInfoMedica.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.pnlInfoMedica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInfoMedica.Controls.Add(Me.lblInfoMedica)
            Me.pnlInfoMedica.Controls.Add(Me.picAreaMedica)
            Me.pnlInfoMedica.Location = New System.Drawing.Point(14, 555)
            Me.pnlInfoMedica.Name = "pnlInfoMedica"
            Me.pnlInfoMedica.Size = New System.Drawing.Size(410, 52)
            Me.pnlInfoMedica.TabIndex = 3
            '
            ' lblInfoMedica
            '
            Me.lblInfoMedica.AutoSize = True
            Me.lblInfoMedica.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblInfoMedica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.lblInfoMedica.Location = New System.Drawing.Point(58, 10)
            Me.lblInfoMedica.Name = "lblInfoMedica"
            Me.lblInfoMedica.Size = New System.Drawing.Size(325, 26)
            Me.lblInfoMedica.TabIndex = 1
            Me.lblInfoMedica.Text = "Área de Admisión Hospitalaria - Base de Datos: Hospital" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tablas integradas: pacientes" &
    " y citas médicas."
            '
            ' picAreaMedica
            '
            Me.picAreaMedica.BackColor = System.Drawing.Color.Transparent
            Me.picAreaMedica.Location = New System.Drawing.Point(8, 6)
            Me.picAreaMedica.Name = "picAreaMedica"
            Me.picAreaMedica.Size = New System.Drawing.Size(42, 38)
            Me.picAreaMedica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picAreaMedica.TabIndex = 0
            Me.picAreaMedica.TabStop = False
            '
            ' grpOperaciones
            '
            Me.grpOperaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpOperaciones.Controls.Add(Me.btnSalir)
            Me.grpOperaciones.Controls.Add(Me.btnVerDetalle)
            Me.grpOperaciones.Controls.Add(Me.btnLimpiar)
            Me.grpOperaciones.Controls.Add(Me.btnEliminar)
            Me.grpOperaciones.Controls.Add(Me.btnActualizar)
            Me.grpOperaciones.Controls.Add(Me.btnGuardar)
            Me.grpOperaciones.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.grpOperaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.grpOperaciones.Location = New System.Drawing.Point(14, 435)
            Me.grpOperaciones.Name = "grpOperaciones"
            Me.grpOperaciones.Size = New System.Drawing.Size(410, 112)
            Me.grpOperaciones.TabIndex = 2
            Me.grpOperaciones.TabStop = False
            Me.grpOperaciones.Text = " Operaciones del Sistema "
            '
            ' btnSalir
            '
            Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSalir.FlatAppearance.BorderSize = 0
            Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnSalir.ForeColor = System.Drawing.Color.White
            Me.btnSalir.Location = New System.Drawing.Point(276, 68)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(124, 32)
            Me.btnSalir.TabIndex = 5
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.UseVisualStyleBackColor = False
            '
            ' btnVerDetalle
            '
            Me.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnVerDetalle.FlatAppearance.BorderSize = 0
            Me.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnVerDetalle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnVerDetalle.ForeColor = System.Drawing.Color.White
            Me.btnVerDetalle.Location = New System.Drawing.Point(144, 68)
            Me.btnVerDetalle.Name = "btnVerDetalle"
            Me.btnVerDetalle.Size = New System.Drawing.Size(124, 32)
            Me.btnVerDetalle.TabIndex = 4
            Me.btnVerDetalle.Text = "Ver Detalle"
            Me.btnVerDetalle.UseVisualStyleBackColor = False
            '
            ' btnLimpiar
            '
            Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLimpiar.FlatAppearance.BorderSize = 0
            Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnLimpiar.ForeColor = System.Drawing.Color.White
            Me.btnLimpiar.Location = New System.Drawing.Point(12, 68)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(124, 32)
            Me.btnLimpiar.TabIndex = 3
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.UseVisualStyleBackColor = False
            '
            ' btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnEliminar.ForeColor = System.Drawing.Color.White
            Me.btnEliminar.Location = New System.Drawing.Point(276, 25)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(124, 34)
            Me.btnEliminar.TabIndex = 2
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            ' btnActualizar
            '
            Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnActualizar.FlatAppearance.BorderSize = 0
            Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnActualizar.ForeColor = System.Drawing.Color.White
            Me.btnActualizar.Location = New System.Drawing.Point(144, 25)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(124, 34)
            Me.btnActualizar.TabIndex = 1
            Me.btnActualizar.Text = "Actualizar"
            Me.btnActualizar.UseVisualStyleBackColor = False
            '
            ' btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.FlatAppearance.BorderSize = 0
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnGuardar.ForeColor = System.Drawing.Color.White
            Me.btnGuardar.Location = New System.Drawing.Point(12, 25)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(124, 34)
            Me.btnGuardar.TabIndex = 0
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            ' grpCita
            '
            Me.grpCita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpCita.Controls.Add(Me.txtSintomas)
            Me.grpCita.Controls.Add(Me.lblSintomas)
            Me.grpCita.Controls.Add(Me.cboTipoConsulta)
            Me.grpCita.Controls.Add(Me.lblTipoConsulta)
            Me.grpCita.Controls.Add(Me.dtpFechaCita)
            Me.grpCita.Controls.Add(Me.lblFechaCita)
            Me.grpCita.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.grpCita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.grpCita.Location = New System.Drawing.Point(14, 218)
            Me.grpCita.Name = "grpCita"
            Me.grpCita.Size = New System.Drawing.Size(410, 208)
            Me.grpCita.TabIndex = 1
            Me.grpCita.TabStop = False
            Me.grpCita.Text = " Datos de la Cita Médica (Tabla 'citas') "
            '
            ' txtSintomas
            '
            Me.txtSintomas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSintomas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtSintomas.Location = New System.Drawing.Point(14, 98)
            Me.txtSintomas.MaxLength = 500
            Me.txtSintomas.Multiline = True
            Me.txtSintomas.Name = "txtSintomas"
            Me.txtSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtSintomas.Size = New System.Drawing.Size(382, 98)
            Me.txtSintomas.TabIndex = 5
            '
            ' lblSintomas
            '
            Me.lblSintomas.AutoSize = True
            Me.lblSintomas.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblSintomas.Location = New System.Drawing.Point(14, 78)
            Me.lblSintomas.Name = "lblSintomas"
            Me.lblSintomas.Size = New System.Drawing.Size(256, 15)
            Me.lblSintomas.TabIndex = 4
            Me.lblSintomas.Text = "Síntomas manifestados / Motivo consulta: (*)"
            '
            ' cboTipoConsulta
            '
            Me.cboTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboTipoConsulta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.cboTipoConsulta.FormattingEnabled = True
            Me.cboTipoConsulta.Location = New System.Drawing.Point(185, 45)
            Me.cboTipoConsulta.Name = "cboTipoConsulta"
            Me.cboTipoConsulta.Size = New System.Drawing.Size(211, 23)
            Me.cboTipoConsulta.TabIndex = 3
            '
            ' lblTipoConsulta
            '
            Me.lblTipoConsulta.AutoSize = True
            Me.lblTipoConsulta.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblTipoConsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblTipoConsulta.Location = New System.Drawing.Point(185, 25)
            Me.lblTipoConsulta.Name = "lblTipoConsulta"
            Me.lblTipoConsulta.Size = New System.Drawing.Size(117, 15)
            Me.lblTipoConsulta.TabIndex = 2
            Me.lblTipoConsulta.Text = "Tipo de consulta: (*)"
            '
            ' dtpFechaCita
            '
            Me.dtpFechaCita.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaCita.Location = New System.Drawing.Point(14, 45)
            Me.dtpFechaCita.Name = "dtpFechaCita"
            Me.dtpFechaCita.Size = New System.Drawing.Size(155, 23)
            Me.dtpFechaCita.TabIndex = 1
            '
            ' lblFechaCita
            '
            Me.lblFechaCita.AutoSize = True
            Me.lblFechaCita.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblFechaCita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblFechaCita.Location = New System.Drawing.Point(14, 25)
            Me.lblFechaCita.Name = "lblFechaCita"
            Me.lblFechaCita.Size = New System.Drawing.Size(117, 15)
            Me.lblFechaCita.TabIndex = 0
            Me.lblFechaCita.Text = "Fecha de la cita: (*)"
            '
            ' grpDatosPaciente
            '
            Me.grpDatosPaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpDatosPaciente.Controls.Add(Me.lblEdadValor)
            Me.grpDatosPaciente.Controls.Add(Me.lblEdad)
            Me.grpDatosPaciente.Controls.Add(Me.dtpFechaNacimiento)
            Me.grpDatosPaciente.Controls.Add(Me.lblFechaNac)
            Me.grpDatosPaciente.Controls.Add(Me.txtNombre)
            Me.grpDatosPaciente.Controls.Add(Me.lblNombre)
            Me.grpDatosPaciente.Controls.Add(Me.txtCedula)
            Me.grpDatosPaciente.Controls.Add(Me.lblCedula)
            Me.grpDatosPaciente.Controls.Add(Me.txtCodigo)
            Me.grpDatosPaciente.Controls.Add(Me.lblCodigo)
            Me.grpDatosPaciente.Controls.Add(Me.txtId)
            Me.grpDatosPaciente.Controls.Add(Me.lblId)
            Me.grpDatosPaciente.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.grpDatosPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.grpDatosPaciente.Location = New System.Drawing.Point(14, 12)
            Me.grpDatosPaciente.Name = "grpDatosPaciente"
            Me.grpDatosPaciente.Size = New System.Drawing.Size(410, 198)
            Me.grpDatosPaciente.TabIndex = 0
            Me.grpDatosPaciente.TabStop = False
            Me.grpDatosPaciente.Text = " Datos del Paciente (Tabla 'pacientes') "
            '
            ' lblEdadValor
            '
            Me.lblEdadValor.AutoSize = True
            Me.lblEdadValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.lblEdadValor.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEdadValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.lblEdadValor.Location = New System.Drawing.Point(265, 156)
            Me.lblEdadValor.Name = "lblEdadValor"
            Me.lblEdadValor.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
            Me.lblEdadValor.Size = New System.Drawing.Size(59, 21)
            Me.lblEdadValor.TabIndex = 11
            Me.lblEdadValor.Text = "-- años"
            '
            ' lblEdad
            '
            Me.lblEdad.AutoSize = True
            Me.lblEdad.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblEdad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblEdad.Location = New System.Drawing.Point(265, 134)
            Me.lblEdad.Name = "lblEdad"
            Me.lblEdad.Size = New System.Drawing.Size(89, 15)
            Me.lblEdad.TabIndex = 10
            Me.lblEdad.Text = "Edad calculada:"
            '
            ' dtpFechaNacimiento
            '
            Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaNacimiento.Location = New System.Drawing.Point(14, 155)
            Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
            Me.dtpFechaNacimiento.Size = New System.Drawing.Size(235, 23)
            Me.dtpFechaNacimiento.TabIndex = 9
            '
            ' lblFechaNac
            '
            Me.lblFechaNac.AutoSize = True
            Me.lblFechaNac.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblFechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblFechaNac.Location = New System.Drawing.Point(14, 134)
            Me.lblFechaNac.Name = "lblFechaNac"
            Me.lblFechaNac.Size = New System.Drawing.Size(141, 15)
            Me.lblFechaNac.TabIndex = 8
            Me.lblFechaNac.Text = "Fecha de Nacimiento: (*)"
            '
            ' txtNombre
            '
            Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtNombre.Location = New System.Drawing.Point(14, 98)
            Me.txtNombre.MaxLength = 100
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(382, 23)
            Me.txtNombre.TabIndex = 7
            '
            ' lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblNombre.Location = New System.Drawing.Point(14, 78)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(126, 15)
            Me.lblNombre.TabIndex = 6
            Me.lblNombre.Text = "Nombre completo: (*)"
            '
            ' txtCedula
            '
            Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtCedula.Location = New System.Drawing.Point(265, 45)
            Me.txtCedula.MaxLength = 20
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(131, 23)
            Me.txtCedula.TabIndex = 5
            '
            ' lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblCedula.Location = New System.Drawing.Point(265, 25)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(63, 15)
            Me.lblCedula.TabIndex = 4
            Me.lblCedula.Text = "Cédula: (*)"
            '
            ' txtCodigo
            '
            Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtCodigo.Location = New System.Drawing.Point(115, 45)
            Me.txtCodigo.MaxLength = 10
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(134, 23)
            Me.txtCodigo.TabIndex = 3
            '
            ' lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblCodigo.Location = New System.Drawing.Point(115, 25)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(114, 15)
            Me.lblCodigo.TabIndex = 2
            Me.lblCodigo.Text = "Código Paciente: (*)"
            '
            ' txtId
            '
            Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.txtId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.txtId.Location = New System.Drawing.Point(14, 45)
            Me.txtId.Name = "txtId"
            Me.txtId.ReadOnly = True
            Me.txtId.Size = New System.Drawing.Size(85, 23)
            Me.txtId.TabIndex = 1
            Me.txtId.Text = "(Nuevo)"
            '
            ' lblId
            '
            Me.lblId.AutoSize = True
            Me.lblId.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblId.Location = New System.Drawing.Point(14, 25)
            Me.lblId.Name = "lblId"
            Me.lblId.Size = New System.Drawing.Size(68, 15)
            Me.lblId.TabIndex = 0
            Me.lblId.Text = "ID Sistema:"
            '
            ' pnlDerecho
            '
            Me.pnlDerecho.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlDerecho.BackColor = System.Drawing.Color.White
            Me.pnlDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDerecho.Controls.Add(Me.lblEstado)
            Me.pnlDerecho.Controls.Add(Me.dgvPacientes)
            Me.pnlDerecho.Controls.Add(Me.grpBusqueda)
            Me.pnlDerecho.Location = New System.Drawing.Point(470, 98)
            Me.pnlDerecho.Name = "pnlDerecho"
            Me.pnlDerecho.Size = New System.Drawing.Size(685, 620)
            Me.pnlDerecho.TabIndex = 2
            '
            ' lblEstado
            '
            Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblEstado.AutoSize = True
            Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
            Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.lblEstado.Location = New System.Drawing.Point(14, 585)
            Me.lblEstado.Name = "lblEstado"
            Me.lblEstado.Size = New System.Drawing.Size(374, 15)
            Me.lblEstado.TabIndex = 2
            Me.lblEstado.Text = "Total de pacientes: 0 | Seleccione un registro para visualizar o modificar."
            '
            ' dgvPacientes
            '
            Me.dgvPacientes.AllowUserToAddRows = False
            Me.dgvPacientes.AllowUserToDeleteRows = False
            Me.dgvPacientes.AllowUserToResizeRows = False
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
            Me.dgvPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4)
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgvPacientes.ColumnHeadersHeight = 35
            Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgvPacientes.EnableHeadersVisualStyles = False
            Me.dgvPacientes.Location = New System.Drawing.Point(14, 90)
            Me.dgvPacientes.MultiSelect = False
            Me.dgvPacientes.Name = "dgvPacientes"
            Me.dgvPacientes.ReadOnly = True
            Me.dgvPacientes.RowHeadersVisible = False
            Me.dgvPacientes.RowTemplate.Height = 28
            Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPacientes.Size = New System.Drawing.Size(655, 485)
            Me.dgvPacientes.TabIndex = 1
            '
            ' grpBusqueda
            '
            Me.grpBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpBusqueda.Controls.Add(Me.btnMostrarTodo)
            Me.grpBusqueda.Controls.Add(Me.btnBuscar)
            Me.grpBusqueda.Controls.Add(Me.txtBuscar)
            Me.grpBusqueda.Controls.Add(Me.lblBuscar)
            Me.grpBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.grpBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.grpBusqueda.Location = New System.Drawing.Point(14, 12)
            Me.grpBusqueda.Name = "grpBusqueda"
            Me.grpBusqueda.Size = New System.Drawing.Size(655, 68)
            Me.grpBusqueda.TabIndex = 0
            Me.grpBusqueda.TabStop = False
            Me.grpBusqueda.Text = " Búsqueda Rápida de Pacientes y Citas "
            '
            ' btnMostrarTodo
            '
            Me.btnMostrarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(116, Byte), Integer))
            Me.btnMostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnMostrarTodo.FlatAppearance.BorderSize = 0
            Me.btnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMostrarTodo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnMostrarTodo.ForeColor = System.Drawing.Color.White
            Me.btnMostrarTodo.Location = New System.Drawing.Point(525, 23)
            Me.btnMostrarTodo.Name = "btnMostrarTodo"
            Me.btnMostrarTodo.Size = New System.Drawing.Size(120, 32)
            Me.btnMostrarTodo.TabIndex = 3
            Me.btnMostrarTodo.Text = "Mostrar Todo"
            Me.btnMostrarTodo.UseVisualStyleBackColor = False
            '
            ' btnBuscar
            '
            Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnBuscar.ForeColor = System.Drawing.Color.White
            Me.btnBuscar.Location = New System.Drawing.Point(395, 23)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(120, 32)
            Me.btnBuscar.TabIndex = 2
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            ' txtBuscar
            '
            Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtBuscar.Location = New System.Drawing.Point(155, 27)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.Size = New System.Drawing.Size(230, 24)
            Me.txtBuscar.TabIndex = 1
            '
            ' lblBuscar
            '
            Me.lblBuscar.AutoSize = True
            Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer))
            Me.lblBuscar.Location = New System.Drawing.Point(10, 31)
            Me.lblBuscar.Name = "lblBuscar"
            Me.lblBuscar.Size = New System.Drawing.Size(141, 15)
            Me.lblBuscar.TabIndex = 0
            Me.lblBuscar.Text = "Buscar (Cód/Nom/Céd):"
            '
            ' FrmPacientes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1174, 731)
            Me.Controls.Add(Me.pnlDerecho)
            Me.Controls.Add(Me.pnlIzquierdo)
            Me.Controls.Add(Me.pnlEncabezado)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.MinimumSize = New System.Drawing.Size(1100, 700)
            Me.Name = "FrmPacientes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Registro de Pacientes en un Hospital - Hospital (SQL Server)"
            Me.pnlEncabezado.ResumeLayout(False)
            Me.pnlEncabezado.PerformLayout()
            CType(Me.picHeaderMed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlIzquierdo.ResumeLayout(False)
            Me.pnlInfoMedica.ResumeLayout(False)
            Me.pnlInfoMedica.PerformLayout()
            CType(Me.picAreaMedica, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpOperaciones.ResumeLayout(False)
            Me.grpCita.ResumeLayout(False)
            Me.grpCita.PerformLayout()
            Me.grpDatosPaciente.ResumeLayout(False)
            Me.grpDatosPaciente.PerformLayout()
            Me.pnlDerecho.ResumeLayout(False)
            Me.pnlDerecho.PerformLayout()
            CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpBusqueda.ResumeLayout(False)
            Me.grpBusqueda.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
