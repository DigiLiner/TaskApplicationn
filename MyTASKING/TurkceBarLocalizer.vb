Imports System.Text
Imports DevExpress.XtraLayout.Localization
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Localization


Public Class TurkceBarLocalizer
    Inherits BarLocalizer
    Public Overrides ReadOnly Property Language() As String
        Get
            Return "Turkish"
        End Get
    End Property
    Public Overrides Function GetLocalizedString(id As BarString) As String
        Select Case id
            Case BarString.AddOrRemove
                Return "Ekle yada Kaldır"
            Case BarString.BarAllItems
                Return "Tüm öğeler"
            Case BarString.BarUnassignedItems
                Return "Atanmamış öğeler"
            Case BarString.CancelButton
                Return "İptal"
            Case BarString.CloseButton
                Return "Kapat"
            Case BarString.NewToolbarName
                Return "Yeni Menu Adı"

            Case BarString.RibbonToolbarAdd
                Return "Yeni Menu"
            Case BarString.RibbonToolbarBelow
                Return "Yeni Toolbar Menu"
            Case BarString.RibbonToolbarRemove
                Return "Menu Kaldır"
            Case BarString.RibbonToolbarAbove
                Return "Toolbar Menu"
            Case BarString.NewToolbarName
                Return "Yeni Menu Adı"

            Case BarString.CustomizeButton
                Return "a"

            Case Else
                Return ""
        End Select
    End Function
End Class