Public Class frmSystemSetup
    Private Sub frmSystemSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StrNasHostNameTextBox.Text = My.ChungJee.Default.strNasHostName
        Me.StrNasUserNameTextBox.Text = My.ChungJee.Default.strNasUserName

        Me.Con_BASE_DATATextBox.Text = My.ChungJee.Default.con_BASE_DATA
        Me.Con_COMPANY_INFOTextBox.Text = My.ChungJee.Default.con_COMPANY_INFO
        Me.Con_NAS_HOME_FOLDERNAMETextBox.Text = My.ChungJee.Default.con_NAS_HOME_FOLDERNAME
        Me.Con_START_DATETextBox.Text = My.ChungJee.Default.con_START_DATE
        Me.Con_END_DATETextBox.Text = My.ChungJee.Default.con_END_DATE
        Me.StrNasSidTextBox.Text = My.ChungJee.Default.strNasSid
        Me.JsonUrlListTextBox.Text = My.ChungJee.Default.jsonUrlList
    End Sub

    Private Sub frmSystemSetup_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With My.ChungJee.Default
            .strNasHostName = Me.StrNasHostNameTextBox.Text
            .strNasUserName = Me.StrNasUserNameTextBox.Text
            .con_BASE_DATA = Me.Con_BASE_DATATextBox.Text
            .con_COMPANY_INFO = Me.Con_COMPANY_INFOTextBox.Text
            .con_NAS_HOME_FOLDERNAME = Me.Con_NAS_HOME_FOLDERNAMETextBox.Text
            .con_START_DATE = Me.Con_START_DATETextBox.Text
            .con_END_DATE = Me.Con_END_DATETextBox.Text
            .jsonUrlList = Me.JsonUrlListTextBox.Text
            .Save()
        End With
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.StrNasSidTextBox.Text = ""
        My.ChungJee.Default.strNasSid = ""
        My.ChungJee.Default.Save()
    End Sub
End Class