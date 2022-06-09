Imports MediaToolkit
Imports MediaToolkit.Model
Public Class Convert
    Public Function Mp4ToMp3(filepath As String, videoFullName As String) As Boolean
        Try
            Dim cfilepath As String = filepath
            cfilepath = filepath & "\" & videoFullName

            videoFullName = videoFullName.Substring(0, videoFullName.Length - 4)
            filepath += ("\" & videoFullName & ".mp3")

            Dim convert = New NReco.VideoConverter.FFMpegConverter()
            convert.ConvertMedia(cfilepath, filepath, "mp3")

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

End Class
