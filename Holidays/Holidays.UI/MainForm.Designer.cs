namespace Holidays.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeEmailLabel = new System.Windows.Forms.Label();
            this.EmployeeEmailTextBox = new System.Windows.Forms.TextBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RejectButton = new System.Windows.Forms.Button();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.ManagerEmailTextBox = new System.Windows.Forms.TextBox();
            this.ManagerEmailLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeEmailLabel
            // 
            this.EmployeeEmailLabel.AutoSize = true;
            this.EmployeeEmailLabel.Location = new System.Drawing.Point(20, 41);
            this.EmployeeEmailLabel.Name = "EmployeeEmailLabel";
            this.EmployeeEmailLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeEmailLabel.TabIndex = 11;
            this.EmployeeEmailLabel.Text = "Employee Email:";
            // 
            // EmployeeEmailTextBox
            // 
            this.EmployeeEmailTextBox.Location = new System.Drawing.Point(116, 38);
            this.EmployeeEmailTextBox.Name = "EmployeeEmailTextBox";
            this.EmployeeEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.EmployeeEmailTextBox.TabIndex = 10;
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(138, 144);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(86, 23);
            this.ApproveButton.TabIndex = 9;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButtonClicked);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(20, 123);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(55, 13);
            this.EndDateLabel.TabIndex = 8;
            this.EndDateLabel.Text = "End Date:";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(20, 97);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(58, 13);
            this.StartDateLabel.TabIndex = 7;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(116, 118);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDateTimePicker.TabIndex = 5;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(116, 91);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDateTimePicker.TabIndex = 6;
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(230, 144);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(86, 23);
            this.RejectButton.TabIndex = 9;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButtonClicked);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(116, 12);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.EmployeeNameTextBox.TabIndex = 10;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(20, 15);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EmployeeNameLabel.TabIndex = 11;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // ManagerEmailTextBox
            // 
            this.ManagerEmailTextBox.Location = new System.Drawing.Point(116, 64);
            this.ManagerEmailTextBox.Name = "ManagerEmailTextBox";
            this.ManagerEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.ManagerEmailTextBox.TabIndex = 10;
            // 
            // ManagerEmailLabel
            // 
            this.ManagerEmailLabel.AutoSize = true;
            this.ManagerEmailLabel.Location = new System.Drawing.Point(20, 67);
            this.ManagerEmailLabel.Name = "ManagerEmailLabel";
            this.ManagerEmailLabel.Size = new System.Drawing.Size(80, 13);
            this.ManagerEmailLabel.TabIndex = 11;
            this.ManagerEmailLabel.Text = "Manager Email:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(46, 144);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 23);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitHolidayRequestButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 187);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ManagerEmailLabel);
            this.Controls.Add(this.EmployeeEmailLabel);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.ManagerEmailTextBox);
            this.Controls.Add(this.EmployeeEmailTextBox);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "MainForm";
            this.Text = "Holidays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeEmailLabel;
        private System.Windows.Forms.TextBox EmployeeEmailTextBox;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox ManagerEmailTextBox;
        private System.Windows.Forms.Label ManagerEmailLabel;
        private System.Windows.Forms.Button SubmitButton;
    }
}

