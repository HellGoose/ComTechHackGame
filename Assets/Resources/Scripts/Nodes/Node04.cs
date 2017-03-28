using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node04 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock04");
        node = GameObject.FindGameObjectWithTag("Node04");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 04 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 04)
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
        // if (!locked || (PlayerUI.currentNode == 05 && !Node05.locked) || (PlayerUI.currentNode == 08 && !Node08.locked) || (PlayerUI.currentNode == 09 && !Node08.locked))
        if (!locked || !Node05.locked || !Node08.locked || !Node08.locked)
        {
            PlayerUI.currentNode = 04;
            PlayerUI.open = false;
        }
    }
}