Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.organizerGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.mailGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.inboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.outboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.schedulerSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.popupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.someLabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.someLabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.EditAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
        Me.EditOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
        Me.EditSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
        Me.DeleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
        Me.DeleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
        Me.DeleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
        Me.SplitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
        Me.ChangeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
        Me.ChangeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
        Me.ToggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
        Me.ChangeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
        Me.RepositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        Me.SwitchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
        Me.SwitchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
        Me.SwitchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
        Me.SwitchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
        Me.SwitchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
        Me.SwitchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
        Me.SwitchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
        Me.SwitchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
        Me.ChangeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.SwitchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
        Me.SwitchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
        Me.SwitchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
        Me.SwitchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
        Me.ChangeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
        Me.NewAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
        Me.NewRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
        Me.NavigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
        Me.NavigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
        Me.GotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
        Me.ViewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
        Me.ViewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
        Me.GroupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
        Me.GroupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
        Me.GroupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
        Me.OpenScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
        Me.SaveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
        Me.PrintPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
        Me.PrintItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
        Me.PrintPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.CalendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
        Me.AppointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
        Me.ActionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
        Me.OptionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
        Me.FileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
        Me.PrintRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
        Me.HomeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
        Me.AppointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
        Me.NavigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
        Me.ArrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
        Me.GroupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
        Me.ViewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
        Me.ActiveViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
        Me.TimeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
        Me.LayoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
        Me.RibbonPageSkins = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.TaskDependenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIMDataSet = New MyTASKING.BIMDataSet()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRVBirimlerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dateNavigator = New DevExpress.XtraScheduler.DateNavigator()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AppointmentsTableAdapter = New MyTASKING.BIMDataSetTableAdapters.AppointmentsTableAdapter()
        Me.GRV_BirimlerTableAdapter = New MyTASKING.BIMDataSetTableAdapters.GRV_BirimlerTableAdapter()
        Me.TaskDependenciesTableAdapter = New MyTASKING.BIMDataSetTableAdapters.TaskDependenciesTableAdapter()
        Me.Gorev_Liste1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.KisiidToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.KisiidToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Gorev_Liste1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Gorev_Liste1ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.KisiidToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.KisiidToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Gorev_Liste1ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DoldurToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DoldurToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GorevCekToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LoginidToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LoginidToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GorevCekToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerControl.SuspendLayout()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.schedulerSplitContainerControl.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer2.SuspendLayout()
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer1.SuspendLayout()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRVBirimlerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gorev_Liste1ToolStrip.SuspendLayout()
        Me.Gorev_Liste1ToolStrip1.SuspendLayout()
        Me.DoldurToolStrip.SuspendLayout()
        Me.GorevCekToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainerControl
        '
        Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl.Location = New System.Drawing.Point(0, 143)
        Me.splitContainerControl.Name = "splitContainerControl"
        Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6)
        Me.splitContainerControl.Panel1.Controls.Add(Me.navBarControl)
        Me.splitContainerControl.Panel1.Text = "Panel1"
        Me.splitContainerControl.Panel2.Controls.Add(Me.schedulerSplitContainerControl)
        Me.splitContainerControl.Panel2.Text = "Panel2"
        Me.splitContainerControl.Size = New System.Drawing.Size(1100, 526)
        Me.splitContainerControl.SplitterPosition = 165
        Me.splitContainerControl.TabIndex = 1
        Me.splitContainerControl.Text = "splitContainerControl1"
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.organizerGroup
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.mailGroup, Me.organizerGroup})
        Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.inboxItem, Me.outboxItem, Me.NavBarItem1, Me.NavBarItem2})
        Me.navBarControl.LargeImages = Me.navbarImageCollectionLarge
        Me.navBarControl.Location = New System.Drawing.Point(0, 0)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 165
        Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.navBarControl.Size = New System.Drawing.Size(165, 514)
        Me.navBarControl.SmallImages = Me.navbarImageCollection
        Me.navBarControl.StoreDefaultPaintStyleName = True
        Me.navBarControl.TabIndex = 2
        Me.navBarControl.Text = "navBarControl1"
        '
        'organizerGroup
        '
        Me.organizerGroup.Caption = "Organizer"
        Me.organizerGroup.Expanded = True
        Me.organizerGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.organizerGroup.LargeImageIndex = 1
        Me.organizerGroup.Name = "organizerGroup"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "YENİLE"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = CType(resources.GetObject("NavBarItem2.SmallImage"), System.Drawing.Image)
        '
        'mailGroup
        '
        Me.mailGroup.Caption = "Görevler"
        Me.mailGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.inboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.outboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1)})
        Me.mailGroup.LargeImage = CType(resources.GetObject("mailGroup.LargeImage"), System.Drawing.Image)
        Me.mailGroup.LargeImageIndex = 0
        Me.mailGroup.Name = "mailGroup"
        Me.mailGroup.Visible = False
        '
        'inboxItem
        '
        Me.inboxItem.Caption = "Gelen Görevler"
        Me.inboxItem.Name = "inboxItem"
        Me.inboxItem.SmallImage = CType(resources.GetObject("inboxItem.SmallImage"), System.Drawing.Image)
        Me.inboxItem.SmallImageIndex = 0
        '
        'outboxItem
        '
        Me.outboxItem.Caption = "Verilen Görevler"
        Me.outboxItem.Name = "outboxItem"
        Me.outboxItem.SmallImage = CType(resources.GetObject("outboxItem.SmallImage"), System.Drawing.Image)
        Me.outboxItem.SmallImageIndex = 1
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Tüm Görevler"
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = CType(resources.GetObject("NavBarItem1.SmallImage"), System.Drawing.Image)
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png")
        Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png")
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
        '
        'schedulerSplitContainerControl
        '
        Me.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.schedulerSplitContainerControl.Location = New System.Drawing.Point(0, 0)
        Me.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl"
        Me.schedulerSplitContainerControl.Panel1.Controls.Add(Me.XtraTabControl1)
        Me.schedulerSplitContainerControl.Panel1.Text = "Panel1"
        Me.schedulerSplitContainerControl.Panel2.Controls.Add(Me.dateNavigator)
        Me.schedulerSplitContainerControl.Panel2.Text = "Panel2"
        Me.schedulerSplitContainerControl.Size = New System.Drawing.Size(918, 514)
        Me.schedulerSplitContainerControl.SplitterPosition = 190
        Me.schedulerSplitContainerControl.TabIndex = 3
        Me.schedulerSplitContainerControl.Text = "splitContainerControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(723, 514)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.schedulerControl)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(717, 486)
        Me.XtraTabPage1.Text = "Görev Akış Şeması"
        '
        'schedulerControl
        '
        Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.schedulerControl.MenuManager = Me.ribbonControl
        Me.schedulerControl.Name = "schedulerControl"
        Me.schedulerControl.Size = New System.Drawing.Size(717, 486)
        Me.schedulerControl.Start = New Date(2016, 8, 9, 0, 0, 0, 0)
        Me.schedulerControl.Storage = Me.schedulerStorage
        Me.schedulerControl.TabIndex = 0
        Me.schedulerControl.Text = "schedulerControl1"
        Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.schedulerControl.Views.FullWeekView.Enabled = True
        Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.schedulerControl.Views.WeekView.Enabled = False
        Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.siStatus, Me.rgbiSkins, Me.EditAppointmentQueryItem1, Me.EditOccurrenceUICommandItem1, Me.EditSeriesUICommandItem1, Me.DeleteAppointmentsItem1, Me.DeleteOccurrenceItem1, Me.DeleteSeriesItem1, Me.SplitAppointmentItem1, Me.ChangeAppointmentStatusItem1, Me.ChangeAppointmentLabelItem1, Me.ToggleRecurrenceItem1, Me.ChangeAppointmentReminderItem1, Me.SwitchToDayViewItem1, Me.SwitchToWorkWeekViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchToTimelineViewItem1, Me.SwitchToGanttViewItem1, Me.SwitchTimeScalesItem1, Me.ChangeScaleWidthItem1, Me.SwitchTimeScalesCaptionItem1, Me.SwitchCompressWeekendItem1, Me.SwitchShowWorkTimeOnlyItem1, Me.SwitchCellsAutoHeightItem1, Me.ChangeSnapToCellsUIItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 102
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.CalendarToolsRibbonPageCategory1})
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.HomeRibbonPage1, Me.ViewRibbonPage1, Me.RibbonPageSkins, Me.helpRibbonPage})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDuration1, Me.RepositoryItemSpinEdit1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.Size = New System.Drawing.Size(1100, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        '
        'appMenu
        '
        Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.RightPaneControlContainer = Me.popupControlContainer1
        Me.appMenu.ShowRightPane = True
        '
        'popupControlContainer2
        '
        Me.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer2.Appearance.Options.UseBackColor = True
        Me.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer2.Controls.Add(Me.buttonEdit)
        Me.popupControlContainer2.Location = New System.Drawing.Point(238, 289)
        Me.popupControlContainer2.Name = "popupControlContainer2"
        Me.popupControlContainer2.Ribbon = Me.ribbonControl
        Me.popupControlContainer2.Size = New System.Drawing.Size(118, 28)
        Me.popupControlContainer2.TabIndex = 7
        Me.popupControlContainer2.Visible = False
        '
        'buttonEdit
        '
        Me.buttonEdit.EditValue = "Some Text"
        Me.buttonEdit.Location = New System.Drawing.Point(3, 5)
        Me.buttonEdit.MenuManager = Me.ribbonControl
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
        Me.buttonEdit.TabIndex = 0
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer1.Appearance.Options.UseBackColor = True
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Controls.Add(Me.someLabelControl2)
        Me.popupControlContainer1.Controls.Add(Me.someLabelControl1)
        Me.popupControlContainer1.Location = New System.Drawing.Point(111, 197)
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Ribbon = Me.ribbonControl
        Me.popupControlContainer1.Size = New System.Drawing.Size(76, 70)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'someLabelControl2
        '
        Me.someLabelControl2.Location = New System.Drawing.Point(3, 57)
        Me.someLabelControl2.Name = "someLabelControl2"
        Me.someLabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl2.TabIndex = 0
        Me.someLabelControl2.Text = "Some Info"
        '
        'someLabelControl1
        '
        Me.someLabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.someLabelControl1.Name = "someLabelControl1"
        Me.someLabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl1.TabIndex = 0
        Me.someLabelControl1.Text = "Some Info"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'siStatus
        '
        Me.siStatus.Caption = "Some Status Info"
        Me.siStatus.Id = 31
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'EditAppointmentQueryItem1
        '
        Me.EditAppointmentQueryItem1.Id = 62
        Me.EditAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.EditOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.EditSeriesUICommandItem1)})
        Me.EditAppointmentQueryItem1.Name = "EditAppointmentQueryItem1"
        Me.EditAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'EditOccurrenceUICommandItem1
        '
        Me.EditOccurrenceUICommandItem1.Id = 63
        Me.EditOccurrenceUICommandItem1.Name = "EditOccurrenceUICommandItem1"
        '
        'EditSeriesUICommandItem1
        '
        Me.EditSeriesUICommandItem1.Id = 64
        Me.EditSeriesUICommandItem1.Name = "EditSeriesUICommandItem1"
        '
        'DeleteAppointmentsItem1
        '
        Me.DeleteAppointmentsItem1.Id = 65
        Me.DeleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteSeriesItem1)})
        Me.DeleteAppointmentsItem1.Name = "DeleteAppointmentsItem1"
        Me.DeleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'DeleteOccurrenceItem1
        '
        Me.DeleteOccurrenceItem1.Id = 66
        Me.DeleteOccurrenceItem1.Name = "DeleteOccurrenceItem1"
        '
        'DeleteSeriesItem1
        '
        Me.DeleteSeriesItem1.Id = 67
        Me.DeleteSeriesItem1.Name = "DeleteSeriesItem1"
        '
        'SplitAppointmentItem1
        '
        Me.SplitAppointmentItem1.Id = 68
        Me.SplitAppointmentItem1.Name = "SplitAppointmentItem1"
        '
        'ChangeAppointmentStatusItem1
        '
        Me.ChangeAppointmentStatusItem1.Id = 69
        Me.ChangeAppointmentStatusItem1.Name = "ChangeAppointmentStatusItem1"
        '
        'ChangeAppointmentLabelItem1
        '
        Me.ChangeAppointmentLabelItem1.Id = 70
        Me.ChangeAppointmentLabelItem1.Name = "ChangeAppointmentLabelItem1"
        '
        'ToggleRecurrenceItem1
        '
        Me.ToggleRecurrenceItem1.Id = 71
        Me.ToggleRecurrenceItem1.Name = "ToggleRecurrenceItem1"
        '
        'ChangeAppointmentReminderItem1
        '
        Me.ChangeAppointmentReminderItem1.Edit = Me.RepositoryItemDuration1
        Me.ChangeAppointmentReminderItem1.Id = 72
        Me.ChangeAppointmentReminderItem1.Name = "ChangeAppointmentReminderItem1"
        '
        'RepositoryItemDuration1
        '
        Me.RepositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDuration1.AutoHeight = False
        Me.RepositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDuration1.DisabledStateText = Nothing
        Me.RepositoryItemDuration1.Name = "RepositoryItemDuration1"
        Me.RepositoryItemDuration1.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemDuration1.ShowEmptyItem = True
        Me.RepositoryItemDuration1.ValidateOnEnterKey = True
        '
        'SwitchToDayViewItem1
        '
        Me.SwitchToDayViewItem1.Caption = "Günlük Görünüm"
        Me.SwitchToDayViewItem1.Id = 73
        Me.SwitchToDayViewItem1.Name = "SwitchToDayViewItem1"
        '
        'SwitchToWorkWeekViewItem1
        '
        Me.SwitchToWorkWeekViewItem1.Caption = "Haftalık Çalışma Görünümü"
        Me.SwitchToWorkWeekViewItem1.Id = 74
        Me.SwitchToWorkWeekViewItem1.Name = "SwitchToWorkWeekViewItem1"
        '
        'SwitchToWeekViewItem1
        '
        Me.SwitchToWeekViewItem1.Id = 75
        Me.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1"
        '
        'SwitchToFullWeekViewItem1
        '
        Me.SwitchToFullWeekViewItem1.Caption = "Haftalık Görünüm"
        Me.SwitchToFullWeekViewItem1.Id = 76
        Me.SwitchToFullWeekViewItem1.Name = "SwitchToFullWeekViewItem1"
        '
        'SwitchToMonthViewItem1
        '
        Me.SwitchToMonthViewItem1.Caption = "Aylık Görünüm"
        Me.SwitchToMonthViewItem1.Id = 77
        Me.SwitchToMonthViewItem1.Name = "SwitchToMonthViewItem1"
        '
        'SwitchToTimelineViewItem1
        '
        Me.SwitchToTimelineViewItem1.Caption = "Zaman Çizelgesi Görünümü"
        Me.SwitchToTimelineViewItem1.Id = 78
        Me.SwitchToTimelineViewItem1.Name = "SwitchToTimelineViewItem1"
        '
        'SwitchToGanttViewItem1
        '
        Me.SwitchToGanttViewItem1.Caption = "Görev Akış Şeması"
        Me.SwitchToGanttViewItem1.Id = 79
        Me.SwitchToGanttViewItem1.Name = "SwitchToGanttViewItem1"
        '
        'SwitchTimeScalesItem1
        '
        Me.SwitchTimeScalesItem1.Id = 80
        Me.SwitchTimeScalesItem1.Name = "SwitchTimeScalesItem1"
        '
        'ChangeScaleWidthItem1
        '
        Me.ChangeScaleWidthItem1.Edit = Me.RepositoryItemSpinEdit1
        Me.ChangeScaleWidthItem1.Id = 81
        Me.ChangeScaleWidthItem1.Name = "ChangeScaleWidthItem1"
        Me.ChangeScaleWidthItem1.UseCommandCaption = True
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'SwitchTimeScalesCaptionItem1
        '
        Me.SwitchTimeScalesCaptionItem1.Id = 82
        Me.SwitchTimeScalesCaptionItem1.Name = "SwitchTimeScalesCaptionItem1"
        '
        'SwitchCompressWeekendItem1
        '
        Me.SwitchCompressWeekendItem1.Id = 83
        Me.SwitchCompressWeekendItem1.Name = "SwitchCompressWeekendItem1"
        '
        'SwitchShowWorkTimeOnlyItem1
        '
        Me.SwitchShowWorkTimeOnlyItem1.Id = 84
        Me.SwitchShowWorkTimeOnlyItem1.Name = "SwitchShowWorkTimeOnlyItem1"
        '
        'SwitchCellsAutoHeightItem1
        '
        Me.SwitchCellsAutoHeightItem1.Id = 85
        Me.SwitchCellsAutoHeightItem1.Name = "SwitchCellsAutoHeightItem1"
        '
        'ChangeSnapToCellsUIItem1
        '
        Me.ChangeSnapToCellsUIItem1.Id = 86
        Me.ChangeSnapToCellsUIItem1.Name = "ChangeSnapToCellsUIItem1"
        '
        'NewAppointmentItem1
        '
        Me.NewAppointmentItem1.Caption = "Yeni Görev"
        Me.NewAppointmentItem1.Id = 87
        Me.NewAppointmentItem1.Name = "NewAppointmentItem1"
        '
        'NewRecurringAppointmentItem1
        '
        Me.NewRecurringAppointmentItem1.Caption = "Yeni Tekrarlayan Görev"
        Me.NewRecurringAppointmentItem1.Id = 88
        Me.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1"
        '
        'NavigateViewBackwardItem1
        '
        Me.NavigateViewBackwardItem1.Caption = "Geri"
        Me.NavigateViewBackwardItem1.Id = 89
        Me.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1"
        '
        'NavigateViewForwardItem1
        '
        Me.NavigateViewForwardItem1.Caption = "İleri"
        Me.NavigateViewForwardItem1.Id = 90
        Me.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1"
        '
        'GotoTodayItem1
        '
        Me.GotoTodayItem1.Caption = "Bugüne Git"
        Me.GotoTodayItem1.Id = 91
        Me.GotoTodayItem1.Name = "GotoTodayItem1"
        '
        'ViewZoomInItem1
        '
        Me.ViewZoomInItem1.Caption = "Büyült"
        Me.ViewZoomInItem1.Id = 92
        Me.ViewZoomInItem1.Name = "ViewZoomInItem1"
        '
        'ViewZoomOutItem1
        '
        Me.ViewZoomOutItem1.Caption = "Küçült"
        Me.ViewZoomOutItem1.Id = 93
        Me.ViewZoomOutItem1.Name = "ViewZoomOutItem1"
        '
        'GroupByNoneItem1
        '
        Me.GroupByNoneItem1.Id = 94
        Me.GroupByNoneItem1.Name = "GroupByNoneItem1"
        '
        'GroupByDateItem1
        '
        Me.GroupByDateItem1.Id = 95
        Me.GroupByDateItem1.Name = "GroupByDateItem1"
        '
        'GroupByResourceItem1
        '
        Me.GroupByResourceItem1.Id = 96
        Me.GroupByResourceItem1.Name = "GroupByResourceItem1"
        '
        'OpenScheduleItem1
        '
        Me.OpenScheduleItem1.Id = 97
        Me.OpenScheduleItem1.Name = "OpenScheduleItem1"
        '
        'SaveScheduleItem1
        '
        Me.SaveScheduleItem1.Id = 98
        Me.SaveScheduleItem1.Name = "SaveScheduleItem1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 99
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 100
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPageSetupItem1
        '
        Me.PrintPageSetupItem1.Id = 101
        Me.PrintPageSetupItem1.Name = "PrintPageSetupItem1"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'CalendarToolsRibbonPageCategory1
        '
        Me.CalendarToolsRibbonPageCategory1.Control = Me.schedulerControl
        Me.CalendarToolsRibbonPageCategory1.Name = "CalendarToolsRibbonPageCategory1"
        Me.CalendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.AppointmentRibbonPage1})
        Me.CalendarToolsRibbonPageCategory1.Visible = False
        '
        'AppointmentRibbonPage1
        '
        Me.AppointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActionsRibbonPageGroup1, Me.OptionsRibbonPageGroup1})
        Me.AppointmentRibbonPage1.Name = "AppointmentRibbonPage1"
        Me.AppointmentRibbonPage1.Visible = False
        '
        'ActionsRibbonPageGroup1
        '
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.EditAppointmentQueryItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.DeleteAppointmentsItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.SplitAppointmentItem1)
        Me.ActionsRibbonPageGroup1.Name = "ActionsRibbonPageGroup1"
        '
        'OptionsRibbonPageGroup1
        '
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentStatusItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentLabelItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ToggleRecurrenceItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentReminderItem1)
        Me.OptionsRibbonPageGroup1.Name = "OptionsRibbonPageGroup1"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.PrintRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        Me.FileRibbonPage1.Visible = False
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.OpenScheduleItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SaveScheduleItem1)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        Me.CommonRibbonPageGroup1.Visible = False
        '
        'PrintRibbonPageGroup1
        '
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1)
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintPageSetupItem1)
        Me.PrintRibbonPageGroup1.Name = "PrintRibbonPageGroup1"
        Me.PrintRibbonPageGroup1.Visible = False
        '
        'HomeRibbonPage1
        '
        Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.AppointmentRibbonPageGroup1, Me.NavigatorRibbonPageGroup1, Me.ArrangeRibbonPageGroup1, Me.GroupByRibbonPageGroup1})
        Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
        Me.HomeRibbonPage1.Text = "Anasayfa"
        '
        'AppointmentRibbonPageGroup1
        '
        Me.AppointmentRibbonPageGroup1.Enabled = False
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewRecurringAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.Name = "AppointmentRibbonPageGroup1"
        Me.AppointmentRibbonPageGroup1.Text = "Görev"
        '
        'NavigatorRibbonPageGroup1
        '
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewBackwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewForwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.GotoTodayItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomInItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomOutItem1)
        Me.NavigatorRibbonPageGroup1.Name = "NavigatorRibbonPageGroup1"
        Me.NavigatorRibbonPageGroup1.Text = "Görünüm Araçları"
        '
        'ArrangeRibbonPageGroup1
        '
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDayViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWorkWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToFullWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToMonthViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToTimelineViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToGanttViewItem1)
        Me.ArrangeRibbonPageGroup1.Name = "ArrangeRibbonPageGroup1"
        Me.ArrangeRibbonPageGroup1.Text = "Görünüm Ayarları"
        '
        'GroupByRibbonPageGroup1
        '
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByNoneItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByDateItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByResourceItem1)
        Me.GroupByRibbonPageGroup1.Name = "GroupByRibbonPageGroup1"
        Me.GroupByRibbonPageGroup1.Visible = False
        '
        'ViewRibbonPage1
        '
        Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActiveViewRibbonPageGroup1, Me.TimeScaleRibbonPageGroup1, Me.LayoutRibbonPageGroup1})
        Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
        Me.ViewRibbonPage1.Text = "Çizelge"
        '
        'ActiveViewRibbonPageGroup1
        '
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDayViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWorkWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToFullWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToMonthViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToTimelineViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToGanttViewItem1)
        Me.ActiveViewRibbonPageGroup1.Name = "ActiveViewRibbonPageGroup1"
        Me.ActiveViewRibbonPageGroup1.Text = "Çizelgeler"
        '
        'TimeScaleRibbonPageGroup1
        '
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.ChangeScaleWidthItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.TimeScaleRibbonPageGroup1.Name = "TimeScaleRibbonPageGroup1"
        Me.TimeScaleRibbonPageGroup1.Visible = False
        '
        'LayoutRibbonPageGroup1
        '
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCompressWeekendItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCellsAutoHeightItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.ChangeSnapToCellsUIItem1)
        Me.LayoutRibbonPageGroup1.Name = "LayoutRibbonPageGroup1"
        Me.LayoutRibbonPageGroup1.Visible = False
        '
        'RibbonPageSkins
        '
        Me.RibbonPageSkins.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.skinsRibbonPageGroup})
        Me.RibbonPageSkins.Name = "RibbonPageSkins"
        Me.RibbonPageSkins.Text = "Tema"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Temalar"
        '
        'helpRibbonPage
        '
        Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.helpRibbonPageGroup})
        Me.helpRibbonPage.Name = "helpRibbonPage"
        Me.helpRibbonPage.Text = "Help"
        Me.helpRibbonPage.Visible = False
        '
        'helpRibbonPageGroup
        '
        Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
        Me.helpRibbonPageGroup.Text = "Help"
        Me.helpRibbonPageGroup.Visible = False
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 669)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 31)
        '
        'schedulerStorage
        '
        Me.schedulerStorage.AppointmentDependencies.DataSource = Me.TaskDependenciesBindingSource
        Me.schedulerStorage.AppointmentDependencies.Mappings.DependentId = "DependentId"
        Me.schedulerStorage.AppointmentDependencies.Mappings.ParentId = "ParentId"
        Me.schedulerStorage.AppointmentDependencies.Mappings.Type = "Type"
        Me.schedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Kisiname", "CustomField1"))
        Me.schedulerStorage.Appointments.DataSource = Me.AppointmentsBindingSource
        Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
        Me.schedulerStorage.Appointments.Mappings.AppointmentId = "UniqueId"
        Me.schedulerStorage.Appointments.Mappings.Description = "Description"
        Me.schedulerStorage.Appointments.Mappings.End = "EndDate"
        Me.schedulerStorage.Appointments.Mappings.Label = "Label"
        Me.schedulerStorage.Appointments.Mappings.Location = "Location"
        Me.schedulerStorage.Appointments.Mappings.PercentComplete = "PercentComplete"
        Me.schedulerStorage.Appointments.Mappings.ResourceId = "ResourceId"
        Me.schedulerStorage.Appointments.Mappings.Start = "StartDate"
        Me.schedulerStorage.Appointments.Mappings.Status = "Status"
        Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
        Me.schedulerStorage.Appointments.Mappings.TimeZoneId = "ResourceIds"
        Me.schedulerStorage.Appointments.Mappings.Type = "Type"
        Me.schedulerStorage.Resources.DataSource = Me.GRVBirimlerBindingSource
        Me.schedulerStorage.Resources.Mappings.Caption = "dbbirim_amir"
        Me.schedulerStorage.Resources.Mappings.Id = "dbbirim_id"
        Me.schedulerStorage.Resources.Mappings.ParentId = "FK_Gorev_Teslim_Edilen_Kisi"
        '
        'TaskDependenciesBindingSource
        '
        Me.TaskDependenciesBindingSource.DataMember = "TaskDependencies"
        Me.TaskDependenciesBindingSource.DataSource = Me.BIMDataSet
        '
        'BIMDataSet
        '
        Me.BIMDataSet.DataSetName = "BIMDataSet"
        Me.BIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.BIMDataSet
        '
        'GRVBirimlerBindingSource
        '
        Me.GRVBirimlerBindingSource.DataMember = "GRV_Birimler"
        Me.GRVBirimlerBindingSource.DataSource = Me.BIMDataSet
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(717, 486)
        Me.XtraTabPage2.Text = "Görev Listesi"
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.MenuManager = Me.ribbonControl
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(717, 486)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        '
        'dateNavigator
        '
        Me.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dateNavigator.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dateNavigator.HotDate = Nothing
        Me.dateNavigator.Location = New System.Drawing.Point(0, 0)
        Me.dateNavigator.Name = "dateNavigator"
        Me.dateNavigator.SchedulerControl = Me.schedulerControl
        Me.dateNavigator.Size = New System.Drawing.Size(190, 514)
        Me.dateNavigator.TabIndex = 1
        '
        'SchedulerBarController1
        '
        Me.SchedulerBarController1.BarItems.Add(Me.EditAppointmentQueryItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditOccurrenceUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditSeriesUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteAppointmentsItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteOccurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteSeriesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SplitAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentStatusItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentLabelItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ToggleRecurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentReminderItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToDayViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWorkWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToFullWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToMonthViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToTimelineViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToGanttViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeScaleWidthItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCompressWeekendItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCellsAutoHeightItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeSnapToCellsUIItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewRecurringAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewBackwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewForwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GotoTodayItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomInItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomOutItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByNoneItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByDateItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByResourceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.OpenScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SaveScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPageSetupItem1)
        Me.SchedulerBarController1.Control = Me.schedulerControl
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.ribbonControl
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(400, 200)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'GRV_BirimlerTableAdapter
        '
        Me.GRV_BirimlerTableAdapter.ClearBeforeFill = True
        '
        'TaskDependenciesTableAdapter
        '
        Me.TaskDependenciesTableAdapter.ClearBeforeFill = True
        '
        'Gorev_Liste1ToolStrip
        '
        Me.Gorev_Liste1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KisiidToolStripLabel, Me.KisiidToolStripTextBox, Me.Gorev_Liste1ToolStripButton})
        Me.Gorev_Liste1ToolStrip.Location = New System.Drawing.Point(0, 143)
        Me.Gorev_Liste1ToolStrip.Name = "Gorev_Liste1ToolStrip"
        Me.Gorev_Liste1ToolStrip.Size = New System.Drawing.Size(1100, 25)
        Me.Gorev_Liste1ToolStrip.TabIndex = 20
        Me.Gorev_Liste1ToolStrip.Text = "Gorev_Liste1ToolStrip"
        Me.Gorev_Liste1ToolStrip.Visible = False
        '
        'KisiidToolStripLabel
        '
        Me.KisiidToolStripLabel.Name = "KisiidToolStripLabel"
        Me.KisiidToolStripLabel.Size = New System.Drawing.Size(37, 22)
        Me.KisiidToolStripLabel.Text = "kisiid:"
        '
        'KisiidToolStripTextBox
        '
        Me.KisiidToolStripTextBox.Name = "KisiidToolStripTextBox"
        Me.KisiidToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Gorev_Liste1ToolStripButton
        '
        Me.Gorev_Liste1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Gorev_Liste1ToolStripButton.Name = "Gorev_Liste1ToolStripButton"
        Me.Gorev_Liste1ToolStripButton.Size = New System.Drawing.Size(77, 22)
        Me.Gorev_Liste1ToolStripButton.Text = "Gorev_Liste1"
        '
        'BackgroundWorker1
        '
        '
        'Gorev_Liste1ToolStrip1
        '
        Me.Gorev_Liste1ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KisiidToolStripLabel1, Me.KisiidToolStripTextBox1, Me.Gorev_Liste1ToolStripButton1})
        Me.Gorev_Liste1ToolStrip1.Location = New System.Drawing.Point(0, 143)
        Me.Gorev_Liste1ToolStrip1.Name = "Gorev_Liste1ToolStrip1"
        Me.Gorev_Liste1ToolStrip1.Size = New System.Drawing.Size(1100, 25)
        Me.Gorev_Liste1ToolStrip1.TabIndex = 23
        Me.Gorev_Liste1ToolStrip1.Text = "Gorev_Liste1ToolStrip1"
        Me.Gorev_Liste1ToolStrip1.Visible = False
        '
        'KisiidToolStripLabel1
        '
        Me.KisiidToolStripLabel1.Name = "KisiidToolStripLabel1"
        Me.KisiidToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.KisiidToolStripLabel1.Text = "kisiid:"
        '
        'KisiidToolStripTextBox1
        '
        Me.KisiidToolStripTextBox1.Name = "KisiidToolStripTextBox1"
        Me.KisiidToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'Gorev_Liste1ToolStripButton1
        '
        Me.Gorev_Liste1ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Gorev_Liste1ToolStripButton1.Name = "Gorev_Liste1ToolStripButton1"
        Me.Gorev_Liste1ToolStripButton1.Size = New System.Drawing.Size(77, 22)
        Me.Gorev_Liste1ToolStripButton1.Text = "Gorev_Liste1"
        '
        'DoldurToolStrip
        '
        Me.DoldurToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoldurToolStripButton})
        Me.DoldurToolStrip.Location = New System.Drawing.Point(0, 143)
        Me.DoldurToolStrip.Name = "DoldurToolStrip"
        Me.DoldurToolStrip.Size = New System.Drawing.Size(1100, 25)
        Me.DoldurToolStrip.TabIndex = 26
        Me.DoldurToolStrip.Text = "DoldurToolStrip"
        Me.DoldurToolStrip.Visible = False
        '
        'DoldurToolStripButton
        '
        Me.DoldurToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DoldurToolStripButton.Name = "DoldurToolStripButton"
        Me.DoldurToolStripButton.Size = New System.Drawing.Size(47, 22)
        Me.DoldurToolStripButton.Text = "Doldur"
        '
        'GorevCekToolStrip
        '
        Me.GorevCekToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginidToolStripLabel, Me.LoginidToolStripTextBox, Me.GorevCekToolStripButton})
        Me.GorevCekToolStrip.Location = New System.Drawing.Point(0, 143)
        Me.GorevCekToolStrip.Name = "GorevCekToolStrip"
        Me.GorevCekToolStrip.Size = New System.Drawing.Size(1100, 25)
        Me.GorevCekToolStrip.TabIndex = 35
        Me.GorevCekToolStrip.Text = "GorevCekToolStrip"
        Me.GorevCekToolStrip.Visible = False
        '
        'LoginidToolStripLabel
        '
        Me.LoginidToolStripLabel.Name = "LoginidToolStripLabel"
        Me.LoginidToolStripLabel.Size = New System.Drawing.Size(47, 22)
        Me.LoginidToolStripLabel.Text = "loginid:"
        '
        'LoginidToolStripTextBox
        '
        Me.LoginidToolStripTextBox.Name = "LoginidToolStripTextBox"
        Me.LoginidToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'GorevCekToolStripButton
        '
        Me.GorevCekToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GorevCekToolStripButton.Name = "GorevCekToolStripButton"
        Me.GorevCekToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.GorevCekToolStripButton.Text = "GorevCek"
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.GorevCekToolStrip)
        Me.Controls.Add(Me.Gorev_Liste1ToolStrip)
        Me.Controls.Add(Me.Gorev_Liste1ToolStrip1)
        Me.Controls.Add(Me.DoldurToolStrip)
        Me.Controls.Add(Me.splitContainerControl)
        Me.Controls.Add(Me.popupControlContainer1)
        Me.Controls.Add(Me.popupControlContainer2)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "SPTASKING v0.4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerControl.ResumeLayout(False)
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.schedulerSplitContainerControl.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer2.ResumeLayout(False)
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer1.ResumeLayout(False)
        Me.popupControlContainer1.PerformLayout()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRVBirimlerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gorev_Liste1ToolStrip.ResumeLayout(False)
        Me.Gorev_Liste1ToolStrip.PerformLayout()
        Me.Gorev_Liste1ToolStrip1.ResumeLayout(False)
        Me.Gorev_Liste1ToolStrip1.PerformLayout()
        Me.DoldurToolStrip.ResumeLayout(False)
        Me.DoldurToolStrip.PerformLayout()
        Me.GorevCekToolStrip.ResumeLayout(False)
        Me.GorevCekToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Private WithEvents splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents someLabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents someLabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents popupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents buttonEdit As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Private WithEvents mailGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents organizerGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents inboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents outboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents schedulerSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Private WithEvents dateNavigator As DevExpress.XtraScheduler.DateNavigator
    Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents EditAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
    Friend WithEvents EditOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
    Friend WithEvents EditSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
    Friend WithEvents DeleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
    Friend WithEvents DeleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
    Friend WithEvents DeleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
    Friend WithEvents SplitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
    Friend WithEvents ChangeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
    Friend WithEvents ChangeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
    Friend WithEvents ToggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
    Friend WithEvents ChangeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
    Friend WithEvents RepositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
    Friend WithEvents SwitchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
    Friend WithEvents SwitchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
    Friend WithEvents SwitchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
    Friend WithEvents SwitchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem
    Friend WithEvents SwitchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
    Friend WithEvents SwitchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
    Friend WithEvents SwitchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem
    Friend WithEvents SwitchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
    Friend WithEvents ChangeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SwitchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem
    Friend WithEvents SwitchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
    Friend WithEvents SwitchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
    Friend WithEvents SwitchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem
    Friend WithEvents ChangeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem
    Friend WithEvents NewAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
    Friend WithEvents NewRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
    Friend WithEvents NavigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
    Friend WithEvents NavigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
    Friend WithEvents GotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
    Friend WithEvents ViewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
    Friend WithEvents ViewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
    Friend WithEvents GroupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
    Friend WithEvents GroupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
    Friend WithEvents GroupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
    Friend WithEvents OpenScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
    Friend WithEvents SaveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
    Friend WithEvents PrintItem1 As DevExpress.XtraScheduler.UI.PrintItem
    Friend WithEvents PrintPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
    Friend WithEvents CalendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
    Friend WithEvents AppointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage
    Friend WithEvents ActionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup
    Friend WithEvents OptionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup
    Friend WithEvents PrintRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup
    Friend WithEvents HomeRibbonPage1 As DevExpress.XtraScheduler.UI.HomeRibbonPage
    Friend WithEvents AppointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup
    Friend WithEvents NavigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup
    Friend WithEvents ArrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup
    Friend WithEvents GroupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup
    Friend WithEvents ViewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage
    Friend WithEvents ActiveViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup
    Friend WithEvents TimeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup
    Friend WithEvents LayoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup
    Friend WithEvents SchedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
    Private WithEvents RibbonPageSkins As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TaskDependenciesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GRVBirimlerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gorev_Liste1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents KisiidToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KisiidToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Gorev_Liste1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents AppointmentsTableAdapter As MyTASKING.BIMDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents GRV_BirimlerTableAdapter As MyTASKING.BIMDataSetTableAdapters.GRV_BirimlerTableAdapter
    Friend WithEvents TaskDependenciesTableAdapter As MyTASKING.BIMDataSetTableAdapters.TaskDependenciesTableAdapter
    Friend WithEvents BIMDataSet As MyTASKING.BIMDataSet
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Gorev_Liste1ToolStrip1 As ToolStrip
    Friend WithEvents KisiidToolStripLabel1 As ToolStripLabel
    Friend WithEvents KisiidToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Gorev_Liste1ToolStripButton1 As ToolStripButton
    Friend WithEvents DoldurToolStrip As ToolStrip
    Friend WithEvents DoldurToolStripButton As ToolStripButton
    Friend WithEvents GorevCekToolStrip As ToolStrip
    Friend WithEvents LoginidToolStripLabel As ToolStripLabel
    Friend WithEvents LoginidToolStripTextBox As ToolStripTextBox
    Friend WithEvents GorevCekToolStripButton As ToolStripButton
End Class
