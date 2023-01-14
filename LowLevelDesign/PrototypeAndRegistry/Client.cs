namespace LowLevelDesign.PrototypeAndRegistry
{
    internal class Client
    {
        static void Main(string[] args)
        {
            EmployeeRegistry empreg = new();
            RegisterTemplate(empreg);
            var enggEmpTemplateObj = empreg.GetEmployeeObj("Engineering");
            if (enggEmpTemplateObj != null)
            {
                var newEngg = enggEmpTemplateObj.clone();
                newEngg.Id = 1;
                newEngg.Name = "dk";
            }
        }
        private static void RegisterTemplate(EmployeeRegistry empreg)
        {
            BaseEmployee engineeringEmp = new()
            {
                Salary = 4.4,
                Department = "Engineering"
            };
            empreg.Register(engineeringEmp);

            BaseEmployee qualityEmp = new()
            {
                Salary = 2.4,
                Department = "Quality"
            };
            empreg.Register(qualityEmp);
        }
    }
}
