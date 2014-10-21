using System.Net.Mail;

namespace Holidays
{
    public class Email
    {
        private readonly string from;
        private readonly string subject;
        private readonly string message;
                
        public Email(string from, string subject, string message)
        {
            this.from = from;
            this.subject = subject;
            this.message = message;
        }

        public void SendTo(string emailAddress)
        {
            var email = new MailMessage
                              {
                                  From = new MailAddress(from), 
                                  Subject = subject, 
                                  Body = message
                              };
            email.To.Add(new MailAddress(emailAddress));
            var mailClient = new SmtpClient();
            mailClient.Send(email);
        }
    }
}