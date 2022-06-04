namespace KYapp.ConsoleFactoryGame.Commands;

public static partial class Commands
{
    public static void HelpCommand(string[] param)
    {
        Console.WriteLine(
@"このゲームはコンソール画面上で動く自動化ゲームです。"
        );
    }
}