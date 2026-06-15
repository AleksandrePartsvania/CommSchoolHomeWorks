namespace WEEK6_HW2;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region Problem2
        var student = new Student_Prob1("ნიკა", 20, 2023);
        var teacher = new Teacher_Prob1("გურამი", true);

        var subject = student.RandomSubject();
        Console.WriteLine($"სტუდენტი: {student.Name}\n");
        Console.WriteLine($"საგანი: {subject}\n");
        
        teacher.CheckSubject(subject);

        Console.WriteLine();

        Console.WriteLine($"უნივერსიტეტის დასრულებამდე დარჩა: {student.YearsLeftToGraduate(student.EnrollementYear)} წელი");
        #endregion
        */

        
        #region Problem3

        Student_Prob3 student1 = new GoodStudent_Prob3("გიორგი");
        var student2 = new LazyStudent_Prob3("ანი");
        var student3 = new GoodStudent_Prob3("სანდრო");
        
        ClassRoom_Prob3 MyClassroom = new ClassRoom_Prob3(new Student_Prob3[] { student1, student2, student3});
        
        MyClassroom.AllStudentMethods();
        #endregion
        
    }
}