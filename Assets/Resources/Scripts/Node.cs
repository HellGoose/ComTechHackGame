using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	private bool locked;
	private bool key;

	// Use this for initialization
	void Start () {

		locked = true;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void unlock() {
		if (key = true ) {
			locked = false; 
		}
	}
}
