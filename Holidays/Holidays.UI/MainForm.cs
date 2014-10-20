using System;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace Holidays.UI
{
    public partial class MainForm : Form
    {
        private readonly EmailNotifier _notifier = new EmailNotifier();
 
        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitHolidayRequestButtonClicked(object sender, EventArgs e)
        {
            _notifier.NotifySubmission(GetRequest());
        }

        private void ApproveButtonClicked(object sender, EventArgs e)
        {
            _notifier.NotifyApproval(GetRequest());
        }

        private void RejectButtonClicked(object sender, EventArgs e)
        {
            _notifier.NotifyRejection(GetRequest());
        }

        private HolidayRequest GetRequest()
        {
            return new HolidayRequest
                       {
                           EmployeeName = EmployeeNameTextBox.Text,
                           EmployeeEmail = EmployeeEmailTextBox.Text,
                           ManagerEmail = UserPrincipal.Current.EmailAddress,
                           From = StartDateTimePicker.Value,
                           To = EndDateTimePicker.Value
                       };
        }
    }
}