using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees.DefaultDabaseValues
{
    class DatabaseCreate
    {
        public static void Create()
        {
            SqlConnection myConn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;");
            
            string str = "if db_id('EmployeeDatabase') is null CREATE DATABASE EmployeeDatabase";

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