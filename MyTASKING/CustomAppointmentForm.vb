#Region "Note"
'
'{**************************************************************************************************************}
'{  This file is automatically created when you open the Scheduler Control smart tag                            }
'{  *and click Create Customizable Appointment Dialog.                                                          }
'{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
'{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
'{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
'{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
'{  The code that displays this form is automatically inserted                                                  }
'{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
'{                                                                                                              }
'{**************************************************************************************************************}
'
#End Region ' Note

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Partial Public Class CustomAppointmentForm
    Inherits DevExpress.XtraScheduler.UI.AppointmentForm
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As DevExpress.XtraScheduler.Appointment)
        MyBase.New(control, apt)
        InitializeComponent()
    End Sub

    Dim yetkim() As String
    Dim gorevAlan, Kisimail As String
    Dim apt As Appointment
    Dim basTar As String = Nothing
    Dim bitTar As String = Nothing
    Dim gelenid As String

    Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As DevExpress.XtraScheduler.Appointment, ByVal openRecurrenceForm As Boolean, ByVal kisi As String, ByVal yetki() As String, ByVal GorevAlanID As String)
        MyBase.New(control, apt, openRecurrenceForm)
        InitializeComponent()
        Kisimail = kisi
        yetkim = yetki
        gorevAlan = GorevAlanID
    End Sub
    ''' <summary>
    ''' Add your code to obtain a custom field value and fill the editor with data.
    ''' </summary>

    Public Overrides Sub LoadFormData(ByVal appointment As DevExpress.XtraScheduler.Appointment)

        If appointment.Subject = "" Then
            gorevAlan = Nothing
        Else
            basTar = appointment.Start
            bitTar = appointment.End
        End If

        If (appointment.CustomFields("Kisiname") Is Nothing) Then
            tb_GorevVeren.Text = edtResource.Properties.Items(Kisimail).ToString
            gelenid = Kisimail
        Else
            tb_GorevVeren.Text = edtResource.Properties.Items(appointment.CustomFields("Kisiname").ToString()).ToString()
            gelenid = appointment.CustomFields("Kisiname").ToString()
        End If


        btnOk.Enabled = False
        btnDelete.Enabled = False

        If appointment.Subject = Nothing Then
            btnRecurrence.Enabled = True
        Else
            btnRecurrence.Enabled = False

        End If

        For i = 0 To yetkim.Length - 1

            If yetkim(i).Equals("G2") Then
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If
            If yetkim(i).Equals("G1") Then

                btnOk.Enabled = True

                'Kendine Görev Verdiyse 
                If Kisimail = gorevAlan And Kisimail.Equals(gelenid) Then

                    tb_GorevVeren.Enabled = True
                    tbDescription.Enabled = True
                    tbKisi.Enabled = True
                    tbLocation.Enabled = True
                    tbSubject.Enabled = True
                    tbProgress.Enabled = True
                    cbReminder.Enabled = True
                    edtShowTimeAs.Enabled = True
                    edtStartTime.Enabled = True
                    edtEndTime.Enabled = True
                    edtLabel.Enabled = True
                    edtResources.Enabled = True
                    edtResource.Enabled = True
                    panel1.Enabled = True
                    edtEndDate.Enabled = True
                    edtStartDate.Enabled = True

                    'Gorev alansa
                ElseIf Kisimail = gorevAlan Then
                    tb_GorevVeren.Enabled = False
                    tbDescription.Enabled = False
                    tbKisi.Enabled = False
                    tbLocation.Enabled = False
                    tbSubject.Enabled = False
                    tbProgress.Enabled = True
                    cbReminder.Enabled = True
                    edtShowTimeAs.Enabled = False
                    edtStartTime.Enabled = False
                    edtEndTime.Enabled = False
                    edtLabel.Enabled = False
                    edtResources.Enabled = False
                    edtResource.Enabled = False
                    panel1.Enabled = False
                    btnRecurrence.Enabled = False
                    edtEndDate.Enabled = False
                    edtStartDate.Enabled = False


                    'Görev Verense
                ElseIf Kisimail = gelenid Then

                    tb_GorevVeren.Enabled = False
                    tbDescription.Enabled = True
                    tbKisi.Enabled = True
                    tbLocation.Enabled = True
                    tbSubject.Enabled = True
                    tbProgress.Enabled = False
                    edtEndDate.Enabled = True
                    edtStartDate.Enabled = True
                    edtShowTimeAs.Enabled = True
                    edtStartTime.Enabled = True
                    edtEndTime.Enabled = True
                    edtLabel.Enabled = True
                    edtResources.Enabled = True
                    edtResource.Enabled = True
                    chkAllDay.Enabled = True
                    chkReminder.Enabled = True
                    cbReminder.Enabled = True
                    panel1.Enabled = True


                Else 'Yöneticiyse
                    tb_GorevVeren.Enabled = False
                    tbDescription.Enabled = False
                    tbKisi.Enabled = False
                    tbLocation.Enabled = False
                    tbSubject.Enabled = False
                    tbProgress.Enabled = False
                    edtEndDate.Enabled = False
                    edtStartDate.Enabled = False
                    edtShowTimeAs.Enabled = False
                    edtStartTime.Enabled = False
                    edtEndTime.Enabled = False
                    edtLabel.Enabled = False
                    edtResources.Enabled = False
                    edtResource.Enabled = False
                    chkAllDay.Enabled = False
                    chkReminder.Enabled = False
                    cbReminder.Enabled = False
                    panel1.Enabled = False
                    btnRecurrence.Enabled = False
                End If
            End If
        Next
        MyBase.LoadFormData(appointment)
    End Sub
    ''' <summary>
    ''' Add your code to retrieve a value from the editor and set the custom appointment field.
    ''' </summary>
    Public Overrides Function SaveFormData(ByVal appointment As DevExpress.XtraScheduler.Appointment) As Boolean

        If appointment.Subject = "" Then
            MsgBox("Görev Baþlýgýný Girmek Zorunludur!!!")
        Else
            If tbSubject.Enabled = True Then
                basTar = appointment.Start
                bitTar = appointment.End
            End If
            appointment.CustomFields("Kisiname") = gelenid

            appointment.End = bitTar
            appointment.Start = basTar

            Return MyBase.SaveFormData(appointment)
        End If
    End Function



    Public Overrides Function IsAppointmentChanged(ByVal appointment As DevExpress.XtraScheduler.Appointment) As Boolean
        appointment.CustomFields("Kisiname") = gelenid
        Return False
    End Function


End Class
