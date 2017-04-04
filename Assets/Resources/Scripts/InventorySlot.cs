using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    private Text moduleName;
    private Text moduleLevel;
    private Module module;
    public static Inventory inventory;
    private Vector3 startPostition;

    // Use this for initialization
    void Start () {
        inventory = GetComponentInParent<Inventory>();
        moduleName = GetComponentsInChildren<Text>()[0];
        moduleLevel = GetComponentsInChildren<Text>()[1];
        
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPostition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startPostition;
        if (Node.currentModule == Node.currentNode)
        {
            useItem();
        }
    }

    

    private void useItem()
    {
        if ((Node.Locks[Node.currentModule]) && (moduleName.text.Equals("decrypt()")))
        {
            if (Node.currentLevel.ToString().Equals(moduleLevel.text))
            {
                Node.Locks[Node.currentModule] = false;
                inventory.removeItem(module);
            }

        }
        else if (!Node.Locks[Node.currentModule] && moduleName.text.Equals("encrypt()"))
        {
            if (Node.currentLevel.ToString().Equals(moduleLevel.text))
            {
                Node.Hacks[Node.currentModule] = true;
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
