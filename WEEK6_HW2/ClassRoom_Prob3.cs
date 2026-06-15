namespace WEEK6_HW2;

public class ClassRoom_Prob3
{
    public List<Student_Prob3> Students = new List<Student_Prob3>();

    public ClassRoom_Prob3( Student_Prob3[] students)
    {
        foreach (var item in students)
        {
            Students.Add(item);
        }
    }

    public void AllStudentMethods()
    {
        foreach (var student in Students)
        {
            Console.WriteLine($"{student.Name}");
            student.Study();
            student.Read();
            student.Write();
            student.Relax();
        }
    }
    
}