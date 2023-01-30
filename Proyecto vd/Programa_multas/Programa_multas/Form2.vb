Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class Form2
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If combox_placa.Text = "" Then
            MsgBox("DEBE LLENAR EL CAMPO DE TIPO PLACA")
        ElseIf txt_placa.Text = "" Then
            MsgBox("DEBE LLENAR EL CAMPO DE PLACA")
        End If

        Try
            Dim da As New SqlDataAdapter("select * from Multa where Placa='" + combox_placa.Text + "" + txt_placa.Text + "'", Con)
            Dim ds As New DataTable
            da.Fill(ds)
            txt_multa.Text = ds.Rows(0)("Total").ToString
            MessageBox.Show("BUSQUEDA ENCONTRADA")
        Catch ex As Exception
            combox_placa.Text = ""
            txt_placa.Clear()

        End Try

    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        REPORTE.Show()
        MessageBox.Show("IMPRIMA SU REPORTE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New MENU
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs) Handles GunaGroupBox2.Click

    End Sub
End Class

