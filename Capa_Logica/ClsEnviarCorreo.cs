using System;
using System.Web;
using System.Text;//permite darle formato al correo 
using System.Net.Mail;//permite realizar el envio de correo electronico.
using System.Net;//permite acceder al sistema de seguridad del correo SSL


namespace Capa_Logica
{
  public  class ClsEnviarCorreo
    {
        public String correo = "softwareuraba2019@gmail.com", contraseña = "uraba2019";
        public String mensaje, destinatario, asunto;
        protected void Func_EnviarCorreo()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                mail.From = new MailAddress(correo, "WORKSHOP SENA", Encoding.UTF8);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.To.Add(destinatario);
                SmtpServer.Credentials = new System.Net.NetworkCredential(correo, contraseña);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch
            (Exception)
            { }
        }
        public void Func_Enviar()
        { Func_EnviarCorreo(); }
    }
}

