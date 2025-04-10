<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSystemSetup
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Con_BASE_DATALabel As System.Windows.Forms.Label
        Dim Con_COMPANY_INFOLabel As System.Windows.Forms.Label
        Dim Con_END_DATELabel As System.Windows.Forms.Label
        Dim Con_NAS_HOME_FOLDERNAMELabel As System.Windows.Forms.Label
        Dim Con_START_DATELabel As System.Windows.Forms.Label
        Dim StrNasHostNameLabel As System.Windows.Forms.Label
        Dim StrNasUserNameLabel As System.Windows.Forms.Label
        Dim StrNasSidLabel As System.Windows.Forms.Label
        Dim JsonUrlListLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemSetup))
        Me.Con_BASE_DATATextBox = New System.Windows.Forms.TextBox()
        Me.ChungJeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Con_COMPANY_INFOTextBox = New System.Windows.Forms.TextBox()
        Me.Con_END_DATETextBox = New System.Windows.Forms.TextBox()
        Me.Con_NAS_HOME_FOLDERNAMETextBox = New System.Windows.Forms.TextBox()
        Me.Con_START_DATETextBox = New System.Windows.Forms.TextBox()
        Me.StrNasHostNameTextBox = New System.Windows.Forms.TextBox()
        Me.StrNasUserNameTextBox = New System.Windows.Forms.TextBox()
        Me.StrNasSidTextBox = New System.Windows.Forms.TextBox()
        Me.JsonUrlListTextBox = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Con_BASE_DATALabel = New System.Windows.Forms.Label()
        Con_COMPANY_INFOLabel = New System.Windows.Forms.Label()
        Con_END_DATELabel = New System.Windows.Forms.Label()
        Con_NAS_HOME_FOLDERNAMELabel = New System.Windows.Forms.Label()
        Con_START_DATELabel = New System.Windows.Forms.Label()
        StrNasHostNameLabel = New System.Windows.Forms.Label()
        StrNasUserNameLabel = New System.Windows.Forms.Label()
        StrNasSidLabel = New System.Windows.Forms.Label()
        JsonUrlListLabel = New System.Windows.Forms.Label()
        CType(Me.ChungJeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Con_BASE_DATALabel
        '
        Con_BASE_DATALabel.AutoSize = True
        Con_BASE_DATALabel.Location = New System.Drawing.Point(58, 30)
        Con_BASE_DATALabel.Name = "Con_BASE_DATALabel"
        Con_BASE_DATALabel.Size = New System.Drawing.Size(120, 15)
        Con_BASE_DATALabel.TabIndex = 0
        Con_BASE_DATALabel.Text = "基础数据表名称:"
        '
        'Con_COMPANY_INFOLabel
        '
        Con_COMPANY_INFOLabel.AutoSize = True
        Con_COMPANY_INFOLabel.Location = New System.Drawing.Point(58, 69)
        Con_COMPANY_INFOLabel.Name = "Con_COMPANY_INFOLabel"
        Con_COMPANY_INFOLabel.Size = New System.Drawing.Size(120, 15)
        Con_COMPANY_INFOLabel.TabIndex = 2
        Con_COMPANY_INFOLabel.Text = "单位信息表名称:"
        '
        'Con_END_DATELabel
        '
        Con_END_DATELabel.AutoSize = True
        Con_END_DATELabel.Location = New System.Drawing.Point(73, 108)
        Con_END_DATELabel.Name = "Con_END_DATELabel"
        Con_END_DATELabel.Size = New System.Drawing.Size(105, 15)
        Con_END_DATELabel.TabIndex = 4
        Con_END_DATELabel.Text = "结束日期标识:"
        '
        'Con_NAS_HOME_FOLDERNAMELabel
        '
        Con_NAS_HOME_FOLDERNAMELabel.AutoSize = True
        Con_NAS_HOME_FOLDERNAMELabel.Location = New System.Drawing.Point(28, 264)
        Con_NAS_HOME_FOLDERNAMELabel.Name = "Con_NAS_HOME_FOLDERNAMELabel"
        Con_NAS_HOME_FOLDERNAMELabel.Size = New System.Drawing.Size(150, 15)
        Con_NAS_HOME_FOLDERNAMELabel.TabIndex = 6
        Con_NAS_HOME_FOLDERNAMELabel.Text = "网络存储用户文件夹:"
        '
        'Con_START_DATELabel
        '
        Con_START_DATELabel.AutoSize = True
        Con_START_DATELabel.Location = New System.Drawing.Point(73, 147)
        Con_START_DATELabel.Name = "Con_START_DATELabel"
        Con_START_DATELabel.Size = New System.Drawing.Size(105, 15)
        Con_START_DATELabel.TabIndex = 8
        Con_START_DATELabel.Text = "开始日期标识:"
        '
        'StrNasHostNameLabel
        '
        StrNasHostNameLabel.AutoSize = True
        StrNasHostNameLabel.Location = New System.Drawing.Point(43, 186)
        StrNasHostNameLabel.Name = "StrNasHostNameLabel"
        StrNasHostNameLabel.Size = New System.Drawing.Size(135, 15)
        StrNasHostNameLabel.TabIndex = 10
        StrNasHostNameLabel.Text = "网络存储主机地址:"
        '
        'StrNasUserNameLabel
        '
        StrNasUserNameLabel.AutoSize = True
        StrNasUserNameLabel.Location = New System.Drawing.Point(58, 225)
        StrNasUserNameLabel.Name = "StrNasUserNameLabel"
        StrNasUserNameLabel.Size = New System.Drawing.Size(120, 15)
        StrNasUserNameLabel.TabIndex = 12
        StrNasUserNameLabel.Text = "网络存储用户名:"
        '
        'Con_BASE_DATATextBox
        '
        Me.Con_BASE_DATATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "con_BASE_DATA", True))
        Me.Con_BASE_DATATextBox.Location = New System.Drawing.Point(184, 24)
        Me.Con_BASE_DATATextBox.Name = "Con_BASE_DATATextBox"
        Me.Con_BASE_DATATextBox.Size = New System.Drawing.Size(200, 25)
        Me.Con_BASE_DATATextBox.TabIndex = 1
        '
        'ChungJeeBindingSource
        '
        Me.ChungJeeBindingSource.DataSource = GetType(VSTO_Excel_WebView2.My.ChungJee)
        '
        'Con_COMPANY_INFOTextBox
        '
        Me.Con_COMPANY_INFOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "con_COMPANY_INFO", True))
        Me.Con_COMPANY_INFOTextBox.Location = New System.Drawing.Point(184, 63)
        Me.Con_COMPANY_INFOTextBox.Name = "Con_COMPANY_INFOTextBox"
        Me.Con_COMPANY_INFOTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Con_COMPANY_INFOTextBox.TabIndex = 3
        '
        'Con_END_DATETextBox
        '
        Me.Con_END_DATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "con_END_DATE", True))
        Me.Con_END_DATETextBox.Location = New System.Drawing.Point(184, 141)
        Me.Con_END_DATETextBox.Name = "Con_END_DATETextBox"
        Me.Con_END_DATETextBox.Size = New System.Drawing.Size(200, 25)
        Me.Con_END_DATETextBox.TabIndex = 5
        '
        'Con_NAS_HOME_FOLDERNAMETextBox
        '
        Me.Con_NAS_HOME_FOLDERNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "con_NAS_HOME_FOLDERNAME", True))
        Me.Con_NAS_HOME_FOLDERNAMETextBox.Location = New System.Drawing.Point(184, 258)
        Me.Con_NAS_HOME_FOLDERNAMETextBox.Name = "Con_NAS_HOME_FOLDERNAMETextBox"
        Me.Con_NAS_HOME_FOLDERNAMETextBox.Size = New System.Drawing.Size(200, 25)
        Me.Con_NAS_HOME_FOLDERNAMETextBox.TabIndex = 7
        '
        'Con_START_DATETextBox
        '
        Me.Con_START_DATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "con_START_DATE", True))
        Me.Con_START_DATETextBox.Location = New System.Drawing.Point(184, 102)
        Me.Con_START_DATETextBox.Name = "Con_START_DATETextBox"
        Me.Con_START_DATETextBox.Size = New System.Drawing.Size(200, 25)
        Me.Con_START_DATETextBox.TabIndex = 9
        '
        'StrNasHostNameTextBox
        '
        Me.StrNasHostNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "strNasHostName", True))
        Me.StrNasHostNameTextBox.Location = New System.Drawing.Point(184, 180)
        Me.StrNasHostNameTextBox.Name = "StrNasHostNameTextBox"
        Me.StrNasHostNameTextBox.Size = New System.Drawing.Size(200, 25)
        Me.StrNasHostNameTextBox.TabIndex = 11
        '
        'StrNasUserNameTextBox
        '
        Me.StrNasUserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "strNasUserName", True))
        Me.StrNasUserNameTextBox.Location = New System.Drawing.Point(184, 219)
        Me.StrNasUserNameTextBox.Name = "StrNasUserNameTextBox"
        Me.StrNasUserNameTextBox.Size = New System.Drawing.Size(200, 25)
        Me.StrNasUserNameTextBox.TabIndex = 13
        '
        'StrNasSidLabel
        '
        StrNasSidLabel.AutoSize = True
        StrNasSidLabel.Location = New System.Drawing.Point(43, 303)
        StrNasSidLabel.Name = "StrNasSidLabel"
        StrNasSidLabel.Size = New System.Drawing.Size(135, 15)
        StrNasSidLabel.TabIndex = 14
        StrNasSidLabel.Text = "网络存储用户令牌:"
        '
        'StrNasSidTextBox
        '
        Me.StrNasSidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "strNasSid", True))
        Me.StrNasSidTextBox.Enabled = False
        Me.StrNasSidTextBox.Location = New System.Drawing.Point(184, 297)
        Me.StrNasSidTextBox.Name = "StrNasSidTextBox"
        Me.StrNasSidTextBox.Size = New System.Drawing.Size(126, 25)
        Me.StrNasSidTextBox.TabIndex = 15
        '
        'JsonUrlListLabel
        '
        JsonUrlListLabel.AutoSize = True
        JsonUrlListLabel.Location = New System.Drawing.Point(405, 27)
        JsonUrlListLabel.Name = "JsonUrlListLabel"
        JsonUrlListLabel.Size = New System.Drawing.Size(150, 15)
        JsonUrlListLabel.TabIndex = 16
        JsonUrlListLabel.Text = "网络响应接受过滤器:"
        '
        'JsonUrlListTextBox
        '
        Me.JsonUrlListTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChungJeeBindingSource, "jsonUrlList", True))
        Me.JsonUrlListTextBox.Location = New System.Drawing.Point(408, 45)
        Me.JsonUrlListTextBox.Multiline = True
        Me.JsonUrlListTextBox.Name = "JsonUrlListTextBox"
        Me.JsonUrlListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JsonUrlListTextBox.Size = New System.Drawing.Size(293, 277)
        Me.JsonUrlListTextBox.TabIndex = 17
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.btnClear.Location = New System.Drawing.Point(316, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "清空"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSystemSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 333)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(JsonUrlListLabel)
        Me.Controls.Add(Me.JsonUrlListTextBox)
        Me.Controls.Add(StrNasSidLabel)
        Me.Controls.Add(Me.StrNasSidTextBox)
        Me.Controls.Add(StrNasUserNameLabel)
        Me.Controls.Add(Me.StrNasUserNameTextBox)
        Me.Controls.Add(StrNasHostNameLabel)
        Me.Controls.Add(Me.StrNasHostNameTextBox)
        Me.Controls.Add(Con_START_DATELabel)
        Me.Controls.Add(Me.Con_START_DATETextBox)
        Me.Controls.Add(Con_NAS_HOME_FOLDERNAMELabel)
        Me.Controls.Add(Me.Con_NAS_HOME_FOLDERNAMETextBox)
        Me.Controls.Add(Con_END_DATELabel)
        Me.Controls.Add(Me.Con_END_DATETextBox)
        Me.Controls.Add(Con_COMPANY_INFOLabel)
        Me.Controls.Add(Me.Con_COMPANY_INFOTextBox)
        Me.Controls.Add(Con_BASE_DATALabel)
        Me.Controls.Add(Me.Con_BASE_DATATextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSystemSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统设置"
        CType(Me.ChungJeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Con_BASE_DATATextBox As Windows.Forms.TextBox
    Friend WithEvents Con_COMPANY_INFOTextBox As Windows.Forms.TextBox
    Friend WithEvents Con_END_DATETextBox As Windows.Forms.TextBox
    Friend WithEvents Con_NAS_HOME_FOLDERNAMETextBox As Windows.Forms.TextBox
    Friend WithEvents Con_START_DATETextBox As Windows.Forms.TextBox
    Friend WithEvents StrNasHostNameTextBox As Windows.Forms.TextBox
    Friend WithEvents StrNasUserNameTextBox As Windows.Forms.TextBox
    Public WithEvents ChungJeeBindingSource As Windows.Forms.BindingSource
    Friend WithEvents StrNasSidTextBox As Windows.Forms.TextBox
    Friend WithEvents JsonUrlListTextBox As Windows.Forms.TextBox
    Friend WithEvents btnClear As Windows.Forms.Button
End Class
