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
    private Inventory inventory;

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
        if (module == null) { inventory.addItem(new Decrypt(1)); }
        else { inventory.removeItem(module); }
    }

    private void useItem()
    {
        //module.use(Somehow find the node, or do it elsewhere);
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
