using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node05 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock05");
        node = GameObject.FindGameObjectWithTag("Node05");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 05 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 05)
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
        // if (!locked || (PlayerUI.currentNode == 04 && !Node04.locked) || (PlayerUI.currentNode == 09 && !Node09.locked))
        if (!locked || !Node04.locked || !Node09.locked)
        {
            PlayerUI.currentNode = 05;
            PlayerUI.open = false;
        }
    }
}
