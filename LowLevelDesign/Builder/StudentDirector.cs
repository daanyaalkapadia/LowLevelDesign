namespace LowLevelDesign.Builder
{
    internal class StudentDirector
    {
        public Student GetSchoolStudentObj(int id, string name, double percentage)
        {
            return Student.GetBuilder().SetId(id).SetName(name).SetPercentage(percentage).Build();
        }
        public Student GetCollegeStudentObj(int id, string name, double cgpa)
        {
            return Student.GetBuilder().SetId(id).SetName(name).SetCGPA(cgpa).Build();
        }
    }
}
