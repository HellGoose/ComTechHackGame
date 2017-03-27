using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour {

	public static GameObject nodeLock;
	public static bool locked;
	public static bool key;

	// Use this for initialization
	void Start () {
		nodeLock = GameObject.FindGameObjectWithTag("Lock0");
		key = true;
		locked = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.K) && (key == true)) {
			nodeLock.SetActive (false);
			locked = false;
		}
		
		
	}
}
