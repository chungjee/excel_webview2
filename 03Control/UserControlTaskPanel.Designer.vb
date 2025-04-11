<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebviewTaskPaneControl
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebviewTaskPaneControl))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.spcAddress = New System.Windows.Forms.SplitContainer()
        Me.txbURL = New System.Windows.Forms.TextBox()
        Me.btnNavigate = New System.Windows.Forms.Button()
        Me.wbvTaskPan = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.palBottom = New System.Windows.Forms.Panel()
        Me.spcNagivate = New System.Windows.Forms.SplitContainer()
        Me.lbPage = New System.Windows.Forms.Label()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnBackward = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItemSystemSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemRequestDirection = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemResponseParser = New System.Windows.Forms.ToolStripMenuItem()
        Me.StripMenuItemSystemSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.tooltxtLable = New System.Windows.Forms.ToolStripTextBox()
        Me.tooltxtForward = New System.Windows.Forms.ToolStripTextBox()
        Me.tooltxtBackward = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuItemFilterSwitch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemRequestSwitch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemResponseSwitch = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        CType(Me.spcAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcAddress.Panel1.SuspendLayout()
        Me.spcAddress.Panel2.SuspendLayout()
        Me.spcAddress.SuspendLayout()
        CType(Me.wbvTaskPan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palBottom.SuspendLayout()
        CType(Me.spcNagivate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcNagivate.Panel1.SuspendLayout()
        Me.spcNagivate.Panel2.SuspendLayout()
        Me.spcNagivate.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "13")
        Me.ImageList1.Images.SetKeyName(1, "9")
        '
        'spcAddress
        '
        Me.spcAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spcAddress.Dock = System.Windows.Forms.DockStyle.Top
        Me.spcAddress.Location = New System.Drawing.Point(0, 0)
        Me.spcAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.spcAddress.Name = "spcAddress"
        '
        'spcAddress.Panel1
        '
        Me.spcAddress.Panel1.Controls.Add(Me.txbURL)
        Me.spcAddress.Panel1MinSize = 22
        '
        'spcAddress.Panel2
        '
        Me.spcAddress.Panel2.Controls.Add(Me.btnNavigate)
        Me.spcAddress.Panel2MinSize = 22
        Me.spcAddress.Size = New System.Drawing.Size(700, 27)
        Me.spcAddress.SplitterDistance = 542
        Me.spcAddress.SplitterIncrement = 2
        Me.spcAddress.SplitterWidth = 2
        Me.spcAddress.TabIndex = 2
        '
        'txbURL
        '
        Me.txbURL.AutoCompleteCustomSource.AddRange(New String() {"https://www.baidu.com", "https://e.dianping.com"})
        Me.txbURL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbURL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txbURL.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.txbURL.Location = New System.Drawing.Point(0, 2)
        Me.txbURL.Margin = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.txbURL.Name = "txbURL"
        Me.txbURL.Size = New System.Drawing.Size(540, 23)
        Me.txbURL.TabIndex = 0
        '
        'btnNavigate
        '
        Me.btnNavigate.AutoSize = True
        Me.btnNavigate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNavigate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNavigate.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.btnNavigate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNavigate.ImageIndex = 1
        Me.btnNavigate.ImageList = Me.ImageList1
        Me.btnNavigate.Location = New System.Drawing.Point(0, 0)
        Me.btnNavigate.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.btnNavigate.Name = "btnNavigate"
        Me.btnNavigate.Size = New System.Drawing.Size(154, 25)
        Me.btnNavigate.TabIndex = 0
        Me.btnNavigate.TabStop = False
        Me.btnNavigate.Text = "转到"
        Me.btnNavigate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNavigate.UseVisualStyleBackColor = False
        '
        'wbvTaskPan
        '
        Me.wbvTaskPan.AllowExternalDrop = True
        Me.wbvTaskPan.CreationProperties = Nothing
        Me.wbvTaskPan.DefaultBackgroundColor = System.Drawing.Color.White
        Me.wbvTaskPan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbvTaskPan.Location = New System.Drawing.Point(0, 27)
        Me.wbvTaskPan.Name = "wbvTaskPan"
        Me.wbvTaskPan.Size = New System.Drawing.Size(700, 473)
        Me.wbvTaskPan.TabIndex = 1
        Me.wbvTaskPan.ZoomFactor = 1.0R
        '
        'palBottom
        '
        Me.palBottom.Controls.Add(Me.spcNagivate)
        Me.palBottom.Controls.Add(Me.ToolStripContainer1)
        Me.palBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.palBottom.Location = New System.Drawing.Point(0, 472)
        Me.palBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.palBottom.Name = "palBottom"
        Me.palBottom.Size = New System.Drawing.Size(700, 28)
        Me.palBottom.TabIndex = 3
        '
        'spcNagivate
        '
        Me.spcNagivate.Dock = System.Windows.Forms.DockStyle.Left
        Me.spcNagivate.Location = New System.Drawing.Point(0, 0)
        Me.spcNagivate.Margin = New System.Windows.Forms.Padding(0)
        Me.spcNagivate.Name = "spcNagivate"
        '
        'spcNagivate.Panel1
        '
        Me.spcNagivate.Panel1.Controls.Add(Me.lbPage)
        Me.spcNagivate.Panel1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        '
        'spcNagivate.Panel2
        '
        Me.spcNagivate.Panel2.Controls.Add(Me.btnForward)
        Me.spcNagivate.Panel2.Controls.Add(Me.btnBackward)
        Me.spcNagivate.Panel2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.spcNagivate.Size = New System.Drawing.Size(160, 28)
        Me.spcNagivate.SplitterDistance = 80
        Me.spcNagivate.SplitterWidth = 2
        Me.spcNagivate.TabIndex = 7
        '
        'lbPage
        '
        Me.lbPage.AutoSize = True
        Me.lbPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPage.Font = New System.Drawing.Font("宋体", 8.0!)
        Me.lbPage.Location = New System.Drawing.Point(0, 8)
        Me.lbPage.Margin = New System.Windows.Forms.Padding(0)
        Me.lbPage.Name = "lbPage"
        Me.lbPage.Size = New System.Drawing.Size(49, 14)
        Me.lbPage.TabIndex = 9
        Me.lbPage.Text = "......"
        Me.lbPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnForward
        '
        Me.btnForward.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnForward.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.btnForward.Location = New System.Drawing.Point(0, 4)
        Me.btnForward.Margin = New System.Windows.Forms.Padding(0)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(25, 24)
        Me.btnForward.TabIndex = 4
        Me.btnForward.Text = "<"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnBackward
        '
        Me.btnBackward.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBackward.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.btnBackward.Location = New System.Drawing.Point(53, 4)
        Me.btnBackward.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBackward.Name = "btnBackward"
        Me.btnBackward.Size = New System.Drawing.Size(25, 24)
        Me.btnBackward.TabIndex = 3
        Me.btnBackward.Text = ">"
        Me.btnBackward.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(240, 3)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStripContainer1.Location = New System.Drawing.Point(460, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(240, 28)
        Me.ToolStripContainer1.TabIndex = 6
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSystemSetup, Me.MenuItemFilterSwitch})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(240, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuItemSystemSetup
        '
        Me.MenuItemSystemSetup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemRequestDirection, Me.MenuItemResponseParser, Me.StripMenuItemSystemSetup, Me.tooltxtLable, Me.tooltxtForward, Me.tooltxtBackward})
        Me.MenuItemSystemSetup.Image = Global.VSTO_Excel_WebView2.My.Resources.Resources.qkwck9cj
        Me.MenuItemSystemSetup.Name = "MenuItemSystemSetup"
        Me.MenuItemSystemSetup.Size = New System.Drawing.Size(103, 24)
        Me.MenuItemSystemSetup.Text = "系统设置"
        '
        'MenuItemRequestDirection
        '
        Me.MenuItemRequestDirection.Image = Global.VSTO_Excel_WebView2.My.Resources.Resources._9
        Me.MenuItemRequestDirection.Name = "MenuItemRequestDirection"
        Me.MenuItemRequestDirection.Size = New System.Drawing.Size(212, 26)
        Me.MenuItemRequestDirection.Text = "请求过滤转向设置"
        '
        'MenuItemResponseParser
        '
        Me.MenuItemResponseParser.Name = "MenuItemResponseParser"
        Me.MenuItemResponseParser.Size = New System.Drawing.Size(212, 26)
        Me.MenuItemResponseParser.Text = "响应过滤解析设置"
        '
        'StripMenuItemSystemSetup
        '
        Me.StripMenuItemSystemSetup.Name = "StripMenuItemSystemSetup"
        Me.StripMenuItemSystemSetup.Size = New System.Drawing.Size(212, 26)
        Me.StripMenuItemSystemSetup.Text = "系统参数设置"
        '
        'tooltxtLable
        '
        Me.tooltxtLable.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.tooltxtLable.Name = "tooltxtLable"
        Me.tooltxtLable.Size = New System.Drawing.Size(100, 27)
        '
        'tooltxtForward
        '
        Me.tooltxtForward.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.tooltxtForward.Name = "tooltxtForward"
        Me.tooltxtForward.Size = New System.Drawing.Size(100, 27)
        '
        'tooltxtBackward
        '
        Me.tooltxtBackward.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.tooltxtBackward.Name = "tooltxtBackward"
        Me.tooltxtBackward.Size = New System.Drawing.Size(100, 27)
        '
        'MenuItemFilterSwitch
        '
        Me.MenuItemFilterSwitch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemRequestSwitch, Me.MenuItemResponseSwitch})
        Me.MenuItemFilterSwitch.Image = Global.VSTO_Excel_WebView2.My.Resources.Resources._91
        Me.MenuItemFilterSwitch.Name = "MenuItemFilterSwitch"
        Me.MenuItemFilterSwitch.Size = New System.Drawing.Size(118, 24)
        Me.MenuItemFilterSwitch.Text = "过滤器开关"
        '
        'MenuItemRequestSwitch
        '
        Me.MenuItemRequestSwitch.Name = "MenuItemRequestSwitch"
        Me.MenuItemRequestSwitch.Size = New System.Drawing.Size(197, 26)
        Me.MenuItemRequestSwitch.Text = "请求过滤器转向"
        '
        'MenuItemResponseSwitch
        '
        Me.MenuItemResponseSwitch.Name = "MenuItemResponseSwitch"
        Me.MenuItemResponseSwitch.Size = New System.Drawing.Size(197, 26)
        Me.MenuItemResponseSwitch.Text = "响应过滤器捕捉"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(115, 601)
        '
        'WebviewTaskPaneControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.palBottom)
        Me.Controls.Add(Me.wbvTaskPan)
        Me.Controls.Add(Me.spcAddress)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "WebviewTaskPaneControl"
        Me.Size = New System.Drawing.Size(700, 500)
        Me.spcAddress.Panel1.ResumeLayout(False)
        Me.spcAddress.Panel1.PerformLayout()
        Me.spcAddress.Panel2.ResumeLayout(False)
        Me.spcAddress.Panel2.PerformLayout()
        CType(Me.spcAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcAddress.ResumeLayout(False)
        CType(Me.wbvTaskPan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palBottom.ResumeLayout(False)
        Me.spcNagivate.Panel1.ResumeLayout(False)
        Me.spcNagivate.Panel1.PerformLayout()
        Me.spcNagivate.Panel2.ResumeLayout(False)
        CType(Me.spcNagivate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcNagivate.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents spcAddress As Windows.Forms.SplitContainer
    Friend WithEvents txbURL As Windows.Forms.TextBox
    Friend WithEvents btnNavigate As Windows.Forms.Button
    Friend WithEvents wbvTaskPan As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents palBottom As Windows.Forms.Panel
    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents MenuItemSystemSetup As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemRequestDirection As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemResponseParser As Windows.Forms.ToolStripMenuItem
    Friend WithEvents StripMenuItemSystemSetup As Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As Windows.Forms.ToolStripContentPanel
    Friend WithEvents MenuItemFilterSwitch As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemRequestSwitch As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemResponseSwitch As Windows.Forms.ToolStripMenuItem
    Friend WithEvents spcNagivate As Windows.Forms.SplitContainer
    Friend WithEvents btnForward As Windows.Forms.Button
    Friend WithEvents btnBackward As Windows.Forms.Button
    Friend WithEvents lbPage As Windows.Forms.Label
    Friend WithEvents tooltxtLable As Windows.Forms.ToolStripTextBox
    Friend WithEvents tooltxtBackward As Windows.Forms.ToolStripTextBox
    Friend WithEvents tooltxtForward As Windows.Forms.ToolStripTextBox
End Class
