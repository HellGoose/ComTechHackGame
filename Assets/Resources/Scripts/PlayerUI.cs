using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

	//static Sprite player;
	public static float x = -5;
	public static float y = 0;
	public Vector3 position = new Vector3(x, y, 0);
	public static bool locked;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) && (x <= 0)) {
			x += 5;
			transform.position = new Vector3(x, y, 0);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && (x >= 0)) {
			x -= 5;
			transform.position = new Vector3(x, y, 0);
		}


}
