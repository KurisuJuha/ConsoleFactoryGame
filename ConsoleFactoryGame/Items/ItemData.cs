namespace KYapp.ConsoleFactoryGame.Items;

public static class Items
{
    public static List<Item> ItemData = new List<Item>();

    public static void Init()
    {
        ItemData.Add(new TestItem());
    }
}

public abstract class Item
{
    public string name;
    public Structure Structure;
    public List<Item> Recipe = new List<Item>();
    public string Info;
}

public abstract class Structure
{
    public Item Item;
}