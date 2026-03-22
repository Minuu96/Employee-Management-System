using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using EmployeeMgmtAPI.Models;

namespace EmployeeMgmtAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly string _connString;

        public AuthController(IConfiguration config)
        {
            _connString = config.GetConnectionString("DefaultConnection") ?? "";
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserDto user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                return BadRequest(new AuthResponse { Success = false, Message = "Please fill all blank fields." });
            }

            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();

                string query = "SELECT * FROM users WHERE username = @user AND password = @pass";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user.Username);
                cmd.Parameters.AddWithValue("@pass", user.Password);

                using var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count >= 1)
                {
                    return Ok(new AuthResponse { Success = true, Message = "Login successful." });
                }
                else
                {
                    return Unauthorized(new AuthResponse { Success = false, Message = "Incorrect Username/Password." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new AuthResponse { Success = false, Message = "Connection fail: " + ex.Message });
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserDto user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                return BadRequest(new AuthResponse { Success = false, Message = "Please fill all blank fields." });
            }

            try
            {
                using var conn = new SqlConnection(_connString);
                conn.Open();

                // Check if exists
                string checkUser = "SELECT * FROM users WHERE username = @user";
                using var checkCmd = new SqlCommand(checkUser, conn);
                checkCmd.Parameters.AddWithValue("@user", user.Username);
                
                using var adapter = new SqlDataAdapter(checkCmd);
                var table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count >= 1)
                {
                    return Conflict(new AuthResponse { Success = false, Message = user.Username + " is already taken." });
                }

                DateTime today = DateTime.Today;
                string insertQuery = "INSERT INTO users (username, password, date_register) VALUES (@user, @pass, @date)";
                using var cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@user", user.Username);
                cmd.Parameters.AddWithValue("@pass", user.Password);
                cmd.Parameters.AddWithValue("@date", today);
                cmd.ExecuteNonQuery();

                return Ok(new AuthResponse { Success = true, Message = "Registered successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new AuthResponse { Success = false, Message = "Connection fail: " + ex.Message });
            }
        }
    }
}
