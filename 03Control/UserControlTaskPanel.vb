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

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If Me.txbURL.Text <> "" Then
            Try
                Me.wvCoreWevview2.Navigate(Me.txbURL.Text)
            Catch ex As Exception
                Debug.WriteLine(ex.InnerException.Message)
            End Try
        End If
    End Sub

    Private Sub btnSetupParser_Click(sender As Object, e As EventArgs) Handles btnSetupParser.Click
        Dim frmAnalysis As New frmAnalysiserSetup
        frmAnalysis.Show()
    End Sub

End Class
