using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    private List<InventoryItem> inventory;

	// Use this for initialization
	void Start () {
        inventory = new List<InventoryItem>();
	}
	
	// Update is called once per frame
	void Update () {
        drawItems();
	}

    private void drawItems()
    {

    }

    public void addItem(InventoryItem item) { inventory.Add(item); }
    public bool removeItem(InventoryItem item) { return inventory.Remove(item); }
    public InventoryItem getItemAt(int i) { return i < inventory.Count ? inventory[i] : null; }
}
