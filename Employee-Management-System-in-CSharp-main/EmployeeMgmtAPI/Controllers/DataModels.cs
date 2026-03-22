namespace EmployeeMgmtAPI.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string ContactNum { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Salary { get; set; }
        public string DateAdded { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    public class SalaryUpdateDto
    {
        public string EmployeeId { get; set; } = string.Empty;
        public int Salary { get; set; }
    }
}
