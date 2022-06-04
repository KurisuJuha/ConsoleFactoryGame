namespace KYapp.ConsoleFactoryGame.Commands;

public static partial class Commands
{
    public static void Init()
    {
        Parser.Commands.Add("help", HelpCommand);
        Parser.Commands.Add("info", InfoCommand);
    }
}