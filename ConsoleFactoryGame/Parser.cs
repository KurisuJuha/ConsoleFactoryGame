namespace KYapp.ConsoleFactoryGame;

public static class Parser
{
    public static Dictionary<string, Action<string[]>> Commands = new Dictionary<string, Action<string[]>>();

    public static void Parse(string command)
    {
        string[] _command = Split(command);
        Action<string[]> action;

        if (_command.Length < 1) return;


        if (Commands.TryGetValue(_command[0], out action))
        {
            action(_command[1.._command.Length]);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("CommandError");
            Console.ResetColor();
        }
    }

    public static string[] Split(string command)
    {
        return command.Split(' ');
    }
}