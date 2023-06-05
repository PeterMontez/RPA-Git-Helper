using System;
using System.IO;

public class Search
{
    public void Run()
    {
        foreach (var path in Paths.GetPaths())
        {
            FolderInspector(path);

            //;

        }
    }

    private void FolderInspector(string path)
    {
        var ls = Directory.EnumerateDirectories(path);
        foreach (var dir in path)
        {
            if (dir.ToString().Contains(".git"))
            {
                Paths.AddRepo(dir.ToString());
                break;
            }
        }
    }

}

//var ls = Directory.EnumerateDirectories("..//ORMLib");

// foreach (var dir in ls)
//     Console.WriteLine(dir);

// System.Console.WriteLine(ls.ElementAt(1));