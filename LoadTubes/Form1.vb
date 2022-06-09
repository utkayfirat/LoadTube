Imports Salaros.Configuration
Imports System.IO
Imports VideoLibrary

Public Class MainForm



    'Path & Config
    Dim filepath As String = ""
    Private settingsConfig As String = Application.StartupPath + "\settings.dat"

    'Background Worker Control
    Dim BW_Proses As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSettings()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub folderImageBtn_Click(sender As Object, e As EventArgs) Handles downloadFolderLocationLabel.Click, folderImageBtn.Click
        selectFolderMethod()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BW_Proses = True
        Try
            If youtubeLinkTextBox.Text.Trim.Length <= 0 Then
                MessageBox.Show("I can't see the link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Not youtubeLinkTextBox.Text.Contains("youtube.com") Then
                MessageBox.Show("Not contains ""youtube.com""", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If youtubeLinkTextBox.Text <> "" Then
                If Not mp3CheckBox.Checked And Not mp4CheckBox.Checked Then
                    MessageBox.Show("Please choose mp3 or mp4", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                downloadBtn.Image = LoadTubes.My.Resources.sandclock
                mp3CheckBox.Enabled = False
                mp4CheckBox.Enabled = False
                downloadBtn.Enabled = False
                youtubeLinkTextBox.Enabled = False
                folderImageBtn.Enabled = False
                downloadFolderLocationLabel.Enabled = False


                If mp3CheckBox.Checked And mp4CheckBox.Checked Then
                    Dim downloaders As Downloader = New Downloader()
                    downloaders.Downloader(youtubeLinkTextBox.Text)
                    downloaders.VideoDownload(filepath)


                    Dim convert As Convert = New Convert()
                    convert.Mp4ToMp3(filepath, downloaders.VideoName)



                    MessageBox.Show("Download Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                Dim downloader As Downloader = New Downloader()
                downloader.Downloader(youtubeLinkTextBox.Text)
                downloader.VideoDownload(filepath)

                If mp3CheckBox.Checked Then
                    Dim convert As Convert = New Convert()
                    convert.Mp4ToMp3(filepath, downloader.VideoName)
                End If

                If Not mp4CheckBox.Checked Then
                    File.Delete($"{filepath & "\" & downloader.VideoName}")
                End If


                MessageBox.Show("Download Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        BW_Proses = False
        downloadBtn.Image = LoadTubes.My.Resources.download_icon212
        mp3CheckBox.Enabled = True
        mp4CheckBox.Enabled = True
        downloadBtn.Enabled = True
        youtubeLinkTextBox.Enabled = True
        folderImageBtn.Enabled = True
        downloadFolderLocationLabel.Enabled = True
    End Sub

    Private Sub youtubeLinkTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles youtubeLinkTextBox.OnValueChanged
        Try
            If youtubeLinkTextBox.Text = "" Then
                labelName.Text = ""
                labelDuration.Text = ""
                labelAuthor.Text = ""

                videoPictureBox.Image = LoadTubes.My.Resources.unknowmusic
                Return
            End If
            If youtubeLinkTextBox.Text.Contains("youtube.com") Then
                labelName.Text = ""
                labelDuration.Text = ""

                Dim down As Downloader = New Downloader()
                down.Downloader(youtubeLinkTextBox.Text)
                down.GetImage()

                videoPictureBox.Image = down.GetImageBitmap()
                If (down.VideoName.Length >= 20) Then
                    labelName.Text = down.VideoName.Substring(0, 20) & "..."
                Else
                    labelName.Text = down.VideoName
                End If

                labelDuration.Text = "Duration " & (down.VideoSec / 60) & " Min"
                labelAuthor.Text = down.Author

            End If
        Catch ex As Exception
            MessageBox.Show("Not Found Video", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = 1
    End Sub

    Private Sub questBtn_click(sender As Object, e As EventArgs) Handles questBtn.Click
        Dim box = New AboutForm()
        box.Show()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles closeBtn.Click, downloadBtn.Click
        If BW_Proses = False Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub selectFolderMethod()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim cfg = New ConfigParser(settingsConfig)
            filepath = FolderBrowserDialog1.SelectedPath
            downloadFolderLocationLabel.Text = filepath
            cfg.SetValue("USER-SETTINGS", "location", filepath)
            cfg.Save()
        End If
    End Sub

    Private Sub loadSettings()
        Dim cfg = New ConfigParser(settingsConfig)
        Dim locationUS = cfg.GetValue("USER-SETTINGS", "location", "")
        If locationUS <> "" Then
            filepath = locationUS
            downloadFolderLocationLabel.Text = filepath
        End If
    End Sub

End Class
