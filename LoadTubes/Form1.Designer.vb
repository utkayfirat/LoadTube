<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FormLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.questBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.closeBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.downloadFolderLocationLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.mp3CheckBox = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.folderImageBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.mp4CheckBox = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.youtubeLinkTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.labelName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelDuration = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelAuthor = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.videoPictureBox = New System.Windows.Forms.PictureBox()
        Me.downloadBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.questBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.folderImageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.videoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.downloadBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FormLabel)
        Me.Panel1.Controls.Add(Me.questBtn)
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 37)
        Me.Panel1.TabIndex = 0
        '
        'FormLabel
        '
        Me.FormLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormLabel.AutoSize = True
        Me.FormLabel.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold)
        Me.FormLabel.ForeColor = System.Drawing.Color.White
        Me.FormLabel.Location = New System.Drawing.Point(10, 6)
        Me.FormLabel.Name = "FormLabel"
        Me.FormLabel.Size = New System.Drawing.Size(97, 22)
        Me.FormLabel.TabIndex = 1
        Me.FormLabel.Text = "LoadTube"
        '
        'questBtn
        '
        Me.questBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.questBtn.Image = Global.LoadTubes.My.Resources.Resources.quest_icon
        Me.questBtn.ImageActive = Nothing
        Me.questBtn.Location = New System.Drawing.Point(720, 4)
        Me.questBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.questBtn.Name = "questBtn"
        Me.questBtn.Size = New System.Drawing.Size(36, 27)
        Me.questBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.questBtn.TabIndex = 3
        Me.questBtn.TabStop = False
        Me.questBtn.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.Image = Global.LoadTubes.My.Resources.Resources.close_throw_bottom_lr
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(762, 4)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(36, 27)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.Image = Global.LoadTubes.My.Resources.Resources.close_image
        Me.closeBtn.ImageActive = Nothing
        Me.closeBtn.Location = New System.Drawing.Point(804, 4)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(36, 27)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.TabStop = False
        Me.closeBtn.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BackgroundWorker1
        '
        '
        'downloadFolderLocationLabel
        '
        Me.downloadFolderLocationLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.downloadFolderLocationLabel.AutoSize = True
        Me.downloadFolderLocationLabel.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold)
        Me.downloadFolderLocationLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.downloadFolderLocationLabel.Location = New System.Drawing.Point(81, 20)
        Me.downloadFolderLocationLabel.Name = "downloadFolderLocationLabel"
        Me.downloadFolderLocationLabel.Size = New System.Drawing.Size(161, 22)
        Me.downloadFolderLocationLabel.TabIndex = 3
        Me.downloadFolderLocationLabel.Text = "[Folder-Location]"
        '
        'mp3CheckBox
        '
        Me.mp3CheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mp3CheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.mp3CheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.mp3CheckBox.Checked = False
        Me.mp3CheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mp3CheckBox.ForeColor = System.Drawing.Color.White
        Me.mp3CheckBox.Location = New System.Drawing.Point(747, 108)
        Me.mp3CheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mp3CheckBox.Name = "mp3CheckBox"
        Me.mp3CheckBox.Size = New System.Drawing.Size(20, 20)
        Me.mp3CheckBox.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.folderImageBtn)
        Me.Panel2.Controls.Add(Me.downloadFolderLocationLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 428)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 66)
        Me.Panel2.TabIndex = 5
        '
        'folderImageBtn
        '
        Me.folderImageBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.folderImageBtn.Image = Global.LoadTubes.My.Resources.Resources.folder2
        Me.folderImageBtn.ImageActive = Nothing
        Me.folderImageBtn.Location = New System.Drawing.Point(24, 14)
        Me.folderImageBtn.Name = "folderImageBtn"
        Me.folderImageBtn.Size = New System.Drawing.Size(50, 34)
        Me.folderImageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.folderImageBtn.TabIndex = 1
        Me.folderImageBtn.TabStop = False
        Me.folderImageBtn.Zoom = 10
        '
        'mp4CheckBox
        '
        Me.mp4CheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mp4CheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.mp4CheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.mp4CheckBox.Checked = False
        Me.mp4CheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mp4CheckBox.ForeColor = System.Drawing.Color.White
        Me.mp4CheckBox.Location = New System.Drawing.Point(747, 138)
        Me.mp4CheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mp4CheckBox.Name = "mp4CheckBox"
        Me.mp4CheckBox.Size = New System.Drawing.Size(20, 20)
        Me.mp4CheckBox.TabIndex = 6
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(773, 108)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(41, 19)
        Me.BunifuCustomLabel1.TabIndex = 7
        Me.BunifuCustomLabel1.Text = "MP3"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(773, 138)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(41, 19)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "MP4"
        '
        'youtubeLinkTextBox
        '
        Me.youtubeLinkTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.youtubeLinkTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.youtubeLinkTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.youtubeLinkTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.youtubeLinkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.youtubeLinkTextBox.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.youtubeLinkTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.youtubeLinkTextBox.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.youtubeLinkTextBox.HintText = "Youtube Video URL"
        Me.youtubeLinkTextBox.isPassword = False
        Me.youtubeLinkTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.youtubeLinkTextBox.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.youtubeLinkTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.youtubeLinkTextBox.LineThickness = 4
        Me.youtubeLinkTextBox.Location = New System.Drawing.Point(25, 60)
        Me.youtubeLinkTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.youtubeLinkTextBox.MaxLength = 32767
        Me.youtubeLinkTextBox.Name = "youtubeLinkTextBox"
        Me.youtubeLinkTextBox.Size = New System.Drawing.Size(688, 38)
        Me.youtubeLinkTextBox.TabIndex = 11
        Me.youtubeLinkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'labelName
        '
        Me.labelName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelName.AutoSize = True
        Me.labelName.BackColor = System.Drawing.Color.Transparent
        Me.labelName.Font = New System.Drawing.Font("Century Gothic", 17.75!, System.Drawing.FontStyle.Bold)
        Me.labelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelName.Location = New System.Drawing.Point(373, 178)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(0, 28)
        Me.labelName.TabIndex = 12
        '
        'labelDuration
        '
        Me.labelDuration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelDuration.AutoSize = True
        Me.labelDuration.BackColor = System.Drawing.Color.Transparent
        Me.labelDuration.Font = New System.Drawing.Font("Century Gothic", 14.75!, System.Drawing.FontStyle.Bold)
        Me.labelDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelDuration.Location = New System.Drawing.Point(373, 279)
        Me.labelDuration.Name = "labelDuration"
        Me.labelDuration.Size = New System.Drawing.Size(0, 23)
        Me.labelDuration.TabIndex = 13
        '
        'labelAuthor
        '
        Me.labelAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelAuthor.AutoSize = True
        Me.labelAuthor.BackColor = System.Drawing.Color.Transparent
        Me.labelAuthor.Font = New System.Drawing.Font("Century Gothic", 14.75!, System.Drawing.FontStyle.Bold)
        Me.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelAuthor.Location = New System.Drawing.Point(373, 230)
        Me.labelAuthor.Name = "labelAuthor"
        Me.labelAuthor.Size = New System.Drawing.Size(0, 23)
        Me.labelAuthor.TabIndex = 14
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.FormLabel
        Me.BunifuDragControl2.Vertical = True
        '
        'videoPictureBox
        '
        Me.videoPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.videoPictureBox.Image = Global.LoadTubes.My.Resources.Resources.unknowmusic
        Me.videoPictureBox.Location = New System.Drawing.Point(25, 125)
        Me.videoPictureBox.Name = "videoPictureBox"
        Me.videoPictureBox.Size = New System.Drawing.Size(328, 250)
        Me.videoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.videoPictureBox.TabIndex = 10
        Me.videoPictureBox.TabStop = False
        '
        'downloadBtn
        '
        Me.downloadBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.downloadBtn.BackColor = System.Drawing.Color.Transparent
        Me.downloadBtn.Image = Global.LoadTubes.My.Resources.Resources.download_icon212
        Me.downloadBtn.ImageActive = Nothing
        Me.downloadBtn.Location = New System.Drawing.Point(720, 48)
        Me.downloadBtn.Name = "downloadBtn"
        Me.downloadBtn.Size = New System.Drawing.Size(120, 50)
        Me.downloadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.downloadBtn.TabIndex = 2
        Me.downloadBtn.TabStop = False
        Me.downloadBtn.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LoadTubes.My.Resources.Resources.music_notes
        Me.PictureBox1.Location = New System.Drawing.Point(292, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 344)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 494)
        Me.Controls.Add(Me.labelAuthor)
        Me.Controls.Add(Me.labelDuration)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.youtubeLinkTextBox)
        Me.Controls.Add(Me.videoPictureBox)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.mp4CheckBox)
        Me.Controls.Add(Me.mp3CheckBox)
        Me.Controls.Add(Me.downloadBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadTubes made by utkay firat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.questBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.folderImageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.videoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.downloadBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents closeBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents questBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents FormLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents folderImageBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents downloadBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents downloadFolderLocationLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents mp3CheckBox As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mp4CheckBox As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents videoPictureBox As PictureBox
    Friend WithEvents youtubeLinkTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents labelName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelDuration As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelAuthor As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
End Class
