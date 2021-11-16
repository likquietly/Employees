using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Employees.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            DataSetEmployee dataSet = new DataSetEmployee();
            SqlConnection sqlConnection = new SqlConnection(AppConnection.ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employee", sqlConnection);
            sqlDataAdapter.Fill(dataSet, dataSet.Tables[0].TableName);

            ReportDataSource reportDataSource = new ReportDataSource("Employee", dataSet.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}