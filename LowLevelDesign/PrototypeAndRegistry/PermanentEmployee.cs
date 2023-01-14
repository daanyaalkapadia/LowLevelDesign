namespace LowLevelDesign.PrototypeAndRegistry
{
    internal class PermanentEmployee : BaseEmployee, Prototype<PermanentEmployee>
    {
        public PermanentEmployee() { }
        private PermanentEmployee(PermanentEmployee perEmp) : base(perEmp)
        {
            EmployeeID = perEmp.EmployeeID;
        }

        public int EmployeeID { get; set; }
        public new PermanentEmployee clone()
        {
            return new PermanentEmployee(this);
        }
    }
}
