using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node22 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock22");
        node = GameObject.FindGameObjectWithTag("Node22");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 22 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 22)
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
        // if (!locked || (PlayerUI.currentNode == 17 && !Node17.locked) || (PlayerUI.currentNode == 21 && !Node21.locked) || (PlayerUI.currentNode == 23 && !Node23.locked))
        if (!locked || !Node17.locked || !Node21.locked || !Node23.locked)
        {
            PlayerUI.currentNode = 22;
            PlayerUI.open = false;
        }
    }
}
