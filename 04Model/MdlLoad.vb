Imports System.Diagnostics
Imports System.IO
Imports System.Security.Policy
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Xml
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json.Linq

Module MdlLoad
    Public xlApp As Excel.Application = Globals.ThisAddIn.Application
    Public strFileFullName As String
    Public Sub eventWebResourceRequested(sender As Object, e As CoreWebView2WebResourceRequestedEventArgs)
        'Debug.WriteLine("eventWebResourceRequested Content: " & e.Request.Uri)
        If InStr(e.Request.Uri, "https://e.dianping.com/couponrecord/consumeItemsNewDownload") Then
            ' xlApp.Run("frmShow")
        End If
    End Sub '网络资源请求事件执行程序
    Public Async Sub eventWebResourceResponseReceived(sender As Object, e As CoreWebView2WebResourceResponseReceivedEventArgs)
        If Globals.ThisAddIn.tpConstomWebVieTaskPanel.MenuItemResponseSwitch.Checked = False Then
            Return
            'Dim strFileName As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ResponseSnap" & Now.ToString("yyyyMMddHHmmss") & ".txt")
            'Using writer As New StreamWriter(strFileName, True)
            'writer.WriteLine(strResponse)
            'End Using
        End If '如果选中响应快照，保存响应数据到临时文件中
        Dim request As CoreWebView2WebResourceRequest = e.Request
        Dim response As CoreWebView2WebResourceResponseView = e.Response
        Dim strRequestUrl As String = request.Uri
        If response.StatusCode <> 200 Then
            Exit Sub
        End If
        Dim content As String
        For Each key As JToken In Globals.ThisAddIn.jsonUrlList.Item("data")
            If InStr(strRequestUrl, key.Item("url").Value(Of String)) Then
                xlApp.Run("frmShow")
                Dim uriRequest As New Uri(request.Uri)
                content = Await getResponseContext(e.Response)
                xlApp.ScreenUpdating = False : xlApp.EnableEvents = False
                If content <> "" Then analysisResponseData(content, uriRequest)
                xlApp.ScreenUpdating = True : xlApp.EnableEvents = True
                xlApp.Run("frmHidden")

                Return
            End If
        Next
        '如果选中响应快照，保存响应数据到临时文件中
        Dim strScript = Globals.ThisAddIn.tpConstomWebVieTaskPanel.tooltxtLable.Text
        If strScript <> "" Then
            Try
                Dim strResult As Object = Await Globals.ThisAddIn.tpConstomWebVieTaskPanel.wvCoreWevview2.ExecuteScriptWithResultAsync(strScript)
                If strResult.ResultAsJson <> "null" Then
                    Globals.ThisAddIn.tpConstomWebVieTaskPanel.lbPage.Text = Replace(strResult.ResultAsJson, """", "")
                Else
                    Globals.ThisAddIn.tpConstomWebVieTaskPanel.lbPage.Text = "......"
                End If
        Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If

    End Sub '网络资源接收事件执行程序
    Public Sub eventDownloadStarting(sender As Object, e As CoreWebView2DownloadStartingEventArgs)
        MdlLoad.strFileFullName = e.ResultFilePath
        'MsgBox(e.ResultFilePath)
        Debug.WriteLine(MdlLoad.strFileFullName)
    End Sub '文件下载事件执行程序

    Private Function analysisResponseData(ByVal strResponse As String, ByVal uriRequest As Uri) As Boolean
        Dim strVBAFunctionName As String = uriRequest.AbsolutePath
        strVBAFunctionName = Regex.Replace(strVBAFunctionName, "[^a-zA-Z0-9]", "")
        'Debug.WriteLine("strVBAFunctionName: " & strVBAFunctionName & "长度：" & strVBAFunctionName.Length)
        'Debug.WriteLine("strResponse: " & strResponse)
        Try
            xlApp.Run(strVBAFunctionName, strResponse)
            Return True
        Catch ex As Exception
            Dim objVBModuleComponent As Microsoft.Vbe.Interop.VBComponent, strVBModuleName As String
            If strVBAFunctionName.Length > 30 Then
                strVBModuleName = strVBAFunctionName.Substring(0, 30)
            Else
                strVBModuleName = strVBAFunctionName
            End If

            Try
                objVBModuleComponent = xlApp.ActiveWorkbook.VBProject.VBComponents.Item(strVBModuleName)
                If objVBModuleComponent.CodeModule.CountOfLines = 0 Then
                    Try
                        objVBModuleComponent.CodeModule.AddFromFile(strVBAFunctionName)
                        xlApp.Run(strVBAFunctionName, strResponse)
                        System.IO.File.Delete(strVBAFunctionName)
                        Return True
                    Catch ex5 As Exception
                        If ex5.Message.Contains("文件未找到") Then
                            Dim strFileUrl As String, strSid As String
                            If My.ChungJee.Default.strNasSid <> "" And My.ChungJee.Default.strNasSid <> "False" Then
                                strFileUrl = My.ChungJee.Default.strNasHostName & "/webapi/entry.cgi?api=SYNO.FileStation.Download&version=2&method=download&path=" & My.ChungJee.Default.con_NAS_HOME_FOLDERNAME & strVBAFunctionName & "&mode=open&_sid=" & My.ChungJee.Default.strNasSid
                                strSid = NasModel.nasDownloadFile(strFileUrl, strVBAFunctionName)
                                If strSid = strVBAFunctionName Then
                                    Try
                                        objVBModuleComponent.CodeModule.AddFromFile(strVBAFunctionName)
                                        xlApp.Run(strVBAFunctionName, strResponse)
                                        System.IO.File.Delete(strVBAFunctionName)
                                        Return True
                                    Catch ex6 As Exception
                                        Debug.WriteLine(ex6.Message)
                                    End Try '下载代码文件成功，重新加载VBA模块代码
                                Else
                                    Debug.WriteLine("文件下载失败，请检查网络连接或文件路径。或者请联系管理员分配权限！")
                                End If '如果代码文件下载成功，重新加载VBA模块代码，否则提示下载失败
                            Else
                                MsgBox("令牌为空，请重新登录网络存储系统！")
                            End If '网络存储系统令牌不为空，重新下载代码文件；如果令牌为空，提示重新登录网络存储系统
                        Else
                            Debug.WriteLine(ex5.Message)
                        End If 'VBA工程中已经存在该模块，该模块中的代码为空，重新加载VBA模块代码，代码文件不存在，下载代码文件
                    End Try 'VBA工程中已经存在该模块，重新加载VBA模块代码
                End If 'VBA工程中已经存在该模块，该模块中的代码为空，重新加载VBA模块代码，如果代码文件不存在，下载代码文件
            Catch ex1 As Exception
                If ex1.Message.Contains("不信任") Then
                    Debug.WriteLine(ex1.Message)
                    Return False
                End If
                If ex1.Message.Contains("下标越界") Then
                    With xlApp.ActiveWorkbook.VBProject.VBComponents.Add(Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_StdModule)
                        Try
                            .Name = strVBModuleName
                            .CodeModule.AddFromFile(strVBAFunctionName)
                            xlApp.Run(strVBAFunctionName, strResponse)
                            System.IO.File.Delete(strVBAFunctionName)
                            Return True
                        Catch ex2 As Exception
                            If ex2.Message.Contains("文件未找到") Then
                                Dim strFileUrl As String, strSid As String
                                If My.ChungJee.Default.strNasSid <> "" And My.ChungJee.Default.strNasSid <> "False" Then
                                    strFileUrl = My.ChungJee.Default.strNasHostName & "/webapi/entry.cgi?api=SYNO.FileStation.Download&version=2&method=download&path=" & My.ChungJee.Default.con_NAS_HOME_FOLDERNAME & strVBAFunctionName & "&mode=open&_sid=" & My.ChungJee.Default.strNasSid
                                    strSid = NasModel.nasDownloadFile(strFileUrl, strVBAFunctionName)
                                    If strSid = strVBAFunctionName Then
                                        Try
                                            .CodeModule.AddFromFile(strVBAFunctionName)
                                            xlApp.Run(strVBAFunctionName, strResponse)
                                            System.IO.File.Delete(strVBAFunctionName)
                                            Return True
                                        Catch ex3 As Exception
                                            Debug.WriteLine(ex3.Message)
                                        End Try '下载代码文件成功，重新加载VBA模块代码，并删除代码文件
                                    Else
                                        Debug.WriteLine("文件下载失败，请检查网络连接或文件路径。或者请联系管理员分配权限！")
                                    End If '代码文件下载成功，重新加载VBA模块代码
                                Else
                                    MsgBox("令牌为空，请重新登录网络存储系统！")
                                End If '网络存储系统令牌不为空，重新下载代码文件；如果令牌为空，提示重新登录网络存储系统
                            Else
                                Debug.WriteLine(ex2.Message)
                            End If ' 'VBA工程中不存在该模块，创建VBA模块，加载VBA模块代码失败,下载代码文件
                        End Try 'VBA工程中不存在该模块，创建VBA模块，加载VBA模块代码，如果代码文件不存在，下载代码文件
                    End With 'VBA工程中不存在该模块，创建VBA模块，加载VBA模块代码，如果代码文件不存在，下载代码文件
                Else
                    Debug.WriteLine(ex1.Message)
                End If 'VBA工程中不存在该模块，创建VBA模块，加载VBA模块代码，如果代码文件不存在，下载代码文件
            End Try
            Return False
        End Try
    End Function '分析响应数据，调用VBA函数处理数据

    Public Async Function getResponseContext(objResponse As Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView) As Threading.Tasks.Task(Of String)
        Dim content As String = ""
        Dim contentStream As Stream = Await objResponse.GetContentAsync()
        Using reader As New StreamReader(contentStream)
            content = Await reader.ReadToEndAsync()
            Return content
        End Using
    End Function '返回字符格式的响应体内容

    Public Sub getXMLData(ByVal XMLStr As String)
        Dim objXmlDoc As New XmlDocument(), strFileName As String = "temp.xls", strRangeAdress As String, strListObjectName As String
        Dim wbDownload As Microsoft.Office.Interop.Excel.Workbook, shDownload As Microsoft.Office.Interop.Excel.Worksheet, shCurrent As Microsoft.Office.Interop.Excel.Worksheet
        objXmlDoc.LoadXml(XMLStr)
        objXmlDoc.Save(strFileName)
        Dim xlappDownload As New Microsoft.Office.Interop.Excel.Application : xlappDownload.Visible = False : xlappDownload.DisplayAlerts = False
        Dim strFieldName As String
        wbDownload = xlappDownload.Workbooks.Open(strFileName) : shDownload = wbDownload.Sheets.Item(1)
        strRangeAdress = shDownload.UsedRange.Offset(1).Address
        strListObjectName = Strings.Left(shDownload.Cells(1, 1).Value, InStr(shDownload.Cells(1, 1).Value, "[") - 1)
        shDownload.ListObjects.AddEx(, shDownload.UsedRange.Offset(1), , 1).Name = strListObjectName
        xlApp.ScreenUpdating = False
        shCurrent = xlApp.ActiveSheet
        shCurrent.Cells.Delete()
        With shCurrent.ListObjects.AddEx(, shCurrent.Range(strRangeAdress), , 1)
            .Name = strListObjectName
            .ListColumns(4).DataBodyRange.NumberFormatLocal = "@"
            .ListColumns(5).DataBodyRange.NumberFormatLocal = "￥#,##0.00;￥-#,##0.00"
            .HeaderRowRange.Value = shDownload.ListObjects(strListObjectName).HeaderRowRange.Value : .DataBodyRange.Value = shDownload.ListObjects(strListObjectName).DataBodyRange.Value
            .DataBodyRange.Font.Size = 9 : .DataBodyRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter

            wbDownload.Close(SaveChanges:=False) : xlappDownload.Quit() '关闭临时文件和应用程序

            .ShowAutoFilter = False : .ListRows(.ListRows.Count).Delete()
            strFieldName = "序号"
            With .ListColumns.Add(1)
                .Name = strFieldName
                .DataBodyRange.Value = "=ROW()-2"
            End With '增加序号列
            strFieldName = .ListColumns(8).Name
            With .ListColumns.Add(2)
                .DataBodyRange.NumberFormatLocal = "yyyy/mm/dd hh:mm"
                .DataBodyRange.Value = shCurrent.ListObjects(strListObjectName).ListColumns(strFieldName).DataBodyRange.Value : shCurrent.ListObjects(strListObjectName).ListColumns(strFieldName).Delete() : .Name = strFieldName
            End With '移动时间列
            strFieldName = .ListColumns(10).Name
            With .ListColumns.Add(3)
                .DataBodyRange.NumberFormatLocal = "@"
                .DataBodyRange.Value = shCurrent.ListObjects(strListObjectName).ListColumns(strFieldName).DataBodyRange.Value
                shCurrent.ListObjects(strListObjectName).ListColumns(strFieldName).Delete() : .Name = strFieldName
            End With '移动门店列

            strFieldName = .ListColumns(4).Name
            Dim objArrayProduct As Object(,) = .ListColumns(strFieldName).DataBodyRange.Value : Dim objProductObjectItem As Object
            Dim objArrayProductPrice As Object(,) = .ListColumns(strFieldName).DataBodyRange.Value
            Dim objArrayShopActivity As Object(,) = .ListColumns("商家优惠金额").DataBodyRange.Value
            Dim i As Integer = 1, strArrayProductInfo As String()
            For Each objProductObjectItem In objArrayProduct
                strArrayProductInfo = ParseServiceString(objProductObjectItem)
                objArrayProduct(i， 1) = strArrayProductInfo(0)
                objArrayProductPrice(i， 1) = CInt(Mid(strArrayProductInfo(1), InStr(strArrayProductInfo(1), "[") + 1, InStr(strArrayProductInfo(1), "]") - 3)) - SumNumbersInString(objArrayShopActivity(i, 1))
                i = i + 1
            Next
            .ListColumns(strFieldName).DataBodyRange.Value = objArrayProduct '分析商品信息的内容，提取商品名称，提取商品价格

            strFieldName = "结算金额"
            With .ListColumns.Add(9)
                .Name = strFieldName : .DataBodyRange.NumberFormatLocal = "0.00" : .DataBodyRange.Value = objArrayProductPrice
                .TotalsCalculation = Microsoft.Office.Interop.Excel.XlTotalsCalculation.xlTotalsCalculationSum : .DataBodyRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight
            End With '增加结算金额列


            .ListColumns("验券帐号").Delete()
            .ListColumns("分店城市").Delete()
            .ListColumns("商品类型").Delete()
            .ListColumns("商家优惠金额").DataBodyRange.EntireColumn.Hidden = True
            .DataBodyRange.EntireColumn.AutoFit()
            .DataBodyRange.EntireRow.AutoFit()
            .ShowTotals = True '整理超级表

            '.Sort.SortFields.Clear()
            .Sort.SortFields.Add(.ListColumns(2).Range, Microsoft.Office.Interop.Excel.XlSortOn.xlSortOnValues, Microsoft.Office.Interop.Excel.XlSortOrder.xlAscending, Microsoft.Office.Interop.Excel.XlSortDataOption.xlSortNormal)

        End With

        Try
            File.Delete(strFileName)
            Debug.WriteLine("文件已成功删除。")
        Catch ex As Exception
            Debug.WriteLine("删除文件时出错: " & ex.Message)
        End Try
        xlApp.ScreenUpdating = True
        xlApp.Run("frmHidden")
    End Sub '处理XML数据，生成Excel表格
    Public Function ParseServiceString(inputString As String) As String()
        Dim pattern As String = "^(.*?)(\[.*?\])(\[.*?\])$"        ' 定义正则表达式模式
        ' 创建正则表达式对象
        Dim regex As New Regex(pattern, RegexOptions.IgnoreCase) : Dim match As Match = regex.Match(inputString.Trim()) : Dim result(2) As String
        If match.Success Then
            result(0) = match.Groups(1).Value.Trim() : result(1) = match.Groups(2).Value : result(2) = match.Groups(3).Value ' 提取ID
        Else
            result(0) = "未知服务" : result(1) = "0.00" : result(2) = "0"
        End If
        Return result
    End Function '处理服务项目字符串，返回数组
    Function SumNumbersInString(input As String) As Double
        ' 使用正则表达式匹配所有数字（包括小数）
        Dim matches As MatchCollection = Regex.Matches(input, "\d+(\.\d+)?")
        Dim sum As Double = 0
        ' 遍历所有匹配项并累加
        For Each match As Match In matches
            sum += Double.Parse(match.Value)
        Next
        Return sum
    End Function '处理商家活动字符串，返回活动金额合计数字

    Public Sub initializeLoadingForm()
        Dim Wb As Microsoft.Office.Interop.Excel.Workbook = xlApp.ActiveWorkbook
        Try
            Wb.CustomXMLParts.Add("RequestFilter", "<RequestFilter><RequestUrl>https://e.dianping.com/couponrecord/consumeItemsNewDownload</RequestUrl></RequestFilter>")
        Catch ex As Exception
            Debug.WriteLine("error:CustomXMLParts>>" & ex.Message)
        End Try
        xlApp.AutomationSecurity = Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityLow
        Dim strFormName As String = "frmLoading"
        Dim objVBFormComponent As Microsoft.Vbe.Interop.VBComponent = Nothing
        Dim objVBModuleComponent As Microsoft.Vbe.Interop.VBComponent = Nothing
        Try
            objVBModuleComponent = xlApp.ActiveWorkbook.VBProject.VBComponents.Item(strFormName)
        Catch ex As Exception
            If ex.Message.Contains("不信任") Then Return
            If ex.Message.Contains("下标越界") Then
                With xlApp.ActiveWorkbook.VBProject.VBComponents.Add(Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_StdModule)
                    .Name = "MdlLoad"
                    .CodeModule.AddFromString("public sub frmShow()" & Chr(13) & "frmLoading.show 0" & Chr(13) & "end sub")
                    .CodeModule.AddFromString("public sub frmHidden" & Chr(13) & "frmLoading.hide" & Chr(13) & "end sub")
                End With
            End If 'VBA工程中没有MdlLoad模块，创建VBA的MdlLoad模块
        End Try '加载或创建VBA的MdlLoad模块

        Try
            objVBFormComponent = xlApp.ActiveWorkbook.VBProject.VBComponents.Item(strFormName)
            If objVBFormComponent.CodeModule.CountOfLines = 0 Then
                Try
                    objVBFormComponent.CodeModule.AddFromFile(strFormName)
                Catch ex2 As Exception
                    If ex2.Message.Contains("文件未找到") Then
                        Dim strUrl As String, strSid As String
                        If My.ChungJee.Default.strNasSid <> "" And My.ChungJee.Default.strNasSid <> "False" Then
                            strUrl = My.ChungJee.Default.strNasHostName & "/webapi/entry.cgi?api=SYNO.FileStation.Download&version=2&method=download&path=" & My.ChungJee.Default.con_NAS_HOME_FOLDERNAME & strFormName & "&mode=open&_sid=" & My.ChungJee.Default.strNasSid
                            strSid = NasModel.nasDownloadFile(strUrl, strFormName)
                            If strSid = strFormName Then
                                objVBFormComponent.CodeModule.AddFromFile(strFormName)
                            Else
                                MsgBox("文件下载失败，请检查网络连接或文件路径。或者请联系管理员分配权限！")
                            End If
                        Else
                            Dim frmLoginForm As New LoginForm
                            frmLoginForm.UsernameTextBox.Text = My.ChungJee.Default.strNasUserName
                            If My.ChungJee.Default.strNasPassWord <> "" Then frmLoginForm.PasswordTextBox.Text = My.ChungJee.Default.strNasPassWord
                            xlApp.Visible = False
                            frmLoginForm.ShowDialog()
                            xlApp.Visible = True
                            If My.ChungJee.Default.strNasSid <> "" And My.ChungJee.Default.strNasSid <> "False" Then
                                strUrl = My.ChungJee.Default.strNasHostName & "/webapi/entry.cgi?api=SYNO.FileStation.Download&version=2&method=download&path=" & My.ChungJee.Default.con_NAS_HOME_FOLDERNAME & strFormName & "&mode=open&_sid=" & My.ChungJee.Default.strNasSid
                                strSid = NasModel.nasDownloadFile(strUrl, strFormName)
                                If strSid = strFormName Then
                                    objVBFormComponent.CodeModule.AddFromFile(strFormName)
                                Else
                                    MsgBox("文件下载失败，请检查网络连接或文件路径。或者请联系管理员分配权限！")
                                End If
                            End If
                        End If
                    Else
                        MsgBox("加载窗体失败，请检查文件路径或联系管理员！")
                    End If
                End Try
            End If 'VBA工程中有frmloading窗体，但窗体代码为空，重新加载窗体代码
        Catch ex As Exception
            If ex.Message.Contains("不信任") Then Return
            If ex.Message.Contains("下标越界") Then
                With xlApp.ActiveWorkbook.VBProject.VBComponents
                    objVBModuleComponent = .Add(Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_MSForm)
                    With objVBModuleComponent
                        .Name = strFormName
                        Try
                            .CodeModule.AddFromFile(strFormName)
                        Catch ex1 As Exception
                            If ex1.Message.Contains("文件未找到") Then
                                Dim strUrl As String, strSid As String
                                If My.ChungJee.Default.strNasSid <> "" And My.ChungJee.Default.strNasSid <> "False" Then
                                    strUrl = My.ChungJee.Default.strNasHostName & "/webapi/entry.cgi?api=SYNO.FileStation.Download&version=2&method=download&path=" & My.ChungJee.Default.con_NAS_HOME_FOLDERNAME & strFormName & "&mode=open&_sid=" & My.ChungJee.Default.strNasSid
                                    strSid = NasModel.nasDownloadFile(strUrl, strFormName)
                                    If strSid = strFormName Then
                                        objVBModuleComponent.CodeModule.AddFromFile(strFormName)
                                    Else
                                        MsgBox("文件下载失败，请检查网络连接或文件路径。或者请联系管理员分配权限！")
                                    End If
                                Else
                                    Dim frmLoginForm As New LoginForm
                                    frmLoginForm.UsernameTextBox.Text = My.ChungJee.Default.strNasUserName
                                    If My.ChungJee.Default.strNasPassWord <> "" Then frmLoginForm.PasswordTextBox.Text = My.ChungJee.Default.strNasPassWord
                                    frmLoginForm.ShowDialog()
                                    If My.ChungJee.Default.strNasSid <> "" And My.ChungJee.Default.strNasSid <> "False" Then
                                        strUrl = My.ChungJee.Default.strNasHostName & "/webapi/entry.cgi?api=SYNO.FileStation.Download&version=2&method=download&path=" & My.ChungJee.Default.con_NAS_HOME_FOLDERNAME & strFormName & "&mode=open&_sid=" & My.ChungJee.Default.strNasSid
                                        strSid = NasModel.nasDownloadFile(strUrl, strFormName)
                                        If strSid = strFormName Then
                                            objVBModuleComponent.CodeModule.AddFromFile(strFormName)
                                        Else
                                            MsgBox("文件下载失败，请检查网络连接或文件路径。或者请联系管理员分配权限！")
                                        End If
                                    End If
                                End If
                            End If
                        End Try
                    End With
                End With
            Else
                MsgBox(ex.Message)
            End If 'VBA工程中没有frmloading窗体，创建VBA的frmLoading窗体
        End Try '加载VBA的frmLoading窗体
    End Sub '初始化VBA模块中的frmLoading窗体

    Public Function jsonResponseUrlListToArrayList(objJToken As JToken) As Dictionary(Of String, System.Collections.Generic.List(Of String))
        Dim arrlsResponseUrlDictionary As New Dictionary(Of String, System.Collections.Generic.List(Of String))
        For Each key As JToken In objJToken
            Dim uriRequest As New Uri(key("url"))
            If arrlsResponseUrlDictionary.ContainsKey(uriRequest.Host) Then
                arrlsResponseUrlDictionary.Item(uriRequest.Host).Add(uriRequest.AbsolutePath)
            Else
                arrlsResponseUrlDictionary.Add(uriRequest.Host, New System.Collections.Generic.List(Of String))
                arrlsResponseUrlDictionary.Item(uriRequest.Host).Add(uriRequest.AbsolutePath)
            End If
        Next key
        Return arrlsResponseUrlDictionary
    End Function

    Private Sub ExecuteScriptExample()
        Try
            ' 确保 WebView2 已初始化
            If Globals.ThisAddIn.tpConstomWebVieTaskPanel.wvCoreWevview2 Is Nothing Then
                Debug.WriteLine("WebView2 is not initialized.")
                Return
            End If

            ' 定义脚本
            Dim script As String = "document.title"

            ' 执行脚本并获取结果
            Dim result As String = Globals.ThisAddIn.tpConstomWebVieTaskPanel.wvCoreWevview2.ExecuteScriptWithResultAsync(script).Result.ResultAsJson
            ' 处理结果
            If Not String.IsNullOrEmpty(result) Then
                Globals.ThisAddIn.tpConstomWebVieTaskPanel.lbPage.Text = result
                Debug.WriteLine("Script execution result: " & result)
            Else
                Debug.WriteLine("Script execution returned an empty result.")
            End If
        Catch ex As Exception
            ' 捕获并记录异常
            Debug.WriteLine("Error executing script: " & ex.Message)
        End Try
    End Sub

End Module
