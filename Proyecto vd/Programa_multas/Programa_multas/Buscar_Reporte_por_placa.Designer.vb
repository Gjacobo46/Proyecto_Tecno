<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_Reporte_por_placa
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscar_Reporte_por_placa))
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_placa2 = New System.Windows.Forms.TextBox()
        Me.txt_marca2 = New System.Windows.Forms.TextBox()
        Me.txt_subtotal2 = New System.Windows.Forms.TextBox()
        Me.txt_color2 = New System.Windows.Forms.TextBox()
        Me.txt_modelo2 = New System.Windows.Forms.TextBox()
        Me.txt_descuento2 = New System.Windows.Forms.TextBox()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.txt_descripcion2 = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_buscar2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tipo_de_placa = New Guna.UI.WinForms.GunaComboBox()
        Me.placa_tipo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox1.BorderSize = 3
        Me.GunaGroupBox1.Controls.Add(Me.GunaGroupBox2)
        Me.GunaGroupBox1.Controls.Add(Me.btn_reporte)
        Me.GunaGroupBox1.Controls.Add(Me.txt_descripcion2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_total2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_descuento2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_modelo2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_color2)
        Me.GunaGroupBox1.Controls.Add(Me.Label10)
        Me.GunaGroupBox1.Controls.Add(Me.txt_subtotal2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_marca2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_placa2)
        Me.GunaGroupBox1.Controls.Add(Me.Label9)
        Me.GunaGroupBox1.Controls.Add(Me.Label8)
        Me.GunaGroupBox1.Controls.Add(Me.Label7)
        Me.GunaGroupBox1.Controls.Add(Me.Label6)
        Me.GunaGroupBox1.Controls.Add(Me.Label5)
        Me.GunaGroupBox1.Controls.Add(Me.Label4)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(908, 504)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "CONSULTAR ESTADO DE PLACA"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(403, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BUSCAR PLACA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(100, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INFORMACION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PLACA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(327, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MODELO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(316, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MARCA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "COLOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(549, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SUB_TOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(549, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "DESCUENTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(46, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "DESCRIPCION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(719, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "TOTAL"
        '
        'txt_placa2
        '
        Me.txt_placa2.Location = New System.Drawing.Point(13, 146)
        Me.txt_placa2.Name = "txt_placa2"
        Me.txt_placa2.Size = New System.Drawing.Size(179, 23)
        Me.txt_placa2.TabIndex = 11
        '
        'txt_marca2
        '
        Me.txt_marca2.Location = New System.Drawing.Point(239, 146)
        Me.txt_marca2.Name = "txt_marca2"
        Me.txt_marca2.Size = New System.Drawing.Size(215, 23)
        Me.txt_marca2.TabIndex = 12
        '
        'txt_subtotal2
        '
        Me.txt_subtotal2.Location = New System.Drawing.Point(475, 146)
        Me.txt_subtotal2.Name = "txt_subtotal2"
        Me.txt_subtotal2.Size = New System.Drawing.Size(202, 23)
        Me.txt_subtotal2.TabIndex = 13
        '
        'txt_color2
        '
        Me.txt_color2.Location = New System.Drawing.Point(13, 217)
        Me.txt_color2.Name = "txt_color2"
        Me.txt_color2.Size = New System.Drawing.Size(179, 23)
        Me.txt_color2.TabIndex = 14
        '
        'txt_modelo2
        '
        Me.txt_modelo2.Location = New System.Drawing.Point(239, 217)
        Me.txt_modelo2.Name = "txt_modelo2"
        Me.txt_modelo2.Size = New System.Drawing.Size(215, 23)
        Me.txt_modelo2.TabIndex = 15
        '
        'txt_descuento2
        '
        Me.txt_descuento2.Location = New System.Drawing.Point(475, 217)
        Me.txt_descuento2.Name = "txt_descuento2"
        Me.txt_descuento2.Size = New System.Drawing.Size(202, 23)
        Me.txt_descuento2.TabIndex = 16
        '
        'txt_total2
        '
        Me.txt_total2.Location = New System.Drawing.Point(676, 181)
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.Size = New System.Drawing.Size(175, 23)
        Me.txt_total2.TabIndex = 17
        '
        'txt_descripcion2
        '
        Me.txt_descripcion2.BaseColor = System.Drawing.Color.White
        Me.txt_descripcion2.BorderColor = System.Drawing.Color.Silver
        Me.txt_descripcion2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descripcion2.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_descripcion2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descripcion2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_descripcion2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_descripcion2.Location = New System.Drawing.Point(13, 299)
        Me.txt_descripcion2.Name = "txt_descripcion2"
        Me.txt_descripcion2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descripcion2.Size = New System.Drawing.Size(217, 169)
        Me.txt_descripcion2.TabIndex = 18
        Me.txt_descripcion2.Text = "HOLA PILOTO"
        '
        'btn_reporte
        '
        Me.btn_reporte.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte.Location = New System.Drawing.Point(676, 37)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(124, 49)
        Me.btn_reporte.TabIndex = 19
        Me.btn_reporte.Text = "IMPRIMIR REPORTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Green
        Me.GunaGroupBox2.BorderSize = 3
        Me.GunaGroupBox2.Controls.Add(Me.btn_buscar2)
        Me.GunaGroupBox2.Controls.Add(Me.PictureBox1)
        Me.GunaGroupBox2.Controls.Add(Me.tipo_de_placa)
        Me.GunaGroupBox2.Controls.Add(Me.placa_tipo)
        Me.GunaGroupBox2.Controls.Add(Me.Label11)
        Me.GunaGroupBox2.Controls.Add(Me.Label12)
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Black
        Me.GunaGroupBox2.Location = New System.Drawing.Point(239, 246)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(446, 222)
        Me.GunaGroupBox2.TabIndex = 21
        Me.GunaGroupBox2.Text = "BUSCAR"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_buscar2
        '
        Me.btn_buscar2.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar2.Location = New System.Drawing.Point(254, 42)
        Me.btn_buscar2.Name = "btn_buscar2"
        Me.btn_buscar2.Size = New System.Drawing.Size(116, 23)
        Me.btn_buscar2.TabIndex = 25
        Me.btn_buscar2.Text = "CONSULTAR"
        Me.btn_buscar2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(178, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'tipo_de_placa
        '
        Me.tipo_de_placa.BackColor = System.Drawing.Color.Transparent
        Me.tipo_de_placa.BaseColor = System.Drawing.Color.White
        Me.tipo_de_placa.BorderColor = System.Drawing.Color.Silver
        Me.tipo_de_placa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tipo_de_placa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_de_placa.FocusedColor = System.Drawing.Color.Empty
        Me.tipo_de_placa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tipo_de_placa.ForeColor = System.Drawing.Color.Black
        Me.tipo_de_placa.FormattingEnabled = True
        Me.tipo_de_placa.Items.AddRange(New Object() {"A", "C", "O", "P", "M", "U", "CC", "CD", "CH", "MI", "TC", "DIS"})
        Me.tipo_de_placa.Location = New System.Drawing.Point(23, 82)
        Me.tipo_de_placa.Name = "tipo_de_placa"
        Me.tipo_de_placa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tipo_de_placa.OnHoverItemForeColor = System.Drawing.Color.White
        Me.tipo_de_placa.Size = New System.Drawing.Size(141, 31)
        Me.tipo_de_placa.TabIndex = 23
        '
        'placa_tipo
        '
        Me.placa_tipo.Location = New System.Drawing.Point(23, 136)
        Me.placa_tipo.Name = "placa_tipo"
        Me.placa_tipo.Size = New System.Drawing.Size(141, 23)
        Me.placa_tipo.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(20, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "PLACA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "TIPO DE PLACA"
        '
        'Buscar_Reporte_por_placa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Buscar_Reporte_por_placa"
        Me.Size = New System.Drawing.Size(923, 523)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_reporte As Button
    Friend WithEvents txt_descripcion2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_total2 As TextBox
    Friend WithEvents txt_descuento2 As TextBox
    Friend WithEvents txt_modelo2 As TextBox
    Friend WithEvents txt_color2 As TextBox
    Friend WithEvents txt_subtotal2 As TextBox
    Friend WithEvents txt_marca2 As TextBox
    Friend WithEvents txt_placa2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_buscar2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tipo_de_placa As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents placa_tipo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
