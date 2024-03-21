using System;


public class Player
{
    public int money { get; set; }

    public Inventory inventory;
    public Player(int money)
    {
        this.money = money;
        inventory = new();
    }
}