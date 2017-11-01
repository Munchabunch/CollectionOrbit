<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_CollOrbit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CollOrbit))
        Me.oSplitContainer_01 = New System.Windows.Forms.SplitContainer()
        Me.oSplitContainer_Left = New System.Windows.Forms.SplitContainer()
        Me.m_oDirListBox_01 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.btn_Now = New System.Windows.Forms.Button()
        Me.m_oFileListBox_01 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.oSplitContainer_Right = New System.Windows.Forms.SplitContainer()
        Me.cmdbtn_CreateInfoFile = New System.Windows.Forms.Button()
        Me.oTextBox_Info = New System.Windows.Forms.TextBox()
        Me.oSplitContainer_Viewer = New System.Windows.Forms.SplitContainer()
        Me.m_qimg_01 = New Queens_ImageControl.ImageControl()
        Me.oListBox_Properties = New System.Windows.Forms.ListBox()
        Me.m_text_PathedFileName_Info = New System.Windows.Forms.TextBox()
        Me.m_text_ToSearch = New System.Windows.Forms.TextBox()
        Me.m_btn_Search = New System.Windows.Forms.Button()
        Me.m_oToolStrip_01 = New System.Windows.Forms.ToolStrip()
        Me.m_oToolStripButton_01 = New System.Windows.Forms.ToolStripButton()
        Me.m_oToolStripButton_Fit = New System.Windows.Forms.ToolStripButton()
        Me.m_oToolStripButton_SaveAsJpeg = New System.Windows.Forms.ToolStripButton()
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_01.Panel1.SuspendLayout()
        Me.oSplitContainer_01.Panel2.SuspendLayout()
        Me.oSplitContainer_01.SuspendLayout()
        CType(Me.oSplitContainer_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Left.Panel1.SuspendLayout()
        Me.oSplitContainer_Left.Panel2.SuspendLayout()
        Me.oSplitContainer_Left.SuspendLayout()
        CType(Me.oSplitContainer_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Right.Panel1.SuspendLayout()
        Me.oSplitContainer_Right.Panel2.SuspendLayout()
        Me.oSplitContainer_Right.SuspendLayout()
        CType(Me.oSplitContainer_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Viewer.Panel1.SuspendLayout()
        Me.oSplitContainer_Viewer.Panel2.SuspendLayout()
        Me.oSplitContainer_Viewer.SuspendLayout()
        Me.m_oToolStrip_01.SuspendLayout()
        Me.SuspendLayout()
        '
        'oSplitContainer_01
        '
        Me.oSplitContainer_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oSplitContainer_01.Location = New System.Drawing.Point(12, 89)
        Me.oSplitContainer_01.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oSplitContainer_01.Name = "oSplitContainer_01"
        '
        'oSplitContainer_01.Panel1
        '
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.oSplitContainer_Left)
        '
        'oSplitContainer_01.Panel2
        '
        Me.oSplitContainer_01.Panel2.Controls.Add(Me.oSplitContainer_Right)
        Me.oSplitContainer_01.Size = New System.Drawing.Size(919, 450)
        Me.oSplitContainer_01.SplitterDistance = 266
        Me.oSplitContainer_01.TabIndex = 13
        '
        'oSplitContainer_Left
        '
        Me.oSplitContainer_Left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Left.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Left.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oSplitContainer_Left.Name = "oSplitContainer_Left"
        '
        'oSplitContainer_Left.Panel1
        '
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.m_oDirListBox_01)
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.btn_Now)
        '
        'oSplitContainer_Left.Panel2
        '
        Me.oSplitContainer_Left.Panel2.Controls.Add(Me.m_oFileListBox_01)
        Me.oSplitContainer_Left.Size = New System.Drawing.Size(266, 450)
        Me.oSplitContainer_Left.SplitterDistance = 151
        Me.oSplitContainer_Left.TabIndex = 0
        '
        'm_oDirListBox_01
        '
        Me.m_oDirListBox_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_oDirListBox_01.FormattingEnabled = True
        Me.m_oDirListBox_01.IntegralHeight = False
        Me.m_oDirListBox_01.Location = New System.Drawing.Point(0, 0)
        Me.m_oDirListBox_01.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_oDirListBox_01.Name = "m_oDirListBox_01"
        Me.m_oDirListBox_01.ScrollAlwaysVisible = True
        Me.m_oDirListBox_01.Size = New System.Drawing.Size(151, 450)
        Me.m_oDirListBox_01.TabIndex = 8
        '
        'btn_Now
        '
        Me.btn_Now.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Now.Enabled = False
        Me.btn_Now.Location = New System.Drawing.Point(0, 526)
        Me.btn_Now.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Now.Name = "btn_Now"
        Me.btn_Now.Size = New System.Drawing.Size(151, 30)
        Me.btn_Now.TabIndex = 7
        Me.btn_Now.Text = "Now"
        Me.btn_Now.UseVisualStyleBackColor = True
        '
        'm_oFileListBox_01
        '
        Me.m_oFileListBox_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_oFileListBox_01.FormattingEnabled = True
        Me.m_oFileListBox_01.Location = New System.Drawing.Point(0, 0)
        Me.m_oFileListBox_01.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_oFileListBox_01.Name = "m_oFileListBox_01"
        Me.m_oFileListBox_01.Pattern = "*.*"
        Me.m_oFileListBox_01.ScrollAlwaysVisible = True
        Me.m_oFileListBox_01.Size = New System.Drawing.Size(111, 436)
        Me.m_oFileListBox_01.TabIndex = 8
        '
        'oSplitContainer_Right
        '
        Me.oSplitContainer_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Right.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Right.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oSplitContainer_Right.Name = "oSplitContainer_Right"
        '
        'oSplitContainer_Right.Panel1
        '
        Me.oSplitContainer_Right.Panel1.Controls.Add(Me.cmdbtn_CreateInfoFile)
        Me.oSplitContainer_Right.Panel1.Controls.Add(Me.oTextBox_Info)
        '
        'oSplitContainer_Right.Panel2
        '
        Me.oSplitContainer_Right.Panel2.Controls.Add(Me.oSplitContainer_Viewer)
        Me.oSplitContainer_Right.Size = New System.Drawing.Size(649, 450)
        Me.oSplitContainer_Right.SplitterDistance = 280
        Me.oSplitContainer_Right.TabIndex = 0
        '
        'cmdbtn_CreateInfoFile
        '
        Me.cmdbtn_CreateInfoFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_CreateInfoFile.Enabled = False
        Me.cmdbtn_CreateInfoFile.Location = New System.Drawing.Point(0, 0)
        Me.cmdbtn_CreateInfoFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdbtn_CreateInfoFile.Name = "cmdbtn_CreateInfoFile"
        Me.cmdbtn_CreateInfoFile.Size = New System.Drawing.Size(278, 39)
        Me.cmdbtn_CreateInfoFile.TabIndex = 13
        Me.cmdbtn_CreateInfoFile.Text = "Create Info File"
        Me.cmdbtn_CreateInfoFile.UseVisualStyleBackColor = True
        '
        'oTextBox_Info
        '
        Me.oTextBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oTextBox_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oTextBox_Info.Location = New System.Drawing.Point(0, 0)
        Me.oTextBox_Info.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oTextBox_Info.Multiline = True
        Me.oTextBox_Info.Name = "oTextBox_Info"
        Me.oTextBox_Info.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.oTextBox_Info.Size = New System.Drawing.Size(280, 450)
        Me.oTextBox_Info.TabIndex = 8
        Me.oTextBox_Info.WordWrap = False
        '
        'oSplitContainer_Viewer
        '
        Me.oSplitContainer_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Viewer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oSplitContainer_Viewer.Name = "oSplitContainer_Viewer"
        Me.oSplitContainer_Viewer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'oSplitContainer_Viewer.Panel1
        '
        Me.oSplitContainer_Viewer.Panel1.Controls.Add(Me.m_qimg_01)
        '
        'oSplitContainer_Viewer.Panel2
        '
        Me.oSplitContainer_Viewer.Panel2.Controls.Add(Me.oListBox_Properties)
        Me.oSplitContainer_Viewer.Size = New System.Drawing.Size(365, 450)
        Me.oSplitContainer_Viewer.SplitterDistance = 371
        Me.oSplitContainer_Viewer.TabIndex = 11
        '
        'm_qimg_01
        '
        Me.m_qimg_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_qimg_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_qimg_01.Image = Nothing
        Me.m_qimg_01.initialimage = Nothing
        Me.m_qimg_01.Location = New System.Drawing.Point(0, 0)
        Me.m_qimg_01.Margin = New System.Windows.Forms.Padding(5)
        Me.m_qimg_01.Name = "m_qimg_01"
        Me.m_qimg_01.Origin = New System.Drawing.Point(0, 0)
        Me.m_qimg_01.PanButton = System.Windows.Forms.MouseButtons.Left
        Me.m_qimg_01.PanMode = True
        Me.m_qimg_01.ScrollbarsVisible = True
        Me.m_qimg_01.Size = New System.Drawing.Size(365, 368)
        Me.m_qimg_01.StretchImageToFit = False
        Me.m_qimg_01.TabIndex = 48
        Me.m_qimg_01.ZoomFactor = 1.0R
        Me.m_qimg_01.ZoomOnMouseWheel = True
        '
        'oListBox_Properties
        '
        Me.oListBox_Properties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListBox_Properties.FormattingEnabled = True
        Me.oListBox_Properties.ItemHeight = 16
        Me.oListBox_Properties.Location = New System.Drawing.Point(0, 0)
        Me.oListBox_Properties.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oListBox_Properties.Name = "oListBox_Properties"
        Me.oListBox_Properties.Size = New System.Drawing.Size(365, 75)
        Me.oListBox_Properties.TabIndex = 0
        '
        'm_text_PathedFileName_Info
        '
        Me.m_text_PathedFileName_Info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_text_PathedFileName_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_text_PathedFileName_Info.Location = New System.Drawing.Point(12, 31)
        Me.m_text_PathedFileName_Info.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_text_PathedFileName_Info.Name = "m_text_PathedFileName_Info"
        Me.m_text_PathedFileName_Info.ReadOnly = True
        Me.m_text_PathedFileName_Info.Size = New System.Drawing.Size(919, 22)
        Me.m_text_PathedFileName_Info.TabIndex = 47
        '
        'm_text_ToSearch
        '
        Me.m_text_ToSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_text_ToSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_text_ToSearch.Location = New System.Drawing.Point(12, 62)
        Me.m_text_ToSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_text_ToSearch.Name = "m_text_ToSearch"
        Me.m_text_ToSearch.Size = New System.Drawing.Size(839, 22)
        Me.m_text_ToSearch.TabIndex = 48
        '
        'm_btn_Search
        '
        Me.m_btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_btn_Search.Location = New System.Drawing.Point(856, 59)
        Me.m_btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.m_btn_Search.Name = "m_btn_Search"
        Me.m_btn_Search.Size = New System.Drawing.Size(75, 25)
        Me.m_btn_Search.TabIndex = 49
        Me.m_btn_Search.Text = "Search"
        Me.m_btn_Search.UseVisualStyleBackColor = True
        '
        'm_oToolStrip_01
        '
        Me.m_oToolStrip_01.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.m_oToolStrip_01.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_oToolStripButton_01, Me.m_oToolStripButton_Fit, Me.m_oToolStripButton_SaveAsJpeg})
        Me.m_oToolStrip_01.Location = New System.Drawing.Point(0, 0)
        Me.m_oToolStrip_01.Name = "m_oToolStrip_01"
        Me.m_oToolStrip_01.Size = New System.Drawing.Size(943, 27)
        Me.m_oToolStrip_01.TabIndex = 50
        Me.m_oToolStrip_01.Text = "ToolStrip1"
        '
        'm_oToolStripButton_01
        '
        Me.m_oToolStripButton_01.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.m_oToolStripButton_01.Image = CType(resources.GetObject("m_oToolStripButton_01.Image"), System.Drawing.Image)
        Me.m_oToolStripButton_01.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_oToolStripButton_01.Name = "m_oToolStripButton_01"
        Me.m_oToolStripButton_01.Size = New System.Drawing.Size(94, 24)
        Me.m_oToolStripButton_01.Text = "Rename JPG"
        '
        'm_oToolStripButton_Fit
        '
        Me.m_oToolStripButton_Fit.CheckOnClick = True
        Me.m_oToolStripButton_Fit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.m_oToolStripButton_Fit.Image = CType(resources.GetObject("m_oToolStripButton_Fit.Image"), System.Drawing.Image)
        Me.m_oToolStripButton_Fit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_oToolStripButton_Fit.Name = "m_oToolStripButton_Fit"
        Me.m_oToolStripButton_Fit.Size = New System.Drawing.Size(29, 24)
        Me.m_oToolStripButton_Fit.Text = "Fit"
        '
        'm_oToolStripButton_SaveAsJpeg
        '
        Me.m_oToolStripButton_SaveAsJpeg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.m_oToolStripButton_SaveAsJpeg.Image = CType(resources.GetObject("m_oToolStripButton_SaveAsJpeg.Image"), System.Drawing.Image)
        Me.m_oToolStripButton_SaveAsJpeg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_oToolStripButton_SaveAsJpeg.Name = "m_oToolStripButton_SaveAsJpeg"
        Me.m_oToolStripButton_SaveAsJpeg.Size = New System.Drawing.Size(97, 24)
        Me.m_oToolStripButton_SaveAsJpeg.Text = "Save as JPEG"
        '
        'frm_CollOrbit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 551)
        Me.Controls.Add(Me.m_oToolStrip_01)
        Me.Controls.Add(Me.m_btn_Search)
        Me.Controls.Add(Me.m_text_ToSearch)
        Me.Controls.Add(Me.m_text_PathedFileName_Info)
        Me.Controls.Add(Me.oSplitContainer_01)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_CollOrbit"
        Me.Text = "Collection Orbit"
        Me.oSplitContainer_01.Panel1.ResumeLayout(False)
        Me.oSplitContainer_01.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_01.ResumeLayout(False)
        Me.oSplitContainer_Left.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Left.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Left.ResumeLayout(False)
        Me.oSplitContainer_Right.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Right.Panel1.PerformLayout()
        Me.oSplitContainer_Right.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Right.ResumeLayout(False)
        Me.oSplitContainer_Viewer.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Viewer.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Viewer.ResumeLayout(False)
        Me.m_oToolStrip_01.ResumeLayout(False)
        Me.m_oToolStrip_01.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oSplitContainer_01 As SplitContainer
    Friend WithEvents oSplitContainer_Left As SplitContainer
    Friend WithEvents oSplitContainer_Right As SplitContainer
    Friend WithEvents cmdbtn_CreateInfoFile As Button
    Friend WithEvents oTextBox_Info As TextBox
    Friend WithEvents oSplitContainer_Viewer As SplitContainer
    Friend WithEvents btn_Now As Button
    Friend WithEvents m_oDirListBox_01 As Compatibility.VB6.DirListBox
    Friend WithEvents m_oFileListBox_01 As Compatibility.VB6.FileListBox
    Friend WithEvents m_text_PathedFileName_Info As TextBox
    Friend WithEvents oListBox_Properties As ListBox
    Friend WithEvents m_qimg_01 As Queens_ImageControl.ImageControl
    Friend WithEvents m_text_ToSearch As TextBox
    Friend WithEvents m_btn_Search As Button
    Friend WithEvents m_oToolStrip_01 As ToolStrip
    Friend WithEvents m_oToolStripButton_01 As ToolStripButton
    Friend WithEvents m_oToolStripButton_Fit As ToolStripButton
    Friend WithEvents m_oToolStripButton_SaveAsJpeg As ToolStripButton
End Class
