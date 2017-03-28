using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node17 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock17");
        node = GameObject.FindGameObjectWithTag("Node17");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 17 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 17)
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
        //if (!locked || (PlayerUI.currentNode == 11 && !Node11.locked) || (PlayerUI.currentNode == 12 && !Node12.locked) || (PlayerUI.currentNode == 13 && !Node13.locked) || (PlayerUI.currentNode == 21 && !Node21.locked) || (PlayerUI.currentNode == 22 && !Node22.locked) || (PlayerUI.currentNode == 23 && !Node23.locked))
        if (!locked || !Node11.locked || !Node12.locked || !Node13.locked || !Node21.locked || !Node22.locked || !Node23.locked)
        {
            PlayerUI.currentNode = 17;
            PlayerUI.open = false;
        }
    }
}
