using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmentscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

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
