using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using EmployeeMgmtAPI.Models;

namespace EmployeeMgmtAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaryController : ControllerBase
    {
        private readonly string _connString;

        public SalaryController(IConfiguration config)
        {
            _connString = config.GetConnectionString("DefaultConnection") ?? "";
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSalary(string id, [FromBody] SalaryUpdateDto dto)
        {
            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();
                
                string q = "UPDATE employees SET salary = @salary WHERE employee_id = @id AND delete_date IS NULL";
                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@salary", dto.Salary);
                cmd.Parameters.AddWithValue("@id", id);
                
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                    return Ok(new { message = "Salary updated successfully." });
                return NotFound(new { message = "Employee not found." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
