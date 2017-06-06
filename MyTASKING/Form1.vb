Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraScheduler
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository

Public Class Form1

    Sub New(ByVal kisi As String, ByVal kisimail As String, ByVal id As String, ByVal yetki() As String)
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
        schedulerControl.Start = DateTime.Now
        adsoyad = kisi
        mail = kisimail
        LoginID = id
        yetkim = yetki
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub


    Private Sub Doldur(ByVal ytki)

        If ytki.Equals("G3") Then

            'TODO: This line of code loads data into the 'BIMDataSet.TaskDependencies' table. You can move, or remove it, as needed.
            Me.TaskDependenciesTableAdapter.Doldur(Me.BIMDataSet.TaskDependencies)
            '       TODO: This line of code loads data into the 'BIMDataSet.GRV_Birimler' table. You can move, or remove it, as needed.
            Me.GRV_BirimlerTableAdapter.Fill(Me.BIMDataSet.GRV_Birimler)
            '      TODO: This line of code loads data into the 'BIMDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.AppointmentsTableAdapter.Fill(Me.BIMDataSet.Appointments)
        Else
            'TODO: This line of code loads data into the 'BIMDataSet.TaskDependencies' table. You can move, or remove it, as needed.
            Me.TaskDependenciesTableAdapter.Fill(Me.BIMDataSet.TaskDependencies, LoginID)
            '       TODO: This line of code loads data into the 'BIMDataSet.GRV_Birimler' table. You can move, or remove it, as needed.
            Me.GRV_BirimlerTableAdapter.Fill(Me.BIMDataSet.GRV_Birimler)
            '      TODO: This line of code loads data into the 'BIMDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.AppointmentsTableAdapter.GorevCek(Me.BIMDataSet.Appointments, LoginID)
        End If


    End Sub


#Region "Global Degişkenler"
    Private id As Integer = 0
    Dim mail, adsoyad, LoginID, GorevVerenID, GorevAlanId As String
    Dim ayar As New Ayar
    Dim yetkim() As String
    Dim durum As Boolean = False
    Dim sayac As Integer = 0
    Dim uniqID, bagid, parentId As Integer
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Görme yetkisi  
        Yeki_Gorme()


        TurkceBarLocalizer.Active = New TurkceBarLocalizer
        TakvimTR.Active = New TakvimTR

        schedulerStorage.Appointments.CommitIdToDataSource = False

        schedulerControl.ActiveViewType = SchedulerViewType.Gantt
        schedulerControl.GroupType = SchedulerGroupType.Resource
        schedulerControl.GanttView.ShowResourceHeaders = True
        schedulerControl.GanttView.CellsAutoHeightOptions.Enabled = True

        organizerGroup.Caption = adsoyad

        Ustmenukontrol()


    End Sub

    Private Sub Yenile()
        Yeki_Gorme()

    End Sub

    Private Sub appointmentsTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
            id = 0
            Using cmd As New SqlCommand("SELECT @@IDENTITY", AppointmentsTableAdapter.Connection)
                Try
                    id = Convert.ToInt32(cmd.ExecuteScalar())
                    e.Row("UniqueId") = id
                Catch ex As Exception

                End Try

            End Using
        End If
    End Sub

    Private Sub schedulerControl_EditAppointmentFormShowing_1(sender As Object, e As AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
        Yetki_Cek()
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As MyTASKING.CustomAppointmentForm = New MyTASKING.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm, LoginID, yetkim, GorevAlanId)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True

        Catch ex As Exception

        Finally
            form.Dispose()
        End Try


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If (XtraTabControl1.SelectedTabPage.Name = "XtraTabPage1") Then
            mailGroup.Visible = False
            mailGroup.Expanded = False
            organizerGroup.Expanded = True
            HomeRibbonPage1.Visible = True
            ViewRibbonPage1.Visible = True
            ribbonControl.SelectedPage = HomeRibbonPage1
        Else
            mailGroup.Visible = True
            mailGroup.Expanded = True
            organizerGroup.Expanded = False
            HomeRibbonPage1.Visible = False
            ViewRibbonPage1.Visible = False

        End If

    End Sub

    'Yenile Butonu
    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Yenile()
    End Sub
    'Görev listeleme Üstmenu
    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

        Dim b As DevExpress.XtraNavBar.NavBarLinkEventArgs
        inboxItem_LinkClicked(sender, b)
        AppointmentRibbonPage1.Visible = True

    End Sub


#Region "Yetki_İslemleri"

    Sub Yetki_Cek()

        For i = 0 To schedulerControl.SelectedAppointments.Count - 1
            For j = 0 To schedulerControl.SelectedDependencies.Count - 1
                bagid = Convert.ToInt32(schedulerControl.SelectedDependencies.GetDependenciesByParentId(uniqID))
            Next
            Dim apt As Appointment
            If bagid = Nothing Then
                apt = schedulerControl.SelectedAppointments(i)
            Else
                apt = schedulerControl.Storage.Appointments(bagid)
            End If
            GorevVerenID = apt.CustomFields("Kisiname")
            GorevAlanId = apt.ResourceId
            uniqID = apt.Id
        Next

        Dim liste As New List(Of String)
        Dim dep As AppointmentDependency

        For index = 0 To schedulerControl.SelectedDependencies.Count - 1
            dep = schedulerControl.SelectedDependencies(index)
            parentId = dep.ParentId
            liste = ayar.Grvbilgiyolla(parentId)
            GorevVerenID = liste(1)
        Next


    End Sub

    Sub Ustmenukontrol()

        For index = 0 To yetkim.Length - 1

            If yetkim(index).Equals("G1") Then
                AppointmentRibbonPageGroup1.Enabled = True
                Exit Sub
            Else
                AppointmentRibbonPageGroup1.Enabled = False

            End If

        Next
    End Sub

    Sub mesajyolla(ByVal msj As String, ByVal e As PersistentObjectsEventArgs, ByVal msj_aciklama As String)
        Yetki_Cek()

        Me.Cursor = Cursors.WaitCursor
        Dim a As New Appointment
        a = (CType(e.Objects(0), Appointment))

        Dim Gorev_Alanlist As New List(Of String)
        Dim Gorev_Verenliste As New List(Of String)

        If (GorevVerenID = Nothing) Then
            Gorev_Verenliste.Add(adsoyad)
            Gorev_Verenliste.Add(mail)
            Gorev_Alanlist = ayar.bilgiyolla(a.ResourceId)


        Else

            Gorev_Verenliste = ayar.bilgiyolla(GorevVerenID)
            Gorev_Alanlist = ayar.bilgiyolla(GorevAlanId)
        End If





        Dim htmlicerik As String
        htmlicerik = "<html> " &
"<head> " &
"<meta http-equiv='Content-Language' content='tr'> " &
"<meta http-equiv='Content-Type' content='text/html; charset=windows-1254'> " &
"<title>Yeni Sayfa 1</title> " &
"</head> " &
"<body> " &
"<p><font face='Tahoma' size='2'>&nbsp;&nbsp;&nbsp;" & msj_aciklama & "</font></p> " &
"<table border='0' width='100%' cellpadding='3' cellspacing='3'> " &
"	<tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>Konu</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>" & a.Subject & "</font></td> " &
"	</tr> " &
"	<tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>Açıklama</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>" & a.Description & "</font></td> " &
"	</tr> " &
"	<tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>Görev Veren</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>" & Gorev_Verenliste(0) & "  </font></td> " &
"	</tr> " &
"	<tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>Görev Alan</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>" & Gorev_Alanlist(0) & "</font></td> " &
"	</tr> " &
"	<tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>Baş.Tarih</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>" & a.Start & "</font></td> " &
"	</tr> " &
"	<tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>Bit.Tarih</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>" & a.End & "</font></td> " &
"	</tr> " &
"   <tr> " &
"		<td width='116'><b><font face='Tahoma' size='2'>İşlem Durumu</font></b></td> " &
"		<td width='5'><b><font face='Tahoma' size='2'>:</font></b></td> " &
"		<td width='970'><font face='Tahoma' size='2'>%" & a.PercentComplete & "</font></td> " &
"	</tr> " &
"	<tr> " &
"		<td width='116'>&nbsp;</td> " &
"		<td width='5'>&nbsp;</td> " &
"		<td width='970'>&nbsp;</td> " &
"	</tr> " &
"</table> " &
"<p>&nbsp;</p> " &
"<p><font face='Tahoma' size='2'>Bilgi Sistemleri Bilgilendirme Servisi</font></p> " &
"</body> " &
"</html> "

        Dim email As String
        If (msj.Equals("İşlem durumu değiştirildi")) Then

            email = Gorev_Verenliste(1)

        Else
            email = Gorev_Alanlist(1)
        End If



        Dim veri As String = email + "*" + "Bilgi Sistemleri" + "*" + msj + "*" + htmlicerik
        Dim bgw As BackgroundWorker = New BackgroundWorker
        AddHandler bgw.DoWork, AddressOf BackgroundWorker1_DoWork
        AddHandler bgw.RunWorkerCompleted, AddressOf BackgroundWorker1_RunWorkerCompleted


        bgw.RunWorkerAsync(veri)

        Me.Cursor = Cursors.Default


    End Sub

    Sub YetkiDurum(ByVal ytki As String, ByVal e As PersistentObjectsEventArgs)
        sayac = 0
        Yetki_Cek()

        For j = 0 To yetkim.Length - 1

            If yetkim(j).Equals(ytki) And LoginID.Equals(GorevVerenID) Then

                If yetkim(j) = "G2" Then

                    Dim varmi As Integer = ayar.BaglantiKontrol(uniqID)
                    Dim altbag As Integer = ayar.DependecyBaglantiKontrol(uniqID)

                    If (varmi > 0 Or altbag > 0) Then
                        MsgBox("Baglantı Olduğu İçin Silinemez.Önce Bağı Siliniz.Lütfen Yenile Butonuna Basınız")
                        Exit Sub
                    Else
                        Dim onay As Integer = MsgBox("Silmek istediğinizden eminmisiniz?", MsgBoxStyle.YesNo)
                        If onay <> 6 Then
                            MsgBox("Görev Silinmedi Lütfen Yenile Tuşuna Basınız!!!")
                        Else
                            CommitTask()
                            mesajyolla("Görev silindi", e, " Adınıza açılmış aşağıda belirtien görev, görev veren kişi tarafından silinmiştir.Bilginize")
                            Exit Sub
                        End If
                    End If
                End If

                If yetkim(j) = "G1" And LoginID.Equals(GorevVerenID) Then
                    CommitTask()
                    mesajyolla("Görev Değişikliğe Uğradı", e, "Adınıza açılmış aşağıda belirtien görev degiştirilmiştir.Bilginize")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                'İşlem durumunu değiştirmesi için
            ElseIf yetkim(j).Equals(ytki) And LoginID.Equals(GorevAlanId) Then
                CommitTask()
                mesajyolla("İşlem durumu değiştirildi", e, "Açmış Olduğunuz Görevin İşlem Durumununda Değişiklik Meydana Gelmiştir.Bilginize")
                Exit Sub
            Else
                sayac = sayac + 1
            End If
        Next
        If sayac = yetkim.Length Then
            MsgBox("Yetkiniz Yok,Lütfen Yenile Butonuna Basınız!!")
        End If
    End Sub

    Sub Yeki_Gorme()

        Dim ytki As String = "G3"

        For j = 0 To yetkim.Length - 1

            If yetkim(j).Contains(ytki) Then
                'TODO: This line of code loads data into the 'BIMDataSet.TaskDependencies' table. You can move, or remove it, as needed.
                Me.TaskDependenciesTableAdapter.Doldur(Me.BIMDataSet.TaskDependencies)
                '       TODO: This line of code loads data into the 'BIMDataSet.GRV_Birimler' table. You can move, or remove it, as needed.
                Me.GRV_BirimlerTableAdapter.Fill(Me.BIMDataSet.GRV_Birimler)
                '      TODO: This line of code loads data into the 'BIMDataSet.Appointments' table. You can move, or remove it, as needed.
                Me.AppointmentsTableAdapter.Fill(Me.BIMDataSet.Appointments)
                Exit Sub
            Else
                'TODO: This line of code loads data into the 'BIMDataSet.TaskDependencies' table. You can move, or remove it, as needed.
                Me.TaskDependenciesTableAdapter.Fill(Me.BIMDataSet.TaskDependencies, LoginID)
                '       TODO: This line of code loads data into the 'BIMDataSet.GRV_Birimler' table. You can move, or remove it, as needed.
                Me.GRV_BirimlerTableAdapter.Fill(Me.BIMDataSet.GRV_Birimler)
                '      TODO: This line of code loads data into the 'BIMDataSet.Appointments' table. You can move, or remove it, as needed.
                Me.AppointmentsTableAdapter.GorevCek(Me.BIMDataSet.Appointments, LoginID)
            End If
        Next

    End Sub

    Sub Baglanti_Yetki_Kontrol(ByVal ytki As String)
        sayac = 0

        Yetki_Cek()
        For j = 0 To yetkim.Length - 1

            If yetkim(j).Equals(ytki) And LoginID.Equals(GorevVerenID) Then

                If yetkim(j) = "G2" Then

                    Dim varmi As Integer = ayar.BaglantiKontrol(uniqID)

                    Dim onay As Integer = MsgBox("Baglantıyı Silmek istediğinizden eminmisiniz?", MsgBoxStyle.YesNo)

                    If onay <> 6 Then

                        MsgBox("Baglantı Silinmedi.Lütfen Yenileyiniz!")
                    Else
                        CommitTaskDependency()
                    End If

                Else
                    CommitTaskDependency()
                End If
            Else
                sayac = sayac + 1
            End If
        Next

        If sayac = yetkim.Length Then
            MsgBox("Silme Yetkiniz Yoktur.Lütfen Yenile Butonuna Basınız!!")
        End If
    End Sub

#End Region

#Region "Görev_İşlemleri"

    Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsChanged
        Yetki_Cek()
        Dim apt As Appointment
        apt = schedulerControl.SelectedAppointments(0)
        Dim liste As New List(Of String)
        liste = ayar.Grvbilgiyolla(apt.Id)

        If LoginID = GorevVerenID And LoginID = GorevAlanId Then
            YetkiDurum("G1", e)
            MsgBox("Değişiklik Yapılmıştır,Mail kutunuzu kontrol edin!")

        ElseIf LoginID = GorevAlanId Then

            If apt.Subject.Equals(liste(0)) Then 'sadece işlem durumu değiştirilecek
                YetkiDurum("G1", e)
                MsgBox("Değişiklik Yapılmıştır,Mail kutunuzu kontrol edin!")
            Else
                MsgBox("Görev Başlığında Değişiklik Yapamazsınız.Lütfen Yenileyiniz!")
                Exit Sub
            End If

        ElseIf LoginID = GorevVerenID Then
            YetkiDurum("G1", e)
            MsgBox("Değişiklik Yapılmıştır,Mail kutunuzu kontrol edin!")

        Else
            MsgBox("Değişiklik Yapamazsınız,Lütfen Yenile Butonuna Basın !!")
            Exit Sub
        End If
    End Sub
    Private Sub schedulerStorage1_AppointmentsDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsDeleted
        'G2 SİLME YETKSİ
        Yetki_Cek()
        If (LoginID = GorevVerenID) Then
            YetkiDurum("G2", e)
        Else

            MsgBox("Görevi Veren Kisi Silebilir.Silme Yetkiniz bulunmamaktadır.Yenile Butonuna Basınız!!")
        End If

    End Sub
    Private Sub schedulerStorage1_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsInserted
        'G1 Ekleme Yetkisi


        Yetki_Cek()
        Dim ytki As String = "G1"
        For j = 0 To yetkim.Length - 1

            If yetkim(j).Equals(ytki) Then

                CommitTask()
                schedulerStorage.SetAppointmentId((CType(e.Objects(0), Appointment)), id)
                mesajyolla("Bilgi Sistemleri Servisi", e, " Adınıza açılmış yeni görev veya proje tanımı yapılmıştır, SPTASKING üzerinden süreci takip edebilirsiniz! Sürecin zaman bilgileri uymuyor ise zaman bilgilerini veren kişiye düzeltme yaptırınız.")
                Exit Sub
            Else
                sayac = sayac + 1

            End If
        Next

        If sayac = yetkim.Length Then
            MsgBox("Yetkiniz Yok")
        End If
    End Sub
    Private Sub CommitTask()
        AppointmentsTableAdapter.Update(BIMDataSet)
        Me.BIMDataSet.AcceptChanges()
    End Sub

    Private Sub schedulerStorage1_AppointmentDependenciesChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentDependenciesChanged
        Yetki_Cek()
        If LoginID = GorevVerenID Then
            Baglanti_Yetki_Kontrol("G1")
        Else
            MsgBox("Yetkiniz bulunmamaktadır.Lütfen Yenile Butonuna Basınız!")

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        siStatus.Caption = "MAİL GÖNDERİLİYOR!!"
        Dim veri As String
        veri = e.Argument
        Dim split() As String
        split = veri.Split("*")
        MailClass.gonder(split(0), split(1), split(2), split(3))
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        siStatus.Caption = "MAİL GÖNDERİLDİ"

    End Sub

    Private Sub Gorev_Liste1ToolStripButton1_Click(sender As Object, e As EventArgs) Handles Gorev_Liste1ToolStripButton1.Click
        Try
            Me.AppointmentsTableAdapter.Gorev_Liste1(Me.BIMDataSet.Appointments, New System.Nullable(Of Integer)(CType(KisiidToolStripTextBox1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DoldurToolStripButton_Click(sender As Object, e As EventArgs) Handles DoldurToolStripButton.Click
        Try
            Me.TaskDependenciesTableAdapter.Doldur(Me.BIMDataSet.TaskDependencies)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GorevleriCekToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TaskDependenciesTableAdapter.GorevleriCek(Me.BIMDataSet.TaskDependencies, New System.Nullable(Of Integer)(CType(LoginidToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GorevCekToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.AppointmentsTableAdapter.GorevCek(Me.BIMDataSet.Appointments, LoginidToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GorevCekToolStripButton_Click_1(sender As Object, e As EventArgs) Handles GorevCekToolStripButton.Click
        Try
            Me.AppointmentsTableAdapter.GorevCek(Me.BIMDataSet.Appointments, LoginidToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Gorev_Liste1ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Gorev_Liste1ToolStrip1.ItemClicked

    End Sub

    Private Sub schedulerStorage1_AppointmentDependenciesDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentDependenciesDeleted

        Yetki_Cek()
        If LoginID = GorevVerenID Then
            Baglanti_Yetki_Kontrol("G2")
        Else
            MsgBox("Yetkiniz bulunmamaktadır.Lütfen Yenile Butonuna Basınız!")

        End If

    End Sub
    Private Sub schedulerStorage1_AppointmentDependenciesInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentDependenciesInserted
        Yetki_Cek()
        If LoginID = GorevVerenID Then
            Baglanti_Yetki_Kontrol("G1")
        Else
            MsgBox("Yetkiniz bulunmamaktadır.Lütfen Yenile Butonuna Basınız!")

        End If
    End Sub
    Private Sub CommitTaskDependency()
        TaskDependenciesTableAdapter.Update(Me.BIMDataSet)
        Me.BIMDataSet.AcceptChanges()
    End Sub

#End Region

#Region "Grid Dolduran İşlemler"
    'Alınan Görevler
    Private Sub inboxItem_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles inboxItem.LinkClicked

        Dim cmd As New SqlCommand
        cmd.CommandText = "SELECT * From Gorev_Alan WHERE Gorev_AlanID ='" & LoginID & "'"
        ayar.Listele(cmd, GridControl3)

    End Sub
    'Verilen Görevler
    Private Sub outboxItem_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles outboxItem.LinkClicked

        Dim cmd As New SqlCommand
        cmd.CommandText = "SELECT * FROM Gorev_Veren WHERE Gorev_VerenID ='" & LoginID & "'"
        cmd.CommandType = CommandType.Text
        ayar.Listele(cmd, GridControl3)

    End Sub
    'Tüm görevleri listele
    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        Dim cmd As New SqlCommand

        For j = 0 To yetkim.Length - 1

            If yetkim(j).Equals("G3") Then
                cmd.CommandText = "select * from GOREV_FULL"
                cmd.CommandType = CommandType.Text
                Exit For
            Else
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "GOREV_LISTELE_PROF"
                cmd.Parameters.AddWithValue("@loginid", LoginID)
                Exit For

            End If
        Next
        ayar.Listele(cmd, GridControl3)


    End Sub

#End Region


End Class
