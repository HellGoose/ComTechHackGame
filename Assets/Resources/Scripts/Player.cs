using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    private string name;
    private List<Object> inventory;

    //Model for the player. Add stuff as you need it :)
    public Player(string name)
    {
        this.name = name;
        inventory = new List<Object>();
    }

    public void changeName(string name) { this.name = name; }

    public void addItem(Object item){ inventory.Add(item); }
    public bool removeItem(Object item){ return inventory.Remove(item); }

    
}
