Public Class Main_menu
    Private Sub Login_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GetLocalizedText("main_menu_title")
        StammdatenToolStripMenuItem.Text = GetLocalizedText("master_data")
        EinstellungenToolStripMenuItem.Text = GetLocalizedText("settings")
    End Sub




    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Settings_Main_Menu.Show()
    End Sub

    Private Function GetLocalizedText(key As String) As String
        Return LocalizationManager.ResourceManager.GetString(key)
    End Function
End Class
