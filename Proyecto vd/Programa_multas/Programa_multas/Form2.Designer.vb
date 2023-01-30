<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_multa = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.combox_placa = New Guna.UI.WinForms.GunaComboBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GunaImageButton1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1267, 137)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(40, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 50)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "REGRESAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(662, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 95)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mixco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(490, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 95)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Muni"
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = CType(resources.GetObject("GunaImageButton1.Image"), System.Drawing.Image)
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(125, 125)
        Me.GunaImageButton1.Location = New System.Drawing.Point(344, 12)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(152, 131)
        Me.GunaImageButton1.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Book Antiqua", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(506, 107)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(396, 28)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "!Trabajando Por Nuestra Ciudad¡"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Green
        Me.GunaGroupBox2.BorderSize = 3
        Me.GunaGroupBox2.Controls.Add(Me.Btn_Imprimir)
        Me.GunaGroupBox2.Controls.Add(Me.Label4)
        Me.GunaGroupBox2.Controls.Add(Me.Label3)
        Me.GunaGroupBox2.Controls.Add(Me.txt_multa)
        Me.GunaGroupBox2.Controls.Add(Me.btn_buscar)
        Me.GunaGroupBox2.Controls.Add(Me.PictureBox1)
        Me.GunaGroupBox2.Controls.Add(Me.combox_placa)
        Me.GunaGroupBox2.Controls.Add(Me.txt_placa)
        Me.GunaGroupBox2.Controls.Add(Me.Label11)
        Me.GunaGroupBox2.Controls.Add(Me.Label10)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Black
        Me.GunaGroupBox2.Location = New System.Drawing.Point(63, 141)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(1144, 534)
        Me.GunaGroupBox2.TabIndex = 21
        Me.GunaGroupBox2.Text = "BUSCAR"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Btn_Imprimir.Location = New System.Drawing.Point(872, 47)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(241, 99)
        Me.Btn_Imprimir.TabIndex = 29
        Me.Btn_Imprimir.Text = "IMPRIMIR REPORTE"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(832, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 95)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(947, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "TOTAL DE MULTA"
        '
        'txt_multa
        '
        Me.txt_multa.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_multa.Location = New System.Drawing.Point(929, 348)
        Me.txt_multa.Name = "txt_multa"
        Me.txt_multa.Size = New System.Drawing.Size(188, 35)
        Me.txt_multa.TabIndex = 26
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Location = New System.Drawing.Point(449, 421)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(164, 46)
        Me.btn_buscar.TabIndex = 25
        Me.btn_buscar.Text = "Consultar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(410, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'combox_placa
        '
        Me.combox_placa.BackColor = System.Drawing.Color.Transparent
        Me.combox_placa.BaseColor = System.Drawing.Color.White
        Me.combox_placa.BorderColor = System.Drawing.Color.Silver
        Me.combox_placa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combox_placa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combox_placa.FocusedColor = System.Drawing.Color.Empty
        Me.combox_placa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combox_placa.ForeColor = System.Drawing.Color.Black
        Me.combox_placa.FormattingEnabled = True
        Me.combox_placa.Items.AddRange(New Object() {"A", "C", "O", "P", "M", "U", "CC", "CD", "CH", "MI", "TC", "DIS"})
        Me.combox_placa.Location = New System.Drawing.Point(325, 273)
        Me.combox_placa.Name = "combox_placa"
        Me.combox_placa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combox_placa.OnHoverItemForeColor = System.Drawing.Color.White
        Me.combox_placa.Size = New System.Drawing.Size(470, 31)
        Me.combox_placa.TabIndex = 23
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(325, 358)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(470, 42)
        Me.txt_placa.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(328, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 36)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "PLACA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(322, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 36)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "TIPO DE PLACA"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 685)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents combox_placa As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_multa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Button1 As Button
End Class
