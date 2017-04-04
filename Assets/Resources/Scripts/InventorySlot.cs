using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IPointerClickHandler {
    private Text moduleName;
    private Text moduleLevel;
    private Module module;
    public static Inventory inventory;

    // Use this for initialization
    void Start () {
        inventory = GetComponentInParent<Inventory>();
        moduleName = GetComponentsInChildren<Text>()[0];
        moduleLevel = GetComponentsInChildren<Text>()[1];
        
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        useItem();
        // test funcionality. Should only remove an item.
        //if (module == null) { inventory.addItem(new Decrypt(1)); }
        //else {
        //inventory.removeItem(module); //}
    }

    private void useItem()
    {
        if (Node.Locks[Node.currentNode]) //&& moduleName.Equals("decrypt()"))
        {
            if (Node.currentLevel == 1) //.ToString().Equals(moduleLevel))
            {
                Node.Locks[Node.currentNode] = false;
                inventory.removeItem(module);
            }

        }
        else if (!Node.Locks[Node.currentNode]) // && moduleName.Equals("encrypt()"))
        {
            if (Node.currentLevel == 1) //.ToString().Equals(moduleLevel))
            {
                Node.Locks[Node.currentNode] = true;
                inventory.removeItem(module);
            }
        }

    }

    public void setItem(Module module)
    {
        this.module = module;
        moduleName.text = "";
        moduleLevel.text = "";
        if (module != null)
        {
            moduleName.text = module.getName();
            moduleLevel.text = module.getLevel().ToString();
        }
    }
}
