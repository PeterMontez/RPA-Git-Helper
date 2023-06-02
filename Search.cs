using System;
using System.IO;

var ls = Directory.EnumerateDirectories("..//ORMLib");

foreach (var dir in ls)
    Console.WriteLine(dir);

System.Console.WriteLine(ls.ElementAt(1));