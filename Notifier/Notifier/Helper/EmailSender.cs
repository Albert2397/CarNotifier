using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Notifier.Helper
{
    public class EmailSender
    {
        public static void Send(string email, string data)
        {
            var fromAddress = new MailAddress("carnotifier2020@gmail.com", "Car Notifier");
            var toAddress = new MailAddress(email, "email");
            string fromPassword = "Notifier!23";
            string subject = "New Offers";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject
                Body = data
            })
            {
                smtp.Send(message);
            }
        }
    }
}
