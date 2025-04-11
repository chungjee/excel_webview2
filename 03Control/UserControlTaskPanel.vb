Imports System.Diagnostics
Imports System.IO
Imports System.Threading.Tasks
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports System.Web.Script.Serialization
Imports System.Dynamic
Imports System.Windows.Forms
Imports System.Xml
Public Class WebviewTaskPaneControl
    Public WithEvents wvCoreWevview2 As CoreWebView2
    Private Sub MyTaskPaneControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        'InitializeAsync()
        'Dim frmSystemSetup1 As New frmSystemSetup
        'frmSystemSetup1.Show()
        'Debug.WriteLine("ok")
    End Sub

    Private Sub txbURL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbURL.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Me.wvCoreWevview2.Navigate(sender.Text)
            Catch ex As Exception
                Debug.WriteLine(ex.InnerException.Message)
            End Try
        End If

    End Sub



    Private Sub btnNavigate_Click(sender As Object, e As EventArgs) Handles btnNavigate.Click
        If Me.txbURL.Text <> "" Then
            Try
                Me.wvCoreWevview2.Navigate(Me.txbURL.Text)
            Catch ex As Exception
                Debug.WriteLine(ex.InnerException.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItemResponseParser_Click(sender As Object, e As EventArgs) Handles MenuItemResponseParser.Click
        Dim frmAnalysis As New frmAnalysiserSetup
        frmAnalysis.Show()
    End Sub

    Private Sub StripMenuItemSystemSetup_Click(sender As Object, e As EventArgs) Handles StripMenuItemSystemSetup.Click
        Dim frmSystemSetup1 As New frmSystemSetup
        frmSystemSetup1.Show()
    End Sub

    Private Sub MenuItemRequestSwitch_Click(sender As Object, e As EventArgs) Handles MenuItemRequestSwitch.Click
        sender.checked = Not sender.checked
    End Sub

    Private Sub MenuItemResponseSwitch_Click(sender As Object, e As EventArgs) Handles MenuItemResponseSwitch.Click
        sender.checked = Not sender.checked
    End Sub

    Private Sub btnBackward_Click(sender As Object, e As EventArgs) Handles btnBackward.Click
        If Me.tooltxtBackward.Text <> "" Then
            Try
                Me.wvCoreWevview2.ExecuteScriptAsync(Me.tooltxtBackward.Text)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If Me.tooltxtForward.Text <> "" Then
            Try
                Me.wvCoreWevview2.ExecuteScriptWithResultAsync(Me.tooltxtForward.Text)
                'Me.wvCoreWevview2.CallDevToolsProtocolMethodAsync("Network.getAllCookies")
                'Dim script As String = Me.tooltxtForward.Text
                'ExecuteScriptUsingDevTools(script)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Async Sub ExecuteScriptUsingDevTools(script As String)
        Try
            ' 构造参数
            Dim parameters As String = "{""expression"":""" & script.Replace("""", "\""") & """}"

            ' 调用 Runtime.evaluate 方法
            Dim result As String = Await Me.wvCoreWevview2.CallDevToolsProtocolMethodAsync("Runtime.evaluate", parameters)

            ' 输出结果
            Debug.WriteLine("Script Execution Result: " & result)
        Catch ex As Exception
            ' 捕获并处理异常
            Debug.WriteLine("Error executing script: " & ex.Message)
        End Try
    End Sub

    Private Async Sub wvCoreWevview2_FrameNavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles wvCoreWevview2.FrameNavigationCompleted
        Dim strScript = Me.tooltxtLable.Text
        If strScript <> "" Then
            Try
                Dim strResult As Object = Await Me.wvCoreWevview2.ExecuteScriptWithResultAsync(strScript)
                Me.lbPage.Text = strResult.ResultAsJson
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If

    End Sub

    Private Sub wvCoreWevview2_SourceChanged(sender As Object, e As CoreWebView2SourceChangedEventArgs) Handles wvCoreWevview2.SourceChanged
        If e.IsNewDocument = False Then
            Dim wvWebview As Microsoft.Web.WebView2.Core.CoreWebView2 = sender
            wvWebview.AddHostObjectToScript()
        End If
    End Sub

    Private Sub wvCoreWevview2_WebMessageReceived(sender As Object, e As CoreWebView2WebMessageReceivedEventArgs) Handles wvCoreWevview2.WebMessageReceived
        MsgBox(e.WebMessageAsJson)
    End Sub
End Class
