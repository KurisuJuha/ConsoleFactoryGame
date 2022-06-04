using System.ComponentModel;

namespace KYapp.ConsoleFactoryGame.Commands;

public static partial class Commands
{
    public static void InfoCommand(string[] param)
    {
        foreach (var item in Items.Items.ItemData)
        {
            if (item.name == param[0])
            {
                Console.WriteLine(item.Info);
                return;
            }
        }
        
        Console.WriteLine("\"" + param[0] + "\"" + "というnameのアイテムは見つかりませんでした。");
    }
}