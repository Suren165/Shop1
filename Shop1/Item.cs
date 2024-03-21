using System;
public class Item
{
    public string name { get; set; }
    public int price { get; set; }
    public Item(String name, int price)
    {
        this.name = name;
        this.price = price;
    }

}