

public class Inventory
{
    public List<Item> itemsInInventory = new List<Item>();

    public void AddToInventory(Item item)
    {
        itemsInInventory.Add(item);
    }
}