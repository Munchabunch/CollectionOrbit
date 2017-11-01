Imports System.IO.File

Module bas_General

    ''' <summary>
    ''' Make a backup copy of a file.
    ''' </summary>
    ''' <param name="str_PathedFileName_Orig"></param>
    ''' <remarks></remarks>
    ''' <credits>Original code by Mike Adams</credits>
    Public Sub BackupFile(ByVal str_PathedFileName_Orig As String)

        '-----------------------------------------------------------------------------------------------------
        '
        ' Exceptions:
        '   If backup file #999 exists, we will not make any more backups.
        '
        ' Notes:
        '   The name of the backup file will be the name of the original file, plus ".bak", plus the backup
        '      number.  For example, the first backup of "Names.txt" will be called "Names.txt.bak.001",
        '      and the second will be called "Names.txt.bak.002".
        '
        '-----------------------------------------------------------------------------------------------------

        Dim str_PathedFileName_Backup As String
        Dim i_BackupNum As Long
        Dim str_BackupNum As String


        '// Find the backup file name:
        i_BackupNum = 999
        str_BackupNum = Format(i_BackupNum, "000")
        str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNum

        '// If "~~~.bak.999" exists, then we will not back up the file.
        If Exists(str_PathedFileName_Backup) Then Exit Sub

        Do Until i_BackupNum = 0 Or Exists(str_PathedFileName_Backup)

            '// Find the next backup file name:
            i_BackupNum = i_BackupNum - 1
            str_BackupNum = Format(i_BackupNum, "000")
            str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNum

        Loop

        '// Find the backup file name:
        i_BackupNum = i_BackupNum + 1
        str_BackupNum = Format(i_BackupNum, "000")
        str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNum

        FileCopy(str_PathedFileName_Orig, str_PathedFileName_Backup)

    End Sub

    Public Function NormalizePath(ByVal str_FilePath As String) As String

        '-----------------------------------------------------------------------------------------------------
        ' Make sure that a string has a trailing backslash.
        '-----------------------------------------------------------------------------------------------------
        '
        ' Returns string:
        '   path to a subdirectory ending with "\"
        '
        ' Required parameters:
        '   str_FilePath
        '     path to a subdirectory
        '
        ' Optional parameters:
        '   none
        '
        ' Notes:
        '
        ' See also:
        '
        ' Credits:
        '
        '-----------------------------------------------------------------------------------------------------


        If (Len(str_FilePath) > 0) Then
            If (str_FilePath.EndsWith("\")) Then
                NormalizePath = str_FilePath
            Else
                NormalizePath = (str_FilePath + "\")
            End If
        End If

    End Function

    ''' <summary>
    ''' Return a file's text contents.
    ''' </summary>
    ''' <param name="str_PathedFileName"></param>
    ''' <returns></returns>
    Public Function GetFileContents(ByVal str_PathedFileName As String) As String

        Dim oStreamReader_01 As New IO.StreamReader(str_PathedFileName)
        Dim str_Text As String = oStreamReader_01.ReadToEnd()

        oStreamReader_01.Close()

        Return str_Text

    End Function

    ''' <summary>
    ''' Write a text string to a file.
    ''' </summary>
    ''' <param name="str_PathedFileName"></param>
    ''' <param name="str_FileText"></param>
    Public Sub SetFileContents(ByVal str_PathedFileName As String, ByVal str_FileText As String)

        Dim oStreamWriter_01 As New IO.StreamWriter(str_PathedFileName, False)

        oStreamWriter_01.Write(str_FileText)
        oStreamWriter_01.Close()

    End Sub

End Module
