<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.UI_CustomButton5 = New UIDC.UI_CustomButton()
        Me.UI_CustomButton6 = New UIDC.UI_CustomButton()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LblRuta = New System.Windows.Forms.TextBox()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.LblRuta)
        Me.Panel12.Controls.Add(Me.UI_CustomButton5)
        Me.Panel12.Controls.Add(Me.UI_CustomButton6)
        Me.Panel12.Location = New System.Drawing.Point(9, 9)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(172, 64)
        Me.Panel12.TabIndex = 14
        '
        'UI_CustomButton5
        '
        Me.UI_CustomButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton5.ButtonImage = CType(resources.GetObject("UI_CustomButton5.ButtonImage"), System.Drawing.Image)
        Me.UI_CustomButton5.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton5.ButtonText = "Copias de seguridad"
        Me.UI_CustomButton5.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UI_CustomButton5.ClickTextColor = System.Drawing.Color.White
        Me.UI_CustomButton5.CornerRadius = 5
        Me.UI_CustomButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_CustomButton5.HoverTextColor = System.Drawing.Color.Gainsboro
        Me.UI_CustomButton5.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton5.Location = New System.Drawing.Point(7, 3)
        Me.UI_CustomButton5.Name = "UI_CustomButton5"
        Me.UI_CustomButton5.Size = New System.Drawing.Size(153, 29)
        Me.UI_CustomButton5.TabIndex = 6
        Me.UI_CustomButton5.Text = "Inventarios"
        Me.UI_CustomButton5.TextColor = System.Drawing.Color.White
        Me.UI_CustomButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'UI_CustomButton6
        '
        Me.UI_CustomButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.UI_CustomButton6.ButtonImage = Nothing
        Me.UI_CustomButton6.ButtonStyle = UIDC.UI_CustomButton.Style.MaterialRounded
        Me.UI_CustomButton6.ButtonText = "Restaurar Base de datos"
        Me.UI_CustomButton6.ClickBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UI_CustomButton6.ClickTextColor = System.Drawing.Color.White
        Me.UI_CustomButton6.CornerRadius = 5
        Me.UI_CustomButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_CustomButton6.Horizontal_Alignment = System.Drawing.StringAlignment.Center
        Me.UI_CustomButton6.HoverBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_CustomButton6.HoverTextColor = System.Drawing.Color.Gainsboro
        Me.UI_CustomButton6.ImagePosition = UIDC.UI_CustomButton.imgPosition.Left
        Me.UI_CustomButton6.Location = New System.Drawing.Point(7, 34)
        Me.UI_CustomButton6.Name = "UI_CustomButton6"
        Me.UI_CustomButton6.Size = New System.Drawing.Size(153, 29)
        Me.UI_CustomButton6.TabIndex = 7
        Me.UI_CustomButton6.Text = "Restaurar Base de datos"
        Me.UI_CustomButton6.TextColor = System.Drawing.Color.White
        Me.UI_CustomButton6.Vertical_Alignment = System.Drawing.StringAlignment.Center
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'LblRuta
        '
        Me.LblRuta.Location = New System.Drawing.Point(177, 12)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(114, 20)
        Me.LblRuta.TabIndex = 39
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 450)
        Me.Controls.Add(Me.Panel12)
        Me.Name = "FrmDashboard"
        Me.Text = "FrmDashboard"
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel12 As Panel
    Friend WithEvents UI_CustomButton5 As UIDC.UI_CustomButton
    Friend WithEvents UI_CustomButton6 As UIDC.UI_CustomButton
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LblRuta As TextBox
End Class
