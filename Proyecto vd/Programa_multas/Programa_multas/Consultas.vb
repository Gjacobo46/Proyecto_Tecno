Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Sql

Public Class Consultas
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
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_remision.TextChanged

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "update registros set Placa='" + txt_placa.Text + "',Marca='" + txt_marca.Text + "',Color='" + txt_color.Text + "',Modelo='" + txt_modelo.Text + "',Descripcion='" + txt_descripcion.Text + "',Sub_total='" + txt_sub_total.Text + "',Descuento='" + txt_descuento.Text + "',Total='" + txt_total.Text + "'where Id='" + txt_remision.Text + "'"
        mensaje = "Datos insertados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from registros", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "delete registros where Id_multa='" + txt_remision.Text + "'"
        mensaje = "Datos insertados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Multa", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("Select * from Multa", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If placa_grupo.Text = "" Then
            MsgBox("DEBE LLENAR EL CAMPO DE PLACA")
        End If
        If grupo_placa.Text = "" Then
            MsgBox("DEBE LLENAR EL CAMPO DE TIPO DE PLACA")
        End If
        Dim da As New SqlDataAdapter("select * from Multa where Placa='" + grupo_placa.Text + "" + placa_grupo.Text + "'", con)
        Dim ds As New DataTable
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds
        grupo_placa.Text = ""
        placa_grupo.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentencia = "insert into Multa values('" + txt_remision.Text + "','" + txt_placa.Text + "','" + txt_marca.Text + "','" + txt_color.Text + "','" + txt_modelo.Text + "','" + txt_descripcion.Text + "','" + txt_sub_total.Text + "','" + txt_descuento.Text + "','" + txt_total.Text + "')"
        mensaje = "Datos insertados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Multa", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
