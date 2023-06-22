namespace Gregg_CourseProject_Part2
{
    partial class InputForm
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
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            SSNLabel = new Label();
            HireDateLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            SSNTextBox = new TextBox();
            HireDateTextBox = new TextBox();
            SubmitButton = new Button();
            ExitButton = new Button();
            BenefitsGroupBox = new GroupBox();
            HealthInsuranceTextBox = new TextBox();
            HealthInsuranceLabel = new Label();
            VacationDaysTextBox = new TextBox();
            VacationDaysLabel = new Label();
            LifeInsuranceTextBox = new TextBox();
            LifeInsuranceLabel = new Label();
            EmployeeTypeLabel = new Label();
            HourlyRadioButton = new RadioButton();
            SalaryRadioButton = new RadioButton();
            HourlyRateTextBox = new TextBox();
            HourlyRateLabel = new Label();
            HoursWorkedTextBox = new TextBox();
            HoursWorkedLabel = new Label();
            SalaryTextBox = new TextBox();
            SalaryLabel = new Label();
            BenefitsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(49, 49);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(134, 32);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(49, 98);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(131, 32);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name:";
            // 
            // SSNLabel
            // 
            SSNLabel.AutoSize = true;
            SSNLabel.Location = new Point(49, 147);
            SSNLabel.Name = "SSNLabel";
            SSNLabel.Size = new Size(63, 32);
            SSNLabel.TabIndex = 2;
            SSNLabel.Text = "SSN:";
            // 
            // HireDateLabel
            // 
            HireDateLabel.AutoSize = true;
            HireDateLabel.Location = new Point(49, 196);
            HireDateLabel.Name = "HireDateLabel";
            HireDateLabel.Size = new Size(120, 32);
            HireDateLabel.TabIndex = 3;
            HireDateLabel.Text = "Hire Date:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(206, 46);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(313, 39);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(206, 95);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(313, 39);
            LastNameTextBox.TabIndex = 1;
            // 
            // SSNTextBox
            // 
            SSNTextBox.Location = new Point(206, 144);
            SSNTextBox.Name = "SSNTextBox";
            SSNTextBox.Size = new Size(313, 39);
            SSNTextBox.TabIndex = 2;
            // 
            // HireDateTextBox
            // 
            HireDateTextBox.Location = new Point(206, 193);
            HireDateTextBox.Name = "HireDateTextBox";
            HireDateTextBox.Size = new Size(313, 39);
            HireDateTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(91, 418);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(140, 44);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(278, 418);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(140, 44);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Cancel";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // BenefitsGroupBox
            // 
            BenefitsGroupBox.Controls.Add(HealthInsuranceTextBox);
            BenefitsGroupBox.Controls.Add(HealthInsuranceLabel);
            BenefitsGroupBox.Controls.Add(VacationDaysTextBox);
            BenefitsGroupBox.Controls.Add(VacationDaysLabel);
            BenefitsGroupBox.Controls.Add(LifeInsuranceTextBox);
            BenefitsGroupBox.Controls.Add(LifeInsuranceLabel);
            BenefitsGroupBox.Location = new Point(580, 46);
            BenefitsGroupBox.Name = "BenefitsGroupBox";
            BenefitsGroupBox.Size = new Size(579, 215);
            BenefitsGroupBox.TabIndex = 6;
            BenefitsGroupBox.TabStop = false;
            BenefitsGroupBox.Text = "Benefits";
            // 
            // HealthInsuranceTextBox
            // 
            HealthInsuranceTextBox.Location = new Point(253, 38);
            HealthInsuranceTextBox.Name = "HealthInsuranceTextBox";
            HealthInsuranceTextBox.Size = new Size(313, 39);
            HealthInsuranceTextBox.TabIndex = 0;
            // 
            // HealthInsuranceLabel
            // 
            HealthInsuranceLabel.AutoSize = true;
            HealthInsuranceLabel.Location = new Point(49, 38);
            HealthInsuranceLabel.Name = "HealthInsuranceLabel";
            HealthInsuranceLabel.Size = new Size(198, 32);
            HealthInsuranceLabel.TabIndex = 4;
            HealthInsuranceLabel.Text = "Health Insurance:";
            // 
            // VacationDaysTextBox
            // 
            VacationDaysTextBox.Location = new Point(253, 146);
            VacationDaysTextBox.Name = "VacationDaysTextBox";
            VacationDaysTextBox.Size = new Size(313, 39);
            VacationDaysTextBox.TabIndex = 2;
            // 
            // VacationDaysLabel
            // 
            VacationDaysLabel.AutoSize = true;
            VacationDaysLabel.Location = new Point(49, 146);
            VacationDaysLabel.Name = "VacationDaysLabel";
            VacationDaysLabel.Size = new Size(167, 32);
            VacationDaysLabel.TabIndex = 10;
            VacationDaysLabel.Text = "Vacation Days:";
            // 
            // LifeInsuranceTextBox
            // 
            LifeInsuranceTextBox.Location = new Point(253, 92);
            LifeInsuranceTextBox.Name = "LifeInsuranceTextBox";
            LifeInsuranceTextBox.Size = new Size(313, 39);
            LifeInsuranceTextBox.TabIndex = 1;
            // 
            // LifeInsuranceLabel
            // 
            LifeInsuranceLabel.AutoSize = true;
            LifeInsuranceLabel.Location = new Point(49, 92);
            LifeInsuranceLabel.Name = "LifeInsuranceLabel";
            LifeInsuranceLabel.Size = new Size(166, 32);
            LifeInsuranceLabel.TabIndex = 8;
            LifeInsuranceLabel.Text = "Life Insurance:";
            // 
            // EmployeeTypeLabel
            // 
            EmployeeTypeLabel.AutoSize = true;
            EmployeeTypeLabel.Location = new Point(49, 273);
            EmployeeTypeLabel.Name = "EmployeeTypeLabel";
            EmployeeTypeLabel.Size = new Size(182, 32);
            EmployeeTypeLabel.TabIndex = 7;
            EmployeeTypeLabel.Text = "Employee Type:";
            // 
            // HourlyRadioButton
            // 
            HourlyRadioButton.AutoSize = true;
            HourlyRadioButton.Location = new Point(255, 273);
            HourlyRadioButton.Name = "HourlyRadioButton";
            HourlyRadioButton.Size = new Size(103, 36);
            HourlyRadioButton.TabIndex = 8;
            HourlyRadioButton.TabStop = true;
            HourlyRadioButton.Text = "Hourly";
            HourlyRadioButton.UseVisualStyleBackColor = true;
            HourlyRadioButton.CheckedChanged += HourlyRadioButton_CheckedChanged;
            // 
            // SalaryRadioButton
            // 
            SalaryRadioButton.AutoSize = true;
            SalaryRadioButton.Location = new Point(384, 273);
            SalaryRadioButton.Name = "SalaryRadioButton";
            SalaryRadioButton.Size = new Size(95, 36);
            SalaryRadioButton.TabIndex = 9;
            SalaryRadioButton.TabStop = true;
            SalaryRadioButton.Text = "Salary";
            SalaryRadioButton.UseVisualStyleBackColor = true;
            SalaryRadioButton.CheckedChanged += SalaryRadioButton_CheckedChanged;
            // 
            // HourlyRateTextBox
            // 
            HourlyRateTextBox.Location = new Point(225, 318);
            HourlyRateTextBox.Name = "HourlyRateTextBox";
            HourlyRateTextBox.Size = new Size(313, 39);
            HourlyRateTextBox.TabIndex = 10;
            HourlyRateTextBox.Visible = false;
            // 
            // HourlyRateLabel
            // 
            HourlyRateLabel.AutoSize = true;
            HourlyRateLabel.Location = new Point(49, 318);
            HourlyRateLabel.Name = "HourlyRateLabel";
            HourlyRateLabel.Size = new Size(144, 32);
            HourlyRateLabel.TabIndex = 11;
            HourlyRateLabel.Text = "Hourly Rate:";
            HourlyRateLabel.Visible = false;
            // 
            // HoursWorkedTextBox
            // 
            HoursWorkedTextBox.Location = new Point(225, 363);
            HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            HoursWorkedTextBox.Size = new Size(313, 39);
            HoursWorkedTextBox.TabIndex = 5;
            HoursWorkedTextBox.Visible = false;
            // 
            // HoursWorkedLabel
            // 
            HoursWorkedLabel.AutoSize = true;
            HoursWorkedLabel.Location = new Point(49, 363);
            HoursWorkedLabel.Name = "HoursWorkedLabel";
            HoursWorkedLabel.Size = new Size(171, 32);
            HoursWorkedLabel.TabIndex = 13;
            HoursWorkedLabel.Text = "Hours Worked:";
            HoursWorkedLabel.Visible = false;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(225, 318);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(313, 39);
            SalaryTextBox.TabIndex = 4;
            SalaryTextBox.Visible = false;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(49, 318);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(82, 32);
            SalaryLabel.TabIndex = 15;
            SalaryLabel.Text = "Salary:";
            SalaryLabel.Visible = false;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 492);
            Controls.Add(SalaryTextBox);
            Controls.Add(SalaryLabel);
            Controls.Add(HoursWorkedTextBox);
            Controls.Add(HoursWorkedLabel);
            Controls.Add(HourlyRateTextBox);
            Controls.Add(HourlyRateLabel);
            Controls.Add(SalaryRadioButton);
            Controls.Add(HourlyRadioButton);
            Controls.Add(EmployeeTypeLabel);
            Controls.Add(BenefitsGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Controls.Add(HireDateTextBox);
            Controls.Add(SSNTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(HireDateLabel);
            Controls.Add(SSNLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "InputForm";
            Text = "Employee Input Form";
            Load += InputForm_Load;
            BenefitsGroupBox.ResumeLayout(false);
            BenefitsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label SSNLabel;
        private Label HireDateLabel;
        public TextBox FirstNameTextBox;
        public TextBox LastNameTextBox;
        public TextBox SSNTextBox;
        public TextBox HireDateTextBox;
        private GroupBox BenefitsGroupBox;
        public TextBox HealthInsuranceTextBox;
        private Label HealthInsuranceLabel;
        public TextBox VacationDaysTextBox;
        private Label VacationDaysLabel;
        public TextBox LifeInsuranceTextBox;
        private Label LifeInsuranceLabel;
        private Label EmployeeTypeLabel;
        public TextBox HourlyRateTextBox;
        public TextBox HoursWorkedTextBox;
        public TextBox SalaryTextBox;
        public Button SubmitButton;
        public Button ExitButton;
        public RadioButton SalaryRadioButton;
        public RadioButton HourlyRadioButton;
        public Label HourlyRateLabel;
        public Label HoursWorkedLabel;
        public Label SalaryLabel;
    }
}