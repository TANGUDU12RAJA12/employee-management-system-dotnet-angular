namespace CurdOperationWithDTO.DTO.Request
{
    public class EmployeeRequestAddDTO
    {
        public string Name { get; set; }
        // public string Designation { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeRequestUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public string Designation { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
