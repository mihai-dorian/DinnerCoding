using System;

namespace Holidays
{
    public class HolidayRequest
    {
        private readonly string employeeName;
        private readonly string employeeEmail;
        private readonly string managerEmail;
        private readonly DateTime from;
        private readonly DateTime to;

        public HolidayRequest(string employeeName, string employeeEmail, string managerEmail, DateTime from, DateTime to)
        {
            this.employeeName = employeeName;
            this.employeeEmail = employeeEmail;
            this.managerEmail = managerEmail;
            this.from = from;
            this.to = to;
        }
        
        private void Notify(string status, string emailAddress)
        {
            const string sender = "holidays@company.com";
            string subject = "Holiday Request: " + status;
            string message = string.Format("Employee: {0} ({1}); Period: {2} - {3}", employeeName, employeeEmail, from, to);
            new Email(sender, subject, message).SendTo(emailAddress);
        }

        public void Submit()
        {
            Notify("Submitted", managerEmail);
        }

        public void Approve()
        {
            Notify("Approved", "hr@company.com");
        }

        public void Reject()
        {
            Notify("Rejected", employeeEmail);
        }
    }
}