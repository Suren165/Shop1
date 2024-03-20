using System;

class Store
{
    public static void BuyItem(Player player, Item item)
    {
        if (player.Money >= item.price)
        {
            Console.WriteLine($"Du har köpt {item.Name} för {item.price} kronor.");
        }
        else
        {
            Console.WriteLine("Oj du har inte råd ");

        }
    }
}