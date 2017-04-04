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
    private int lastLevel;
    private int lastNode;

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
    }

    private void useItem()
    {
        if ((Node.Locks[Node.currentNode]) && (moduleName.text.Equals("decrypt()")))
        {
            if (Node.currentLevel.ToString().Equals(moduleLevel.text))
            {
                lastNode = Node.currentNode;
                lastLevel = Node.currentLevel;
                Node.Locks[Node.currentNode] = false;
                inventory.removeItem(module);
            }

        }
        else if (!Node.Locks[lastNode] && moduleName.text.Equals("encrypt()"))
        {
            if (lastLevel.ToString().Equals(moduleLevel.text))
            {
                Node.Locks[lastNode] = true;
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
