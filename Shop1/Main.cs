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
        Store.BuyItem(player, mossa);
        Store.BuyItem(player, gurka);
        Store.BuyItem(player, bulle);

        Console.WriteLine($"Nu har du {player.money} kronor kvar. Tack för ditt köp!");
        
    


        Console.ReadLine();
    }
}
