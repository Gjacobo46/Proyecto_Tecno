Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class Form1
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Consultas1.BringToFront()

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Buscar_Reporte_por_placa1.BringToFront()

    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Dim f2 As New MENU
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Buscar_Reporte_por_placa1_Load(sender As Object, e As EventArgs) Handles Buscar_Reporte_por_placa1.Load

    End Sub
End Class
