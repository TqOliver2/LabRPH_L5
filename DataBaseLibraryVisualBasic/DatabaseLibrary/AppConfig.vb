Imports Microsoft.Extensions.Configuration



Public Class AppConfig

    Private ReadOnly _configuration As IConfiguration

    Public Sub New()

        _configuration =
            New ConfigurationBuilder().
            SetBasePath(AppContext.BaseDirectory).
            AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True).
            Build()

    End Sub

    Public Function GetConnectionString() As String

        Return _configuration.GetConnectionString("Clinica")

    End Function

End Class
