using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node19 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock19");
        node = GameObject.FindGameObjectWithTag("Node19");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 19 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 19)
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
        //if (!locked || (PlayerUI.currentNode == 13 && !Node13.locked) || (PlayerUI.currentNode == 20 && !Node20.locked) || (PlayerUI.currentNode == 23 && !Node23.locked) || (PlayerUI.currentNode == 24 && !Node24.locked) || (PlayerUI.currentNode == 25 && !Node25.locked))
        if (!locked || !Node13.locked || !Node20.locked || !Node23.locked || !Node24.locked || !Node25.locked)
        {
            PlayerUI.currentNode = 19;
            PlayerUI.open = false;
        }
    }
}
