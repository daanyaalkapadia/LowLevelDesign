using static LowLevelDesign.Builder.Student;

namespace LowLevelDesign.Builder
{
    internal interface IStudentBuilder
    {
        StudentBuilder SetName(string name);
        StudentBuilder SetId(int id);
        StudentBuilder SetPercentage(double percentage);
        StudentBuilder SetCGPA(double cgpa);
        Student Build();
    }
}