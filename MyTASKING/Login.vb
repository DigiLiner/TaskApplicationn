Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Partial Public Class Login
    Inherits DevExpress.XtraEditors.XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim baglanti As New SqlConnection(My.Settings.BIMConnectionString)
    Dim yetki As String
    Dim yetkiList() As String
    Private Sub simpleButton1_Click(sender As Object, e As EventArgs) Handles simpleButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim kisimail, ad, id As String

        If comboBoxEdit1.SelectedItem Is Nothing OrElse comboBoxEdit1.SelectedText = "" Then
            MessageBox.Show("Lütfen Kullanıcı seçiniz")
        Else

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If
            Dim cmd As New SqlCommand("Select * from GRV_Birimler", baglanti)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim durum As Boolean = False
            Dim split() As String

            Dim s As String = comboBoxEdit1.SelectedItem
            split = s.Split("-")

            While dr.Read()

                If textEdit1.Text.Equals(dr("dbsifre").ToString) And split(0).Trim.Equals(dr("dbbirim_amir_email")) And split(1).Trim.Equals(dr("dbbirim")) Then
                    kisimail = dr("dbbirim_amir_email").ToString
                    ad = dr("dbbirim_amir").ToString
                    id = dr("dbbirim_id").ToString
                    yetki = dr("dbyetki").ToString
                    durum = True
                    yetkiList = yetki.Split(",")
                    Dim SplasScrn = SplashScreenManager1
                    Try
                        If SplasScrn Is Nothing Then SplasScrn = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(WaitForm1), True, True)
                        Me.Hide()
                        SplasScrn.ShowWaitForm()
                        SplasScrn.SetWaitFormCaption("Lütfen Bekleyiniz....")
                        SplasScrn.SetWaitFormDescription(ad)
                        Dim f As Form1 = New Form1(ad, kisimail, id, yetkiList)
                        f.Show()
                        SplasScrn.CloseWaitForm()
                    Catch ex As Exception
                        SplasScrn.SendCommand(WaitForm1.WaitFormCommand.SomeCommandId, ex.Message)
                        SplasScrn.CloseWaitForm()
                    End Try
                End If
            End While

            dr.Close()
            baglanti.Close()

            If durum = False Then
                MsgBox("Şifre Yanlış!")
            End If

            'yanlısa

        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        liste()
        simpleButton1.BackColor = Color.Gray
    End Sub
    Private Sub liste()
        If baglanti.State = ConnectionState.Closed Then
            baglanti.Open()
        End If
        Dim cmd As New SqlCommand("Select * from GRV_Birimler", baglanti)

        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            comboBoxEdit1.Properties.Items.Add(dr("dbbirim_amir_email").ToString() + " - " + dr("dbbirim").ToString)
        End While

        dr.Close()
        baglanti.Close()
    End Sub

    Private Sub simpleButton1_MouseHover(sender As Object, e As EventArgs) Handles simpleButton1.MouseHover
        simpleButton1.BackColor = Color.Blue
    End Sub


    Private Sub textEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles textEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            simpleButton1.PerformClick()

        End If

    End Sub


End Class
