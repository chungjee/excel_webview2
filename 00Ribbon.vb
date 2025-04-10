Imports System.Diagnostics
Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon
    Private tpWebView As WebviewTaskPaneControl
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        tpWebView = Globals.ThisAddIn.tpConstomWebVieTaskPanel
    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles btnMeiTuan.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs)
        Try
            xlApp.Application.Run("createTable_DataConsum", xlApp.ActiveSheet)
        Catch ex As Exception
            Debug.Write(ex.Message)
        End Try
    End Sub

    Private Sub Ribbon1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
    End Sub

    Private Sub btnTaskPane_Click(sender As Object, e As RibbonControlEventArgs)
        'If Globals.ThisAddIn.wvWebViewTaskPane IsNot Nothing Then
        '    Globals.ThisAddIn.wvWebViewTaskPane.Visible = Not Globals.ThisAddIn.wvWebViewTaskPane.Visible
        '  End If
        If Globals.ThisAddIn.tpAddinWebviewTaskPanel IsNot Nothing Then
            Globals.ThisAddIn.tpAddinWebviewTaskPanel.Visible = Not Globals.ThisAddIn.tpAddinWebviewTaskPanel.Visible
        End If
    End Sub



    Private Sub btnSystemSetup_Click(sender As Object, e As RibbonControlEventArgs) Handles btnSystemSetup.Click
        Dim frmSystemSetup1 As New frmSystemSetup
        frmSystemSetup1.Show()
    End Sub

    Private Sub btnTaskPanel_Click(sender As Object, e As RibbonControlEventArgs) Handles btnTaskPanel.Click
        If Globals.ThisAddIn.tpAddinWebviewTaskPanel IsNot Nothing Then
            Globals.ThisAddIn.tpAddinWebviewTaskPanel.Visible = True
            MdlLoad.initializeLoadingForm()
            If Globals.ThisAddIn.tpConstomWebVieTaskPanel.wvCoreWevview2.Source = "about:blank" Then Globals.ThisAddIn.tpConstomWebVieTaskPanel.wvCoreWevview2.Navigate(My.ChungJee.Default.strHomePage)
        Else
            MsgBox("任务窗格系统错误！")
        End If
    End Sub
End Class
