Imports System.Net '放在最前面
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System
Imports System.Net.Security


Module webdocument_part

    Public Function RemoteCertificateValidationCallback(ByVal sender As Object, ByVal certificate As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

    '取得原始碼的code
    Public Function GetWebDocument(ByVal url As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Randomize()
        Dim a As Integer = Int(Rnd() * 21)
        Select Case a
            Case 1
                Return GetWebDocument_1(url, method, POSTdata)
            Case 2
                Return GetWebDocument_2(url, method, POSTdata)
            Case 3
                Return GetWebDocument_3(url, method, POSTdata)
            Case 4
                Return GetWebDocument_4(url, method, POSTdata)
            Case 5
                Return GetWebDocument_5(url, method, POSTdata)
            Case 6
                Return GetWebDocument_6(url, method, POSTdata)
            Case 7
                Return GetWebDocument_7(url, method, POSTdata)
            Case 8
                Return GetWebDocument_8(url, method, POSTdata)
            Case 9
                Return GetWebDocument_9(url, method, POSTdata)
            Case 10
                Return GetWebDocument_10(url, method, POSTdata)
            Case 11
                Return GetWebDocument_11(url, method, POSTdata)
            Case 12
                Return GetWebDocument_12(url, method, POSTdata)
            Case 13
                Return GetWebDocument_13(url, method, POSTdata)
            Case 14
                Return GetWebDocument_14(url, method, POSTdata)
            Case 15
                Return GetWebDocument_15(url, method, POSTdata)
            Case 16
                Return GetWebDocument_16(url, method, POSTdata)
            Case 17
                Return GetWebDocument_17(url, method, POSTdata)
            Case 18
                Return GetWebDocument_18(url, method, POSTdata)
            Case 19
                Return GetWebDocument_19(url, method, POSTdata)
            Case 20
                Return GetWebDocument_20(url, method, POSTdata)
            Case 21
                Return GetWebDocument_21(url, method, POSTdata)
            Case 22
                Return GetWebDocument_22(url, method, POSTdata)
            Case 23
                Return GetWebDocument_23(url, method, POSTdata)
            Case 24
                Return GetWebDocument_24(url, method, POSTdata)
            Case 25
                Return GetWebDocument_25(url, method, POSTdata)
            Case 26
                Return GetWebDocument_26(url, method, POSTdata)
            Case 27
                Return GetWebDocument_27(url, method, POSTdata)
            Case 28
                Return GetWebDocument_28(url, method, POSTdata)
            Case 29
                Return GetWebDocument_29(url, method, POSTdata)
            Case 30
                Return GetWebDocument_30(url, method, POSTdata)
            Case 31
                Return GetWebDocument_31(url, method, POSTdata)
            Case 32
                Return GetWebDocument_32(url, method, POSTdata)
            Case 33
                Return GetWebDocument_33(url, method, POSTdata)
            Case 34
                Return GetWebDocument_34(url, method, POSTdata)
            Case 35
                Return GetWebDocument_35(url, method, POSTdata)
            Case 36
                Return GetWebDocument_36(url, method, POSTdata)
            Case 37
                Return GetWebDocument_37(url, method, POSTdata)
            Case 38
                Return GetWebDocument_38(url, method, POSTdata)
            Case 39
                Return GetWebDocument_39(url, method, POSTdata)
            Case Else
                Return GetWebDocument_40(url, method, POSTdata)
        End Select
    End Function

    Function GetWebDocument_1(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_2(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_3(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_4(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_5(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_6(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_7(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_8(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_9(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_10(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_11(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_12(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_13(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_14(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_15(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_16(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_17(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_18(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_19(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_20(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_21(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_22(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_23(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_24(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_25(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_26(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_27(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_28(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_29(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_30(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_31(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_32(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_33(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_34(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_35(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_36(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_37(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_38(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_39(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
    Function GetWebDocument_40(ByVal URL As String, Optional ByVal method As String = "GET", Optional ByVal POSTdata As String = "")
        Dim responseData As String = ""
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(URL)
            request.Accept = "*/*"
            request.AllowAutoRedirect = True
            request.UserAgent = "http_requester/0.1"
            request.Timeout = 5000
            request.Method = method
            If request.Method = "POST" Then
                request.ContentType = "application/x-www-form-urlencoded"
                Dim encoding As New ASCIIEncoding()
                Dim postByteArray() As Byte = encoding.GetBytes(POSTdata)
                request.ContentLength = postByteArray.Length
                Dim postStream As IO.Stream = request.GetRequestStream()
                postStream.Write(postByteArray, 0, postByteArray.Length)
                postStream.Close()
            End If
            Dim response As Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim responseStream As IO.StreamReader = _
                  New IO.StreamReader(response.GetResponseStream())
                responseData = responseStream.ReadToEnd()
            End If
            response.Close()
        Catch e As Exception
            responseData = "error "
        End Try
        Return responseData
    End Function
End Module
