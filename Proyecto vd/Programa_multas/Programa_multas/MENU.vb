Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.OleDb

Public Class MENU
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String



    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Application.Exit()

    End Sub

    Private Sub txt_usuari_TextChanged(sender As Object, e As EventArgs) Handles txt_usuari.TextChanged

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If txt_usuari.Text = "" Then
            MsgBox("INGRESE SU USUARIO")
        Else
            If txt_contraseña.Text = "" Then
                MsgBox("INGRESE SU CONTRASEÑA")
            Else
                Dim da As New SqlDataAdapter("select * from Usuario where Nombre='" + txt_usuari.Text + "' And Contraseña='" + txt_contraseña.Text + "'", con)
                Dim ds As New DataTable
                da.Fill(ds)
                Dim validar As Integer = ds.Rows.Count
                If validar > 0 Then
                    Dim tipo As String = ds(0)("Id_cliente").ToString
                    If tipo = 1 Then
                        MsgBox("BIENVENIDO")
                        Form1.Show()
                        Me.Hide()

                    Else
                        If tipo = 2 Then
                            MsgBox("Bienvenido")
                            Form1.Show()
                        Else
                            If tipo = 3 Then
                                MsgBox("Bienvenido")
                                Form2.Show()

                            Else
                                MsgBox("NO ENCONTRADO")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class