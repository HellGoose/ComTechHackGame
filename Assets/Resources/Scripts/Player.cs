using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    private string name;
    private List<Object> inventory;
    public static int currentNode;

    void Start()
    {
        currentNode = 01;
    }

    //Model for the player. Add stuff as you need it :)
    public Player(string name)
    {
        this.name = name;
        inventory = new List<Object>();
    }

    public void changeName(string name) { this.name = name; }
    public string getName() { return name; }

    public void addItem(Object item) { inventory.Add(item); }
    public bool removeItem(Object item) { return inventory.Remove(item); }
    public List<Object> getInventory() { return inventory; }
    //The null should be change to new whateverClass() with out of bounds info, for less frustration :)
    public Object getItemAt(int i) { return i < inventory.Count ? inventory[i] : null; }

    
}
