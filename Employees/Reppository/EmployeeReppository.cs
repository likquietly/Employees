using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Employees
{
    class EmployeeReppository : IReppository<Employee>
    {
        public async void Create(Employee employee)
        {
            using (IDbConnection db = new SqlConnection(AppConnection.ConnectionString))
            {
                var sqlQuery = "INSERT INTO Employee (FirstName, LastName, Position, YearOfBirth, Salary) " +
                    "VALUES(@FirstName, @LastName, @Position, @YearOfBirth, @Salary)";
                await db.ExecuteAsync(sqlQuery, employee);
            }
        }

        public async void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(AppConnection.ConnectionString))
            {
                var sqlQuery = "DELETE FROM Employee WHERE Id = @id";
                await db.ExecuteAsync(sqlQuery, new { id });
            }
        }

        public Employee GetEmployee(int id)
        {
            using (IDbConnection db = new SqlConnection(AppConnection.ConnectionString))
            {
                return db.Query<Employee>("SELECT * FROM Employee WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            using (IDbConnection db = new SqlConnection(AppConnection.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Employee>("select Id, FirstName, LastName, Position, YearOfBirth, Salary from Employee", CommandType.Text);
            }
        }
    }
}



























