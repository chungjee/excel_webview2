Imports System.Diagnostics

Public Class LoginForm

    ' TODO: ������룬��ʹ���ṩ���û���������ִ���Զ���������֤
    ' (����� https://go.microsoft.com/fwlink/?LinkId=35339)��  
    ' ����Զ�������ɸ��ӵ���ǰ�̵߳����壬������ʾ: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' ���� CustomPrincipal ������ִ�������֤�� IPrincipal ʵ�֡�
    ' ���My.User ������ CustomPrincipal �����з�װ�ı�ʶ��Ϣ
    ' ���û�������ʾ����

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Me.UsernameTextBox.Text = "" Then
            MsgBox("�������û���")
            Return
        Else
            My.ChungJee.Default.strNasUserName = Me.UsernameTextBox.Text
            If Me.chkRemember.Checked = True Then My.ChungJee.Default.strNasPassWord = Me.PasswordTextBox.Text
            My.ChungJee.Default.Save()
        End If
        Dim strUrl As String = My.ChungJee.Default.strNasHostName & "/webapi/auth.cgi?api=SYNO.API.Auth&version=7&method=login&" &
                        "account=" & My.ChungJee.Default.strNasUserName & "&passwd=" & Me.PasswordTextBox.Text
        Dim strResponseJson As String = NasModel.nasRequestSid(strUrl)
        Dim objResponseJson As Newtonsoft.Json.Linq.JObject
        If strResponseJson.Contains("""success"":false") Then
            MsgBox("�û������������")
            Return
        Else
            objResponseJson = Newtonsoft.Json.Linq.JObject.Parse(strResponseJson)
            Try
                If objResponseJson("data")("account") = My.ChungJee.Default.strNasUserName Then
                    My.ChungJee.Default.strNasSid = objResponseJson("data")("sid")
                    My.ChungJee.Default.Save()
                Else
                    Return
                End If
            Catch ex1 As Exception
                Return
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
