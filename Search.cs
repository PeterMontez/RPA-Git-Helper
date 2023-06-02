using System;
using System.IO;

public class Search
{
    public void Run()
    {
        foreach (var path in Paths.GetPaths())
        {
            var ls = Directory.EnumerateDirectories(path);

        }
    }


}

//var ls = Directory.EnumerateDirectories("..//ORMLib");

// foreach (var dir in ls)
//     Console.WriteLine(dir);

// System.Console.WriteLine(ls.ElementAt(1));