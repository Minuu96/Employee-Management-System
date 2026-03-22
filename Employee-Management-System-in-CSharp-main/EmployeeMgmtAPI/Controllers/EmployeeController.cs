using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using EmployeeMgmtAPI.Models;

namespace EmployeeMgmtAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly string _connString;

        public EmployeeController(IConfiguration config)
        {
            _connString = config.GetConnectionString("DefaultConnection") ?? "";
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var list = new List<EmployeeDto>();
                using var conn = new SqlConnection(_connString);
                conn.Open();

                string query = "SELECT * FROM employees WHERE delete_date IS NULL";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new EmployeeDto
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        EmployeeId = reader["employee_id"].ToString() ?? "",
                        FullName = reader["full_name"].ToString() ?? "",
                        Gender = reader["gender"].ToString() ?? "",
                        ContactNum = reader["contact_number"].ToString() ?? "",
                        Position = reader["position"].ToString() ?? "",
                        Image = reader["image"].ToString() ?? "",
                        Salary = reader["salary"] != DBNull.Value ? Convert.ToInt32(reader["salary"]) : 0,
                        Status = reader["status"].ToString() ?? "",
                        DateAdded = reader["date_added"].ToString() ?? ""
                    });
                }
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDto emp)
        {
            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();

                // Check if ID exists
                string checkQuery = "SELECT * FROM employees WHERE employee_id = @id AND delete_date IS NULL";
                using var checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", emp.EmployeeId);
                var dt = new DataTable();
                new SqlDataAdapter(checkCmd).Fill(dt);
                if (dt.Rows.Count >= 1) return BadRequest(new { message = $"Employee ID {emp.EmployeeId} already exists." });

                string insertQuery = @"INSERT INTO employees 
                    (employee_id, full_name, gender, contact_number, position, image, salary, date_added, status) 
                    VALUES (@id, @name, @gender, @contact, @position, @img, @salary, @date, @status)";
                
                using var cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@id", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@name", emp.FullName);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@contact", emp.ContactNum);
                cmd.Parameters.AddWithValue("@position", emp.Position);
                // In a real app handle base64 image saving. For now, store string or empty.
                cmd.Parameters.AddWithValue("@img", string.IsNullOrEmpty(emp.Image) ? "" : emp.Image); 
                cmd.Parameters.AddWithValue("@salary", 0);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                cmd.Parameters.AddWithValue("@status", emp.Status);

                cmd.ExecuteNonQuery();
                return Ok(new { message = "Employee Added Successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(string id, [FromBody] EmployeeDto emp)
        {
            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();

                string q = @"UPDATE employees SET 
                    full_name = @name, gender = @gender, contact_number = @contact, position = @position, status = @status 
                    WHERE employee_id = @id AND delete_date IS NULL";

                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@name", emp.FullName);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@contact", emp.ContactNum);
                cmd.Parameters.AddWithValue("@position", emp.Position);
                cmd.Parameters.AddWithValue("@status", emp.Status);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                
                return Ok(new { message = "Updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(string id)
        {
            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();
                string q = "UPDATE employees SET delete_date = @date WHERE employee_id = @id AND delete_date IS NULL";
                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return Ok(new { message = "Deleted logically successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
