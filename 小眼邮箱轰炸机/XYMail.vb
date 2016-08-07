Public Class XYMail

    Private Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles Btn_Send.Click
        On Error GoTo MyERR
        Dim Smtp As New System.Net.Mail.SmtpClient("smtp.yeah.net", 25)
        Dim Mail As New System.Net.Mail.MailMessage()
        Smtp.Credentials = New System.Net.NetworkCredential("HackSystem", "HackSystem123")
        Mail.From = New System.Net.Mail.MailAddress("HackSystem@yeah.net")
        Mail.To.Add(Txt_ToAddress.Text)
        Mail.SubjectEncoding = System.Text.Encoding.GetEncoding("GB2312")
        Mail.BodyEncoding = System.Text.Encoding.GetEncoding("GB2312")
        Mail.Priority = System.Net.Mail.MailPriority.Normal
        Mail.Subject = Txt_MailTitle.Text
        Mail.Body = Txt_MailBody.Text
        Mail.IsBodyHtml = False
        Smtp.Send(Mail)
        Mail.Dispose()
        MsgBox("Finished")
        GC.Collect()
        Exit Sub

MyERR:
        MsgBox("错误描述：" & Err.Description, 32, "错误号：" & Err.Number)
    End Sub

    Private Sub Btn_Send_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_Send.MouseDown
        Btn_Send.Image = My.Resources.MailRes.SendBtn_2
    End Sub

    Private Sub Btn_Send_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Send.MouseEnter
        Btn_Send.Image = My.Resources.MailRes.SendBtn_1
    End Sub

    Private Sub Btn_Send_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Send.MouseLeave
        Btn_Send.Image = My.Resources.MailRes.SendBtn_0
    End Sub

    Private Sub Btn_Send_MouseUp(sender As Object, e As MouseEventArgs) Handles Btn_Send.MouseUp
        Btn_Send.Image = My.Resources.MailRes.SendBtn_1
    End Sub
End Class
