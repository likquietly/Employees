using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.DefaultDabaseValues
{
    class TableCreate
    {
        public static void Create()
        {
            SqlConnection myConn = new SqlConnection(AppConnection.ConnectionString);

            string str = "IF OBJECT_ID(N'Employee','U') IS NULL CREATE TABLE Employee (Id INT PRIMARY KEY IDENTITY, " +
                "FirstName NVARCHAR(50) NOT NULL, " +
                "LastName NVARCHAR(50) NOT NULL, " +
                "Position NVARCHAR(50) NOT NULL," +
                "YearOfBirth INT NOT NULL, " +
                "Salary FLOAT NOT NULL)";

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