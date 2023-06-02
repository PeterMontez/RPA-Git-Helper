
public static class UI
{
    public static string path;

    public static byte ReadKey()
    {
        ConsoleKeyInfo cki;
        cki = Console.ReadKey();
        return Convert.ToByte(cki.Key);
    }

    public static void MainMenu()
    {
        System.Console.WriteLine
        (""" 
        ESCOLHA A OPÇÃO 

        

        """);
    }

}