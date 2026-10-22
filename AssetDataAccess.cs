using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Scottish_Glen_Asset_Tracking
{
    internal class AssetDataAccess
    {
        private readonly string connectionString;

        public AssetDataAccess()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["ScottishGlenConnection"]
                .ConnectionString;
        }

        public DataTable GetDepartments()
        {
            DataTable departments = new DataTable();

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query =
                    "SELECT DepartmentID, DepartmentName " +
                    "FROM dbo.Departments " +
                    "ORDER BY DepartmentID;";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(departments);
                }
            }

            return departments;
        }

        public DataTable GetEmployees()
        {
            DataTable employees = new DataTable();

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query =
                    "SELECT e.EmployeeID, e.Firstname, " +
                    "e.LastName, e.Email, e.DepartmentID, " +
                    "d.DepartmentName " +
                    "FROM dbo.Employees AS e " +
                    "INNER JOIN dbo.Departments AS d " +
                    "ON e.DepartmentID = d.DepartmentID " +
                    "ORDER BY e.LastName, e.FirstName;";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(employees);
                }
            }

            return employees;
        }

        public DataTable GetAssets()
        {
            DataTable assets = new DataTable();

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query =
                    "SELECT a.AssetID, a.SystemName, a.Model, " +
                    "a.Manufacturer, a.AssetType, a.IPAddress, " +
                    "a.PurchaseDate, a.Notes, a.EmployeeID, " +
                    "e.FirstName, e.LastName " +
                    "FROM dbo.Assets AS a " +
                    "INNER JOIN dbo.Employees AS e " +
                    "ON a.EmployeeID = e.EmployeeID " +
                    "ORDER BY a.AssetID;";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(assets);
                }
            }

            return assets;
        }

        public int GetAssetCount()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Assets;";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    connection.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int GetEmployeeCount()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Employees;";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    connection.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int AddEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Employees
                (FirstName, LastName, Email, DepartmentID)
            VALUES
                (@FirstName, @LastName, @Email, @DepartmentID);

            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    command.Parameters.AddWithValue("@DepartmentID", employee.DepartmentID);

                    connection.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int DeleteEmployee(int employeeID)
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                string query =
                    "DELETE FROM dbo.Employees " +
                    "WHERE EmployeeID = @EmployeeID;";

                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@EmployeeID",
                        SqlDbType.Int).Value = employeeID;

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
