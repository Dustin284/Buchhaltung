﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class de_language
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Buchhaltung.de_language", GetType(de_language).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Fehler ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property _error() As String
            Get
                Return ResourceManager.GetString("error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Buchhaltungssoftware ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property accounting_software() As String
            Get
                Return ResourceManager.GetString("accounting_software", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Buchungen ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property booking() As String
            Get
                Return ResourceManager.GetString("booking", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Datenbank ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property database() As String
            Get
                Return ResourceManager.GetString("database", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Finanzübersicht ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property financial_overview() As String
            Get
                Return ResourceManager.GetString("financial_overview", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Allgemein ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property general() As String
            Get
                Return ResourceManager.GetString("general", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Letzte Buchungen ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property last_booking() As String
            Get
                Return ResourceManager.GetString("last_booking", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Buchhaltung • Hauptmenü ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property main_menu_title() As String
            Get
                Return ResourceManager.GetString("main_menu_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Stammdaten ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property master_data() As String
            Get
                Return ResourceManager.GetString("master_data", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die MySQL (Datenbank) Fehler ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property mysql_error() As String
            Get
                Return ResourceManager.GetString("mysql_error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Einstellungen ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property settings() As String
            Get
                Return ResourceManager.GetString("settings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Buchhaltung • Einstellungen ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property settings_menu_title() As String
            Get
                Return ResourceManager.GetString("settings_menu_title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Benutzer ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property users() As String
            Get
                Return ResourceManager.GetString("users", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
