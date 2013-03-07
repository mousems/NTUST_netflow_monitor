Module Module_func
    Private Declare Function GetVersion Lib "kernel32" () As Long
    Public CutNeting As Boolean = False
    Public Function GetWinVer() As String
        Dim lngVer As Long, lngWinVer As Long
        lngVer = GetVersion()
        lngWinVer = lngVer And &HFFFF&
        ' 取得 Windows 版本
        Return Mid(Format((lngWinVer Mod 256) + ((lngWinVer \ 256) / 100), "Fixed"), 1, 1)
    End Function

    Public Function Cmd(ByVal Command As String) As String
        Dim process As New System.Diagnostics.Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardInput = True
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.StandardInput.WriteLine(Command)
        process.StandardInput.WriteLine("exit")
        Dim Result As String = process.StandardOutput.ReadToEnd()
        process.Close()
        Return Result
    End Function
    Public Function gettodaydate()
        Dim datestring As String
        datestring = Now.Year & "/"
        If Now.Month <= 9 Then
            datestring &= "0"
            datestring &= Now.Month
        Else
            datestring &= Now.Month
        End If

        datestring &= "/"
        If Now.Day <= 9 Then
            datestring &= "0"
            datestring &= Now.Day
        Else
            datestring &= Now.Day
        End If
        Return datestring
    End Function

    Public Function ToBase64(ByVal data1 As String) As String
        Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(data1)
        If data Is Nothing Then Throw New ArgumentNullException("data")
        Return Convert.ToBase64String(data)
    End Function

    Public Function FromBase64(ByVal base64 As String) As String
        If base64 Is Nothing Then Throw New ArgumentNullException("base64")
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(base64))
    End Function
    Public Sub firsttime()

        My.Computer.Registry.CurrentUser.CreateSubKey("MouseMs\NTUST_NM\V2.0") '建立資料區
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "version", "1.0")

    End Sub

    Public Function GetYesterday()



        Dim DTDate As Date = DateTime.Now

        Dim Epoch As Date = "01/01/1970"

        Dim TZone As TimeZone = TimeZone.CurrentTimeZone

        Dim TimeZoneOffset As String = TZone.GetUtcOffset(Now).ToString().Substring(0, 2)

        Dim TZORaw As Integer = Convert.ToInt32(TimeZoneOffset) * 3600


        Dim TZO As Integer



        If TZORaw < 0 Then

            TZO = 0 - TZORaw

        Else

            TZO = TZORaw

        End If


        Dim UnixTime As Integer = DateDiff(DateInterval.Second, Epoch, DTDate) + TZO - 86400


        Dim Today As Date = Epoch.AddSeconds(UnixTime - TZO)

        Return (Format(Today, "yyyy/MM/dd"))

    End Function


    Public Function GetNowHourMin()



        Dim DTDate As Date = DateTime.Now

        Dim Epoch As Date = "01/01/1970"

        Dim TZone As TimeZone = TimeZone.CurrentTimeZone

        Dim TimeZoneOffset As String = TZone.GetUtcOffset(Now).ToString().Substring(0, 2)

        Dim TZORaw As Integer = Convert.ToInt32(TimeZoneOffset) * 3600


        Dim TZO As Integer



        If TZORaw < 0 Then

            TZO = 0 - TZORaw

        Else

            TZO = TZORaw

        End If


        Dim UnixTime As Integer = DateDiff(DateInterval.Second, Epoch, DTDate) + TZO


        Dim Today As Date = Epoch.AddSeconds(UnixTime - TZO)

        Return (Format(Today, "HH:mm"))

    End Function
End Module
