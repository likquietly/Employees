using Employees.DefaultDabaseValues;
using Employees.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Employees
{
    public partial class EmployeeTable : Form
    {
        IReppository<Employee> employeeReppository;
        public EmployeeTable()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void EmployeeTable_Load(object sender, EventArgs e)
        {
            DatabaseCreate.Create();
            TableCreate.Create();
            DatabaseValues.FillWithDefault();
            employeeReppository = new EmployeeReppository();
            dataGridView.DataSource = employeeReppository.GetEmployeeList();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeAdd addFrm = new EmployeeAdd() { EmployeeInfo = new Employee() })
            {
                if (addFrm.ShowDialog() == DialogResult.OK && addFrm.ResultValidation)
                {
                    employeeReppository.Create(addFrm.EmployeeInfo);
                    dataGridView.DataSource = employeeReppository.GetEmployeeList();
                }
            }
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeDelete addFrm = new EmployeeDelete())
            {
                if (addFrm.ShowDialog() == DialogResult.OK)
                    dataGridView.DataSource = employeeReppository.GetEmployeeList();
            }
        }

        private void FilterPositionBox_TextChanged(object sender, EventArgs e)
        {
            var result = employeeReppository.GetEmployeeList().Where(x =>
                x.Position.Contains(FilterPositionBox.Text)).ToList();
            dataGridView.DataSource = result;
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}