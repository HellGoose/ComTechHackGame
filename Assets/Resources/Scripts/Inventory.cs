using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour {
    private Module[] modules = new Module[numberOfItemSlots];
    private GameObject[] itemSlots = new GameObject[numberOfItemSlots];
    private const int numberOfItemSlots = 6;

    // Use this for initialization
    void Start()
    {
        itemSlots = GameObject.FindGameObjectsWithTag("ItemSlot");
    }

    public void addItem(Module module) {
        for (int i = 0; i < modules.Length; i++)
        {
            if (modules[i] == null)
            {
                modules[i] = module;
                itemSlots[numberOfItemSlots - i - 1].GetComponent<InventorySlot>().setItem(module);
                return;
            }
        }
    }

    public void removeItem(Module module)
    {
        for (int i = 0; i < modules.Length; i++)
        {
            if (modules[i] == module)
            {
                modules[i] = null;
                itemSlots[numberOfItemSlots - i - 1].GetComponent<InventorySlot>().setItem(null);
                return;
            }
        }
    }
}
