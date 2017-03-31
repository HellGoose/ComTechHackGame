using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node25 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock25");
        node = GameObject.FindGameObjectWithTag("Node25");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 25 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 25)
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
        // if (!locked || (PlayerUI.currentNode == 20 && !Node20.locked) || (PlayerUI.currentNode == 24 && !Node24.locked))
        if (!locked || !Node20.locked || !Node24.locked)
        {
            PlayerUI.currentNode = 25;
            PlayerUI.open = false;
        }
    }
}
