using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node01 : MonoBehaviour {

    // Use this for initialization
    void Start ()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 01)
        {
            gameObject.GetComponent<Renderer>().material.color = PlayerUI.color;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }


    }

    private void OnMouseDown()
    {
        if (PlayerUI.currentNode == 02 || PlayerUI.currentNode == 06)
        {
            PlayerUI.currentNode = 01;
        }
    }
}
