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
        addItem(new Decrypt(1));
        addItem(new Encrypt(2));
    }

    public void addItem(Module module) {
        for (int i = 0; i < modules.Length; i++)
        {
            if (modules[i] == null)
            {
                modules[i] = module;
                itemSlots[numberOfItemSlots - i - 1].GetComponentsInChildren<Text>()[0].text = module.getName();
                itemSlots[numberOfItemSlots - i - 1].GetComponentsInChildren<Text>()[1].text = module.getLevel().ToString();
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
                itemSlots[i].GetComponents<Text>()[0].text = "";
                itemSlots[i].GetComponents<Text>()[0].text = "";
                return;
            }
        }
    }
}
