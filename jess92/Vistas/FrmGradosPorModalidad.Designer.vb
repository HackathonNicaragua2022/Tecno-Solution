<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGradosPorModalidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGradosPorModalidad))
        Me.PnAsignaciondeGrados = New System.Windows.Forms.Panel()
        Me.DtGradoAsignacion = New System.Windows.Forms.DataGridView()
        Me.BtnCerrarGradoAsignacion = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.CmbAsignaturas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbModalidadGrado = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.CmbGradoAsignar = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtIdAsignacionGrado = New System.Windows.Forms.TextBox()
        Me.btnCancelarGradoAsignado = New System.Windows.Forms.Button()
        Me.BtnGuardarGradoAsignado = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblMainTitulo = New System.Windows.Forms.Label()
        Me.BtnNuevoGradoAsignacion = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Opciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnAsignaciondeGrados.SuspendLayout()
        CType(Me.DtGradoAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnAsignaciondeGrados
        '
        Me.PnAsignaciondeGrados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PnAsignaciondeGrados.BackColor = System.Drawing.Color.White
        Me.PnAsignaciondeGrados.Controls.Add(Me.DtGradoAsignacion)
        Me.PnAsignaciondeGrados.Controls.Add(Me.BtnCerrarGradoAsignacion)
        Me.PnAsignaciondeGrados.Controls.Add(Me.Panel11)
        Me.PnAsignaciondeGrados.Controls.Add(Me.Label24)
        Me.PnAsignaciondeGrados.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnAsignaciondeGrados.Location = New System.Drawing.Point(46, 12)
        Me.PnAsignaciondeGrados.Name = "PnAsignaciondeGrados"
        Me.PnAsignaciondeGrados.Size = New System.Drawing.Size(845, 581)
        Me.PnAsignaciondeGrados.TabIndex = 54
        '
        'DtGradoAsignacion
        '
        Me.DtGradoAsignacion.AllowUserToAddRows = False
        Me.DtGradoAsignacion.AllowUserToDeleteRows = False
        Me.DtGradoAsignacion.AllowUserToOrderColumns = True
        Me.DtGradoAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DtGradoAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGradoAsignacion.ContextMenuStrip = Me.Opciones
        Me.DtGradoAsignacion.Location = New System.Drawing.Point(31, 379)
        Me.DtGradoAsignacion.Name = "DtGradoAsignacion"
        Me.DtGradoAsignacion.ReadOnly = True
        Me.DtGradoAsignacion.Size = New System.Drawing.Size(787, 190)
        Me.DtGradoAsignacion.TabIndex = 48
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
        Me.BtnCerrarGradoAsignacion.Location = New System.Drawing.Point(809, 6)
        Me.BtnCerrarGradoAsignacion.Name = "BtnCerrarGradoAsignacion"
        Me.BtnCerrarGradoAsignacion.Size = New System.Drawing.Size(30, 33)
        Me.BtnCerrarGradoAsignacion.TabIndex = 35
        Me.BtnCerrarGradoAsignacion.Text = " "
        Me.BtnCerrarGradoAsignacion.UseVisualStyleBackColor = False
        Me.BtnCerrarGradoAsignacion.Visible = False
        '
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Controls.Add(Me.CmbAsignaturas)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Controls.Add(Me.CmbModalidadGrado)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Controls.Add(Me.LblTitulo)
        Me.Panel11.Controls.Add(Me.CmbGradoAsignar)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.TxtIdAsignacionGrado)
        Me.Panel11.Controls.Add(Me.btnCancelarGradoAsignado)
        Me.Panel11.Controls.Add(Me.BtnGuardarGradoAsignado)
        Me.Panel11.Controls.Add(Me.PictureBox5)
        Me.Panel11.Controls.Add(Me.lblMainTitulo)
        Me.Panel11.Controls.Add(Me.BtnNuevoGradoAsignacion)
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Location = New System.Drawing.Point(31, 73)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(787, 284)
        Me.Panel11.TabIndex = 31
        '
        'CmbAsignaturas
        '
        Me.CmbAsignaturas.FormattingEnabled = True
        Me.CmbAsignaturas.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbAsignaturas.Location = New System.Drawing.Point(169, 179)
        Me.CmbAsignaturas.Name = "CmbAsignaturas"
        Me.CmbAsignaturas.Size = New System.Drawing.Size(398, 27)
        Me.CmbAsignaturas.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(76, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Asignatura:"
        '
        'CmbModalidadGrado
        '
        Me.CmbModalidadGrado.FormattingEnabled = True
        Me.CmbModalidadGrado.Items.AddRange(New Object() {"PREESCOLAR FORMAL", "PREESCOLAR FORMAL MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO" & Global.Microsoft.VisualBasic.ChrW(9), "PREESCOLAR COMUNITARIO MULTINIVEL" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9), "PRIMARIA MULTIGRADO", "SECUNDARIA REGULAR" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA DIURNA" & Global.Microsoft.VisualBasic.ChrW(9), "SECUNDARIA EN EL CAMPO"})
        Me.CmbModalidadGrado.Location = New System.Drawing.Point(169, 134)
        Me.CmbModalidadGrado.Name = "CmbModalidadGrado"
        Me.CmbModalidadGrado.Size = New System.Drawing.Size(350, 27)
        Me.CmbModalidadGrado.TabIndex = 57
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label27.Location = New System.Drawing.Point(76, 138)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 19)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Modalidad:"
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.LblTitulo.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.SlateGray
        Me.LblTitulo.Location = New System.Drawing.Point(28, 234)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(422, 23)
        Me.LblTitulo.TabIndex = 56
        Me.LblTitulo.Text = "Centro Educativo Francica Hernández Espininoza."
        Me.LblTitulo.Visible = False
        '
        'CmbGradoAsignar
        '
        Me.CmbGradoAsignar.FormattingEnabled = True
        Me.CmbGradoAsignar.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "SEPTIMO", "OCTAVO", "NOVENO", "DÉCIMO", "UNDÉCIMO"})
        Me.CmbGradoAsignar.Location = New System.Drawing.Point(622, 134)
        Me.CmbGradoAsignar.Name = "CmbGradoAsignar"
        Me.CmbGradoAsignar.Size = New System.Drawing.Size(98, 27)
        Me.CmbGradoAsignar.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(75, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 19)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Id Asignación:"
        '
        'TxtIdAsignacionGrado
        '
        Me.TxtIdAsignacionGrado.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAsignacionGrado.Location = New System.Drawing.Point(196, 93)
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
        'BtnGuardarGradoAsignado
        '
        Me.BtnGuardarGradoAsignado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarGradoAsignado.FlatAppearance.BorderSize = 0
        Me.BtnGuardarGradoAsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarGradoAsignado.Font = New System.Drawing.Font("Roboto Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarGradoAsignado.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarGradoAsignado.Image = CType(resources.GetObject("BtnGuardarGradoAsignado.Image"), System.Drawing.Image)
        Me.BtnGuardarGradoAsignado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnGuardarGradoAsignado.Location = New System.Drawing.Point(485, 224)
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
        'lblMainTitulo
        '
        Me.lblMainTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMainTitulo.AutoSize = True
        Me.lblMainTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.lblMainTitulo.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitulo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblMainTitulo.Location = New System.Drawing.Point(75, 42)
        Me.lblMainTitulo.Name = "lblMainTitulo"
        Me.lblMainTitulo.Size = New System.Drawing.Size(438, 23)
        Me.lblMainTitulo.TabIndex = 41
        Me.lblMainTitulo.Text = "Centro Educativo Francica Hernández Espininoza."
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
        Me.BtnNuevoGradoAsignacion.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Roboto Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Location = New System.Drawing.Point(554, 141)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 19)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Grado:"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Font = New System.Drawing.Font("Roboto Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label24.Location = New System.Drawing.Point(303, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(239, 27)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Asignaturas por Grado."
        '
        'Opciones
        '
        Me.Opciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(127, 70)
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FrmGradosPorModalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(937, 606)
        Me.Controls.Add(Me.PnAsignaciondeGrados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGradosPorModalidad"
        Me.Text = "FrmGradosPorModalidad"
        Me.PnAsignaciondeGrados.ResumeLayout(False)
        Me.PnAsignaciondeGrados.PerformLayout()
        CType(Me.DtGradoAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Opciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnAsignaciondeGrados As Panel
    Friend WithEvents DtGradoAsignacion As DataGridView
    Friend WithEvents BtnCerrarGradoAsignacion As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents CmbModalidadGrado As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents CmbGradoAsignar As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtIdAsignacionGrado As TextBox
    Friend WithEvents btnCancelarGradoAsignado As Button
    Friend WithEvents BtnGuardarGradoAsignado As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblMainTitulo As Label
    Friend WithEvents BtnNuevoGradoAsignacion As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents CmbAsignaturas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Opciones As ContextMenuStrip
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
