using System;

class Main
{
    public void RunGame()
    {
        Player player = new Player(100);

        Item mossa = new Item("Mössa", 50);
        Item gurka = new Item("Gurka", 20);
        Item bulle = new Item("Bulle", 30);

        Console.WriteLine($"Välkommen Till Butiken! Du har {player.money} kronor.");
        // Store.BuyItem(player, mossa);
        // Store.BuyItem(player, gurka);
        // Store.BuyItem(player, bulle);

        Console.WriteLine("Vad vill du köpa kompis!");
        Console.WriteLine($"1.{mossa.name} som kostar {mossa.price} kronor");
        Console.WriteLine($"2.{gurka.name} som kostar {gurka.price} kronor");
        Console.WriteLine($"3.{bulle.name} som kostar {bulle.price} kronor");

        Console.WriteLine("Köp något du vill ha genom att ange villet nummer");

        string val = Console.ReadLine();

        if (val == "1")
        {
            Store.BuyItem(player, mossa);
        }
        else if (val == "2")
        {
            Store.BuyItem(player, gurka);
        }
        else if (val == "3")
        {
            Store.BuyItem(player, bulle);
        }
        
        






        // Console.WriteLine($"Nu har du {player.money} kronor kvar. Tack för ditt köp!");




                Console.ReadLine();
    }
}
