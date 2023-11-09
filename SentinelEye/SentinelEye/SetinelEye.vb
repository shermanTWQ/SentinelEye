Public Class SetinelEye
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SentinelEye 1.0
        'Provided for non-commercial use. Please refer to Github Repo for more information. 
        'Contact: Sherman_tan@outlook.com
        '(C) Tan Wei Qiang Sherman.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Dim pName As String = txtProcess.Text
        Dim psList() As Process
        Try
            psList = Process.GetProcesses()

            For Each p As Process In psList
                If (pName = p.ProcessName) Then
                    lblDisplay.Text = ""
                    MsgBox("The process of " + txtProcess.Text + " was found running on the system.")
                    Exit For
                Else
                    lblDisplay.Text = txtProcess.Text + " was not found."
                End If

            Next p

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class
