using Employees.Constants;
using System;
using System.Windows.Forms;

namespace Employees.Forms
{
    public partial class EmployeeDelete : Form
    {
        public Employee EmployeeInfo { get; set; }
        readonly IReppository<Employee> employeeReppository = new EmployeeReppository();
        public EmployeeDelete()
        {
            InitializeComponent();
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(idToDeleteTxt.Text, out int idToDelete))
                MessageBox.Show(ConstantsStr.idError, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else EmployeeInfo = employeeReppository.GetEmployee(idToDelete);

            if (EmployeeInfo != null)
            {
                employeeReppository.Delete(idToDelete);
                MessageBox.Show($"Пользователь с Id - {idToDelete} удален", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Пользователя с Id - {idToDelete} не существует", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}