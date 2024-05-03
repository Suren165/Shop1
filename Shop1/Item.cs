using System;
public class Item
{
    public string name { get; set; }
    public int price { get; set; }
    public Item(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

}

public class Bannan : Item //arv
{
    public Bannan(string name, int price) : base(name, price)      //Konstruktor som tar emot egenskaperna int price och int name. Och pinne under är exakt samma sak.
    {

    }
}

public class Pinne : Item
{
    public Pinne(string name, int price) : base(name, price)
    {
    }
}