public class FolderManager
{
    public void Add(string path)
    {
        Paths.AddPath(path);
    }

    public void Remove(string path)
    {
        Paths.RemovePath(path);
    }
}
