<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuchungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StammdatenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buchhaltungssoftware_Label = New System.Windows.Forms.Label()
        Me.Letzte_Buchungen_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Last_Booking_ListBox = New System.Windows.Forms.ListBox()
        Me.Finanzübersicht_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MenuStrip1.SuspendLayout()
        Me.Letzte_Buchungen_GroupBox.SuspendLayout()
        Me.Finanzübersicht_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuchungenToolStripMenuItem, Me.StammdatenToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(112, 307)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuchungenToolStripMenuItem
        '
        Me.BuchungenToolStripMenuItem.Image = Global.Buchhaltung.My.Resources.Resources.money_50x50
        Me.BuchungenToolStripMenuItem.Name = "BuchungenToolStripMenuItem"
        Me.BuchungenToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.BuchungenToolStripMenuItem.Text = "Buchungen"
        '
        'StammdatenToolStripMenuItem
        '
        Me.StammdatenToolStripMenuItem.Image = Global.Buchhaltung.My.Resources.Resources.big_data_50x50
        Me.StammdatenToolStripMenuItem.Name = "StammdatenToolStripMenuItem"
        Me.StammdatenToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.StammdatenToolStripMenuItem.Text = "Stammdaten"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Image = Global.Buchhaltung.My.Resources.Resources.setting_50x50
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'Buchhaltungssoftware_Label
        '
        Me.Buchhaltungssoftware_Label.AutoSize = True
        Me.Buchhaltungssoftware_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buchhaltungssoftware_Label.Location = New System.Drawing.Point(121, 9)
        Me.Buchhaltungssoftware_Label.Name = "Buchhaltungssoftware_Label"
        Me.Buchhaltungssoftware_Label.Size = New System.Drawing.Size(379, 39)
        Me.Buchhaltungssoftware_Label.TabIndex = 1
        Me.Buchhaltungssoftware_Label.Text = "Buchhaltungssoftware"
        '
        'Letzte_Buchungen_GroupBox
        '
        Me.Letzte_Buchungen_GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.Letzte_Buchungen_GroupBox.Controls.Add(Me.Last_Booking_ListBox)
        Me.Letzte_Buchungen_GroupBox.Location = New System.Drawing.Point(122, 51)
        Me.Letzte_Buchungen_GroupBox.Name = "Letzte_Buchungen_GroupBox"
        Me.Letzte_Buchungen_GroupBox.Size = New System.Drawing.Size(226, 252)
        Me.Letzte_Buchungen_GroupBox.TabIndex = 2
        Me.Letzte_Buchungen_GroupBox.TabStop = False
        Me.Letzte_Buchungen_GroupBox.Text = "Letzte Buchungen"
        '
        'Last_Booking_ListBox
        '
        Me.Last_Booking_ListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Last_Booking_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Last_Booking_ListBox.FormattingEnabled = True
        Me.Last_Booking_ListBox.Location = New System.Drawing.Point(6, 19)
        Me.Last_Booking_ListBox.Name = "Last_Booking_ListBox"
        Me.Last_Booking_ListBox.Size = New System.Drawing.Size(214, 223)
        Me.Last_Booking_ListBox.TabIndex = 0
        '
        'Finanzübersicht_GroupBox
        '
        Me.Finanzübersicht_GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.Finanzübersicht_GroupBox.Controls.Add(Me.ListView1)
        Me.Finanzübersicht_GroupBox.Location = New System.Drawing.Point(354, 51)
        Me.Finanzübersicht_GroupBox.Name = "Finanzübersicht_GroupBox"
        Me.Finanzübersicht_GroupBox.Size = New System.Drawing.Size(156, 252)
        Me.Finanzübersicht_GroupBox.TabIndex = 3
        Me.Finanzübersicht_GroupBox.TabStop = False
        Me.Finanzübersicht_GroupBox.Text = "Finanzübersicht"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OwnerDraw = True
        Me.ListView1.Size = New System.Drawing.Size(144, 223)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 307)
        Me.Controls.Add(Me.Finanzübersicht_GroupBox)
        Me.Controls.Add(Me.Letzte_Buchungen_GroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Buchhaltungssoftware_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_menu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Letzte_Buchungen_GroupBox.ResumeLayout(False)
        Me.Finanzübersicht_GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StammdatenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Buchhaltungssoftware_Label As Label
    Friend WithEvents Letzte_Buchungen_GroupBox As GroupBox
    Friend WithEvents Last_Booking_ListBox As ListBox
    Friend WithEvents BuchungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Finanzübersicht_GroupBox As GroupBox
    Friend WithEvents ListView1 As ListView
End Class
