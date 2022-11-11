<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotas_Por_Alumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotas_Por_Alumno))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CmbAño = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtModalidad = New System.Windows.Forms.Label()
        Me.LblId_Mined = New System.Windows.Forms.Label()
        Me.TxtGrado = New System.Windows.Forms.Label()
        Me.LblAlumno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.LblRendimiento = New System.Windows.Forms.Label()
        Me.TtMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblRendimiento)
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.CmbAño)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtModalidad)
        Me.Panel1.Controls.Add(Me.LblId_Mined)
        Me.Panel1.Controls.Add(Me.TxtGrado)
        Me.Panel1.Controls.Add(Me.LblAlumno)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LblTitulo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 124)
        Me.Panel1.TabIndex = 0
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Roboto Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(789, 9)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(86, 42)
        Me.BtnEliminar.TabIndex = 68
        Me.BtnEliminar.Text = "Actualizar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'CmbAño
        '
        Me.CmbAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbAño.BackColor = System.Drawing.SystemColors.Control
        Me.CmbAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAño.FormattingEnabled = True
        Me.CmbAño.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.CmbAño.Location = New System.Drawing.Point(886, 41)
        Me.CmbAño.Name = "CmbAño"
        Me.CmbAño.Size = New System.Drawing.Size(66, 28)
        Me.CmbAño.TabIndex = 67
        Me.CmbAño.Text = "2021"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(881, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 29)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Año:"
        '
        'TxtModalidad
        '
        Me.TxtModalidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtModalidad.AutoSize = True
        Me.TxtModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtModalidad.Location = New System.Drawing.Point(683, 95)
        Me.TxtModalidad.Name = "TxtModalidad"
        Me.TxtModalidad.Size = New System.Drawing.Size(63, 20)
        Me.TxtModalidad.TabIndex = 66
        Me.TxtModalidad.Text = "Alumno"
        '
        'LblId_Mined
        '
        Me.LblId_Mined.AutoSize = True
        Me.LblId_Mined.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId_Mined.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblId_Mined.Location = New System.Drawing.Point(291, 100)
        Me.LblId_Mined.Name = "LblId_Mined"
        Me.LblId_Mined.Size = New System.Drawing.Size(63, 20)
        Me.LblId_Mined.TabIndex = 66
        Me.LblId_Mined.Text = "Alumno"
        '
        'TxtGrado
        '
        Me.TxtGrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGrado.AutoSize = True
        Me.TxtGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrado.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtGrado.Location = New System.Drawing.Point(683, 69)
        Me.TxtGrado.Name = "TxtGrado"
        Me.TxtGrado.Size = New System.Drawing.Size(63, 20)
        Me.TxtGrado.TabIndex = 66
        Me.TxtGrado.Text = "Alumno"
        '
        'LblAlumno
        '
        Me.LblAlumno.AutoSize = True
        Me.LblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlumno.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblAlumno.Location = New System.Drawing.Point(291, 74)
        Me.LblAlumno.Name = "LblAlumno"
        Me.LblAlumno.Size = New System.Drawing.Size(63, 20)
        Me.LblAlumno.TabIndex = 66
        Me.LblAlumno.Text = "Alumno"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(399, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 24)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Boletín Educativo"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(558, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 29)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Modalidad:"
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblTitulo.Location = New System.Drawing.Point(238, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(503, 29)
        Me.LblTitulo.TabIndex = 65
        Me.LblTitulo.Text = "Notas Instituto Francisca Hernándes Espinoza"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(605, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 29)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Grado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(178, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 29)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(176, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Alumno:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 405)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Datalistado)
        Me.Panel4.Location = New System.Drawing.Point(39, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(903, 387)
        Me.Panel4.TabIndex = 3
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AllowUserToOrderColumns = True
        Me.Datalistado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Location = New System.Drawing.Point(18, 18)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.Size = New System.Drawing.Size(869, 353)
        Me.Datalistado.TabIndex = 0
        '
        'LblRendimiento
        '
        Me.LblRendimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRendimiento.AutoSize = True
        Me.LblRendimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRendimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblRendimiento.Location = New System.Drawing.Point(891, 91)
        Me.LblRendimiento.Name = "LblRendimiento"
        Me.LblRendimiento.Size = New System.Drawing.Size(61, 29)
        Me.LblRendimiento.TabIndex = 70
        Me.LblRendimiento.Text = "90%"
        Me.LblRendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TtMensaje.SetToolTip(Me.LblRendimiento, "Rendimiento Académico")
        '
        'TtMensaje
        '
        Me.TtMensaje.ShowAlways = True
        '
        'FrmNotas_Por_Alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmNotas_Por_Alumno"
        Me.Text = "Notas Por Alumno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CmbAño As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblAlumno As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblId_Mined As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtModalidad As Label
    Friend WithEvents TxtGrado As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblRendimiento As Label
    Friend WithEvents TtMensaje As ToolTip
End Class
