using System;
using System.Windows.Forms;

namespace Holidays.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitHolidayRequestButtonClicked(object sender, EventArgs e)
        {
            GetRequest().Submit();
        }

        private void ApproveButtonClicked(object sender, EventArgs e)
        {
            GetRequest().Approve();
        }

        private void RejectButtonClicked(object sender, EventArgs e)
        {
            GetRequest().Reject();
        }

        private HolidayRequest GetRequest()
        {
            return new HolidayRequest(
                EmployeeNameTextBox.Text, 
                EmployeeEmailTextBox.Text,
                ManagerEmailTextBox.Text,
                StartDateTimePicker.Value,
                EndDateTimePicker.Value);
        }
    }
}