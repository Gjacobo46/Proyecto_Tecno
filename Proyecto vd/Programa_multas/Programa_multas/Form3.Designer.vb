<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grupo_placa = New Guna.UI.WinForms.GunaComboBox()
        Me.placa_grupo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_sub_total = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_remision = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 145)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(433, 297)
        Me.DataGridView1.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(277, 267)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_mostrar
        '
        Me.btn_mostrar.ForeColor = System.Drawing.Color.Black
        Me.btn_mostrar.Location = New System.Drawing.Point(267, 231)
        Me.btn_mostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(66, 19)
        Me.btn_mostrar.TabIndex = 49
        Me.btn_mostrar.Text = "MOSTRAR"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(154, 231)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(66, 19)
        Me.btn_eliminar.TabIndex = 48
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.ForeColor = System.Drawing.Color.Black
        Me.btn_actualizar.Location = New System.Drawing.Point(145, 267)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(83, 19)
        Me.btn_actualizar.TabIndex = 47
        Me.btn_actualizar.Text = "ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(43, 231)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 19)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GunaGroupBox2.Location = New System.Drawing.Point(35, 298)
        Me.GunaGroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(321, 150)
        Me.GunaGroupBox2.TabIndex = 45
        Me.GunaGroupBox2.Text = "BUSCAR"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_buscar
        '
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Location = New System.Drawing.Point(190, 34)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(66, 19)
        Me.btn_buscar.TabIndex = 25
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 67)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
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
        Me.grupo_placa.Location = New System.Drawing.Point(17, 67)
        Me.grupo_placa.Margin = New System.Windows.Forms.Padding(2)
        Me.grupo_placa.Name = "grupo_placa"
        Me.grupo_placa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grupo_placa.OnHoverItemForeColor = System.Drawing.Color.White
        Me.grupo_placa.Size = New System.Drawing.Size(107, 26)
        Me.grupo_placa.TabIndex = 23
        '
        'placa_grupo
        '
        Me.placa_grupo.Location = New System.Drawing.Point(17, 110)
        Me.placa_grupo.Margin = New System.Windows.Forms.Padding(2)
        Me.placa_grupo.Name = "placa_grupo"
        Me.placa_grupo.Size = New System.Drawing.Size(107, 20)
        Me.placa_grupo.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(15, 94)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "PLACA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 50)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "TIPO DE PLACA"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(283, 169)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(102, 20)
        Me.txt_total.TabIndex = 44
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(153, 171)
        Me.txt_descuento.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(107, 20)
        Me.txt_descuento.TabIndex = 43
        '
        'txt_sub_total
        '
        Me.txt_sub_total.Location = New System.Drawing.Point(30, 171)
        Me.txt_sub_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sub_total.Name = "txt_sub_total"
        Me.txt_sub_total.Size = New System.Drawing.Size(90, 20)
        Me.txt_sub_total.TabIndex = 42
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(589, 105)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(119, 20)
        Me.txt_descripcion.TabIndex = 41
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(480, 105)
        Me.txt_modelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(76, 20)
        Me.txt_modelo.TabIndex = 40
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(373, 105)
        Me.txt_color.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(76, 20)
        Me.txt_color.TabIndex = 39
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(259, 105)
        Me.txt_marca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(76, 20)
        Me.txt_marca.TabIndex = 38
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(145, 105)
        Me.txt_placa.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(76, 20)
        Me.txt_placa.TabIndex = 37
        '
        'txt_remision
        '
        Me.txt_remision.Location = New System.Drawing.Point(35, 105)
        Me.txt_remision.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_remision.Name = "txt_remision"
        Me.txt_remision.Size = New System.Drawing.Size(76, 20)
        Me.txt_remision.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(315, 145)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "TOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(166, 137)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "DESCUENTO: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "SUB_TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(609, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "DESCRIPCION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(493, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "MODELO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(389, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "COLOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(274, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "MARCA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(166, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "PLACA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "REMISION:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 530)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_descuento)
        Me.Controls.Add(Me.txt_sub_total)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.txt_remision)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
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
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_sub_total As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_placa As TextBox
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
End Class
