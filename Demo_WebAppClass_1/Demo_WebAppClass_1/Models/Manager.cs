namespace Demo_WebAppClass_1.Models
{
    public class Manager
    {

        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public List<Employee> Employees { get; set;}
        public string Name { get; set; }
    }
}
