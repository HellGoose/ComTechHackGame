using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node20 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock20");
        node = GameObject.FindGameObjectWithTag("Node20");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 20 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 20)
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
        if ((PlayerUI.currentNode == 15 && !Node15.locked) || (PlayerUI.currentNode == 19 && !Node19.locked) || (PlayerUI.currentNode == 25 && !Node25.locked))
        {
            PlayerUI.currentNode = 20;
            PlayerUI.open = false;
        }
    }
}
