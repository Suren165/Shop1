using System;

class Store
{

    public static void BuyItem(Player player, Item item)
    {
        if (player.money >= item.price)
        {
            Console.WriteLine($"Du har köpt {item.name} för {item.price} kronor.");
            player.inventory.AddToInventory(item);
            player.money -= item.price;
        }
        else
        {
            Console.WriteLine("Oj du har inte råd ");
        }
    }
}