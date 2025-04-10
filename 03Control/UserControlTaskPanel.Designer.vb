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
        Me.btnForward = New System.Windows.Forms.Button()
        Me.wbvTaskPan = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSetupParser = New System.Windows.Forms.Button()
        CType(Me.spcAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcAddress.Panel1.SuspendLayout()
        Me.spcAddress.Panel2.SuspendLayout()
        Me.spcAddress.SuspendLayout()
        CType(Me.wbvTaskPan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.spcAddress.Panel2.Controls.Add(Me.btnForward)
        Me.spcAddress.Panel2MinSize = 22
        Me.spcAddress.Size = New System.Drawing.Size(356, 27)
        Me.spcAddress.SplitterDistance = 278
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
        Me.txbURL.Size = New System.Drawing.Size(276, 23)
        Me.txbURL.TabIndex = 0
        '
        'btnForward
        '
        Me.btnForward.AutoSize = True
        Me.btnForward.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnForward.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.btnForward.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnForward.ImageIndex = 1
        Me.btnForward.ImageList = Me.ImageList1
        Me.btnForward.Location = New System.Drawing.Point(0, 0)
        Me.btnForward.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(74, 25)
        Me.btnForward.TabIndex = 0
        Me.btnForward.TabStop = False
        Me.btnForward.Text = "转到"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'wbvTaskPan
        '
        Me.wbvTaskPan.AllowExternalDrop = True
        Me.wbvTaskPan.CreationProperties = Nothing
        Me.wbvTaskPan.DefaultBackgroundColor = System.Drawing.Color.White
        Me.wbvTaskPan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbvTaskPan.Location = New System.Drawing.Point(0, 27)
        Me.wbvTaskPan.Name = "wbvTaskPan"
        Me.wbvTaskPan.Size = New System.Drawing.Size(356, 434)
        Me.wbvTaskPan.TabIndex = 1
        Me.wbvTaskPan.ZoomFactor = 1.0R
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSetupParser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 439)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1, 3, 1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 22)
        Me.Panel1.TabIndex = 3
        '
        'btnSetupParser
        '
        Me.btnSetupParser.AutoSize = True
        Me.btnSetupParser.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSetupParser.Location = New System.Drawing.Point(262, 0)
        Me.btnSetupParser.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSetupParser.Name = "btnSetupParser"
        Me.btnSetupParser.Size = New System.Drawing.Size(94, 22)
        Me.btnSetupParser.TabIndex = 0
        Me.btnSetupParser.Text = "设置解析器"
        Me.btnSetupParser.UseVisualStyleBackColor = True
        '
        'WebviewTaskPaneControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.wbvTaskPan)
        Me.Controls.Add(Me.spcAddress)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "WebviewTaskPaneControl"
        Me.Size = New System.Drawing.Size(356, 461)
        Me.spcAddress.Panel1.ResumeLayout(False)
        Me.spcAddress.Panel1.PerformLayout()
        Me.spcAddress.Panel2.ResumeLayout(False)
        Me.spcAddress.Panel2.PerformLayout()
        CType(Me.spcAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcAddress.ResumeLayout(False)
        CType(Me.wbvTaskPan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents spcAddress As Windows.Forms.SplitContainer
    Friend WithEvents txbURL As Windows.Forms.TextBox
    Friend WithEvents btnForward As Windows.Forms.Button
    Friend WithEvents wbvTaskPan As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnSetupParser As Windows.Forms.Button
End Class
