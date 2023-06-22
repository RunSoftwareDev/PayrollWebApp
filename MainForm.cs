using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gregg_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        // class level references
        private const string FILENAME = "Employee.dat";

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // add item to the employee listbox
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form is cancelled
                if (result == DialogResult.Cancel)
                    return; //end of the method since cancelled

                //get users input and create employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text;
                int lifeIns = int.Parse(frmInput.LifeInsuranceTextBox.Text);
                int vacation = Int32.Parse(frmInput.VacationDaysTextBox.Text);


                Benefits ben = new Benefits(healthIns, lifeIns, vacation);

                Employee emp = null;

                if (frmInput.SalaryRadioButton.Checked)
                {
                    double salary = double.Parse(frmInput.SalaryTextBox.Text);
                    emp = new Salary(fName, lName, ssn, hireDate, ben, salary);
                }

                else if (frmInput.HourlyRadioButton.Checked)
                {
                    double hourlyRate = double.Parse(frmInput.HourlyRateTextBox.Text);
                    double hoursWorked = double.Parse(frmInput.HoursWorkedTextBox.Text);
                    emp = new Hourly(fName, lName, ssn, hireDate, ben, hourlyRate, hoursWorked);
                }
                else
                {
                    MessageBox.Show("Error. Please select an employee type.");
                    return;
                }


                //add employee object to Employee ListBox
                EmployeesListBox.Items.Add(emp);

                WriteEmpsToFile();
            }

        }

        private void WriteEmpsToFile()
        {
            // convert the listbox items to generic list
            List<Employee> empList = new List<Employee>();

            foreach (Employee emp in EmployeesListBox.Items)
            {
                empList.Add(emp);
            }

            // open a pipe to the file and create a translator
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();


            // write generic list to file
            formatter.Serialize(fs, empList);

            //close pipe 
            fs.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            ReadEmpsFromFile();
        }

        private void ReadEmpsFromFile()
        {            // check if file exists
                     // check to see if file exists
            if (File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                // create a pipe from the file and create the "translator"
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                // read all Employee objects from the file
                List<Employee> list = (List<Employee>)formatter.Deserialize(fs);

                // close the pipe
                fs.Close();

                // clear ListBox items and copy the file’s Employee objects into our listbox
                EmployeesListBox.Items.Clear();
                foreach (Employee emp in list)
                    EmployeesListBox.Items.Add(emp);


            }

        }

        private FileStream FileStream(string fILENAME, FileMode create)
        {
            throw new NotImplementedException();
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in EmployeesListBox.Items)
            {
                string line1 = "Pay To" + emp.FirstName + " " + emp.LastName;
                string line2 = "Amount Of: " + emp.CalculatePay().ToString("C2");

                string output = "Paycheck: \n\n" + line1 + "\n" + line2;

                MessageBox.Show(output);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            Employee emp = EmployeesListBox.SelectedItem as Employee;

            InputForm frmUpdate = new InputForm();

            frmUpdate.Text = "Update Employee Information";
            frmUpdate.SubmitButton.Text = "Update";
            frmUpdate.StartPosition = FormStartPosition.CenterParent;
            frmUpdate.FirstNameTextBox.Text = emp.FirstName;
            frmUpdate.LastNameTextBox.Text = emp.LastName;
            frmUpdate.SSNTextBox.Text = emp.SSN;
            frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
            frmUpdate.HealthInsuranceTextBox.Text = emp.BenefitsEmp.HealthInsurance;
            frmUpdate.LifeInsuranceTextBox.Text = emp.BenefitsEmp.LifeInsurance.ToString();
            frmUpdate.VacationDaysTextBox.Text = emp.BenefitsEmp.Vacation.ToString();


            if (emp is Salary)
            {
                frmUpdate.HourlyRateLabel.Visible = false;
                frmUpdate.HourlyRateTextBox.Visible = false;
                frmUpdate.HoursWorkedLabel.Visible = false;
                frmUpdate.HoursWorkedTextBox.Visible = false;
                frmUpdate.SalaryLabel.Visible = true; // show this one
                frmUpdate.SalaryTextBox.Visible = true; // show this one

                // mark salary radio button as checked
                frmUpdate.SalaryRadioButton.Checked = true;

                // convert Employee obj to Salary obj
                Salary sal = (Salary)emp;

                //show salary attribute
                frmUpdate.SalaryTextBox.Text = sal.AnnualSalary.ToString("F0");
            }

            else if (emp is Hourly)
            {
                frmUpdate.SalaryLabel.Visible = false;
                frmUpdate.SalaryTextBox.Visible = false;
                frmUpdate.HourlyRateLabel.Visible = true;
                frmUpdate.HourlyRateTextBox.Visible = true;
                frmUpdate.HoursWorkedLabel.Visible = true;
                frmUpdate.HoursWorkedTextBox.Visible = true;

                // mark hourly rdio button as checked
                frmUpdate.HourlyRadioButton.Checked = true;

                // convert Employee obj to hourly obj
                Hourly hrly = (Hourly)emp;

                // show hourly attributes
                frmUpdate.HourlyRateTextBox.Text = hrly.HourlyRate.ToString("F2");
                frmUpdate.HoursWorkedTextBox.Text = hrly.HoursWorked.ToString("F1");
            }

            else
            {
                MessageBox.Show("Error. Invalid emoloyee type found.");
            }

            DialogResult result = frmUpdate.ShowDialog();

            // if cancelled

            if (result == DialogResult.Cancel)
                return; // returns the method

            //delete selected object
            int position = EmployeesListBox.SelectedIndex;
            EmployeesListBox.Items.RemoveAt(position);


            // create new employee using the update information
            Employee newEmp = null;

            string fName = frmUpdate.FirstNameTextBox.Text;
            string lName = frmUpdate.LastNameTextBox.Text;
            string ssn = frmUpdate.SSNTextBox.Text;
            DateTime hireDate = DateTime.Parse(frmUpdate.HireDateTextBox.Text);
            string healthInsurance = frmUpdate.HealthInsuranceTextBox.Text;
            int lifeInsurance = int.Parse(frmUpdate.LifeInsuranceTextBox.Text);
            int vacation = Int32.Parse(frmUpdate.VacationDaysTextBox.Text);

            Benefits ben = new Benefits(healthInsurance, lifeInsurance, vacation);

            if (frmUpdate.SalaryRadioButton.Checked)
            {
                double salary = double.Parse(frmUpdate.SalaryTextBox.Text);
                newEmp = new Salary(fName, lName, ssn, hireDate, ben, salary);
            }

            else if (frmUpdate.HourlyRadioButton.Checked)
            {
                double hourlyRate = double.Parse(frmUpdate.HourlyRateTextBox.Text);
                double hoursWorked = double.Parse(frmUpdate.HoursWorkedTextBox.Text);
                newEmp = new Hourly(fName, lName, ssn, hireDate, ben, hourlyRate, hoursWorked);
            }

            else
            {
                MessageBox.Show("Error. Invalid employee type.");
                return; // end method
            }

            EmployeesListBox.Items.Add(newEmp);
        }
    }
}

