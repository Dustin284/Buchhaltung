Public Class Settings_Main_Menu
    Private Sub Settings_Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GetLocalizedText("settings_menu_title")

        HauptToolStripMenuItem.Text = GetLocalizedText("general")
        DatenbankToolStripMenuItem.Text = GetLocalizedText("database")
        BenutzerToolStripMenuItem.Text = GetLocalizedText("users")


    End Sub

    Private Function GetLocalizedText(key As String) As String
        Return LocalizationManager.ResourceManager.GetString(key)
    End Function

End Class