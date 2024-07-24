Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.Configuration
Imports System.Windows.Forms

Public Class SQL_Utils
    ' Get the connection string from the configuration
    Private Function GetConnectionString() As String
        ' Load the connection string from the app.config file
        Return AppConfigLoader.Config.ConnectionString
    End Function

    ' Check if MySQL connection is valid
    Public Function CheckConnection() As Boolean
        Dim connectionString As String = GetConnectionString()

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Return True
            Catch ex As MySqlException
                ' Optional: Log the MySQL exception message
                MessageBox.Show(GetLocalizedText("mysql_error") + " :" + $" {ex.Message}")
                Return False
            Catch ex As Exception
                ' Optional: Log the general exception message
                MessageBox.Show(GetLocalizedText("error") + " :" + $" {ex.Message}")
                Return False
            End Try
        End Using
    End Function

    Private Function GetLocalizedText(key As String) As String
        Return LocalizationManager.ResourceManager.GetString(key)
    End Function
End Class
