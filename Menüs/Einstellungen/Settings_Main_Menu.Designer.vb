<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings_Main_Menu
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings_Main_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HauptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HauptToolStripMenuItem, Me.BenutzerToolStripMenuItem, Me.DatenbankToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(98, 450)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HauptToolStripMenuItem
        '
        Me.HauptToolStripMenuItem.Image = Global.Buchhaltung.My.Resources.Resources.home_50x50
        Me.HauptToolStripMenuItem.Name = "HauptToolStripMenuItem"
        Me.HauptToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.HauptToolStripMenuItem.Text = "Allgemein"
        '
        'BenutzerToolStripMenuItem
        '
        Me.BenutzerToolStripMenuItem.Image = Global.Buchhaltung.My.Resources.Resources.user_50x50
        Me.BenutzerToolStripMenuItem.Name = "BenutzerToolStripMenuItem"
        Me.BenutzerToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.BenutzerToolStripMenuItem.Text = "Benutzer"
        '
        'DatenbankToolStripMenuItem
        '
        Me.DatenbankToolStripMenuItem.Image = Global.Buchhaltung.My.Resources.Resources.database_storage_50x50
        Me.DatenbankToolStripMenuItem.Name = "DatenbankToolStripMenuItem"
        Me.DatenbankToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.DatenbankToolStripMenuItem.Text = "Datenbank"
        '
        'Settings_Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings_Main_Menu"
        Me.Text = "Settings_Main_Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HauptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BenutzerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatenbankToolStripMenuItem As ToolStripMenuItem
End Class
