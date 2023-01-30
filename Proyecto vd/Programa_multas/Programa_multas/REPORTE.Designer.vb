<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Multas_0DataSet = New Programa_multas.Multas_0DataSet()
        Me.MultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MultaTableAdapter = New Programa_multas.Multas_0DataSetTableAdapters.MultaTableAdapter()
        CType(Me.Multas_0DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MultaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_multas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(27, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1011, 501)
        Me.ReportViewer1.TabIndex = 0
        '
        'Multas_0DataSet
        '
        Me.Multas_0DataSet.DataSetName = "Multas_0DataSet"
        Me.Multas_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MultaBindingSource
        '
        Me.MultaBindingSource.DataMember = "Multa"
        Me.MultaBindingSource.DataSource = Me.Multas_0DataSet
        '
        'MultaTableAdapter
        '
        Me.MultaTableAdapter.ClearBeforeFill = True
        '
        'REPORTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 585)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "REPORTE"
        Me.Text = "REPORTE"
        CType(Me.Multas_0DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MultaBindingSource As BindingSource
    Friend WithEvents Multas_0DataSet As Multas_0DataSet
    Friend WithEvents MultaTableAdapter As Multas_0DataSetTableAdapters.MultaTableAdapter
End Class
