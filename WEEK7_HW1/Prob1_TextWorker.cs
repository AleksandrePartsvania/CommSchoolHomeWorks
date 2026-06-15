namespace WEEK7_HW1;

public class Prob1_TextWorker : Prob1_FileWorker
{
    public override string FileExtension { get => "txt"; set; }

    public Prob1_TextWorker(int maxStorage) : base(maxStorage)
    {
    }
    
    public override void Write()
    {
        Console.WriteLine($"I Can write to {FileExtension} file with max storage {MaxStorage}");
    }
    public override void Read()
    {
        Console.WriteLine($"I Can read from {FileExtension} file with max storage {MaxStorage}");
    }
    public override void Delete()
    {
        Console.WriteLine($"I Can delete from {FileExtension} file with max storage {MaxStorage}");
    }
    public override void Edit()
    {
        Console.WriteLine($"I Can edit{FileExtension} file with max storage {MaxStorage}");
    }
}