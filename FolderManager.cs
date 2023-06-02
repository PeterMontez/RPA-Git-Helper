public class FolderManager
{
    public void Add()
    {
        
        ConsoleKeyInfo cki;
        cki = Console.ReadKey();
        Convert.ToByte(cki.Key);
        Paths.AddPath(path);
    }

    public void Remove()
    {
        Paths.RemovePath(path);
    }
}
