using System;

class Main
{
    public void RunGame()
    {
        Player player = new Player(100);

        List<Item> itemsInStore = new List<Item>();
        itemsInStore.Add(new Item("Mössa", 50));
        itemsInStore.Add(new Item("Gurka", 20));
        itemsInStore.Add(new Item("Bulle", 30));

        Console.WriteLine($"Välkommen Till Butiken! Du har {player.money} kronor.");

        Console.WriteLine("Vad vill du köpa kompis!");


        for (int i = 0; i < itemsInStore.Count; i++)
            Console.WriteLine($"{i + 1}.{itemsInStore[i].name} som kostar {itemsInStore[i].price} kronor");
        

        Console.WriteLine("Köp något du vill ha genom att ange villket nummer");

       

        string val = Console.ReadLine();
        int result = Int32.Parse(val);

        if (result > itemsInStore.Count || result <= 0) 
            Console.WriteLine("Oj då, försök att skriva ett nummer");
        
        else
        {
            Store.BuyItem(player, itemsInStore[result - 1]); //result - 1 innebär indexet i listan. När spelarens input är 1, så returnerar den det första elementet i listan, alltså 0
            Console.WriteLine($"Du har nu {player.money} kronor kvar. Tack för ditt köp!");
        }
        Console.ReadLine();
    }
}
