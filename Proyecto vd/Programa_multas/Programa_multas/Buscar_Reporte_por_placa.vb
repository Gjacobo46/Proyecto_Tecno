Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Sql

Public Class Buscar_Reporte_por_placa
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String

    Sub ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        REPORTE.Show()
        Me.Hide()

    End Sub

    Private Sub btn_buscar2_Click(sender As Object, e As EventArgs) Handles btn_buscar2.Click
        If tipo_de_placa.Text = "" Then
            MsgBox("DEBE LLENAR EL CAMPO DE TIPO PLACA")
        ElseIf placa_tipo.Text = "" Then
            MsgBox("DEBE LLENAR EL CAMPO DE PLACA")
        End If

        Try
            Dim da As New SqlDataAdapter("select * from Multa where Placa='" + tipo_de_placa.Text + "" + placa_tipo.Text + "'", con)
            Dim ds As New DataTable
            da.Fill(ds)
            txt_placa2.Text = ds.Rows(0)("Id_multa").ToString
            txt_marca2.Text = ds.Rows(0)("Marca").ToString
            txt_color2.Text = ds.Rows(0)("Color").ToString
            txt_modelo2.Text = ds.Rows(0)("Modelo").ToString
            txt_descripcion2.Text = ds.Rows(0)("Descripcion").ToString
            txt_subtotal2.Text = ds.Rows(0)("Sub_total").ToString
            txt_descuento2.Text = ds.Rows(0)("Descuento").ToString
            txt_total2.Text = ds.Rows(0)("Total").ToString
            MessageBox.Show("BUSQUEDA ENCONTRADA")
        Catch ex As Exception
            tipo_de_placa.Text = ""
            placa_tipo.Clear()

        End Try
    End Sub
End Class
