Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class frmAnalysiserSetup

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.txtFileName.Text = sender.FileName
    End Sub

    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        Me.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub frmAnalysiserSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim objTreeNode As Windows.Forms.TreeNode
        For Each key As String In Globals.ThisAddIn.dicResponseUrlList.Keys
            objTreeNode = Me.trvResponseFilter.Nodes(0).Nodes.Add(key)
            For Each item As String In Globals.ThisAddIn.dicResponseUrlList(key)
                objTreeNode.Nodes.Add(item)
            Next item
        Next key
    End Sub
End Class