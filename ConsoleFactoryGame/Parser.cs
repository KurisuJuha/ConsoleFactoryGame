namespace KYapp.ConsoleFactoryGame;

public static class Parser
{
    public static Dictionary<string, Action> Commands = new Dictionary<string, Action>();

    public static void Parse(string command)
    {
        string[] _command = Split(command);
        Action action;

        if (_command.Length < 1) return;


        if (Commands.TryGetValue(_command[0], out action))
        {
            action();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error");
            Console.ResetColor();
        }
    }

    public static string[] Split(string command)
    {
        return command.Split(' ');
    }
    
    
}