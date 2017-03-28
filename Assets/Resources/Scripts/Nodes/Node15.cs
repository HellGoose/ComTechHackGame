using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node15 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock15");
        node = GameObject.FindGameObjectWithTag("Node15");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 15 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 15)
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
        if ((PlayerUI.currentNode == 09 && !Node09.locked) || (PlayerUI.currentNode == 13 && !Node13.locked) || (PlayerUI.currentNode == 20 && !Node20.locked))
        {
            PlayerUI.currentNode = 15;
            PlayerUI.open = false;
        }
    }
}
