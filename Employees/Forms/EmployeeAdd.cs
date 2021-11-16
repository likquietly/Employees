using Employees.Validation;
using System;
using System.Windows.Forms;
using Employees.Constants;

namespace Employees
{
    public partial class EmployeeAdd : Form
    {
        public Employee EmployeeInfo { get; set; }
        public bool ResultValidation { get; set; }
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeInfo.FirstName = firstNameAddTxt.Text;
            EmployeeInfo.LastName = lastNameAddTxt.Text;
            EmployeeInfo.Position = positionAddTxt.Text;

            if (!Int32.TryParse(yearOfBirthAddTxt.Text, out int yearOfBirth))
                MessageBox.Show(ConstantsStr.yearError, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else EmployeeInfo.YearOfBirth = yearOfBirth;

            if (!Double.TryParse(salaryAddTxt.Text, out double salary))
                MessageBox.Show(ConstantsStr.salaryError, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else EmployeeInfo.Salary = salary;

            ResultValidation = ValidationModel.TryValidate(EmployeeInfo);
        }
    }
}