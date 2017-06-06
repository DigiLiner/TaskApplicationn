<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomAppointmentForm
    Inherits DevExpress.XtraScheduler.UI.AppointmentForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_GorevVeren = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbKisi = New DevExpress.XtraEditors.TextEdit()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.progressPanel.SuspendLayout()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_GorevVeren.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.Location = New System.Drawing.Point(28, 19)
        Me.lblSubject.Size = New System.Drawing.Size(65, 13)
        Me.lblSubject.Text = "&Görev Baþlýðý:"
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(64, 45)
        Me.lblLocation.Size = New System.Drawing.Size(29, 13)
        Me.lblLocation.Text = "&Birim :"
        '
        'lblLabel
        '
        Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblLabel.Location = New System.Drawing.Point(3, 65)
        Me.lblLabel.Size = New System.Drawing.Size(76, 13)
        Me.lblLabel.Text = "Önem Derecesi:"
        '
        'lblStartTime
        '
        Me.lblStartTime.Size = New System.Drawing.Size(77, 13)
        Me.lblStartTime.Text = "Baþlangýç Tarihi:"
        '
        'lblEndTime
        '
        Me.lblEndTime.Location = New System.Drawing.Point(41, 106)
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.Text = "Bitiþ Tarihi:"
        '
        'lblShowTimeAs
        '
        Me.lblShowTimeAs.Location = New System.Drawing.Point(20, 142)
        Me.lblShowTimeAs.Size = New System.Drawing.Size(73, 13)
        Me.lblShowTimeAs.Text = "Görev Durumu:"
        '
        'chkAllDay
        '
        Me.chkAllDay.Location = New System.Drawing.Point(65, 34)
        Me.chkAllDay.Properties.Caption = "&Tüm Gün Ýçin Geçerli Olsun"
        Me.chkAllDay.Size = New System.Drawing.Size(149, 19)
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(16, 389)
        Me.btnOk.Text = "Tamam"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(104, 389)
        Me.btnCancel.Text = "Ýptal"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(192, 389)
        Me.btnDelete.Text = "&Sil"
        '
        'btnRecurrence
        '
        Me.btnRecurrence.Enabled = False
        Me.btnRecurrence.Location = New System.Drawing.Point(280, 389)
        Me.btnRecurrence.Size = New System.Drawing.Size(85, 23)
        Me.btnRecurrence.Text = "&Kural Oluþtur"
        '
        'edtStartDate
        '
        Me.edtStartDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartDate.Location = New System.Drawing.Point(96, 77)
        Me.edtStartDate.Size = New System.Drawing.Size(105, 20)
        '
        'edtEndDate
        '
        Me.edtEndDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndDate.Size = New System.Drawing.Size(105, 20)
        '
        'edtStartTime
        '
        Me.edtStartTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartTime.Location = New System.Drawing.Point(210, 79)
        Me.edtStartTime.Size = New System.Drawing.Size(68, 20)
        '
        'edtEndTime
        '
        Me.edtEndTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndTime.Location = New System.Drawing.Point(210, 103)
        Me.edtEndTime.Size = New System.Drawing.Size(68, 20)
        '
        'edtLabel
        '
        Me.edtLabel.Location = New System.Drawing.Point(84, 62)
        Me.edtLabel.Size = New System.Drawing.Size(130, 20)
        '
        'edtShowTimeAs
        '
        Me.edtShowTimeAs.Size = New System.Drawing.Size(182, 20)
        '
        'tbSubject
        '
        Me.tbSubject.Size = New System.Drawing.Size(419, 20)
        '
        'edtResource
        '
        Me.edtResource.Location = New System.Drawing.Point(84, 1)
        Me.edtResource.Size = New System.Drawing.Size(130, 20)
        '
        'lblResource
        '
        Me.lblResource.Location = New System.Drawing.Point(2, 3)
        Me.lblResource.Size = New System.Drawing.Size(59, 13)
        Me.lblResource.Text = "Görevi Alan:"
        '
        'edtResources
        '
        Me.edtResources.Location = New System.Drawing.Point(84, 0)
        '
        '
        '
        Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
        Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
        Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
        Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
        Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
        Me.edtResources.Size = New System.Drawing.Size(103, 20)
        '
        'chkReminder
        '
        Me.chkReminder.Location = New System.Drawing.Point(6, 98)
        Me.chkReminder.Properties.Caption = "&Hatýrlatýcý :"
        Me.chkReminder.Size = New System.Drawing.Size(73, 19)
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(20, 239)
        Me.tbDescription.Size = New System.Drawing.Size(499, 138)
        '
        'cbReminder
        '
        Me.cbReminder.Location = New System.Drawing.Point(84, 98)
        Me.cbReminder.Size = New System.Drawing.Size(130, 20)
        '
        'tbLocation
        '
        Me.tbLocation.EditValue = "6"
        Me.tbLocation.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tbLocation.Properties.ReadOnly = True
        Me.tbLocation.Properties.ValidateOnEnterKey = True
        Me.tbLocation.Size = New System.Drawing.Size(182, 20)
        '
        'panel1
        '
        Me.panel1.Location = New System.Drawing.Point(301, 41)
        Me.panel1.Size = New System.Drawing.Size(219, 125)
        '
        'progressPanel
        '
        Me.progressPanel.Size = New System.Drawing.Size(499, 34)
        '
        'tbProgress
        '
        Me.tbProgress.Location = New System.Drawing.Point(91, 1)
        Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbProgress.Size = New System.Drawing.Size(390, 31)
        '
        'lblPercentComplete
        '
        Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentComplete.Location = New System.Drawing.Point(3, 3)
        Me.lblPercentComplete.Size = New System.Drawing.Size(83, 13)
        Me.lblPercentComplete.Text = "% &Ýþlem Durumu:"
        '
        'lblPercentCompleteValue
        '
        Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentCompleteValue.Location = New System.Drawing.Point(481, 10)
        '
        'tb_GorevVeren
        '
        Me.tb_GorevVeren.Location = New System.Drawing.Point(99, 213)
        Me.tb_GorevVeren.Name = "tb_GorevVeren"
        Me.tb_GorevVeren.Size = New System.Drawing.Size(182, 20)
        Me.tb_GorevVeren.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Görev Veren :"
        '
        'tbKisi
        '
        Me.tbKisi.EditValue = "5555555555555555555555"
        Me.tbKisi.Location = New System.Drawing.Point(96, 206)
        Me.tbKisi.Name = "tbKisi"
        Me.tbKisi.Size = New System.Drawing.Size(182, 20)
        Me.tbKisi.TabIndex = 29
        '
        'CustomAppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(531, 423)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_GorevVeren)
        Me.MinimumSize = New System.Drawing.Size(518, 307)
        Me.Name = "CustomAppointmentForm"
        Me.Controls.SetChildIndex(Me.tb_GorevVeren, 0)
        Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.edtEndTime, 0)
        Me.Controls.SetChildIndex(Me.edtEndDate, 0)
        Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.lblEndTime, 0)
        Me.Controls.SetChildIndex(Me.tbLocation, 0)
        Me.Controls.SetChildIndex(Me.lblSubject, 0)
        Me.Controls.SetChildIndex(Me.lblLocation, 0)
        Me.Controls.SetChildIndex(Me.tbSubject, 0)
        Me.Controls.SetChildIndex(Me.lblStartTime, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.edtStartDate, 0)
        Me.Controls.SetChildIndex(Me.edtStartTime, 0)
        Me.Controls.SetChildIndex(Me.panel1, 0)
        Me.Controls.SetChildIndex(Me.progressPanel, 0)
        Me.Controls.SetChildIndex(Me.tbDescription, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.progressPanel.ResumeLayout(False)
        Me.progressPanel.PerformLayout()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_GorevVeren.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_GorevVeren As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbKisi As DevExpress.XtraEditors.TextEdit

End Class
