<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysiserSetup
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("网络响应过滤器")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysiserSetup))
        Me.ChungJeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.trvResponseFilter = New System.Windows.Forms.TreeView()
        Me.spcContentEdit = New System.Windows.Forms.SplitContainer()
        Me.txtContentEdit = New System.Windows.Forms.TextBox()
        Me.spcFileUpload = New System.Windows.Forms.SplitContainer()
        Me.spcBrowseFile = New System.Windows.Forms.SplitContainer()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnBrowseFile = New System.Windows.Forms.Button()
        Me.btnUploadFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ChungJeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        CType(Me.spcContentEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcContentEdit.Panel1.SuspendLayout()
        Me.spcContentEdit.Panel2.SuspendLayout()
        Me.spcContentEdit.SuspendLayout()
        CType(Me.spcFileUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcFileUpload.Panel1.SuspendLayout()
        Me.spcFileUpload.Panel2.SuspendLayout()
        Me.spcFileUpload.SuspendLayout()
        CType(Me.spcBrowseFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcBrowseFile.Panel1.SuspendLayout()
        Me.spcBrowseFile.Panel2.SuspendLayout()
        Me.spcBrowseFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChungJeeBindingSource
        '
        Me.ChungJeeBindingSource.DataSource = GetType(VSTO_Excel_WebView2.My.ChungJee)
        '
        'spcMain
        '
        Me.spcMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 0)
        Me.spcMain.Name = "spcMain"
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.trvResponseFilter)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.spcContentEdit)
        Me.spcMain.Size = New System.Drawing.Size(791, 550)
        Me.spcMain.SplitterDistance = 370
        Me.spcMain.SplitterWidth = 1
        Me.spcMain.TabIndex = 2
        '
        'trvResponseFilter
        '
        Me.trvResponseFilter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.trvResponseFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvResponseFilter.Location = New System.Drawing.Point(0, 0)
        Me.trvResponseFilter.Name = "trvResponseFilter"
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "网络响应过滤器"
        Me.trvResponseFilter.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.trvResponseFilter.Size = New System.Drawing.Size(368, 548)
        Me.trvResponseFilter.TabIndex = 1
        '
        'spcContentEdit
        '
        Me.spcContentEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcContentEdit.Location = New System.Drawing.Point(0, 0)
        Me.spcContentEdit.Name = "spcContentEdit"
        Me.spcContentEdit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcContentEdit.Panel1
        '
        Me.spcContentEdit.Panel1.Controls.Add(Me.txtContentEdit)
        '
        'spcContentEdit.Panel2
        '
        Me.spcContentEdit.Panel2.Controls.Add(Me.spcFileUpload)
        Me.spcContentEdit.Size = New System.Drawing.Size(418, 548)
        Me.spcContentEdit.SplitterDistance = 516
        Me.spcContentEdit.SplitterWidth = 2
        Me.spcContentEdit.TabIndex = 2
        '
        'txtContentEdit
        '
        Me.txtContentEdit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContentEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContentEdit.Location = New System.Drawing.Point(0, 0)
        Me.txtContentEdit.Multiline = True
        Me.txtContentEdit.Name = "txtContentEdit"
        Me.txtContentEdit.Size = New System.Drawing.Size(418, 516)
        Me.txtContentEdit.TabIndex = 0
        '
        'spcFileUpload
        '
        Me.spcFileUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcFileUpload.Location = New System.Drawing.Point(0, 0)
        Me.spcFileUpload.Margin = New System.Windows.Forms.Padding(0)
        Me.spcFileUpload.Name = "spcFileUpload"
        '
        'spcFileUpload.Panel1
        '
        Me.spcFileUpload.Panel1.Controls.Add(Me.spcBrowseFile)
        '
        'spcFileUpload.Panel2
        '
        Me.spcFileUpload.Panel2.Controls.Add(Me.btnUploadFile)
        Me.spcFileUpload.Size = New System.Drawing.Size(418, 30)
        Me.spcFileUpload.SplitterDistance = 328
        Me.spcFileUpload.TabIndex = 0
        '
        'spcBrowseFile
        '
        Me.spcBrowseFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcBrowseFile.Location = New System.Drawing.Point(0, 0)
        Me.spcBrowseFile.Margin = New System.Windows.Forms.Padding(0)
        Me.spcBrowseFile.Name = "spcBrowseFile"
        '
        'spcBrowseFile.Panel1
        '
        Me.spcBrowseFile.Panel1.Controls.Add(Me.txtFileName)
        '
        'spcBrowseFile.Panel2
        '
        Me.spcBrowseFile.Panel2.Controls.Add(Me.btnBrowseFile)
        Me.spcBrowseFile.Size = New System.Drawing.Size(328, 30)
        Me.spcBrowseFile.SplitterDistance = 267
        Me.spcBrowseFile.SplitterWidth = 1
        Me.spcBrowseFile.TabIndex = 2
        '
        'txtFileName
        '
        Me.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(0, 0)
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(267, 30)
        Me.txtFileName.TabIndex = 1
        '
        'btnBrowseFile
        '
        Me.btnBrowseFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBrowseFile.Location = New System.Drawing.Point(0, 0)
        Me.btnBrowseFile.Name = "btnBrowseFile"
        Me.btnBrowseFile.Size = New System.Drawing.Size(60, 30)
        Me.btnBrowseFile.TabIndex = 2
        Me.btnBrowseFile.Text = "浏览文件"
        Me.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBrowseFile.UseVisualStyleBackColor = True
        '
        'btnUploadFile
        '
        Me.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUploadFile.Location = New System.Drawing.Point(0, 0)
        Me.btnUploadFile.Name = "btnUploadFile"
        Me.btnUploadFile.Size = New System.Drawing.Size(86, 30)
        Me.btnUploadFile.TabIndex = 0
        Me.btnUploadFile.Text = "上传文件"
        Me.btnUploadFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        '
        'frmAnalysiserSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 550)
        Me.Controls.Add(Me.spcMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnalysiserSetup"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置解析器"
        CType(Me.ChungJeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.spcContentEdit.Panel1.ResumeLayout(False)
        Me.spcContentEdit.Panel1.PerformLayout()
        Me.spcContentEdit.Panel2.ResumeLayout(False)
        CType(Me.spcContentEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcContentEdit.ResumeLayout(False)
        Me.spcFileUpload.Panel1.ResumeLayout(False)
        Me.spcFileUpload.Panel2.ResumeLayout(False)
        CType(Me.spcFileUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcFileUpload.ResumeLayout(False)
        Me.spcBrowseFile.Panel1.ResumeLayout(False)
        Me.spcBrowseFile.Panel1.PerformLayout()
        Me.spcBrowseFile.Panel2.ResumeLayout(False)
        CType(Me.spcBrowseFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcBrowseFile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChungJeeBindingSource As Windows.Forms.BindingSource
    Friend WithEvents spcMain As Windows.Forms.SplitContainer
    Friend WithEvents trvResponseFilter As Windows.Forms.TreeView
    Friend WithEvents spcContentEdit As Windows.Forms.SplitContainer
    Friend WithEvents txtContentEdit As Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents spcFileUpload As Windows.Forms.SplitContainer
    Friend WithEvents btnUploadFile As Windows.Forms.Button
    Friend WithEvents spcBrowseFile As Windows.Forms.SplitContainer
    Friend WithEvents txtFileName As Windows.Forms.TextBox
    Friend WithEvents btnBrowseFile As Windows.Forms.Button
End Class
