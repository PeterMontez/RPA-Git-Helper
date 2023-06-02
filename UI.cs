public static class UI
{
    public static byte ReadKey()
    {
        ConsoleKeyInfo cki;
        cki = Console.ReadKey();
        return Convert.ToByte(cki.Key);
    }

    public static void MainMenuPrint()
    {
        System.Console.WriteLine
        (""" 
               CHOOSE AN ACTION
        ------------------------------
        1 - REGISTER FOLDER
        2 - REMOVE FOLDER
        3 - UPDATE
        4 - LOAD TO DATABASE
        5 - PULL EVERYTHING
        ------------------------------
        """);
    }

    public static void MainMenu()
    {
        MainMenuPrint();
        ReadKey();
    }

}