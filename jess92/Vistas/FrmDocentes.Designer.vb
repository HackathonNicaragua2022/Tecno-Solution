<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDocentes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocentes))
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnAsignarAsignaturas = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Opciones1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AsignarGradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarAsignaturasAGradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.CmbAsignaturas = New System.Windows.Forms.ComboBox()
        Me.OPAsignatura = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.EpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnAsignaturas = New System.Windows.Forms.Panel()
        Me.DtListadoAsignaturas = New System.Windows.Forms.DataGridView()
        Me.OpAsignaturasGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefrescarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TxtNombreAsignatura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtIdAsignatura = New System.Windows.Forms.TextBox()
        Me.BtnCancelarAsgnt = New System.Windows.Forms.Button()
        Me.BtnGuardarAsignatura = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnNuevaAsigbatura = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnAsignaciondeGrados = New System.Windows.Forms.Panel()
        Me.DtGradoAsignacion = New System.Windows.Forms.DataGridView()
        Me.COPAsignaciondeGrados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCerrarGradoAsignacion = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.CmbModalidadGrado = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LBLDocenteasignacion = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtAño = New System.Windows.Forms.TextBox()
        Me.CmbTurno = New System.Windows.Forms.ComboBox()
        Me.CmbSeccion = New System.Windows.Forms.ComboBox()
        Me.CmbGradoAsignar = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtIdAsignacionGrado = New System.Windows.Forms.TextBox()
        Me.btnCancelarGradoAsignado = New System.Windows.Forms.Button()
        Me.BtnEditarAsignacion_Grado = New System.Windows.Forms.Button()
        Me.BtnGuardarGradoAsignado = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.BtnNuevoGradoAsignacion = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PnAsignaciones = New System.Windows.Forms.Panel()
        Me.DtAsignaciones = New System.Windows.Forms.DataGridView()
        Me.OPAsignaciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCerrarPnAsignaciones = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Anio = New UIDC.UI_Numeric()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CmbAula = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CmTurno = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.BtnCancelarAsignacion = New System.Windows.Forms.Button()
        Me.BtnGuardarAsignacion = New System.Windows.Forms.Button()
        Me.CmbGrado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbModalidades = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnAsignarAsignatura = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LblAvanzado = New System.Windows.Forms.Label()
        Me.UI_CheckWindows1 = New UIDC.UI_CheckWindows()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Dtasignaturas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdDocente = New System.Windows.Forms.TextBox()
        Me.PnDocentes_Lotes = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Load = New System.Windows.Forms.PictureBox()
        Me.LblRegistros = New System.Windows.Forms.Label()
        Me.DtDocentesLote = New System.Windows.Forms.DataGridView()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnCargarMatriculaLotes = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkPorlote = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Opciones1.SuspendLayout()
        Me.OPAsignatura.SuspendLayout()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PnAsignaturas.SuspendLayout()
        CType(Me.DtListadoAsignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpAsignaturasGrid.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnAsignaciondeGrados.SuspendLayout()
        CType(Me.DtGradoAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.COPAsignaciondeGrados.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnAsignaciones.SuspendLayout()
        CType(Me.DtAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OPAsignaciones.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtasignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnDocentes_Lotes.SuspendLayout()
        CType(Me.Load, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDocentesLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(631, 9)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 42)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Controls.Add(Me.BtnAsignarAsignaturas)
        Me.Panel4.Controls.Add(Me.BtnImprimir)
        Me.Panel4.Controls.Add(Me.BtnEliminar)
        Me.Panel4.Controls.Add(Me.LblTotal)
        Me.Panel4.Controls.Add(Me.chkEliminar)
        Me.Panel4.Location = New System.Drawing.Point(23, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(993, 50)
        Me.Panel4.TabIndex = 9
        '
        'BtnAsignarAsignaturas
        '
        Me.BtnAsignarAsignaturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAsignarAsignaturas.FlatAppearance.BorderSize = 0
        Me.BtnAsignarAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsignarAsignaturas.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsignarAsignaturas.ForeColor = System.Drawing.Color.White
        Me.BtnAsignarAsignaturas.Image = CType(resources.GetObject("BtnAsignarAsignaturas.Image"), System.Drawing.Image)
        Me.BtnAsignarAsignaturas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnAsignarAsignaturas.Location = New System.Drawing.Point(822, 5)
        Me.BtnAsignarAsignaturas.Name = "BtnAsignarAsignaturas"
        Me.BtnAsignarAsignaturas.Size = New System.Drawing.Size(165, 42)
        Me.BtnAsignarAsignaturas.TabIndex = 45
        Me.BtnAsignarAsignaturas.Text = "&Asignaturas"
        Me.BtnAsignarAsignaturas.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimir.Enabled = False
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.ForeColor = System.Drawing.Color.White
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(601, 5)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(112, 42)
        Me.BtnImprimir.TabIndex = 8
        Me.BtnImprimir.Text = "Im&primir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimir.UseVisualStyleBackColor = True
        Me.BtnImprimir.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(715, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(104, 42)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.White
        Me.LblTotal.Location = New System.Drawing.Point(428, 22)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(112, 17)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.Text = "Total Registros 0"
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.ForeColor = System.Drawing.Color.White
        Me.chkEliminar.Location = New System.Drawing.Point(17, 17)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(81, 22)
        Me.chkEliminar.TabIndex = 4
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AllowUserToOrderColumns = True
        Me.Datalistado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.Datalistado.ContextMenuStrip = Me.Opciones1
        Me.Datalistado.Location = New System.Drawing.Point(23, 124)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.Size = New System.Drawing.Size(993, 160)
        Me.Datalistado.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Opciones1
        '
        Me.Opciones1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.ToolStripSeparator1, Me.AsignarGradoToolStripMenuItem, Me.AsignarAsignaturasAGradosToolStripMenuItem, Me.ToolStripSeparator2, Me.SalirToolStripMenuItem})
        Me.Opciones1.Name = "Opciones1"
        Me.Opciones1.Size = New System.Drawing.Size(229, 148)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(225, 6)
        '
        'AsignarGradoToolStripMenuItem
        '
        Me.AsignarGradoToolStripMenuItem.Name = "AsignarGradoToolStripMenuItem"
        Me.AsignarGradoToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AsignarGradoToolStripMenuItem.Text = "Asignar Grado"
        '
        'AsignarAsignaturasAGradosToolStripMenuItem
        '
        Me.AsignarAsignaturasAGradosToolStripMenuItem.Name = "AsignarAsignaturasAGradosToolStripMenuItem"
        Me.AsignarAsignaturasAGradosToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AsignarAsignaturasAGradosToolStripMenuItem.Text = "Asignar Asignaturas a Grados"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(225, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.SalirToolStripMenuItem.Text = "Salir."
        '
        'TxtBusquedaNombre
        '
        Me.TxtBusquedaNombre.ForeColor = System.Drawing.Color.Green
        Me.TxtBusquedaNombre.Location = New System.Drawing.Point(109, 17)
        Me.TxtBusquedaNombre.Name = "TxtBusquedaNombre"
        Me.TxtBusquedaNombre.Size = New System.Drawing.Size(227, 25)
        Me.TxtBusquedaNombre.TabIndex = 1
        Me.TTMensaje.SetToolTip(Me.TxtBusquedaNombre, "Nombres de Alumno.")
        '
        'TxtCedula
        '
        Me.TxtCedula.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtCedula.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtCedula.Location = New System.Drawing.Point(179, 123)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(307, 25)
        Me.TxtCedula.TabIndex = 1
        Me.TTMensaje.SetToolTip(Me.TxtCedula, "Contenido Neto Unitario")
        '
        'TxtNombres
        '
        Me.TxtNombres.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtNombres.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtNombres.Location = New System.Drawing.Point(101, 193)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.ReadOnly = True
        Me.TxtNombres.Size = New System.Drawing.Size(268, 25)
        Me.TxtNombres.TabIndex = 2
        Me.TTMensaje.SetToolTip(Me.TxtNombres, "Contenido Neto Unitario")
        '
        'TxtApellidos
        '
        Me.TxtApellidos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtApellidos.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtApellidos.Location = New System.Drawing.Point(480, 193)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.ReadOnly = True
        Me.TxtApellidos.Size = New System.Drawing.Size(274, 25)
        Me.TxtApellidos.TabIndex = 3
        Me.TTMensaje.SetToolTip(Me.TxtApellidos, "Stock Máximo")
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtUser.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtUser.Location = New System.Drawing.Point(90, 335)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.ReadOnly = True
        Me.TxtUser.Size = New System.Drawing.Size(166, 25)
        Me.TxtUser.TabIndex = 43
        Me.TTMensaje.SetToolTip(Me.TxtUser, "Contenido Neto Unitario")
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPass.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtPass.Location = New System.Drawing.Point(377, 335)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.ReadOnly = True
        Me.TxtPass.Size = New System.Drawing.Size(136, 25)
        Me.TxtPass.TabIndex = 44
        Me.TTMensaje.SetToolTip(Me.TxtPass, "Stock Máximo")
        '
        'CmbAsignaturas
        '
        Me.CmbAsignaturas.ContextMenuStrip = Me.OPAsignatura
        Me.CmbAsignaturas.FormattingEnabled = True
        Me.CmbAsignaturas.Items.AddRange(New Object() {""})
        Me.CmbAsignaturas.Location = New System.Drawing.Point(309, 110)
        Me.CmbAsignaturas.Name = "CmbAsignaturas"
        Me.CmbAsignaturas.Size = New System.Drawing.Size(168, 26)
        Me.CmbAsignaturas.TabIndex = 4
        Me.TTMensaje.SetToolTip(Me.CmbAsignaturas, "Clic Secundario para agregar una nueva Asignatura.")
        '
        'OPAsignatura
        '
        Me.OPAsignatura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripSeparator3})
        Me.OPAsignatura.Name = "Opciones1"
        Me.OPAsignatura.Size = New System.Drawing.Size(169, 54)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem3.Text = "Nueva Asignatura"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem4.Text = "Refrescar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(165, 6)
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtTelefono.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtTelefono.Location = New System.Drawing.Point(377, 230)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(193, 25)
        Me.TxtTelefono.TabIndex = 49
        Me.TTMensaje.SetToolTip(Me.TxtTelefono, "Stock Máximo")
        '
        'Lbltitulo
        '
        Me.Lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.Font = New System.Drawing.Font("Roboto Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lbltitulo.Location = New System.Drawing.Point(423, 13)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(264, 33)
        Me.Lbltitulo.TabIndex = 33
        Me.Lbltitulo.Text = ".: Gestion Docentes :."
        '
        'EpError
        '
        Me.EpError.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Búsqueda..."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Roboto Medium", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1097, 674)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.PnAsignaturas)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1089, 643)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Docentes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PnAsignaturas
        '
        Me.PnAsignaturas.BackColor = System.Drawing.Color.White
        Me.PnAsignaturas.Controls.Add(Me.DtListadoAsignaturas)
        Me.PnAsignaturas.Controls.Add(Me.Button1)
        Me.PnAsignaturas.Controls.Add(Me.Panel10)
        Me.PnAsignaturas.Controls.Add(Me.Label18)
        Me.PnAsignaturas.Location = New System.Drawing.Point(66, 8)
        Me.PnAsignaturas.Name = "PnAsignaturas"
        Me.PnAsignaturas.Size = New System.Drawing.Size(27, 73)
        Me.PnAsignaturas.TabIndex = 51
        Me.PnAsignaturas.Visible = False
        '
        'DtListadoAsignaturas
        '
        Me.DtListadoAsignaturas.AllowUserToAddRows = False
        Me.DtListadoAsignaturas.AllowUserToDeleteRows = False
        Me.DtListadoAsignaturas.AllowUserToOrderColumns = True
        Me.DtListadoAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtListadoAsignaturas.ContextMenuStrip = Me.OpAsignaturasGrid
        Me.DtListadoAsignaturas.Location = New System.Drawing.Point(18, 341)
        Me.DtListadoAsignaturas.Name = "DtListadoAsignaturas"
        Me.DtListadoAsignaturas.ReadOnly = True
        Me.DtListadoAsignaturas.Size = New System.Drawing.Size(787, 224)
        Me.DtListadoAsignaturas.TabIndex = 48
        '
        'OpAsignaturasGrid
        '
        Me.OpAsignaturasGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripSeparator5, Me.RefrescarToolStripMenuItem})
        Me.OpAsignaturasGrid.Name = "Opciones1"
        Me.OpAsignaturasGrid.Size = New System.Drawing.Size(169, 76)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem5.Text = "Nueva Asignatura"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem6.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(165, 6)
        '
        'RefrescarToolStripMenuItem
        '
        Me.RefrescarToolStripMenuItem.Name = "RefrescarToolStripMenuItem"
        Me.RefrescarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RefrescarToolStripMenuItem.Text = "Refrescar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.Button1.Location = New System.Drawing.Point(-9, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 29)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Controls.Add(Me.TxtNombreAsignatura)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Controls.Add(Me.TxtIdAsignatura)
        Me.Panel10.Controls.Add(Me.BtnCancelarAsgnt)
        Me.Panel10.Controls.Add(Me.BtnGuardarAsignatura)
        Me.Panel10.Controls.Add(Me.PictureBox4)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.BtnNuevaAsigbatura)
        Me.Panel10.Controls.Add(Me.Label16)
        Me.Panel10.Location = New System.Drawing.Point(-378, 73)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(787, 256)
        Me.Panel10.TabIndex = 31
        '
        'TxtNombreAsignatura
        '
        Me.TxtNombreAsignatura.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreAsignatura.Location = New System.Drawing.Point(401, 131)
        Me.TxtNombreAsignatura.Name = "TxtNombreAsignatura"
        Me.TxtNombreAsignatura.Size = New System.Drawing.Size(354, 27)
        Me.TxtNombreAsignatura.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(66, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 19)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Id Asignaturas:"
        '
        'TxtIdAsignatura
        '
        Me.TxtIdAsignatura.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAsignatura.Location = New System.Drawing.Point(187, 131)
        Me.TxtIdAsignatura.Name = "TxtIdAsignatura"
        Me.TxtIdAsignatura.Size = New System.Drawing.Size(100, 27)
        Me.TxtIdAsignatura.TabIndex = 51
        '
        'BtnCancelarAsgnt
        '
        Me.BtnCancelarAsgnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarAsgnt.FlatAppearance.BorderSize = 0
        Me.BtnCancelarAsgnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarAsgnt.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarAsgnt.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarAsgnt.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.BtnCancelarAsgnt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCancelarAsgnt.Location = New System.Drawing.Point(631, 196)
        Me.BtnCancelarAsgnt.Name = "BtnCancelarAsgnt"
        Me.BtnCancelarAsgnt.Size = New System.Drawing.Size(140, 42)
        Me.BtnCancelarAsgnt.TabIndex = 50
        Me.BtnCancelarAsgnt.Text = "Cancelar"
        Me.BtnCancelarAsgnt.UseVisualStyleBackColor = True
        '
        'BtnGuardarAsignatura
        '
        Me.BtnGuardarAsignatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarAsignatura.FlatAppearance.BorderSize = 0
        Me.BtnGuardarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarAsignatura.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarAsignatura.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarAsignatura.Image = CType(resources.GetObject("BtnGuardarAsignatura.Image"), System.Drawing.Image)
        Me.BtnGuardarAsignatura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardarAsignatura.Location = New System.Drawing.Point(485, 196)
        Me.BtnGuardarAsignatura.Name = "BtnGuardarAsignatura"
        Me.BtnGuardarAsignatura.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardarAsignatura.TabIndex = 49
        Me.BtnGuardarAsignatura.Text = "Guardar"
        Me.BtnGuardarAsignatura.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label15.Location = New System.Drawing.Point(75, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(438, 23)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Centro Educativo Francica Hernández Espininoza."
        '
        'BtnNuevaAsigbatura
        '
        Me.BtnNuevaAsigbatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevaAsigbatura.FlatAppearance.BorderSize = 0
        Me.BtnNuevaAsigbatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaAsigbatura.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevaAsigbatura.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaAsigbatura.Image = CType(resources.GetObject("BtnNuevaAsigbatura.Image"), System.Drawing.Image)
        Me.BtnNuevaAsigbatura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevaAsigbatura.Location = New System.Drawing.Point(631, 23)
        Me.BtnNuevaAsigbatura.Name = "BtnNuevaAsigbatura"
        Me.BtnNuevaAsigbatura.Size = New System.Drawing.Size(140, 42)
        Me.BtnNuevaAsigbatura.TabIndex = 8
        Me.BtnNuevaAsigbatura.Text = "Nuevo"
        Me.BtnNuevaAsigbatura.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(319, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 19)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Nombre:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label18.Location = New System.Drawing.Point(-113, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(251, 27)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Administrar Asignaturas"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PnAsignaciondeGrados)
        Me.Panel2.Controls.Add(Me.PnAsignaciones)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(21, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1042, 614)
        Me.Panel2.TabIndex = 45
        '
        'PnAsignaciondeGrados
        '
        Me.PnAsignaciondeGrados.BackColor = System.Drawing.Color.White
        Me.PnAsignaciondeGrados.Controls.Add(Me.DtGradoAsignacion)
        Me.PnAsignaciondeGrados.Controls.Add(Me.BtnCerrarGradoAsignacion)
        Me.PnAsignaciondeGrados.Controls.Add(Me.Panel11)
        Me.PnAsignaciondeGrados.Controls.Add(Me.Label24)
        Me.PnAsignaciondeGrados.Location = New System.Drawing.Point(26, 8)
        Me.PnAsignaciondeGrados.Name = "PnAsignaciondeGrados"
        Me.PnAsignaciondeGrados.Size = New System.Drawing.Size(131, 124)
        Me.PnAsignaciondeGrados.TabIndex = 53
        Me.PnAsignaciondeGrados.Visible = False
        '
        'DtGradoAsignacion
        '
        Me.DtGradoAsignacion.AllowUserToAddRows = False
        Me.DtGradoAsignacion.AllowUserToDeleteRows = False
        Me.DtGradoAsignacion.AllowUserToOrderColumns = True
        Me.DtGradoAsignacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtGradoAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGradoAsignacion.ContextMenuStrip = Me.COPAsignaciondeGrados
        Me.DtGradoAsignacion.Location = New System.Drawing.Point(-326, 379)
        Me.DtGradoAsignacion.Name = "DtGradoAsignacion"
        Me.DtGradoAsignacion.ReadOnly = True
        Me.DtGradoAsignacion.Size = New System.Drawing.Size(787, 190)
        Me.DtGradoAsignacion.TabIndex = 48
        '
        'COPAsignaciondeGrados
        '
        Me.COPAsignaciondeGrados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.EditarToolStripMenuItem1, Me.ToolStripMenuItem8, Me.ToolStripSeparator6})
        Me.COPAsignaciondeGrados.Name = "Opciones1"
        Me.COPAsignaciondeGrados.Size = New System.Drawing.Size(123, 76)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem9.Text = "Refrescar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem8.Text = "Eliminar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(119, 6)
        '
        'BtnCerrarGradoAsignacion
        '
        Me.BtnCerrarGradoAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarGradoAsignacion.AutoSize = True
        Me.BtnCerrarGradoAsignacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCerrarGradoAsignacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCerrarGradoAsignacion.FlatAppearance.BorderSize = 0
        Me.BtnCerrarGradoAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarGradoAsignacion.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarGradoAsignacion.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.BtnCerrarGradoAsignacion.Location = New System.Drawing.Point(95, 6)
        Me.BtnCerrarGradoAsignacion.Name = "BtnCerrarGradoAsignacion"
        Me.BtnCerrarGradoAsignacion.Size = New System.Drawing.Size(30, 29)
        Me.BtnCerrarGradoAsignacion.TabIndex = 35
        Me.BtnCerrarGradoAsignacion.Text = " "
        Me.BtnCerrarGradoAsignacion.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Controls.Add(Me.CmbModalidadGrado)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Controls.Add(Me.LBLDocenteasignacion)
        Me.Panel11.Controls.Add(Me.Label26)
        Me.Panel11.Controls.Add(Me.TxtAño)
        Me.Panel11.Controls.Add(Me.CmbTurno)
        Me.Panel11.Controls.Add(Me.CmbSeccion)
        Me.Panel11.Controls.Add(Me.CmbGradoAsignar)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.TxtIdAsignacionGrado)
        Me.Panel11.Controls.Add(Me.btnCancelarGradoAsignado)
        Me.Panel11.Controls.Add(Me.BtnEditarAsignacion_Grado)
        Me.Panel11.Controls.Add(Me.BtnGuardarGradoAsignado)
        Me.Panel11.Controls.Add(Me.PictureBox5)
        Me.Panel11.Controls.Add(Me.Label19)
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Controls.Add(Me.BtnNuevoGradoAsignacion)
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Location = New System.Drawing.Point(-326, 73)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(787, 284)
        Me.Panel11.TabIndex = 31
        '
        'CmbModalidadGrado
        '
        Me.CmbModalidadGrado.FormattingEnabled = True
        Me.CmbModalidadGrado.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA MULTIGRADO" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA DIURNA" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidadGrado.Location = New System.Drawing.Point(101, 147)
        Me.CmbModalidadGrado.Name = "CmbModalidadGrado"
        Me.CmbModalidadGrado.Size = New System.Drawing.Size(177, 26)
        Me.CmbModalidadGrado.TabIndex = 57
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label27.Location = New System.Drawing.Point(15, 151)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 18)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Modalidad:"
        '
        'LBLDocenteasignacion
        '
        Me.LBLDocenteasignacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLDocenteasignacion.AutoSize = True
        Me.LBLDocenteasignacion.BackColor = System.Drawing.SystemColors.Control
        Me.LBLDocenteasignacion.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDocenteasignacion.ForeColor = System.Drawing.Color.SlateGray
        Me.LBLDocenteasignacion.Location = New System.Drawing.Point(17, 193)
        Me.LBLDocenteasignacion.Name = "LBLDocenteasignacion"
        Me.LBLDocenteasignacion.Size = New System.Drawing.Size(422, 23)
        Me.LBLDocenteasignacion.TabIndex = 56
        Me.LBLDocenteasignacion.Text = "Centro Educativo Francica Hernández Espininoza."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label26.Location = New System.Drawing.Point(646, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 19)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "Año:"
        '
        'TxtAño
        '
        Me.TxtAño.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAño.Location = New System.Drawing.Point(694, 91)
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.ReadOnly = True
        Me.TxtAño.Size = New System.Drawing.Size(77, 27)
        Me.TxtAño.TabIndex = 54
        '
        'CmbTurno
        '
        Me.CmbTurno.FormattingEnabled = True
        Me.CmbTurno.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        Me.CmbTurno.Location = New System.Drawing.Point(350, 147)
        Me.CmbTurno.Name = "CmbTurno"
        Me.CmbTurno.Size = New System.Drawing.Size(132, 26)
        Me.CmbTurno.TabIndex = 53
        '
        'CmbSeccion
        '
        Me.CmbSeccion.FormattingEnabled = True
        Me.CmbSeccion.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.CmbSeccion.Location = New System.Drawing.Point(730, 147)
        Me.CmbSeccion.Name = "CmbSeccion"
        Me.CmbSeccion.Size = New System.Drawing.Size(41, 26)
        Me.CmbSeccion.TabIndex = 53
        Me.CmbSeccion.Text = "A"
        '
        'CmbGradoAsignar
        '
        Me.CmbGradoAsignar.FormattingEnabled = True
        Me.CmbGradoAsignar.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGradoAsignar.Location = New System.Drawing.Point(616, 147)
        Me.CmbGradoAsignar.Name = "CmbGradoAsignar"
        Me.CmbGradoAsignar.Size = New System.Drawing.Size(112, 26)
        Me.CmbGradoAsignar.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(12, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 19)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Id Asignación:"
        '
        'TxtIdAsignacionGrado
        '
        Me.TxtIdAsignacionGrado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAsignacionGrado.Location = New System.Drawing.Point(133, 92)
        Me.TxtIdAsignacionGrado.Name = "TxtIdAsignacionGrado"
        Me.TxtIdAsignacionGrado.ReadOnly = True
        Me.TxtIdAsignacionGrado.Size = New System.Drawing.Size(100, 27)
        Me.TxtIdAsignacionGrado.TabIndex = 51
        '
        'btnCancelarGradoAsignado
        '
        Me.btnCancelarGradoAsignado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarGradoAsignado.FlatAppearance.BorderSize = 0
        Me.btnCancelarGradoAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarGradoAsignado.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarGradoAsignado.ForeColor = System.Drawing.Color.White
        Me.btnCancelarGradoAsignado.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.btnCancelarGradoAsignado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCancelarGradoAsignado.Location = New System.Drawing.Point(631, 224)
        Me.btnCancelarGradoAsignado.Name = "btnCancelarGradoAsignado"
        Me.btnCancelarGradoAsignado.Size = New System.Drawing.Size(140, 42)
        Me.btnCancelarGradoAsignado.TabIndex = 50
        Me.btnCancelarGradoAsignado.Text = "Cancelar"
        Me.btnCancelarGradoAsignado.UseVisualStyleBackColor = True
        '
        'BtnEditarAsignacion_Grado
        '
        Me.BtnEditarAsignacion_Grado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditarAsignacion_Grado.FlatAppearance.BorderSize = 0
        Me.BtnEditarAsignacion_Grado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarAsignacion_Grado.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarAsignacion_Grado.ForeColor = System.Drawing.Color.White
        Me.BtnEditarAsignacion_Grado.Image = CType(resources.GetObject("BtnEditarAsignacion_Grado.Image"), System.Drawing.Image)
        Me.BtnEditarAsignacion_Grado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEditarAsignacion_Grado.Location = New System.Drawing.Point(488, 224)
        Me.BtnEditarAsignacion_Grado.Name = "BtnEditarAsignacion_Grado"
        Me.BtnEditarAsignacion_Grado.Size = New System.Drawing.Size(140, 42)
        Me.BtnEditarAsignacion_Grado.TabIndex = 49
        Me.BtnEditarAsignacion_Grado.Text = "Editar"
        Me.BtnEditarAsignacion_Grado.UseVisualStyleBackColor = True
        '
        'BtnGuardarGradoAsignado
        '
        Me.BtnGuardarGradoAsignado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarGradoAsignado.FlatAppearance.BorderSize = 0
        Me.BtnGuardarGradoAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarGradoAsignado.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarGradoAsignado.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarGradoAsignado.Image = CType(resources.GetObject("BtnGuardarGradoAsignado.Image"), System.Drawing.Image)
        Me.BtnGuardarGradoAsignado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardarGradoAsignado.Location = New System.Drawing.Point(342, 224)
        Me.BtnGuardarGradoAsignado.Name = "BtnGuardarGradoAsignado"
        Me.BtnGuardarGradoAsignado.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardarGradoAsignado.TabIndex = 49
        Me.BtnGuardarGradoAsignado.Text = "Guardar"
        Me.BtnGuardarGradoAsignado.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 23)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 42
        Me.PictureBox5.TabStop = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label19.Location = New System.Drawing.Point(75, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(438, 23)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Centro Educativo Francica Hernández Espininoza."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label29.Location = New System.Drawing.Point(298, 150)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 19)
        Me.Label29.TabIndex = 32
        Me.Label29.Text = "Turno"
        '
        'BtnNuevoGradoAsignacion
        '
        Me.BtnNuevoGradoAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevoGradoAsignacion.FlatAppearance.BorderSize = 0
        Me.BtnNuevoGradoAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoGradoAsignacion.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoGradoAsignacion.ForeColor = System.Drawing.Color.White
        Me.BtnNuevoGradoAsignacion.Image = CType(resources.GetObject("BtnNuevoGradoAsignacion.Image"), System.Drawing.Image)
        Me.BtnNuevoGradoAsignacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevoGradoAsignacion.Location = New System.Drawing.Point(631, 23)
        Me.BtnNuevoGradoAsignacion.Name = "BtnNuevoGradoAsignacion"
        Me.BtnNuevoGradoAsignacion.Size = New System.Drawing.Size(140, 42)
        Me.BtnNuevoGradoAsignacion.TabIndex = 8
        Me.BtnNuevoGradoAsignacion.Text = "Nuevo"
        Me.BtnNuevoGradoAsignacion.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Location = New System.Drawing.Point(497, 149)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 19)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Grado/Sección:"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label24.Location = New System.Drawing.Point(-35, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(159, 27)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Asignar Grado."
        '
        'PnAsignaciones
        '
        Me.PnAsignaciones.Controls.Add(Me.DtAsignaciones)
        Me.PnAsignaciones.Controls.Add(Me.BtnCerrarPnAsignaciones)
        Me.PnAsignaciones.Controls.Add(Me.Panel9)
        Me.PnAsignaciones.Controls.Add(Me.Label8)
        Me.PnAsignaciones.Location = New System.Drawing.Point(39, 20)
        Me.PnAsignaciones.Name = "PnAsignaciones"
        Me.PnAsignaciones.Size = New System.Drawing.Size(64, 37)
        Me.PnAsignaciones.TabIndex = 11
        Me.PnAsignaciones.Visible = False
        '
        'DtAsignaciones
        '
        Me.DtAsignaciones.AllowUserToAddRows = False
        Me.DtAsignaciones.AllowUserToDeleteRows = False
        Me.DtAsignaciones.AllowUserToOrderColumns = True
        Me.DtAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtAsignaciones.ContextMenuStrip = Me.OPAsignaciones
        Me.DtAsignaciones.Location = New System.Drawing.Point(67, 367)
        Me.DtAsignaciones.Name = "DtAsignaciones"
        Me.DtAsignaciones.ReadOnly = True
        Me.DtAsignaciones.Size = New System.Drawing.Size(787, 207)
        Me.DtAsignaciones.TabIndex = 48
        '
        'OPAsignaciones
        '
        Me.OPAsignaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripSeparator4})
        Me.OPAsignaciones.Name = "Opciones1"
        Me.OPAsignaciones.Size = New System.Drawing.Size(123, 54)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem1.Text = "Refrescar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripMenuItem2.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(119, 6)
        '
        'BtnCerrarPnAsignaciones
        '
        Me.BtnCerrarPnAsignaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarPnAsignaciones.AutoSize = True
        Me.BtnCerrarPnAsignaciones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCerrarPnAsignaciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCerrarPnAsignaciones.FlatAppearance.BorderSize = 0
        Me.BtnCerrarPnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarPnAsignaciones.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarPnAsignaciones.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.BtnCerrarPnAsignaciones.Location = New System.Drawing.Point(28, 6)
        Me.BtnCerrarPnAsignaciones.Name = "BtnCerrarPnAsignaciones"
        Me.BtnCerrarPnAsignaciones.Size = New System.Drawing.Size(30, 29)
        Me.BtnCerrarPnAsignaciones.TabIndex = 35
        Me.BtnCerrarPnAsignaciones.Text = " "
        Me.BtnCerrarPnAsignaciones.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.Anio)
        Me.Panel9.Controls.Add(Me.Label33)
        Me.Panel9.Controls.Add(Me.CmbAula)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.CmTurno)
        Me.Panel9.Controls.Add(Me.Label32)
        Me.Panel9.Controls.Add(Me.BtnCancelarAsignacion)
        Me.Panel9.Controls.Add(Me.BtnGuardarAsignacion)
        Me.Panel9.Controls.Add(Me.CmbGrado)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.CmbModalidades)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.CmbAsignaturas)
        Me.Panel9.Controls.Add(Me.PictureBox3)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Controls.Add(Me.BtnAsignarAsignatura)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Location = New System.Drawing.Point(-359, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(787, 278)
        Me.Panel9.TabIndex = 31
        '
        'Anio
        '
        Me.Anio.BaseColour = System.Drawing.Color.White
        Me.Anio.BorderColour = System.Drawing.Color.Gray
        Me.Anio.ButtonColour = System.Drawing.Color.Gainsboro
        Me.Anio.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Anio.FontColour = System.Drawing.Color.DodgerBlue
        Me.Anio.Location = New System.Drawing.Point(69, 112)
        Me.Anio.Maximum = CType(9999999, Long)
        Me.Anio.Minimum = CType(0, Long)
        Me.Anio.Name = "Anio"
        Me.Anio.SecondBorderColour = System.Drawing.Color.DodgerBlue
        Me.Anio.SignsColor = System.Drawing.Color.DodgerBlue
        Me.Anio.Size = New System.Drawing.Size(133, 24)
        Me.Anio.TabIndex = 57
        Me.Anio.Text = "UI_Numeric1"
        Me.Anio.Value = CType(2021, Long)
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label33.Location = New System.Drawing.Point(23, 112)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 18)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "Año:"
        '
        'CmbAula
        '
        Me.CmbAula.FormattingEnabled = True
        Me.CmbAula.Items.AddRange(New Object() {""})
        Me.CmbAula.Location = New System.Drawing.Point(589, 162)
        Me.CmbAula.Name = "CmbAula"
        Me.CmbAula.Size = New System.Drawing.Size(75, 26)
        Me.CmbAula.TabIndex = 53
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label31.Location = New System.Drawing.Point(512, 167)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 18)
        Me.Label31.TabIndex = 54
        Me.Label31.Text = "Sección:"
        '
        'CmTurno
        '
        Me.CmTurno.FormattingEnabled = True
        Me.CmTurno.Location = New System.Drawing.Point(81, 162)
        Me.CmTurno.Name = "CmTurno"
        Me.CmTurno.Size = New System.Drawing.Size(177, 26)
        Me.CmTurno.TabIndex = 51
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label32.Location = New System.Drawing.Point(23, 166)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 18)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Turno:"
        '
        'BtnCancelarAsignacion
        '
        Me.BtnCancelarAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarAsignacion.FlatAppearance.BorderSize = 0
        Me.BtnCancelarAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarAsignacion.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarAsignacion.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarAsignacion.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Red
        Me.BtnCancelarAsignacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCancelarAsignacion.Location = New System.Drawing.Point(631, 230)
        Me.BtnCancelarAsignacion.Name = "BtnCancelarAsignacion"
        Me.BtnCancelarAsignacion.Size = New System.Drawing.Size(140, 42)
        Me.BtnCancelarAsignacion.TabIndex = 50
        Me.BtnCancelarAsignacion.Text = "Cancelar"
        Me.BtnCancelarAsignacion.UseVisualStyleBackColor = True
        '
        'BtnGuardarAsignacion
        '
        Me.BtnGuardarAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarAsignacion.FlatAppearance.BorderSize = 0
        Me.BtnGuardarAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarAsignacion.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarAsignacion.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarAsignacion.Image = CType(resources.GetObject("BtnGuardarAsignacion.Image"), System.Drawing.Image)
        Me.BtnGuardarAsignacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardarAsignacion.Location = New System.Drawing.Point(485, 230)
        Me.BtnGuardarAsignacion.Name = "BtnGuardarAsignacion"
        Me.BtnGuardarAsignacion.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardarAsignacion.TabIndex = 49
        Me.BtnGuardarAsignacion.Text = "Guardar"
        Me.BtnGuardarAsignacion.UseVisualStyleBackColor = True
        '
        'CmbGrado
        '
        Me.CmbGrado.FormattingEnabled = True
        Me.CmbGrado.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGrado.Location = New System.Drawing.Point(398, 162)
        Me.CmbGrado.Name = "CmbGrado"
        Me.CmbGrado.Size = New System.Drawing.Size(75, 26)
        Me.CmbGrado.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(300, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Grado/Nivel:"
        '
        'CmbModalidades
        '
        Me.CmbModalidades.FormattingEnabled = True
        Me.CmbModalidades.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL", "PREESCOLAR COMUNITARIO", "PREESCOLAR COMUNITARIO MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA REGULAR", "PRIMARIA MULTIGRADO", "SECUNDARIA DIURNA", "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidades.Location = New System.Drawing.Point(591, 109)
        Me.CmbModalidades.Name = "CmbModalidades"
        Me.CmbModalidades.Size = New System.Drawing.Size(177, 26)
        Me.CmbModalidades.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(498, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Modalidad:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(13, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Location = New System.Drawing.Point(75, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(328, 23)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Disciplinas a asignar a cada docente."
        '
        'BtnAsignarAsignatura
        '
        Me.BtnAsignarAsignatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAsignarAsignatura.FlatAppearance.BorderSize = 0
        Me.BtnAsignarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsignarAsignatura.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsignarAsignatura.ForeColor = System.Drawing.Color.White
        Me.BtnAsignarAsignatura.Image = CType(resources.GetObject("BtnAsignarAsignatura.Image"), System.Drawing.Image)
        Me.BtnAsignarAsignatura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnAsignarAsignatura.Location = New System.Drawing.Point(631, 23)
        Me.BtnAsignarAsignatura.Name = "BtnAsignarAsignatura"
        Me.BtnAsignarAsignatura.Size = New System.Drawing.Size(140, 42)
        Me.BtnAsignarAsignatura.TabIndex = 8
        Me.BtnAsignarAsignatura.Text = "Nuevo"
        Me.BtnAsignarAsignatura.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Location = New System.Drawing.Point(216, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 18)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Asignaturas:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(-94, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(265, 27)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Asignación de Disciplinas"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.LblAvanzado)
        Me.Panel5.Controls.Add(Me.UI_CheckWindows1)
        Me.Panel5.Controls.Add(Me.Datalistado)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.TxtBusquedaNombre)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1038, 305)
        Me.Panel5.TabIndex = 0
        '
        'LblAvanzado
        '
        Me.LblAvanzado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAvanzado.AutoSize = True
        Me.LblAvanzado.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAvanzado.ForeColor = System.Drawing.Color.Black
        Me.LblAvanzado.Location = New System.Drawing.Point(517, 24)
        Me.LblAvanzado.Name = "LblAvanzado"
        Me.LblAvanzado.Size = New System.Drawing.Size(137, 17)
        Me.LblAvanzado.TabIndex = 11
        Me.LblAvanzado.Text = "Busqueda Avanzada"
        '
        'UI_CheckWindows1
        '
        Me.UI_CheckWindows1.AutoSize = True
        Me.UI_CheckWindows1.BackColor = System.Drawing.SystemColors.Control
        Me.UI_CheckWindows1.ColorActivado = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.UI_CheckWindows1.ColorDesactivado = System.Drawing.Color.Black
        Me.UI_CheckWindows1.ColorMouseDown = System.Drawing.Color.DimGray
        Me.UI_CheckWindows1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.UI_CheckWindows1.Location = New System.Drawing.Point(347, 21)
        Me.UI_CheckWindows1.Name = "UI_CheckWindows1"
        Me.UI_CheckWindows1.ParentControl = Me
        Me.UI_CheckWindows1.Size = New System.Drawing.Size(155, 21)
        Me.UI_CheckWindows1.TabIndex = 10
        Me.UI_CheckWindows1.Text = "Desactivado           "
        Me.UI_CheckWindows1.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.Dtasignaturas)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(3, 340)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1038, 260)
        Me.Panel6.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Dtasignaturas
        '
        Me.Dtasignaturas.AllowUserToAddRows = False
        Me.Dtasignaturas.AllowUserToDeleteRows = False
        Me.Dtasignaturas.AllowUserToOrderColumns = True
        Me.Dtasignaturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dtasignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtasignaturas.ContextMenuStrip = Me.COPAsignaciondeGrados
        Me.Dtasignaturas.Location = New System.Drawing.Point(23, 69)
        Me.Dtasignaturas.Name = "Dtasignaturas"
        Me.Dtasignaturas.ReadOnly = True
        Me.Dtasignaturas.Size = New System.Drawing.Size(993, 168)
        Me.Dtasignaturas.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(85, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Grados Asignados"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1089, 643)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edición"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnDocentes_Lotes)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel8)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(60, 103)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(800, 532)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.TxtTelefono)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.CmbRol)
        Me.Panel1.Controls.Add(Me.CmbSexo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.BtnNuevo)
        Me.Panel1.Controls.Add(Me.TxtCedula)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TxtNombres)
        Me.Panel1.Controls.Add(Me.TxtApellidos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtIdDocente)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 379)
        Me.Panel1.TabIndex = 8
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label30.Location = New System.Drawing.Point(295, 233)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(71, 18)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Teléfono:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel7.Location = New System.Drawing.Point(79, 304)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(675, 1)
        Me.Panel7.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Location = New System.Drawing.Point(75, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 23)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Datos de Acceso."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label28.Location = New System.Drawing.Point(570, 338)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 18)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = "Rol:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(282, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(20, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Usuario:"
        '
        'CmbRol
        '
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Items.AddRange(New Object() {"Administrador", "Docente", "Secretario", "Director", "Sub Director"})
        Me.CmbRol.Location = New System.Drawing.Point(610, 335)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(144, 26)
        Me.CmbRol.TabIndex = 4
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"F", "M"})
        Me.CmbSexo.Location = New System.Drawing.Point(112, 230)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(121, 26)
        Me.CmbSexo.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(75, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Registro de docentes"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label25.Location = New System.Drawing.Point(24, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 18)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Cedula de Identidad:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(627, 9)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(140, 42)
        Me.BtnNuevo.TabIndex = 8
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label23.Location = New System.Drawing.Point(20, 233)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 18)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Sexo:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(398, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 18)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Apellidos:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label21.Location = New System.Drawing.Point(20, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 18)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "id Docente:"
        '
        'TxtIdDocente
        '
        Me.TxtIdDocente.BackColor = System.Drawing.Color.Ivory
        Me.TxtIdDocente.Enabled = False
        Me.TxtIdDocente.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtIdDocente.Location = New System.Drawing.Point(133, 79)
        Me.TxtIdDocente.Name = "TxtIdDocente"
        Me.TxtIdDocente.ReadOnly = True
        Me.TxtIdDocente.Size = New System.Drawing.Size(134, 25)
        Me.TxtIdDocente.TabIndex = 3
        '
        'PnDocentes_Lotes
        '
        Me.PnDocentes_Lotes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PnDocentes_Lotes.BackColor = System.Drawing.SystemColors.Control
        Me.PnDocentes_Lotes.Controls.Add(Me.btnHelp)
        Me.PnDocentes_Lotes.Controls.Add(Me.Load)
        Me.PnDocentes_Lotes.Controls.Add(Me.LblRegistros)
        Me.PnDocentes_Lotes.Controls.Add(Me.DtDocentesLote)
        Me.PnDocentes_Lotes.Controls.Add(Me.PictureBox6)
        Me.PnDocentes_Lotes.Controls.Add(Me.Label34)
        Me.PnDocentes_Lotes.Controls.Add(Me.BtnCargarMatriculaLotes)
        Me.PnDocentes_Lotes.Location = New System.Drawing.Point(3, 388)
        Me.PnDocentes_Lotes.Name = "PnDocentes_Lotes"
        Me.PnDocentes_Lotes.Size = New System.Drawing.Size(783, 329)
        Me.PnDocentes_Lotes.TabIndex = 32
        Me.PnDocentes_Lotes.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.Location = New System.Drawing.Point(740, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(27, 42)
        Me.btnHelp.TabIndex = 47
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Load
        '
        Me.Load.Image = CType(resources.GetObject("Load.Image"), System.Drawing.Image)
        Me.Load.Location = New System.Drawing.Point(229, 100)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(325, 217)
        Me.Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Load.TabIndex = 46
        Me.Load.TabStop = False
        Me.Load.Visible = False
        '
        'LblRegistros
        '
        Me.LblRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRegistros.AutoSize = True
        Me.LblRegistros.Font = New System.Drawing.Font("Roboto Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistros.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblRegistros.Location = New System.Drawing.Point(10, 80)
        Me.LblRegistros.Name = "LblRegistros"
        Me.LblRegistros.Size = New System.Drawing.Size(112, 17)
        Me.LblRegistros.TabIndex = 45
        Me.LblRegistros.Text = "Total Registros 0"
        '
        'DtDocentesLote
        '
        Me.DtDocentesLote.AllowUserToAddRows = False
        Me.DtDocentesLote.AllowUserToDeleteRows = False
        Me.DtDocentesLote.AllowUserToOrderColumns = True
        Me.DtDocentesLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtDocentesLote.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DtDocentesLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtDocentesLote.GridColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DtDocentesLote.Location = New System.Drawing.Point(13, 100)
        Me.DtDocentesLote.Name = "DtDocentesLote"
        Me.DtDocentesLote.ReadOnly = True
        Me.DtDocentesLote.Size = New System.Drawing.Size(754, 217)
        Me.DtDocentesLote.TabIndex = 43
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(53, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 42
        Me.PictureBox6.TabStop = False
        '
        'Label34
        '
        Me.Label34.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label34.Location = New System.Drawing.Point(75, 28)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(368, 23)
        Me.Label34.TabIndex = 41
        Me.Label34.Text = "Interfaz de Inserción de docentes por lote"
        '
        'BtnCargarMatriculaLotes
        '
        Me.BtnCargarMatriculaLotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCargarMatriculaLotes.FlatAppearance.BorderSize = 0
        Me.BtnCargarMatriculaLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargarMatriculaLotes.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarMatriculaLotes.ForeColor = System.Drawing.Color.White
        Me.BtnCargarMatriculaLotes.Image = CType(resources.GetObject("BtnCargarMatriculaLotes.Image"), System.Drawing.Image)
        Me.BtnCargarMatriculaLotes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCargarMatriculaLotes.Location = New System.Drawing.Point(594, 9)
        Me.BtnCargarMatriculaLotes.Name = "BtnCargarMatriculaLotes"
        Me.BtnCargarMatriculaLotes.Size = New System.Drawing.Size(140, 42)
        Me.BtnCargarMatriculaLotes.TabIndex = 8
        Me.BtnCargarMatriculaLotes.Text = "Cargar Datos"
        Me.BtnCargarMatriculaLotes.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.BtnEditar)
        Me.Panel8.Controls.Add(Me.BtnGuardar)
        Me.Panel8.Controls.Add(Me.BtnCancelar)
        Me.Panel8.Location = New System.Drawing.Point(3, 723)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(783, 55)
        Me.Panel8.TabIndex = 50
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.Enabled = False
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEditar.Location = New System.Drawing.Point(480, 9)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(140, 42)
        Me.BtnEditar.TabIndex = 11
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(330, 9)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 42)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.ChkPorlote)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(32, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(853, 69)
        Me.Panel3.TabIndex = 13
        '
        'ChkPorlote
        '
        Me.ChkPorlote.AutoSize = True
        Me.ChkPorlote.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPorlote.Enabled = False
        Me.ChkPorlote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkPorlote.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ChkPorlote.Location = New System.Drawing.Point(28, 41)
        Me.ChkPorlote.Name = "ChkPorlote"
        Me.ChkPorlote.Size = New System.Drawing.Size(137, 22)
        Me.ChkPorlote.TabIndex = 49
        Me.ChkPorlote.Text = "Insertar Por Lote"
        Me.ChkPorlote.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(322, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(191, 27)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Datos del Docente"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.AutoSize = True
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Image = Global.Ctrl_Estudiantil.My.Resources.Resources.Close
        Me.BtnCerrar.Location = New System.Drawing.Point(1073, 20)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 29)
        Me.BtnCerrar.TabIndex = 34
        Me.BtnCerrar.Text = " "
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'FrmDocentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 749)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Name = "FrmDocentes"
        Me.Text = "FrmDocentes"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Opciones1.ResumeLayout(False)
        Me.OPAsignatura.ResumeLayout(False)
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PnAsignaturas.ResumeLayout(False)
        Me.PnAsignaturas.PerformLayout()
        CType(Me.DtListadoAsignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpAsignaturasGrid.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PnAsignaciondeGrados.ResumeLayout(False)
        Me.PnAsignaciondeGrados.PerformLayout()
        CType(Me.DtGradoAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.COPAsignaciondeGrados.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnAsignaciones.ResumeLayout(False)
        Me.PnAsignaciones.PerformLayout()
        CType(Me.DtAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OPAsignaciones.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtasignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnDocentes_Lotes.ResumeLayout(False)
        Me.PnDocentes_Lotes.PerformLayout()
        CType(Me.Load, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDocentesLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblTotal As Label
    Friend WithEvents chkEliminar As CheckBox
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Opciones1 As ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TTMensaje As ToolTip
    Friend WithEvents TxtBusquedaNombre As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Lbltitulo As Label
    Friend WithEvents EpError As ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Dtasignaturas As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdDocente As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents PnAsignaciones As Panel
    Friend WithEvents BtnAsignarAsignaturas As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents DtAsignaciones As DataGridView
    Friend WithEvents CmbGrado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbModalidades As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbAsignaturas As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnAsignarAsignatura As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCerrarPnAsignaciones As Button
    Friend WithEvents BtnCancelarAsignacion As Button
    Friend WithEvents BtnGuardarAsignacion As Button
    Friend WithEvents OPAsignaciones As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents OPAsignatura As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PnAsignaturas As Panel
    Friend WithEvents DtListadoAsignaturas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TxtNombreAsignatura As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtIdAsignatura As TextBox
    Friend WithEvents BtnCancelarAsgnt As Button
    Friend WithEvents BtnGuardarAsignatura As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnNuevaAsigbatura As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents OpAsignaturasGrid As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents RefrescarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnAsignaciondeGrados As Panel
    Friend WithEvents DtGradoAsignacion As DataGridView
    Friend WithEvents BtnCerrarGradoAsignacion As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents CmbGradoAsignar As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtIdAsignacionGrado As TextBox
    Friend WithEvents btnCancelarGradoAsignado As Button
    Friend WithEvents BtnGuardarGradoAsignado As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnNuevoGradoAsignacion As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtAño As TextBox
    Friend WithEvents AsignarGradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COPAsignaciondeGrados As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents LBLDocenteasignacion As Label
    Friend WithEvents CmbModalidadGrado As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents AsignarAsignaturasAGradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label28 As Label
    Friend WithEvents CmbRol As ComboBox
    Friend WithEvents CmbTurno As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents CmbSeccion As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents BtnEditarAsignacion_Grado As Button
    Friend WithEvents EditarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LblAvanzado As Label
    Friend WithEvents UI_CheckWindows1 As UIDC.UI_CheckWindows
    Friend WithEvents CmbAula As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents CmTurno As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Anio As UIDC.UI_Numeric
    Friend WithEvents Label33 As Label
    Friend WithEvents ChkPorlote As CheckBox
    Friend WithEvents PnDocentes_Lotes As Panel
    Friend WithEvents btnHelp As Button
    Friend WithEvents Load As PictureBox
    Friend WithEvents LblRegistros As Label
    Friend WithEvents DtDocentesLote As DataGridView
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label34 As Label
    Friend WithEvents BtnCargarMatriculaLotes As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel8 As Panel
End Class
