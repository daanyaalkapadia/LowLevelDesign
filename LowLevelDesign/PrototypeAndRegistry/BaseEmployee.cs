namespace LowLevelDesign.PrototypeAndRegistry
{
    internal class BaseEmployee : Prototype<BaseEmployee>
    {
        public BaseEmployee()
        {

        }
        protected BaseEmployee(BaseEmployee baseEmp)
        {
            Id = baseEmp.Id;
            Name = baseEmp.Name;
            Salary = baseEmp.Salary;
            Department = baseEmp.Department;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
        public string Department { get; set; } = string.Empty;
        public BaseEmployee clone()
        {
            return new BaseEmployee(this);
        }
    }
}
