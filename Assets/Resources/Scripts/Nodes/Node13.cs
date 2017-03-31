using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node13 : MonoBehaviour
{
    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock13");
        node = GameObject.FindGameObjectWithTag("Node13");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 13 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 13)
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
        // if (!locked || (PlayerUI.currentNode == 08 && !Node08.locked) || (PlayerUI.currentNode == 09 && !Node09.locked) || (PlayerUI.currentNode == 15 && !Node15.locked) || (PlayerUI.currentNode == 17 && !Node17.locked) || (PlayerUI.currentNode == 19 && !Node19.locked))
        if (!locked || !Node08.locked || !Node09.locked || !Node15.locked || !Node17.locked || !Node19.locked)
        {
            PlayerUI.currentNode = 13;
            PlayerUI.open = false;
        }
    }
}
