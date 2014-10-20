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
            _notifier.SendSubmission(GetRequest());
        }

        private void ApproveButtonClicked(object sender, EventArgs e)
        {
            _notifier.SendApproval(GetRequest());
        }

        private void RejectButtonClicked(object sender, EventArgs e)
        {
            _notifier.SendRejection(GetRequest());
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