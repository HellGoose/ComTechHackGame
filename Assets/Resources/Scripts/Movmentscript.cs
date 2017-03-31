using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Movmentscript : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Makes sure that you are not trying to control other players
        if(!isLocalPlayer)
        {
            return;
        }

        // simple mouse controlls 
        float x = 0.0f;
        float y = 0.0f;
        float speed = 0.1f;
        float h = speed * Input.GetAxis("Mouse X");
        float v = speed * Input.GetAxis("Mouse Y");
        transform.Translate(h, v, 0);

        if (Input.GetKeyDown("up"))
        {
            y = Time.deltaTime * speed;
        }
        if (Input.GetKeyDown("down"))
        {
            y = -Time.deltaTime * speed;
        }
        if (Input.GetKeyDown("left"))
        {
            x = -Time.deltaTime * speed;
        }
        if (Input.GetKeyDown("right"))
        {
            x = Time.deltaTime * speed;
        }
        
        transform.Translate(x , y, 0);
    }
}
