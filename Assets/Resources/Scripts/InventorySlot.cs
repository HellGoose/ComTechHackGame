using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IPointerClickHandler {
    private Text moduleName;
    private Text moduleLevel;
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
        throw new NotImplementedException();
    }
}
