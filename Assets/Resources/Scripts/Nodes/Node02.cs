using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node02 : MonoBehaviour {

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start ()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock02");
        node = GameObject.FindGameObjectWithTag("Node02");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 02 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 02)
        {
            node.GetComponent<Renderer>().material.color = PlayerUI.color;
        }
        else
        {
            node.GetComponent<Renderer>().material.color = Color.black;
        }


    }

    private void OnMouseDown()
    {
        if ((PlayerUI.currentNode == 01 && !Node01.locked)|| (PlayerUI.currentNode == 08 && !Node08.locked) || (PlayerUI.currentNode == 12 && !Node12.locked))
        {
            PlayerUI.currentNode = 02;
            PlayerUI.open = false;
        }
    }
}
