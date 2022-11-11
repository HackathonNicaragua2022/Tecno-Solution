<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddAsignaturaA_Notas
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
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtAsignatura = New System.Windows.Forms.TextBox()
        Me.BtnAddNota = New System.Windows.Forms.Button()
        Me.BtnAddRendimiento = New System.Windows.Forms.Button()
        Me.BtnBuscarAlumnos = New System.Windows.Forms.Button()
        Me.BtnCorregirGrado = New System.Windows.Forms.Button()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListado
        '
        Me.DataListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(28, 74)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.Size = New System.Drawing.Size(742, 349)
        Me.DataListado.TabIndex = 5
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(175, 28)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtAsignatura
        '
        Me.TxtAsignatura.Location = New System.Drawing.Point(28, 28)
        Me.TxtAsignatura.Name = "TxtAsignatura"
        Me.TxtAsignatura.Size = New System.Drawing.Size(132, 20)
        Me.TxtAsignatura.TabIndex = 3
        '
        'BtnAddNota
        '
        Me.BtnAddNota.Location = New System.Drawing.Point(265, 28)
        Me.BtnAddNota.Name = "BtnAddNota"
        Me.BtnAddNota.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddNota.TabIndex = 4
        Me.BtnAddNota.Text = "Add Nota"
        Me.BtnAddNota.UseVisualStyleBackColor = True
        '
        'BtnAddRendimiento
        '
        Me.BtnAddRendimiento.Location = New System.Drawing.Point(361, 28)
        Me.BtnAddRendimiento.Name = "BtnAddRendimiento"
        Me.BtnAddRendimiento.Size = New System.Drawing.Size(106, 23)
        Me.BtnAddRendimiento.TabIndex = 6
        Me.BtnAddRendimiento.Text = "Add Rendimiento"
        Me.BtnAddRendimiento.UseVisualStyleBackColor = True
        '
        'BtnBuscarAlumnos
        '
        Me.BtnBuscarAlumnos.Location = New System.Drawing.Point(488, 28)
        Me.BtnBuscarAlumnos.Name = "BtnBuscarAlumnos"
        Me.BtnBuscarAlumnos.Size = New System.Drawing.Size(106, 23)
        Me.BtnBuscarAlumnos.TabIndex = 7
        Me.BtnBuscarAlumnos.Text = "Buscar Estudiantes"
        Me.BtnBuscarAlumnos.UseVisualStyleBackColor = True
        '
        'BtnCorregirGrado
        '
        Me.BtnCorregirGrado.Location = New System.Drawing.Point(600, 28)
        Me.BtnCorregirGrado.Name = "BtnCorregirGrado"
        Me.BtnCorregirGrado.Size = New System.Drawing.Size(106, 23)
        Me.BtnCorregirGrado.TabIndex = 8
        Me.BtnCorregirGrado.Text = "Corregir Grado"
        Me.BtnCorregirGrado.UseVisualStyleBackColor = True
        '
        'FrmAddAsignaturaA_Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCorregirGrado)
        Me.Controls.Add(Me.BtnBuscarAlumnos)
        Me.Controls.Add(Me.BtnAddRendimiento)
        Me.Controls.Add(Me.DataListado)
        Me.Controls.Add(Me.BtnAddNota)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtAsignatura)
        Me.Name = "FrmAddAsignaturaA_Notas"
        Me.Text = "FrmAddAsignaturaA_Notas"
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataListado As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtAsignatura As TextBox
    Friend WithEvents BtnAddNota As Button
    Friend WithEvents BtnAddRendimiento As Button
    Friend WithEvents BtnBuscarAlumnos As Button
    Friend WithEvents BtnCorregirGrado As Button
End Class
