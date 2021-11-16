using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.DefaultDabaseValues
{
    class DatabaseValues
    {
        public static void FillWithDefault()
        {
            SqlConnection myConn = new SqlConnection(AppConnection.ConnectionString);

            string str = "if not exists(select * from [Employee]) " +
                "INSERT INTO Employee (FirstName, LastName, Position, YearOfBirth, Salary) " +
                "VALUES ('Tom', 'Edinson', 'Manager', '1990', '1200.50')";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
            }
        }
    }
}