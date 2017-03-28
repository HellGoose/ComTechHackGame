using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node23 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock23");
        node = GameObject.FindGameObjectWithTag("Node23");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 23 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 23)
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
        if ((PlayerUI.currentNode == 17 && !Node17.locked) || (PlayerUI.currentNode == 19 && !Node19.locked) || (PlayerUI.currentNode == 22 && !Node22.locked) || (PlayerUI.currentNode == 24 && !Node24.locked))
        {
            PlayerUI.currentNode = 23;
            PlayerUI.open = false;
        }
    }
}
