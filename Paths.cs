    using System.Collections.Generic;

public static class Paths
{
    private static List<string> paths = new();
    private static List<string> repos = new();

    public static List<string> GetPaths() => paths;
    public static List<string> GetRepos() => repos;

    public static void AddPath(string path) => paths.Add(path);

    public static void AddRepo(string repo) => repos.Add(repo);
    public static void RemovePath()
    {
        int count = 01;
        System.Console.WriteLine("Wich folder do you want to remove?\n");
        foreach (var item in paths)
            System.Console.WriteLine($"{count++} - {item} {((count == paths.Count())? "\n> " : "")}");

        byte choice = UI.ReadKey();
    }


    public static void RemoveRepo(string repo)
    {

    }

}