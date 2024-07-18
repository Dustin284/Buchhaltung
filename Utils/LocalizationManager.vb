Imports System.Resources

Public Class LocalizationManager
    Private Shared _resourceManager As ResourceManager

    Public Shared ReadOnly Property ResourceManager As ResourceManager
        Get
            If _resourceManager Is Nothing Then
                InitializeResourceManager()
            End If
            Return _resourceManager
        End Get
    End Property

    Private Shared Sub InitializeResourceManager()
        Try
            Dim language As String = If(AppConfigLoader.Config IsNot Nothing AndAlso Not String.IsNullOrEmpty(AppConfigLoader.Config.Language), AppConfigLoader.Config.Language, "en")
            _resourceManager = New ResourceManager($"Buchhaltung.{language}_language", GetType(LocalizationManager).Assembly)
        Catch ex As Exception
            ' Fehlerbehandlung für ResourceManager
            Throw New ApplicationException($"Error initializing the localization: {ex.Message}", ex)
        End Try
    End Sub
End Class
