using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node08 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock08");
        node = GameObject.FindGameObjectWithTag("Node08");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 08 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 08)
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
        // if (!locked || (PlayerUI.currentNode == 02 && !Node02.locked) || (PlayerUI.currentNode == 04 && !Node04.locked) || (PlayerUI.currentNode == 09 && !Node09.locked) || (PlayerUI.currentNode == 12 && !Node12.locked) || (PlayerUI.currentNode == 13 && !Node13.locked))
        if (!locked || !Node02.locked || !Node04.locked || !Node09.locked || !Node12.locked || !Node13.locked)
        {
            PlayerUI.currentNode = 08;
            PlayerUI.open = false;
        }
    }
}
