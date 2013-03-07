
Imports System.Net.NetworkInformation

Public Class Form1


    Public WithEvents NotifyIcon1 As New System.Windows.Forms.NotifyIcon
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState() = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Icon = Me.Icon
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        ' Make icon invisible & show form
        NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim laststatup As Long = 0
    Dim laststatdl As Long = 0


    '網路速度
    ' Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    ' Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    ' Dim adapter As NetworkInterface
    ' For Each adapter In adapters
    'If adapter.Name = adaptername Then
    'Dim buffer As Long = adapter.GetIPStatistics.BytesReceived
    '  Label1.Text = "download: " & Math.Round((buffer - laststatdl) / 1024, 2) & "KB/S"
    '  laststatdl = buffer
    '
    ' buffer = adapter.GetIPStatistics.BytesSent
    '  Label2.Text = "upload: " & Math.Round((buffer - laststatup) / 1024, 2) & "KB/S"
    '  laststatup = buffer

    '  End If

    '  Next adapter
    ' End Sub


    Public toclick As Boolean = False
    Dim togetnetflow As Boolean = False
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If toclick = True Then
            WebBrowser1.Document.GetElementById("ipdata").SetAttribute("value", network_address)
            WebBrowser1.Document.All.GetElementsByName("Bbase").Item(0).InvokeMember("click") '按下登入
            toclick = False
            togetnetflow = True
            Exit Sub
        End If
        If togetnetflow = True Then
            Dim a() As String = Split(WebBrowser1.DocumentText.ToString, "__VIEWSTATE"" value=""")
            a = Split(a(1), """")


            Dim b As String = FromBase64(a(0))
            b = Replace(b, " ", "")
            b = Replace(b, ",", "")
            a = Split(b, "<AutoPostBack;MaxLength;Width;Text;ToolTip;Enabled;_!SB;>;l<o<f>;i<14>;1<90pt>;")

            If UBound(a) = 0 Then

                network_up = 0
                network_dl = 0
            Else

                Dim upl(), dll() As String

                upl = Split(a(2), ";")
                dll = Split(a(3), ";")
                network_up = Math.Round(Val(upl(0)) / 1000000, 2)
                network_dl = Math.Round(Val(dll(0)) / 1000000, 2)

            End If
            refresh_ui()
            check_netflow()
            togetnetflow = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        GetNetWorkProperties()
        If network_connected = True Then GetStatistics()
        Timer1.Enabled = False
    End Sub

    Public switcha As Integer = 1
    Dim downloadstatics As Long = 0
    Dim uploadstatics As Long = 0

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If network_connected = False Then Exit Sub
        Select Case switcha

            Case 1
                System.Threading.Thread.Sleep(400)
                Label9.Text = "總流量：" & network_dl + network_up & "MB"
                Label8.Text = "下載：" & network_dl & "MB"
                Label7.Text = "上傳：" & network_up & "MB"
            Case 3



                NetworkInterface.GetIsNetworkAvailable()

                Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
                Dim adapter As NetworkInterface

                For Each adapter In adapters
                    If adapter.OperationalStatus = 1 Then
                        If adapter.Name = network_lanname Then
                            downloadstatics = adapter.GetIPStatistics.BytesReceived
                            uploadstatics = adapter.GetIPStatistics.BytesSent

                        End If
                    End If
                Next



            Case 4, 5, 6, 7, 8, 9, 10



                NetworkInterface.GetIsNetworkAvailable()

                Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
                Dim adapter As NetworkInterface

                For Each adapter In adapters
                    If adapter.OperationalStatus = 1 Then
                        If adapter.Name = network_lanname Then

                            Dim a, b As Double
                            a = Math.Round((adapter.GetIPStatistics.BytesReceived - downloadstatics) / 1000, 1)
                            b = Math.Round((adapter.GetIPStatistics.BytesSent - uploadstatics) / 1000, 1)
                            Label9.Text = "總速度：" & a + b & "KB/s"
                            Label8.Text = "下載：" & a & "KB/s"
                            Label7.Text = "上傳：" & b & "KB/s"

                            downloadstatics = adapter.GetIPStatistics.BytesReceived
                            uploadstatics = adapter.GetIPStatistics.BytesSent

                        End If
                    End If
                Next


        End Select
        If switcha = 10 Then
            switcha = 1
        Else
            switcha += 1
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        refresh_ui()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        GetNetWorkProperties()
        GetStatistics()
    End Sub

    Private Sub CheckNetFlowTimer_Tick(sender As Object, e As EventArgs) Handles CheckNetFlowTimer.Tick
        GetStatistics()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Shell("cmd /c start mailto:mousems.kuo@gmail.com?subject=NTUST宿舍網路流量監控軟體錯誤回報", vbMinimizedNoFocus)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("cmd /c start https://www.facebook.com/pages/Ntust-Netflow-Monitor/115608358601148?fref=ts", vbMinimizedNoFocus)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MsgBox("By 台灣科技大學 四資工一 郭杰穎(MouseMs)" & vbCrLf & "E-mail:mousems.kuo@gmail.com" & vbCrLf & "FB:http://fb.com/mousems" & vbCrLf & "Blog:http://mousems.com" & vbCrLf & vbCrLf & "特別感謝:機械系星山吼兒" & vbCrLf & "PS:於XP系統操作網路卡會有點遲鈍，請耐心等候")
        If MsgBox("是否前往軟體的臉書粉絲頁?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Shell("cmd /c start https://www.facebook.com/pages/Ntust-Netflow-Monitor/115608358601148?fref=ts", vbMinimizedNoFocus)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        network_off()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        network_on()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If My.Computer.FileSystem.FileExists("C:\xampp\htdocs\flowrefresh.html") = True Then
            My.Computer.FileSystem.DeleteFile("C:\xampp\htdocs\flowrefresh.html")
            GetStatistics()



        End If
    End Sub
End Class
