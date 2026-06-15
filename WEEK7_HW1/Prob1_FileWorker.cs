namespace WEEK7_HW1;

public abstract class Prob1_FileWorker
{
    public int MaxStorage { get; set; }
    
    public abstract string FileExtension { get; set; }

    public Prob1_FileWorker(int maxStorage)
    {
        MaxStorage = maxStorage;
    }
    
    public abstract void Read();
    public abstract void Write();
    public abstract void Edit();
    public abstract void Delete();
}