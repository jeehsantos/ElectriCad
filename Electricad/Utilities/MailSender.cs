using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Electricad.Utilities
{
    public class MailSender
    {
        private IConfiguration configuration;

        public MailSender(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public bool Send(string from, string to, string subject, string content, List<string> attachments)
        {
            try
            {
                var host = configuration["Gmail:Host"];
                var port = int.Parse(configuration["Gmail:Port"]);
                var username = configuration["Gmail:Username"];
                var password = configuration["Gmail:Password"];
                var enable = bool.Parse(configuration["Gmail:SMTP:starttls:enable"]);

                var smtpClient = new SmtpClient
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable,
                    Credentials = new NetworkCredential(username, password)
                };

                var mailMessage = new MailMessage(from, to);
                if(subject == "1")
                {
                    mailMessage.Subject = "You have got a new quote request !";
                }
                
                mailMessage.Body = content;
                mailMessage.IsBodyHtml = true;
                if (attachments != null)
                {
                    foreach (var attachment in attachments)
                    {
                        mailMessage.Attachments.Add(new Attachment(attachment));
                    }
                }

                smtpClient.Send(mailMessage);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}