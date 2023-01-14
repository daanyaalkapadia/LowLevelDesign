namespace LowLevelDesign.Builder
{
    internal class Client
    {
        static void BuilderMain(string[] args)
        {
            //Implementation 2
            StudentDirector studentDirector = new StudentDirector();
            Student schoolStudent1 = studentDirector.GetSchoolStudentObj(1, "dk", 80.8);
            Student collegeStudent1 = studentDirector.GetCollegeStudentObj(1, "dk", 7.8);

            //Implementation 1
            Student schoolStudent2 = Student.GetBuilder().SetId(1).SetName("Daanyaal").SetPercentage(50.5).Build();
            Student collegeStudent2 = Student.GetBuilder().SetId(1).SetName("Daanyaal").SetCGPA(8.1).Build();
            //Error in below line
            //schoolStudent.Rank = 1;
            Console.WriteLine("CGPA :" + collegeStudent1.CGPA.ToString());
            Console.WriteLine("Percentage :" + schoolStudent1.Percentage.ToString());

            Console.WriteLine("CGPA :" + collegeStudent2.CGPA.ToString());
            Console.WriteLine("Percentage :" + schoolStudent2.Percentage.ToString());
        }
    }
}
