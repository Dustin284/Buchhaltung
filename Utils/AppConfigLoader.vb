Imports Newtonsoft.Json
Imports System.IO

Public Class AppConfigLoader
    Private Const CONFIG_FILE_NAME As String = "config.json"
    Private Const APP_DATA_FOLDER As String = "Buchhaltung"
    Private Shared _configFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), APP_DATA_FOLDER, CONFIG_FILE_NAME)
    Private Shared _config As AppConfig

    Public Shared ReadOnly Property Config As AppConfig
        Get
            If _config Is Nothing Then
                LoadConfig()
            End If
            Return _config
        End Get
    End Property

    Public Shared Sub LoadConfig()
        Try
            If File.Exists(_configFilePath) Then
                Dim jsonString As String = File.ReadAllText(_configFilePath)
                _config = JsonConvert.DeserializeObject(Of AppConfig)(jsonString)
            Else
                ' Standard-Konfiguration setzen
                _config = New AppConfig With {
                    .Language = "de",
                    .ConnectionString = "Server=srv-lh-plextex;Database=plextex;Uid=dev_dustin;Pwd=KeiWg2L.;" ' Initialisieren mit leerem String oder einem Standardwert
                }
                SaveConfig()
            End If
        Catch ex As Exception
            ' Fehlerbehandlung für Laden der Konfiguration
            Throw New ApplicationException($"Error loading the configuration file: {ex.Message}", ex)
        End Try
    End Sub

    Public Shared Sub SaveConfig()
        Try
            Dim directoryPath As String = Path.GetDirectoryName(_configFilePath)
            If Not Directory.Exists(directoryPath) Then
                Directory.CreateDirectory(directoryPath)
            End If
            Dim jsonString As String = JsonConvert.SerializeObject(_config)
            File.WriteAllText(_configFilePath, jsonString)
        Catch ex As Exception
            ' Fehlerbehandlung für Speichern der Konfiguration
            Throw New ApplicationException($"Error saving the configuration file: {ex.Message}", ex)
        End Try
    End Sub
End Class
Public Class AppConfig
    Public Property Language As String
    Public Property ConnectionString As String
End Class