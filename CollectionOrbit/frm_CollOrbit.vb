Imports System.IO
Imports System.IO.File
Imports System.Drawing.Imaging

Public Class frm_CollOrbit

    Private m_PanStartPoint As New Point

#Region "Event procedures"

    Private Sub frm_CollectionOrbit_Load(sender As Object, e As EventArgs) Handles Me.Load

        m_oDirListBox_01.Path = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "Collecting\"

        '// Set up the picture box properties:
        oSplitContainer_Viewer.Panel1.AutoScroll = True
        'm_qimg_01.SizeMode = PictureBoxSizeMode.AutoSize

        '// Maximize the application.
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub m_oDirListBox_01_Change(sender As Object, e As EventArgs) Handles m_oDirListBox_01.Change

        '// Close the "Info" file.
        oTextBox_Info.Text = ""
        m_text_PathedFileName_Info.Text = ""

        m_oFileListBox_01.Path = m_oDirListBox_01.Path
        m_oFileListBox_01.Refresh()

        Call DisplayInfo()

        '// Unload the picture:
        m_qimg_01.Image = Nothing

    End Sub

    Private Sub m_oFileListBox_01_KeyUp(sender As Object, e As KeyEventArgs) Handles m_oFileListBox_01.KeyUp

        Dim str_Prompt As String
        Dim oMsgBoxStyle_01 As MsgBoxStyle
        Dim oMsgBoxResult_01 As MsgBoxResult
        Dim str_PathedFileName_Old As String
        Dim str_FileName_New As String
        Dim i_SelItemIndex As Int32


        Select Case e.KeyCode

            Case Keys.Delete

                '// Remember which item was selected:
                i_SelItemIndex = m_oFileListBox_01.SelectedIndex

                str_Prompt = "This will delete ''" + m_oFileListBox_01.FileName + "''."
                oMsgBoxStyle_01 = MsgBoxStyle.OkCancel

                '// Display the message.
                oMsgBoxResult_01 = MsgBox(str_Prompt, oMsgBoxStyle_01, My.Application.Info.ProductName)

                If oMsgBoxResult_01 = MsgBoxResult.Ok Then

                    '// Unload the picture:
                    m_qimg_01.Image = Nothing

                    '// Rename the file to "ZZZ_...":
                    str_PathedFileName_Old = NormalizePath(m_oDirListBox_01.Path) + m_oFileListBox_01.FileName
                    str_FileName_New = "ZZZ_" + m_oFileListBox_01.FileName
                    My.Computer.FileSystem.RenameFile(str_PathedFileName_Old, "ZZZ_" + m_oFileListBox_01.FileName)

                    m_oFileListBox_01.Refresh()

                End If

                '// Restore the selection:
                m_oFileListBox_01.SelectedIndex = i_SelItemIndex

            Case Keys.Add

                '// WORKING //

            Case Else

                If Len(m_oFileListBox_01.FileName) > 0 Then
                    DisplayFile()
                End If

        End Select

    End Sub

    Private Sub m_oFileListBox_01_MouseUp(sender As Object, e As MouseEventArgs) Handles m_oFileListBox_01.MouseUp

        If Len(m_oFileListBox_01.FileName) > 0 Then
            DisplayFile()
        End If

    End Sub

    Private Sub m_qimg_01_MouseDown(sender As Object, e As MouseEventArgs) Handles m_qimg_01.MouseDown
        'Capture the initial point 
        m_PanStartPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub m_qimg_01_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles m_qimg_01.MouseMove

        'Verify Left Button is pressed while the mouse is moving
        If e.Button = System.Windows.Forms.MouseButtons.Left Then

            'Here we get the change in coordinates.
            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)

            'Then we set the new autoscroll position.
            'ALWAYS pass positive integers to the panels autoScrollPosition method
            oSplitContainer_Viewer.Panel1.AutoScrollPosition = New Drawing.Point((DeltaX - oSplitContainer_Viewer.Panel1.AutoScrollPosition.X), (DeltaY - oSplitContainer_Viewer.Panel1.AutoScrollPosition.Y))

        End If

    End Sub

    Private Sub m_qimg_01_MouseWheel(sender As Object, e As MouseEventArgs) Handles m_qimg_01.MouseWheel

    End Sub

    Private Sub m_qimg_01_KeyUp(sender As Object, e As KeyEventArgs) Handles m_qimg_01.KeyUp

        Select Case e.KeyCode

            Case Keys.Add
                Beep()

        End Select

    End Sub

    Private Sub m_btn_Search_Click(sender As Object, e As EventArgs) Handles m_btn_Search.Click

        Dim Path_ToSearch As String
        Dim Text_ToSearch As String
        Dim FileName_Searching As String
        Dim FileExt_Searching As String


        Text_ToSearch = m_text_ToSearch.Text.ToLower()
        Path_ToSearch = m_oDirListBox_01.Path

        For Each PathedFileName_Searching As String In IO.Directory.GetFiles(Path_ToSearch, "*" + Text_ToSearch + "*", IO.SearchOption.AllDirectories)

            FileName_Searching = RemoveFileExtension(DirObjName(PathedFileName_Searching))
            FileExt_Searching = IO.Path.GetExtension(PathedFileName_Searching)

            If FileExt_Searching = ".suo" Then

                'Skips to next iteration of Loop, ignoring files with .suo extension 
                Continue For

            Else
                If FileExt_Searching = ".ini" Then

                    'Skips to next iteration of Loop, ignoring files with .ini extension
                    Continue For

                Else

                    MsgBox(PathedFileName_Searching)

                End If
            End If
        Next

    End Sub

    Private Sub m_oToolStripButton_01_Click(sender As Object, e As EventArgs) Handles m_oToolStripButton_01.Click

        Dim FileName_01 As String
        Dim FileExt_01 As String
        Dim str_PathedFileName_Old As String
        Dim str_FileName_New As String


        '// Unload the picture:
        m_qimg_01.Image = Nothing

        For Each Item In m_oFileListBox_01.Items
            FileName_01 = Item.ToString()
            FileExt_01 = FileExtension(FileName_01)
            If (FileExt_01.ToLower = "jpg") Then
                str_PathedFileName_Old = NormalizePath(m_oDirListBox_01.Path) + FileName_01
                str_FileName_New = FileName_01.Substring(0, FileName_01.Length - 3) + "jpeg"
                My.Computer.FileSystem.RenameFile(str_PathedFileName_Old, str_FileName_New)
            End If
        Next Item

        m_oFileListBox_01.Refresh()

    End Sub

    Private Sub m_oToolStripButton_SaveAsJpeg_Click(sender As Object, e As EventArgs) Handles m_oToolStripButton_SaveAsJpeg.Click

        Dim img_01 As Image
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo
        Dim PathedFileName_ToSave As String


        '// Set up the encoder parameters:
        oEncoderParameters_01 = New EncoderParameters(1)
        oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
        oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

        img_01 = m_qimg_01.Image

        PathedFileName_ToSave = NormalizePath(m_oFileListBox_01.Path) + RemoveFileExtension(m_oFileListBox_01.FileName) + ".jpeg"

        '// Save the image to the file:
        img_01.Save(PathedFileName_ToSave, oImageCodecInfo_01, oEncoderParameters_01)

        m_oFileListBox_01.Refresh()

        MsgBox("Saved:" + vbCrLf + PathedFileName_ToSave)

    End Sub

#End Region


#Region "Private methods"

    ''' <summary>
    ''' Display the file in the picture box, if possible.
    ''' </summary>
    Private Sub DisplayFile()

        Dim str_FileName_Selected As String
        Dim str_PathedFileName_Selected As String
        Dim str_FileExtension_Selected As String
        Dim bmp As Bitmap


        '// Unload the picture:
        m_qimg_01.Image = Nothing
        Me.Refresh()

        str_FileName_Selected = m_oFileListBox_01.SelectedItem.ToString
        str_FileExtension_Selected = FileExtension(str_FileName_Selected)
        str_PathedFileName_Selected = NormalizePath(m_oFileListBox_01.Path) + str_FileName_Selected

        Select Case LCase$(str_FileExtension_Selected)

            Case "bmp", "gif", "jpg", "jpeg", "png"

                bmp = New Bitmap(str_PathedFileName_Selected)
                Me.m_qimg_01.Image = bmp
                If (m_oToolStripButton_Fit.Checked) Then
                    Me.m_qimg_01.fittoscreen()
                End If

        End Select

    End Sub

    ''' <summary>
    ''' Display the info.txt file in the text box.
    ''' </summary>
    Private Sub DisplayInfo()

        Dim str_PathedFileName_Info As String

        str_PathedFileName_Info = NormalizePath(m_oFileListBox_01.Path) + "info.txt"

        If Exists(str_PathedFileName_Info) Then

            oTextBox_Info.Visible = True
            oTextBox_Info.Text = GetFileContents(str_PathedFileName_Info)
            m_text_PathedFileName_Info.Text = str_PathedFileName_Info

            cmdbtn_CreateInfoFile.Visible = False

        Else

            oTextBox_Info.Visible = False
            oTextBox_Info.Text = ""
            m_text_PathedFileName_Info.Text = ""

            cmdbtn_CreateInfoFile.Visible = True

        End If

    End Sub

    ''' <summary>
    ''' Save the info.txt file to disk.
    ''' </summary>
    Private Sub SaveInfoFile()

        If (oTextBox_Info.Visible And Len(m_text_PathedFileName_Info.Text) > 0) Then
            Call SetFileContents(m_text_PathedFileName_Info.Text, oTextBox_Info.Text)
        End If

    End Sub

    Private Function GetEncoderInfo(ByVal mimeType As String) As ImageCodecInfo

        Dim j As Integer
        Dim encoders As ImageCodecInfo()

        encoders = ImageCodecInfo.GetImageEncoders()
        For j = 0 To encoders.Length
            If encoders(j).MimeType = mimeType Then
                Return encoders(j)
            End If
        Next j
        Return Nothing

    End Function

#End Region

End Class
