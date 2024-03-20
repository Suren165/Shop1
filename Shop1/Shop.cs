using System;

class program
{
    public static void Butik()
    {
        Player player = new Player(100);

        Item item1 = new Item("Mössa", 50);
        Item item2 = new Item("Gurka", 20);
        Item item3 = new Item("Bulle", 30);

        Console.WriteLine($"Välkommen Till Butiken! Du har {player.Money} kronor.");
         Store.BuyItem(player, item1);
        Store.BuyItem(player, item2);
        Store.BuyItem(player, item3);

        Console.WriteLine($"Nu har du {player.Money} kronor kvar. Tack för ditt köp!");
    
        Console.ReadLine();
    }


}
