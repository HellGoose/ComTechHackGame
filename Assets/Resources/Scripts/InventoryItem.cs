using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour {
    private Module module;

    public InventoryItem(Module module)
    {
        this.module = module;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string getName() { return module.getName(); }
    public int getLevel() { return module.getLevel(); }

}
