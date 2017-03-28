using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour {

    public static int currentModule;
    

	// Use this for initialization
	void Start () {
        if (PlayerUI.currentNode < 10)
        {
            currentModule = 0;
        }
        else if (PlayerUI.currentNode < 20)
        {
            currentModule = 1;
        }
        else
        {
            currentModule = 2;
        }
		
	}
	
	// Update is called once per frame
	void Update () {




		
		
	}
}
