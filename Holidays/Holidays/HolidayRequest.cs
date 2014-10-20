using System;

namespace Holidays
{
    public class HolidayRequest
    {
        private readonly ContactDetails _employee;
        private readonly ContactDetails _manager;
        private readonly ContactDetails _hr;
        private readonly DateTime _from;
        private readonly DateTime _to;

        public HolidayRequest(ContactDetails employee, ContactDetails manager, DateTime from, DateTime to)
        {
            _employee = employee;
            _manager = manager;
            _hr = new ContactDetails {EmailAddress = "hr@company.com"};
            _from = from;
            _to = to;
        }

        public string AsText()
        {
            return string.Format("Employee: {0}; Period: {1} - {2}", _employee, _from, _to);
        }
        
        private void Notify(string status, ContactDetails receiver)
        {
            new Notification(status, AsText()).SendTo(receiver);
        }

        public void Submit()
        {
            Notify("submitted", _manager);
        }

        public void Approve()
        {
            Notify("approved", _hr);
        }

        public void Reject()
        {
            Notify("rejected", _employee);
        }
    }
}