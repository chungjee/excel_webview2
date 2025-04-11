Partial Class Ribbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Windows.Forms 类撰写设计器支持所必需的
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        '组件设计器需要此调用。
        InitializeComponent()

    End Sub

    '组件重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '组件设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是组件设计器所必需的
    '可使用组件设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ribbon))
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.tab_WebView = Me.Factory.CreateRibbonTab
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.btnMeiTuan = Me.Factory.CreateRibbonButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnTaskPanel = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.tab_WebView.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Label = "TabAddIns"
        Me.Tab1.Name = "Tab1"
        '
        'tab_WebView
        '
        Me.tab_WebView.Groups.Add(Me.Group2)
        Me.tab_WebView.Label = "数据聚合"
        Me.tab_WebView.Name = "tab_WebView"
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.btnMeiTuan)
        Me.Group2.Label = "WebView2"
        Me.Group2.Name = "Group2"
        '
        'btnMeiTuan
        '
        Me.btnMeiTuan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnMeiTuan.Image = Global.VSTO_Excel_WebView2.My.Resources.Resources._5
        Me.btnMeiTuan.Label = "美团登录"
        Me.btnMeiTuan.Name = "btnMeiTuan"
        Me.btnMeiTuan.ShowImage = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "9")
        '
        'btnTaskPanel
        '
        Me.btnTaskPanel.Image = Global.VSTO_Excel_WebView2.My.Resources.Resources._9
        Me.btnTaskPanel.Label = "浏览器面板"
        Me.btnTaskPanel.Name = "btnTaskPanel"
        Me.btnTaskPanel.ShowImage = True
        '
        'Ribbon
        '
        Me.Name = "Ribbon"
        '
        'Ribbon.OfficeMenu
        '
        Me.OfficeMenu.Items.Add(Me.btnTaskPanel)
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tabs.Add(Me.tab_WebView)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.tab_WebView.ResumeLayout(False)
        Me.tab_WebView.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents tab_WebView As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnMeiTuan As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents btnTaskPanel As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()>
    Friend ReadOnly Property Ribbon1() As Ribbon
        Get
            Return Me.GetRibbon(Of Ribbon)()
        End Get
    End Property
End Class