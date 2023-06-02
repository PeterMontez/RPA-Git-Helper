using System;
using System.IO;

public class Search
{
    public void Run()
    {
        
    }
}

var ls = Directory.EnumerateDirectories("..//ORMLib");

foreach (var dir in ls)
    Console.WriteLine(dir);

System.Console.WriteLine(ls.ElementAt(1));