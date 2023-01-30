Public Class REPORTE
    Private Sub REPORTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Multas_0DataSet.Multa' table. You can move, or remove it, as needed.
        Me.MultaTableAdapter.Fill(Me.Multas_0DataSet.Multa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class