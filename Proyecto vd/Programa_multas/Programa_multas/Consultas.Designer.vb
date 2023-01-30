<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultas))
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_remision = New System.Windows.Forms.TextBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_sub_total = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.placa_grupo = New System.Windows.Forms.TextBox()
        Me.grupo_placa = New Guna.UI.WinForms.GunaComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaGroupBox1.BorderSize = 3
        Me.GunaGroupBox1.Controls.Add(Me.DataGridView1)
        Me.GunaGroupBox1.Controls.Add(Me.Button2)
        Me.GunaGroupBox1.Controls.Add(Me.btn_mostrar)
        Me.GunaGroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GunaGroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GunaGroupBox1.Controls.Add(Me.Button1)
        Me.GunaGroupBox1.Controls.Add(Me.GunaGroupBox2)
        Me.GunaGroupBox1.Controls.Add(Me.txt_total)
        Me.GunaGroupBox1.Controls.Add(Me.txt_descuento)
        Me.GunaGroupBox1.Controls.Add(Me.txt_sub_total)
        Me.GunaGroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GunaGroupBox1.Controls.Add(Me.txt_modelo)
        Me.GunaGroupBox1.Controls.Add(Me.txt_color)
        Me.GunaGroupBox1.Controls.Add(Me.txt_marca)
        Me.GunaGroupBox1.Controls.Add(Me.txt_placa)
        Me.GunaGroupBox1.Controls.Add(Me.txt_remision)
        Me.GunaGroupBox1.Controls.Add(Me.Label9)
        Me.GunaGroupBox1.Controls.Add(Me.Label8)
        Me.GunaGroupBox1.Controls.Add(Me.Label7)
        Me.GunaGroupBox1.Controls.Add(Me.Label6)
        Me.GunaGroupBox1.Controls.Add(Me.Label5)
        Me.GunaGroupBox1.Controls.Add(Me.Label4)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1083, 518)
        Me.GunaGroupBox1.TabIndex = 0
        Me.GunaGroupBox1.Text = "REPORTAR VEHICULO"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REMISION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(191, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PLACA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(335, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MARCA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(488, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "COLOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(626, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MODELO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(781, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DESCRIPCION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(24, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SUB_TOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(191, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "DESCUENTO: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(390, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL"
        '
        'txt_remision
        '
        Me.txt_remision.Location = New System.Drawing.Point(16, 85)
        Me.txt_remision.Name = "txt_remision"
        Me.txt_remision.Size = New System.Drawing.Size(100, 22)
        Me.txt_remision.TabIndex = 10
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(163, 85)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(100, 22)
        Me.txt_placa.TabIndex = 11
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(314, 85)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(100, 22)
        Me.txt_marca.TabIndex = 12
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(466, 85)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(100, 22)
        Me.txt_color.TabIndex = 13
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(609, 85)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(100, 22)
        Me.txt_modelo.TabIndex = 14
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(754, 85)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(157, 22)
        Me.txt_descripcion.TabIndex = 15
        '
        'txt_sub_total
        '
        Me.txt_sub_total.Location = New System.Drawing.Point(9, 166)
        Me.txt_sub_total.Name = "txt_sub_total"
        Me.txt_sub_total.Size = New System.Drawing.Size(118, 22)
        Me.txt_sub_total.TabIndex = 16
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(174, 166)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(141, 22)
        Me.txt_descuento.TabIndex = 17
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(346, 164)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(134, 22)
        Me.txt_total.TabIndex = 18
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Green
        Me.GunaGroupBox2.BorderSize = 3
        Me.GunaGroupBox2.Controls.Add(Me.btn_buscar)
        Me.GunaGroupBox2.Controls.Add(Me.PictureBox1)
        Me.GunaGroupBox2.Controls.Add(Me.grupo_placa)
        Me.GunaGroupBox2.Controls.Add(Me.placa_grupo)
        Me.GunaGroupBox2.Controls.Add(Me.Label11)
        Me.GunaGroupBox2.Controls.Add(Me.Label10)
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Black
        Me.GunaGroupBox2.Location = New System.Drawing.Point(16, 322)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(428, 184)
        Me.GunaGroupBox2.TabIndex = 20
        Me.GunaGroupBox2.Text = "BUSCAR"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(20, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "TIPO DE PLACA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(20, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "PLACA"
        '
        'placa_grupo
        '
        Me.placa_grupo.Location = New System.Drawing.Point(23, 136)
        Me.placa_grupo.Name = "placa_grupo"
        Me.placa_grupo.Size = New System.Drawing.Size(141, 22)
        Me.placa_grupo.TabIndex = 22
        '
        'grupo_placa
        '
        Me.grupo_placa.BackColor = System.Drawing.Color.Transparent
        Me.grupo_placa.BaseColor = System.Drawing.Color.White
        Me.grupo_placa.BorderColor = System.Drawing.Color.Silver
        Me.grupo_placa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.grupo_placa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grupo_placa.FocusedColor = System.Drawing.Color.Empty
        Me.grupo_placa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grupo_placa.ForeColor = System.Drawing.Color.Black
        Me.grupo_placa.FormattingEnabled = True
        Me.grupo_placa.Items.AddRange(New Object() {"A", "C", "O", "P", "M", "U", "CC", "CD", "CH", "MI", "TC", "DIS"})
        Me.grupo_placa.Location = New System.Drawing.Point(23, 82)
        Me.grupo_placa.Name = "grupo_placa"
        Me.grupo_placa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grupo_placa.OnHoverItemForeColor = System.Drawing.Color.White
        Me.grupo_placa.Size = New System.Drawing.Size(141, 31)
        Me.grupo_placa.TabIndex = 23
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
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(27, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.ForeColor = System.Drawing.Color.Black
        Me.btn_actualizar.Location = New System.Drawing.Point(163, 284)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(111, 23)
        Me.btn_actualizar.TabIndex = 22
        Me.btn_actualizar.Text = "ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(175, 240)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(88, 23)
        Me.btn_eliminar.TabIndex = 23
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_mostrar
        '
        Me.btn_mostrar.ForeColor = System.Drawing.Color.Black
        Me.btn_mostrar.Location = New System.Drawing.Point(326, 240)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(88, 23)
        Me.btn_mostrar.TabIndex = 24
        Me.btn_mostrar.Text = "MOSTRAR"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Location = New System.Drawing.Point(254, 42)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(88, 23)
        Me.btn_buscar.TabIndex = 25
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(339, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(491, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(577, 366)
        Me.DataGridView1.TabIndex = 26
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Name = "Consultas"
        Me.Size = New System.Drawing.Size(1116, 548)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txt_remision As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_sub_total As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grupo_placa As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents placa_grupo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
