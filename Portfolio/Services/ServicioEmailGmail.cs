using Portfolio.Models;
using System.Net;
using System.Net.Mail;

namespace Portfolio.Services
{
    public class ServicioEmailGmail : IServiceEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailGmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task EnviarEmail(ContactoViewModel contactoViewModel)
        {
            var emailEmisor = configuration.GetValue<string>("CONFIGURACION_GMAIL:EMAIL");
            var password = configuration.GetValue<string>("CONFIGURACION_GMAIL:PASSWORD");
            var host = configuration.GetValue<string>("CONFIGURACION_GMAIL:HOST");
            var port = configuration.GetValue<int>("CONFIGURACION_GMAIL:PORT");

            var smtpClient = new SmtpClient(host, port);

            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(emailEmisor, password);

            var mensaje = new MailMessage(
                emailEmisor, 
                emailEmisor, 
                $"El cliente {contactoViewModel.Nombre} ({contactoViewModel.Email}) quiere conectar contigo", 
                contactoViewModel.Mensaje
            );

            await smtpClient.SendMailAsync(mensaje);
        }
    }
}
