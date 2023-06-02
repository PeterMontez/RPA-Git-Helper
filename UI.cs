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
        Act(ReadKey());
    }

    public static void Act(byte choice)
    {
        FolderManager folders = new FolderManager();
        Search updater = new Search();

        switch (choice)
        {
            case 1:
                System.Console.WriteLine("What is the desired PATH to be added?");
                folders.Add();
                break;
            case 2:
                System.Console.WriteLine("What is the desired PATH to be removed?");
                folders.Remove();
                break;
            case 3:
                updater.Run();
                break;
            case 4:
                //DATABASE CODE HERE
                break;
            case 5:
                //CODE PULLER HERE
                break;
            default:
                System.Console.WriteLine("INVALID OPTION!");
                break;
        }
    }

}