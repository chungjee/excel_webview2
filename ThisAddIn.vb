Imports System.Diagnostics
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Tools
Imports Microsoft.Web.WebView2.Core


Public Class ThisAddIn

    Public tpAddinWebviewTaskPanel As CustomTaskPane
    Public tpConstomWebVieTaskPanel As WebviewTaskPaneControl
    Public jsonUrlList As Newtonsoft.Json.Linq.JObject
    Public Sub ThisAddIn_Startup() Handles Me.Startup

        tpConstomWebVieTaskPanel = New WebviewTaskPaneControl()
        tpAddinWebviewTaskPanel = Me.CustomTaskPanes.Add(tpConstomWebVieTaskPanel, My.ChungJee.Default.strTabName)
        initializeAsync()
        jsonUrlList = Newtonsoft.Json.Linq.JObject.Parse(My.ChungJee.Default.jsonUrlList)
    End Sub

    Private Sub ThisAddIn_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
        tpConstomWebVieTaskPanel.Dispose()
        tpAddinWebviewTaskPanel.Dispose()
    End Sub

    Private Sub Application_SheetBeforeDoubleClick(Sh As Object, Target As Range, ByRef Cancel As Boolean) Handles Application.SheetBeforeDoubleClick
        xlApp.DisplayAlerts = False
        If Sh.name = My.ChungJee.Default.con_BASE_DATA Then
            tpAddinWebviewTaskPanel.Visible = True
        End If
        xlApp.DisplayAlerts = True
    End Sub

    Private Async Sub initializeAsync()
        Dim options As New Microsoft.Web.WebView2.Core.CoreWebView2EnvironmentOptions()
        Dim userDataFolder As String = System.IO.Path.GetTempPath() ' 请确保此路径存在并且应用程序有写入权限
        Dim environment As Microsoft.Web.WebView2.Core.CoreWebView2Environment = Await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(Nothing, userDataFolder, options)
        Await tpConstomWebVieTaskPanel.wbvTaskPan.EnsureCoreWebView2Async(environment)
        tpConstomWebVieTaskPanel.wbvTaskPan.ZoomFactor = 0.8
        tpConstomWebVieTaskPanel.wvCoreWevview2 = tpConstomWebVieTaskPanel.wbvTaskPan.CoreWebView2

        Dim wbCurrent As Microsoft.Office.Interop.Excel.Workbook, strUrl As String = ""
        wbCurrent = xlApp.ActiveWorkbook
        If wbCurrent IsNot Nothing Then
            Try
                strUrl = wbCurrent.CustomXMLParts.Item("RequestFilter").XML
            Catch ex As Exception
                Debug.WriteLine("没有找到自定义XML部分。")
            End Try
        End If

        tpConstomWebVieTaskPanel.wvCoreWevview2.AddWebResourceRequestedFilter("*://e.dianping.com/*", CoreWebView2WebResourceContext.All)
        AddHandler tpConstomWebVieTaskPanel.wvCoreWevview2.WebResourceRequested, AddressOf MdlLoad.eventWebResourceRequested
        AddHandler tpConstomWebVieTaskPanel.wvCoreWevview2.DownloadStarting, AddressOf MdlLoad.eventDownloadStarting
        AddHandler tpConstomWebVieTaskPanel.wvCoreWevview2.WebResourceResponseReceived, AddressOf MdlLoad.eventWebResourceResponseReceived

    End Sub '初始化CoreWebview，进行事件绑定

    Private Sub Application_WorkbookActivate(Wb As Workbook) Handles Application.WorkbookActivate
        Debug.WriteLine(My.ChungJee.Default.jsonUrlList)
    End Sub
End Class
