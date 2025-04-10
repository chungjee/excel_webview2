Imports System.Security.Policy
Imports System.IO
Imports System.Diagnostics
Imports Newtonsoft.Json
Imports System.Net
Imports System.Text
Module NasModel
    Public Function nasRequestWebFile(ByVal strUrl As String, ByVal strFileName As String) As Boolean
        Dim objWebClient As New System.Net.WebClient()
        Dim strFileFullName As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), strFileName)
        Try
            Try
                objWebClient.DownloadFile(strUrl, strFileFullName)
                Return True
            Catch ex1 As Exception
                Debug.WriteLine(ex1.Message)
                Return False
            End Try
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function nasRequestSid(ByVal strUrl As String) As String
        Dim objWebClient As New System.Net.WebClient()
        Dim strResponse As String
        Try
            strResponse = objWebClient.DownloadString(strUrl)
            Return strResponse
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function nasDownloadFile(strUrl As String, strFileName As String) As String
        Dim result As String = String.Empty
        Dim objWebClient As New System.Net.WebClient()
        Try
            objWebClient.DownloadFile(strUrl, strFileName)
            'Dim fileContent As String = File.ReadAllText(strFileName, Encoding.UTF8)
            ' 以 ANSI 编码重新写入文件
            'File.WriteAllText(strFileName, fileContent, Encoding.Default)
            result = strFileName
        Catch ex As Exception
            ' 处理异常
            Debug.WriteLine("下载失败: " & ex.Message)
            result = String.Empty
        End Try
        Return result
    End Function
End Module
