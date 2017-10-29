Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.CodeDom.Compiler

Public Class Asemb
    Dim ico As New OpenFileDialog
    Dim p As New OpenFileDialog


    'RES credit for X-SLAYER


    'Random Numbers
    Public Function RandomN()
        Randomize()
        Dim a = Int((10 - 1) * Rnd()) + 1
        Return a
    End Function



    'Random Strings
    Public Function GENRandom(ByVal longitud As Integer, ByVal NNNNN As Integer) As String
        Dim ESS As String = "012345678WERTYUIQWERTYUIWPL123456789KJHGFDSAZXC123456789VBNMQWERTY9QWERTYUIQWERTYUIOPLKJHGF123456789DSAZXCVBNMQWERTYUIOPLKJH123456789GFDSAZXCVBNMQWERTYUI123456789OPLKJHGFDSAYUIOPLKJHGFDSAZX123456789123456789123456789CVBNMOPLKJHGFDSAZXCVBNM"
        Dim r As New Random
        Dim l As Integer
        Dim sb As New System.Text.StringBuilder
        For iA = 1 To longitud
            l = r.Next(0, NNNNN)
            sb.Append(ESS.Substring(l, 1))
        Next

        Return sb.ToString()
    End Function



    'Change Discription
    Private Sub Display_Description(ByVal Name As String)


        If TXTFilename.Text = Nothing Or System.IO.File.Exists(TXTFilename.Text) = False Then
            MsgBox("Select a file", MsgBoxStyle.Information)
            Me.Close()
        Else
            Try
                Application.DoEvents()
                If File.Exists(Application.StartupPath & "\res.exe") Then
                    File.Delete(Application.StartupPath & "\res.exe")
                End If
                Threading.Thread.Sleep(100)
                File.WriteAllBytes(Application.StartupPath & "\res.exe", My.Resources.Res)

                Dim source As String = My.Resources.RHDiscription
                Dim Version = New Collections.Generic.Dictionary(Of String, String) : Version.Add("CompilerVersion", "v2.0")
                Dim Compiler As VBCodeProvider = New VBCodeProvider(Version)
                Dim cResults As CompilerResults
                Dim Settings As New CompilerParameters()
                With Settings
                    .GenerateExecutable = True
                    .OutputAssembly = Application.StartupPath & "\" & T1.Text & ".exe"
                    .CompilerOptions = "/target:winexe"
                    .ReferencedAssemblies.Add("System.dll")
                    .ReferencedAssemblies.Add("System.Windows.Forms.dll")
                    .MainClass = "X"
                End With
                Threading.Thread.Sleep(100)
                source = source.Replace("*Title*", T2.Text)
                source = source.Replace("*Company*", T3.Text)
                source = source.Replace("*Product*", T4.Text)
                source = source.Replace("*Copyright*", T5.Text)
                source = source.Replace("*Trademark*", T1.Text)
                source = source.Replace("*version*", N1.Value.ToString & "." & N2.Value.ToString & "." & N3.Value.ToString & "." & N4.Value.ToString)
                source = source.Replace("*fversion*", N6.Value.ToString & "." & N7.Value.ToString & "." & N8.Value.ToString & "." & N9.Value.ToString)
                cResults = Compiler.CompileAssemblyFromSource(Settings, source)
                Threading.Thread.Sleep(100)
                Dim otherfile As String = Application.StartupPath & "\" & T1.Text & ".exe"
                Dim resfile As String = Application.StartupPath & "\" & T1.Text & ".res"
                Dim mainfile As String = Name
                Threading.Thread.Sleep(100)
                Shell("res.exe -extract " & otherfile & "," & resfile & ",VERSIONINFO,,", AppWinStyle.Hide, True, -1)
                Shell("res.exe -delete " & mainfile & "," & System.AppDomain.CurrentDomain.BaseDirectory() + "res.exe" & ",VERSIONINFO,,", AppWinStyle.Hide, True, -1)
                Shell("res.exe -addoverwrite " & mainfile & "," & mainfile & "," & resfile & ",VERSIONINFO,1,", AppWinStyle.Hide, True, -1)
                Threading.Thread.Sleep(100)
                If File.Exists(Application.StartupPath & "\" & T1.Text & ".exe") Then
                    File.Delete(Application.StartupPath & "\" & T1.Text & ".exe")
                End If
                If File.Exists(Application.StartupPath & "\" & T1.Text & ".res") Then
                    File.Delete(Application.StartupPath & "\" & T1.Text & ".res")
                End If
                If File.Exists(Application.StartupPath & "\res.exe") = True Then
                    File.Delete(Application.StartupPath & "\res.exe")
                End If
                If File.Exists(Application.StartupPath & "\res.log") = True Then
                    File.Delete(Application.StartupPath & "\res.log")
                End If
                If File.Exists(Application.StartupPath & "\res.ini") = True Then
                    File.Delete(Application.StartupPath & "\res.ini")
                    Threading.Thread.Sleep(100)
                End If
                IconInjector.InjectIcon(p.FileName, ico.FileName)
            Catch ex As Exception

            End Try
        End If
        Me.Close()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        T1.Text = GENRandom(12, 55)
        T2.Text = GENRandom(5, 44)
        T3.Text = GENRandom(12, 50)
        T4.Text = GENRandom(12, 88)
        T5.Text = GENRandom(12, 93)
        N1.Value = RandomN()
        N2.Value = RandomN()
        N3.Value = RandomN()
        N4.Value = RandomN()
        N6.Value = RandomN()
        N7.Value = RandomN()
        N8.Value = RandomN()
        N9.Value = RandomN()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dialog As New OpenFileDialog With {
              .Filter = "(.exe) |*.exe"
          }
            dialog.ShowDialog()
            If (dialog.FileName.Length > 0) Then
                Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(dialog.FileName)
                T1.Text = IO.Path.GetFileNameWithoutExtension(dialog.FileName)
                T2.Text = versionInfo.FileDescription
                T3.Text = versionInfo.CompanyName
                T4.Text = versionInfo.ProductName
                T5.Text = versionInfo.LegalCopyright
                Dim strArray As String() = versionInfo.ProductVersion.Split(New Char() {"."c})
                N1.Value = Conversions.ToDecimal(strArray(0))
                N2.Value = Conversions.ToDecimal(strArray(1))
                N3.Value = Conversions.ToDecimal(strArray(2))
                N4.Value = Conversions.ToDecimal(strArray(3))
                Dim strArray2 As String() = versionInfo.FileVersion.Split(New Char() {"."c})
                N6.Value = Conversions.ToDecimal(strArray2(0))
                N7.Value = Conversions.ToDecimal(strArray2(1))
                N8.Value = Conversions.ToDecimal(strArray2(2))
                N9.Value = Conversions.ToDecimal(strArray2(3))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Display_Description(TXTFilename.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p.Filter = "Executable|*.exe"
        p.Title = "Open"
        If p.ShowDialog = Windows.Forms.DialogResult.OK Then
            TXTFilename.Text = p.FileName
        End If
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ico.Filter = "Ico|*.ico"
        ico.Title = "Ico"
        ico.ShowDialog()

        TextBox1.Text = ico.FileName
    End Sub


End Class
