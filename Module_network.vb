Imports System.Net.NetworkInformation

Module Module_network
    Public network_alermLimit As Integer = 2700
    Public network_type As Integer = 1 '1=dorm lan 2=dorm router+lan 3=dorm router+wifi 4=ntust wifi
    Public network_lanname, network_address, network_mask, network_gateway As String
    Public network_dl As Double = "0"
    Public network_up As Double = "0"
    Public network_connected As Boolean = False

    Dim has2 As Boolean = False
    Dim has22 As Boolean = False
    Dim has25 As Boolean = False

    Public adaptername As String = ""
    Public adapterflow As Integer = 0

    Public Sub GetNetWorkProperties()
        Form1.Timer1.Enabled = False
        NetworkInterface.GetIsNetworkAvailable()

        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        Dim ipaddress As String = ""
        Dim adapter_properties(15, 2) As String
        Dim i As Long = 0

        For Each adapter In adapters
            If adapter.OperationalStatus = 1 Then
                adapter_properties(i, 0) = adapter.Name
                adapter_properties(i, 1) = adapter.GetIPStatistics.BytesReceived + adapter.GetIPStatistics.BytesSent
                If i = 15 Then Exit For
                i = i + 1
            End If
        Next

        network_address = getmyip()

        If network_address = "error" Then

            network_lanname = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_lanname", "")
            'MsgBox("並非使用台科網路或網路不穩，無法載入流量查詢頁面，請確認有連線至台科網路後再試。")
        End If
        i = 0
        Dim queueue As Long = 0
        For Each adapter In adapters

            If adapter.OperationalStatus = 1 Then
                If adapter.GetIPStatistics.BytesReceived + adapter.GetIPStatistics.BytesSent - adapter_properties(i, 1) > queueue Then
                    network_lanname = adapter_properties(i, 0)
                    queueue = adapter_properties(i, 1)
                End If
                If i = 15 Then Exit For
                i = i + 1
            End If
        Next

        Dim adapterTypeisWIFI As Boolean = False

        For Each adapter In adapters
            If adapter.OperationalStatus = 1 Then

                If adapter.Name = network_lanname Then
                    Dim fIPInterfaceProperties As IPInterfaceProperties = adapter.GetIPProperties()
                    Dim UnicastIPAddressInformation As UnicastIPAddressInformationCollection
                    Dim a As UnicastIPAddressInformation
                    UnicastIPAddressInformation = fIPInterfaceProperties.UnicastAddresses
                    For Each a In UnicastIPAddressInformation
                        If a.Address.IsIPv6LinkLocal = False Then ipaddress = a.Address.ToString()
                        If a.IPv4Mask.IsIPv6LinkLocal = False Then network_mask = a.IPv4Mask.ToString()
                    Next

                    Dim fGatewayIPAddressInformation As GatewayIPAddressInformationCollection
                    Dim b As GatewayIPAddressInformation
                    fGatewayIPAddressInformation = fIPInterfaceProperties.GatewayAddresses
                    For Each b In fGatewayIPAddressInformation
                        If b.Address.IsIPv6LinkLocal = False Then network_gateway = b.Address.ToString()
                    Next
                    If adapter.NetworkInterfaceType = NetworkInterfaceType.Wireless80211 Then
                        adapterTypeisWIFI = True
                    End If

                End If

            End If
        Next adapter

        If ipaddress Like "140.118*" And adapterTypeisWIFI = True Then
            network_type = 4
        ElseIf ipaddress Like "140.118*" And adapterTypeisWIFI = False Then
            network_type = 1

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_lanname", network_lanname)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_address", network_address)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_mask", network_mask)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_gateway", network_gateway)

        ElseIf Not ipaddress Like "140.118*" And adapterTypeisWIFI = True Then
            network_type = 3
        ElseIf Not ipaddress Like "140.118*" And adapterTypeisWIFI = False Then
            network_type = 2
        End If




        refresh_ui()

    End Sub


    Public Sub refresh_ui()
        If Form1.CheckBox1.Checked = True Then
            Form1.Timer2.Enabled = True
            Form1.switcha = 1
        Else
            Form1.Timer2.Enabled = False
        End If

        If network_connected = True Then
            Select Case network_type
                Case 1
                    Form1.Label14.Text = "已連線至台科網路"
                    Form1.Label19.Text = "0MB　  　　　　　　　　　　　　　　　　　　　 　 3GB"
                    network_alermLimit = 2700
                Case 2
                    Form1.Label14.Text = "已連線至台科網路(區網內使用lan)"
                    Form1.Label19.Text = "0MB　  　　　　　　　　　　　　　　　　　　　 　 3GB"
                    network_alermLimit = 2700
                Case 3
                    Form1.Label14.Text = "已連線至台科網路(區網內使用wifi)"
                    Form1.Label19.Text = "0MB　  　　　　　　　　　　　　　　　　　　　 　 3GB"
                    network_alermLimit = 2700
                Case 4
                    Form1.Label14.Text = "已連線至台科網路(無線網路)"
                    Form1.Label19.Text = "0MB　  　　　　　　　　　　　　　　　　　　　 　 1GB"
                    network_alermLimit = 700
            End Select
            Form1.Label14.ForeColor = Color.Blue
            Form1.Label10.Text = "via:" & network_lanname
            Form1.Label20.Text = "IP:" & network_address
            Form1.Label18.Text = "Mask:" & network_mask
            Form1.Label12.Text = "Gateway:" & network_gateway
            network_dl = network_dl + adds
            Form1.Label9.Text = "總流量：" & network_dl + network_up & "MB"
            Form1.Label8.Text = "下載：" & network_dl & "MB"
            Form1.Label7.Text = "上傳：" & network_up & "MB"
            Dim aaa As String = "IP:" & network_address & "<br />總流量：" & network_dl + network_up & "MB" & "<br />下載：" & network_dl & "MB" & "<br />上傳：" & network_up & "MB<br />最後更新:" & Now & "<form action=""flowrefresh_do.php"" method=""get"">  <label><input type=""submit"" name=""submit"" id=""重新整理"" value=""重新整理"" />  </label><input name=""do"" type=""hidden"" id=""do"" value=""yes"" /></form></body></html>"

            My.Computer.FileSystem.WriteAllText("C:\xampp\htdocs\flow.html", aaa, False)


            Form1.ProgressBar1.Maximum = network_alermLimit + 300
            If Int(network_dl + network_up) > network_alermLimit + 300 Then
                Form1.ProgressBar1.Value = network_alermLimit + 300
            Else
                Form1.ProgressBar1.Value = Int(network_dl + network_up)
            End If
            Form1.Button5.Enabled = True
            Form1.Button1.Enabled = False
        Else
            Form1.Label14.Text = "未連線至台科網路"
            Form1.Label14.ForeColor = Color.Red
            Form1.Label10.Text = "via:未連線至網路"
            Form1.Label20.Text = "IP:"
            Form1.Label18.Text = "Mask:"
            Form1.Label12.Text = "Gateway:"
            network_dl = network_dl + adds
            Form1.Label9.Text = "總流量："
            Form1.Label8.Text = "下載："
            Form1.Label7.Text = "上傳："
            Form1.ProgressBar1.Value = 0
            Form1.Button5.Enabled = False
            Form1.Button1.Enabled = True
        End If

    End Sub


    Public Function getmyip()
        Try
            Dim a() As String = Split(GetWebDocument("http://netweb.ntust.edu.tw/dormweb/flowquery.aspx"), "140.118.")

            a = Split(a(2), """")
            network_connected = True
            Return "140.118." & a(0)
        Catch ex As Exception
            network_connected = False
            Return "error"
        End Try


    End Function


    Public Sub network_off()

        Select Case network_type
            Case 1

                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=dhcp")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=dhcp")
                End Select
            Case 2
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=static 192.168.0.1 255.255.255.0 192.168.0.0 1")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=static address=192.168.10.1 mask=255.255.255.0 gateway=192.168.10.0")
                End Select
            Case 3
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=static 192.168.0.1 255.255.255.0 192.168.0.0 1")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=static address=192.168.10.1 mask=255.255.255.0 gateway=192.168.10.0")
                End Select
            Case 4
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=static 192.168.0.1 255.255.255.0 192.168.0.0 1")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=static address=192.168.10.1 mask=255.255.255.0 gateway=192.168.10.0")
                End Select

        End Select









        GetNetWorkProperties()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_cutdate", gettodaydate)

        CutNeting = True

        If Form1.ProgressBar1.Value >= network_alermLimit Then

            If network_type = 4 Then

                Form1.Label14.Text = "流量超過700MB，已切斷網路"
                MsgBox("流量已超過700MB，軟體已幫您斷網，若要恢復請點選軟體下方""恢復網路""，或隔天啟動軟體時自動恢復")

            Else

                Form1.Label14.Text = "流量超過2.7G，已切斷網路"
                MsgBox("流量已超過2.7G，軟體已幫您斷網，若要恢復請點選軟體下方""恢復網路""，或隔天啟動軟體時自動恢復")

            End If

            Form1.WindowState = FormWindowState.Normal
        End If

    End Sub
    Public Sub network_on()



        Select Case network_type
            Case 1
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=static " & network_address & " " & network_mask & " " & network_gateway & " 1")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=static address=" & network_address & " mask=" & network_mask & " gateway=" & network_gateway)
                End Select
            Case 2
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=dhcp")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=dhcp")
                End Select
            Case 3
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=dhcp")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=dhcp")
                End Select
            Case 4
                Select Case GetWinVer()
                    Case "5"
                        Cmd("netsh interface ip set address """ & network_lanname & """ source=dhcp")
                    Case "6"
                        Cmd("netsh interface ipv4 set address """ & network_lanname & """ source=dhcp")
                End Select
        End Select

        GetNetWorkProperties()

    End Sub
    Public adds As Integer = 0

    Public Sub check_netflow()
        If network_connected = False Then Exit Sub

        Form1.NotifyIcon1.Text = Form1.Label9.Text & vbCrLf & "上次更新：" & Now.Month & "/" & Now.Day & " " & GetNowHourMin()
        Form1.Label15.Text = Now.Month & "/" & Now.Day & " " & GetNowHourMin()


        If network_type = 4 Then

            If network_dl + network_up >= 500 And has2 = False Then
                has2 = True
                MsgBox("提醒您，您的流量已經大於500MB，請您隨時注意流量，避免被停權！")
            End If
            If network_dl + network_up >= 600 And has22 = False Then
                has22 = True
                MsgBox("提醒您，您的流量已經大於600MB，請您隨時注意流量，避免被停權！")
            End If


        Else


            If network_dl + network_up >= 2000 And has2 = False Then
                has2 = True
                MsgBox("提醒您，您的流量已經大於2GB，請您隨時注意流量，避免被停權！")
            End If
            If network_dl + network_up >= 2200 And has22 = False Then
                has22 = True
                MsgBox("提醒您，您的流量已經大於2.2GB，請您隨時注意流量，避免被停權！")
            End If
            If network_dl + network_up >= 2500 And has25 = False Then
                has25 = True
                MsgBox("提醒您，您的流量已經大於2.5GB，請您隨時注意流量，避免被停權！")
            End If

        End If

        If Form1.ProgressBar1.Value > network_alermLimit Then
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_cutdatepass", "") <> gettodaydate() Then
                network_off()
            End If
        End If
    End Sub


    Public Sub GetStatistics()
        If network_connected = False And My.Computer.Registry.GetValue("HKEY_CURRENT_USER\MouseMs\NTUST_NM\V2.0", "network_cutdate", "") <> gettodaydate() Then
            network_on()
        End If
        If Now.Minute <= 10 And Now.Hour = 0 Then
            network_dl = 0
            network_up = 0
            refresh_ui()

            Exit Sub
        End If
        If network_connected = True Then
            Form1.Label14.Text = "正在取得流量..."
            Form1.Label14.ForeColor = Color.Red
            Form1.toclick = True
            Form1.WebBrowser1.Navigate("http://netweb.ntust.edu.tw/dormweb/flowquery.aspx")
        End If
        refresh_ui()
        check_netflow()

    End Sub

End Module
