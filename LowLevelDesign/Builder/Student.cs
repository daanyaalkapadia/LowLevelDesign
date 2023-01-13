namespace LowLevelDesign.Builder
{
    internal class Student
    {
        private Student()
        {

        }
        public string Name { get; private set; } = string.Empty;
        public int Id { get; private set; }
        public int YearOfJoining { get; private set; }
        public string Course { get; private set; } = string.Empty;
        public int Rank { get; private set; }
        public double CGPA { get; private set; }
        public double Percentage { get; private set; }
        public static StudentBuilder GetBuilder()
        {
            return new StudentBuilder();
        }
        internal class StudentBuilder: IStudentBuilder
        {
            private Student std = new Student();

            public StudentBuilder SetName(string name)
            {
                std.Name = name;
                return this;
            }
            public StudentBuilder SetId(int id)
            {
                std.Id = id;
                return this;
            }
            public StudentBuilder SetPercentage(double percentage)
            {
                std.Percentage = percentage;
                return this;
            }
            public StudentBuilder SetCGPA(double cgpa)
            {
                std.CGPA = cgpa;
                return this;
            }
            public Student Build()
            {
                if (std.Percentage > 100 || std.Percentage < 0)
                {
                    throw new ApplicationException("Invalid Percentage");
                }
                if (std.CGPA > 100 || std.CGPA < 0)
                {
                    throw new ApplicationException("Invalid CGPA");
                }
                return std;
            }
        }
    }
}
