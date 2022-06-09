Imports YoutubeExplode
Imports VideoLibrary
Imports System.Threading.Tasks
Imports System.Windows
Imports System.IO
Imports System.Net

Public Class Downloader

    Public Property VideoName As String
    Public Property VideoSec As String
    Public Property Audio_Bitrate As Integer
    Public Property Resolution As Integer
    Public Property Author As String

    Private ImageBitmap As Bitmap
    Private Url As String

    Public Sub Downloader(VideoUrl As String)
        Url = VideoUrl
        GetInfo()
    End Sub

    Private Sub GetInfo()
        Try
            Dim yt = YouTube.Default
            Dim vid = yt.GetVideo(Url)

            VideoName = vid.FullName
            Resolution = vid.Resolution
            VideoSec = vid.Info.LengthSeconds
            Author = vid.Info.Author


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Public Function VideoDownload(path As String) As Boolean
        Try
            Dim yt = YouTube.Default
            Dim vid = yt.GetVideo(Url)

            File.WriteAllBytes(path + "/" + vid.FullName, vid.GetBytes())
            GC.Collect()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return False
        End Try
    End Function

    Public Function GetImageBitmap() As Bitmap
        Return ImageBitmap
    End Function

    Public Sub GetImage()
        Try
            Dim ImageUrl As String = "https://i3.ytimg.com/vi/" & GetVideoIdentifier(Url) & "/hqdefault.jpg"
            Dim client As WebClient = New WebClient()
            Dim stream As Stream = client.OpenRead(ImageUrl)
            ImageBitmap = New Bitmap(stream)
            stream.Flush()
            stream.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return
        End Try
    End Sub

    Private Function GetVideoIdentifier(url As String) As String
        Dim identifier As String() = url.Split(New String() {"=", "&"}, 0)
        Return identifier(1)
    End Function



End Class
