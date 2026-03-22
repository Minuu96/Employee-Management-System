using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeMgmtAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly string _connString;

        public DashboardController(IConfiguration config)
        {
            _connString = config.GetConnectionString("DefaultConnection") ?? "";
        }

        [HttpGet("stats")]
        public IActionResult GetStats()
        {
            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();

                var stats = new { Total = 0, Active = 0, Inactive = 0 };

                // Get Total
                using (var tCmd = new SqlCommand("SELECT COUNT(id) FROM employees WHERE delete_date IS NULL", conn))
                {
                    stats = new { Total = Convert.ToInt32(tCmd.ExecuteScalar()), Active = stats.Active, Inactive = stats.Inactive };
                }

                // Get Active
                using (var aCmd = new SqlCommand("SELECT COUNT(id) FROM employees WHERE status = 'Active' AND delete_date IS NULL", conn))
                {
                    stats = new { Total = stats.Total, Active = Convert.ToInt32(aCmd.ExecuteScalar()), Inactive = stats.Inactive };
                }

                // Get Inactive
                using (var iCmd = new SqlCommand("SELECT COUNT(id) FROM employees WHERE status = 'Inactive' AND delete_date IS NULL", conn))
                {
                    stats = new { Total = stats.Total, Active = stats.Active, Inactive = Convert.ToInt32(iCmd.ExecuteScalar()) };
                }

                return Ok(stats);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
