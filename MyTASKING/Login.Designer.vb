Partial Public Class Login
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.pictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.MyTASKING.WaitForm1), True, True)
        CType(Me.pictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'simpleButton1
        '
        Me.simpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.simpleButton1.Appearance.Options.UseFont = True
        Me.simpleButton1.Image = CType(resources.GetObject("simpleButton1.Image"), System.Drawing.Image)
        Me.simpleButton1.Location = New System.Drawing.Point(329, 188)
        Me.simpleButton1.Name = "simpleButton1"
        Me.simpleButton1.Size = New System.Drawing.Size(105, 38)
        Me.simpleButton1.TabIndex = 3
        Me.simpleButton1.Text = "Giriş"
        '
        'pictureEdit3
        '
        Me.pictureEdit3.EditValue = CType(resources.GetObject("pictureEdit3.EditValue"), Object)
        Me.pictureEdit3.Location = New System.Drawing.Point(77, 145)
        Me.pictureEdit3.Name = "pictureEdit3"
        Me.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pictureEdit3.Size = New System.Drawing.Size(20, 20)
        Me.pictureEdit3.TabIndex = 56
        '
        'pictureEdit2
        '
        Me.pictureEdit2.EditValue = CType(resources.GetObject("pictureEdit2.EditValue"), Object)
        Me.pictureEdit2.Location = New System.Drawing.Point(78, 109)
        Me.pictureEdit2.Name = "pictureEdit2"
        Me.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pictureEdit2.Size = New System.Drawing.Size(19, 20)
        Me.pictureEdit2.TabIndex = 55
        '
        'textEdit1
        '
        Me.textEdit1.Location = New System.Drawing.Point(96, 145)
        Me.textEdit1.Name = "textEdit1"
        Me.textEdit1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textEdit1.Size = New System.Drawing.Size(338, 20)
        Me.textEdit1.TabIndex = 2
        '
        'comboBoxEdit1
        '
        Me.comboBoxEdit1.Location = New System.Drawing.Point(96, 109)
        Me.comboBoxEdit1.Name = "comboBoxEdit1"
        Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboBoxEdit1.Size = New System.Drawing.Size(338, 20)
        Me.comboBoxEdit1.TabIndex = 1
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.Properties.ClosingDelay = 500
        '
        'Login
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 238)
        Me.Controls.Add(Me.simpleButton1)
        Me.Controls.Add(Me.pictureEdit3)
        Me.Controls.Add(Me.pictureEdit2)
        Me.Controls.Add(Me.textEdit1)
        Me.Controls.Add(Me.comboBoxEdit1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TASKING v0.4"
        CType(Me.pictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents pictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
    Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager

#End Region

End Class
