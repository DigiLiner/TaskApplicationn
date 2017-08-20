Imports System.Net.Mail
Public Class mail
    Public Shared Sub gonder(Gonderilecek, MailBasligi, MailKonusu, httpicerik)

        Try
            Dim yolla As New MailMessage
            Dim Gonderen As String = "bilgi@sekeroglu.com.tr"
            Dim web As New System.Net.WebClient
            Dim Gondere As New System.Net.Mail.MailAddress(Gonderen, MailKonusu)
            Dim Alici As New System.Net.Mail.MailAddress(Gonderilecek)
            Dim eposta As New System.Net.Mail.MailMessage(Gondere, Alici)
            eposta.IsBodyHtml = True
            eposta.Subject = MailBasligi
            Dim mailbilgileri As New System.Net.NetworkCredential("******", "****")
            eposta.Body = httpicerik
            Dim MailClient As New System.Net.Mail.SmtpClient()
            MailClient.Host = "smtp.turkcellsuperbulut.com" 'Smtp Adresi
            'Hotmail kullanıcıları için smtp adresi: smtp.live.com
            'Gmail kullanıcıları için smtp adresi: smtp.gmail.com
            'Portlar her smtp'de aynıdır.
            MailClient.Port = "587" 'Smtp Giden Portu
            MailClient.EnableSsl = True 'Burası da önemli|Güvenli Giriş Miriş Dalgası, Burası olmadan Mail hata veriyor.
            MailClient.UseDefaultCredentials = True 'Rastgele ekledim ama Bir üstteki kodla bağlantısı olabilir.
            MailClient.Credentials = mailbilgileri
            MailClient.Send(eposta) 'Maili gönderiyor...
            ' ----- Mail Gönderimi Başarılı ------

        Catch ex As Exception

        End Try

    End Sub
End Class

