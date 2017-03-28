using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node09 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock09");
        node = GameObject.FindGameObjectWithTag("Node09");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 09 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 09)
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
        if ((PlayerUI.currentNode == 04 && !Node04.locked) || (PlayerUI.currentNode == 05 && !Node05.locked) || (PlayerUI.currentNode == 08 && !Node08.locked) || (PlayerUI.currentNode == 13 && !Node13.locked) || (PlayerUI.currentNode == 15 && !Node15.locked))
        {
            PlayerUI.currentNode = 09;
            PlayerUI.open = false;
        }
    }
}
