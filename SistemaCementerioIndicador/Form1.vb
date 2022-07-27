Imports System.Configuration
Imports System.Data.SqlClient
Imports FileHelpers
Imports System.Collections.Generic
Imports Microsoft.Office.Interop

Public Class Indicador

    Dim Adapter As SqlDataAdapter
    Dim cone As New SqlConnection(My.Settings.Conec)
    Dim Data As New DataSet
    Dim Data2 As New DataSet
    Dim Data3 As New DataSet
    Dim Data4 As New DataSet
    Dim Causa As String
    Dim Genero As String
    Dim Periodo As String
    Dim conteo As String
    Dim ds As New DataSet

    Private Sub Indicador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboGenero()
        comboCausa()
        ComboPeriodo()
    End Sub

    Private Sub comboGenero()
        Dim combo As String
        combo = "Select DISTINCT sexo  from V_Fallecimiento"
        Adapter = New System.Data.SqlClient.SqlDataAdapter(combo, cone)
        Data = New DataSet
        Adapter.Fill(Data)
        Cmb_Genero.DataSource = Data.Tables(0)
        Cmb_Genero.DisplayMember = "sexo"
        Cmb_Genero.ValueMember = "sexo"
        cone.Close()
    End Sub
    Private Sub ComboPeriodo()
        Dim combo2 As String
        combo2 = "Select DISTINCT anio from DimTime"
        Adapter = New System.Data.SqlClient.SqlDataAdapter(combo2, cone)
        Data2 = New DataSet
        Adapter.Fill(Data2)
        cmb_periodo.DataSource = Data2.Tables(0)
        cmb_periodo.DisplayMember = "anio"
        cmb_periodo.ValueMember = "anio"
        cone.Close()
    End Sub
    Private Sub comboCausa()
        Dim combo3 As String
        combo3 = "Select DISTINCT  CausaFallecimiento from V_Fallecimiento"
        Adapter = New System.Data.SqlClient.SqlDataAdapter(combo3, cone)
        Data3 = New DataSet
        Adapter.Fill(Data3)
        cmb_CausaMuerte.DataSource = Data3.Tables(0)
        cmb_CausaMuerte.DisplayMember = "CausaFallecimiento"
        cmb_CausaMuerte.ValueMember = "CausaFallecimiento"
        cone.Close()

    End Sub

    Private Sub btn_lupa_Click(sender As Object, e As EventArgs) Handles btn_lupa.Click

        Try
            Genero = Cmb_Genero.Text
            Periodo = cmb_periodo.Text
            Causa = cmb_CausaMuerte.Text
            dataGridView1.AllowUserToAddRows = False

            If chk_todo.Checked = True Then
                Dim Sql As New SqlDataAdapter("Select * from V_Fallecimiento", cone)
                cone.Open()

                Sql.Fill(ds, "Grid")
                Dim total1 = ds.Tables("Grid").Rows.Count
                lbl_total.Text = total1

                Me.dataGridView1.DataSource = ds.Tables("Grid")
                cone.Close()
            Else
                Dim Sql As New SqlDataAdapter("Select * from V_Fallecimiento where anio = '" & Periodo & "' and sexo= '" & Genero & "' and causafallecimiento = '" & Causa & "'", cone)
                cone.Open()

                Sql.Fill(ds, "Grid")
                Dim total2 = ds.Tables("Grid").Rows.Count
                lbl_total.Text = total2

                Me.dataGridView1.DataSource = ds.Tables("Grid")

                cone.Close()
            End If


        Catch ex As Exception



            cone.Close()
            MessageBox.Show(ex.Message)

        End Try

        CrearGrilla(dataGridView1)
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If dataGridView1.RowCount > 0 Then
            Dim save As New SaveFileDialog
            save.Filter = "ARCHIVO XML (*.xml)|*.xml"
            save.FileName = "DOCUMENTO" & " " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xml"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fs As System.IO.FileStream
                Dim xtw As System.Xml.XmlTextWriter
                ds.DataSetName = "Grid"
                fs = New System.IO.FileStream(save.FileName, IO.FileMode.Create)
                xtw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.Unicode)
                xtw.WriteProcessingInstruction("xml", "version='1.0'")
                xtw.WriteProcessingInstruction("mso-application", "progid='Excel.Sheet'")
                ds.WriteXml(xtw)
                xtw.Close()
                MsgBox("SE EXPORTO CORRECTAMENTE")
            End If
        Else
            MsgBox("NO HAY DATOS QUE EXPORTAR", MsgBoxStyle.Critical, "VERIFICAR")
            Exit Sub
        End If
    End Sub



    Private Sub CrearGrilla(ByVal dgv As DataGridView)

        'Dim cmd As New SqlDataAdapter("Select  mes,sum(edad )from V_Fallecimiento group by mes ", cone)
        'Dim ds As New DataSet()
        'cmd.Fill(ds, "Grid")
        'Chart1.DataSource = ds.Tables("Grid")
        'For x = 0 To dataGridView1.Rows.Count - 1

        '    'Tomanos los datos de DataView para la gráfica
        '    Me.Chart1.Series("mes").Points.AddXY(ds(x)("edad"), ds(x)("Edad"))
        'Next
        Dim Reader As SqlDataReader
        cone.Open()
        Dim cmd = "Select  mes,sum(edad) edad from V_Fallecimiento group by mes "
        Dim comma = New SqlCommand(cmd, cone)
        Reader = comma.ExecuteReader
        While Reader.Read
            Chart1.Series("Indicador").Points.AddXY(Reader(0).ToString, CInt(Reader(1).ToString))
        End While
        cone.Close()

    End Sub




End Class
