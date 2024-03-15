using System;

class store
{
    public static void BuyItem(Player player, Item item)
    {
        if (player.Money >= item.price)
        {
            Console.WriteLine($"Du har köpt {item.Name} för {item.price} tack för köpet");
        }
        else
        {

        }
    }
}