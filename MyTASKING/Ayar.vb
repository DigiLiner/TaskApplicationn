Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Public Class Ayar

    Dim baglanti As New SqlConnection(My.Settings.BIMConnectionString)

    Sub Listele(cmd As SqlCommand, ByRef grid As DevExpress.XtraGrid.GridControl)

        Dim view As New GridView(grid)
        view.Columns.Clear()
        view.OptionsView.ShowGroupPanel = False
        view.OptionsView.ShowColumnHeaders = True
        view.OptionsBehavior.Editable = False
        view.OptionsBehavior.ReadOnly = True

        cmd.Connection = baglanti
        If (baglanti.State = ConnectionState.Closed) Then
            baglanti.Open()
        End If
        cmd.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        grid.DataSource = Nothing

        grid.MainView = view
        grid.DataSource = dt

        Dim ritem As RepositoryItemProgressBar = New RepositoryItemProgressBar()
        ritem.ShowTitle = True
        ritem.Maximum = 100
        ritem.Minimum = 0
        grid.RepositoryItems.Add(ritem)
        view.Columns("Tamamlanma_Durumu").ColumnEdit = ritem


        baglanti.Close()

    End Sub

    Function BaglantiKontrol(ByVal id As String)

        If baglanti.State = ConnectionState.Closed Then
            baglanti.Open()
        End If
        Dim cmd As New SqlCommand
        cmd.Connection = baglanti
        cmd.CommandText = "select Count(*) from TaskDependencies where  ParentId='" & id & "' "
        Dim sayi As Integer = cmd.ExecuteScalar()
        baglanti.Close()
        Return sayi
    End Function

    Function DependecyBaglantiKontrol(ByVal id As String)

        If baglanti.State = ConnectionState.Closed Then
            baglanti.Open()
        End If
        Dim cmd As New SqlCommand
        cmd.Connection = baglanti
        cmd.CommandText = "select Count(*) from TaskDependencies where  DependentId='" & id & "' "
        Dim sayi As Integer = cmd.ExecuteScalar()
        baglanti.Close()
        Return sayi
    End Function


    Function bilgiyolla(ByVal id As String)
        Dim cmd As New SqlCommand

        cmd.Connection = baglanti
        If (baglanti.State = ConnectionState.Closed) Then
            baglanti.Open()
        End If
        cmd.CommandText = "select dbbirim_amir,dbbirim_amir_email from GRV_Birimler where dbbirim_id=" & id & ""
        Dim dt As SqlDataReader
        dt = cmd.ExecuteReader()
        Dim list As New List(Of String)
        While (dt.Read())
            list.Add(dt("dbbirim_amir"))
            list.Add(dt("dbbirim_amir_email"))
        End While
        baglanti.Close()
        Return list
    End Function

    Function Grvbilgiyolla(ByVal id As String)
        Dim cmd As New SqlCommand

        cmd.Connection = baglanti
        If (baglanti.State = ConnectionState.Closed) Then
            baglanti.Open()
        End If
        cmd.CommandText = "select * from Appointments where UniqueId=" & id & ""
        Dim dt As SqlDataReader
        dt = cmd.ExecuteReader()
        Dim list As New List(Of String)
        While (dt.Read())
            list.Add(dt("Subject"))
            list.Add(dt("CustomField1"))
        End While
        baglanti.Close()
        Return list
    End Function

End Class
