using System.Net.Mail;

namespace Holidays
{
    public class EmailNotifier
    {
        private const string AppEmailAddress = "holidays@company.com";
        private const string HrEmailAddress = "hr@company.com";

        public void NotifySubmission(HolidayRequest request)
        {
            SendMail("Holiday Request Submitted", GetBody(request), request.ManagerEmail);
        }

        public void NotifyApproval(HolidayRequest request)
        {
            SendMail("Holiday Request Approved", GetBody(request), HrEmailAddress);
        }

        public void NotifyRejection(HolidayRequest request)
        {
            SendMail("Holiday Request Rejected", GetBody(request), request.EmployeeEmail);
        }

        private string GetBody(HolidayRequest request)
        {
            return string.Format("Requester: {0}; Period: {1} - {2}", request.EmployeeName, request.From, request.To);
        }

        private void SendMail(string subject, string body, string emailAddress)
        {
            var message = new MailMessage { From = new MailAddress(AppEmailAddress), Subject = subject, Body = body };
            message.To.Add(new MailAddress(emailAddress));
            var mailClient = new SmtpClient();
            mailClient.Send(message);
        }
    }
}