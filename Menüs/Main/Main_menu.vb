Public Class Main_menu
    ' Main Function
    Private Sub Login_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setText()
    End Sub
    ' Function
    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Settings_Main_Menu.Show()
    End Sub
    ' Helper
    Private Sub setText()
        Me.Text = GetLocalizedText("main_menu_title")
        StammdatenToolStripMenuItem.Text = GetLocalizedText("master_data")
        EinstellungenToolStripMenuItem.Text = GetLocalizedText("settings")
        BuchungenToolStripMenuItem.Text = GetLocalizedText("booking")
        Buchhaltungssoftware_Label.Text = GetLocalizedText("accounting_software")
        Letzte_Buchungen_GroupBox.Text = GetLocalizedText("last_booking")
        Finanzübersicht_GroupBox.Text = GetLocalizedText("financial_overview")
    End Sub
    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        If e.Item IsNot Nothing Then
            Dim backgroundBrush As Brush
            If e.Item.Text.Contains("€") Then
                If e.Item.Text.Contains("-") Then
                    backgroundBrush = Brushes.Red
                Else
                    backgroundBrush = Brushes.Green
                End If
            Else
                backgroundBrush = Brushes.Transparent
            End If
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds)
            Dim textBrush As Brush = Brushes.White
            e.Graphics.DrawString(e.Item.Text, e.Item.Font, textBrush, e.Bounds)
        End If
    End Sub
    Private Function GetLocalizedText(key As String) As String
        Return LocalizationManager.ResourceManager.GetString(key)
    End Function

End Class
