namespace APICoreProvider.DTO
{
    public class DeptWithListEmpInfo
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<string> EmployeeNames { get; set; } = new List<string>();
    }
}
