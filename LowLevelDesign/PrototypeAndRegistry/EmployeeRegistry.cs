namespace LowLevelDesign.PrototypeAndRegistry
{
    internal class EmployeeRegistry
    {
        private Dictionary<string, BaseEmployee> empCache;
        internal EmployeeRegistry()
        {
            this.empCache = new Dictionary<string, BaseEmployee>();
        }
        public void Register(BaseEmployee emp)
        {
            if (!empCache.ContainsKey(emp.Department))
            {
                empCache.Add(emp.Department, emp);
            }
        }
        public BaseEmployee? GetEmployeeObj(string dept)
        {
            if (empCache.ContainsKey(dept))
            {
                return empCache[dept];
            }
            return null;
        }
    }
}
