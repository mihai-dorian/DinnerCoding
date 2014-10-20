using System.Net.Mail;

namespace Holidays
{
    public class Notification
    {
        private readonly string _status;
        private readonly string _message;
                
        public Notification(string status, string message)
        {
            _status = status;
            _message = message;
        }

        public void SendTo(ContactDetails receiver)
        {
            var email = new MailMessage
                              {
                                  From = new MailAddress("holidays@company.com"), 
                                  Subject = "Holiday Request: " + _status.ToUpper(), 
                                  Body = _message
                              };
            email.To.Add(new MailAddress(receiver.EmailAddress));
            var mailClient = new SmtpClient();
            mailClient.Send(email);
        }
    }
}