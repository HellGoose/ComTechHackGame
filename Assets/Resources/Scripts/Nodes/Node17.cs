using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node17 : Node
{

    public static bool locked;
    private int thisNode = 17;

    // Use this for initialization
    void Start()
    {
        nodeRen = "Node" + thisNode.ToString();
        lockRen = "Lock" + thisNode.ToString();


        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        nodeLock = GameObject.FindGameObjectWithTag(lockRen);
        node = GameObject.FindGameObjectWithTag(nodeRen);

        node.GetComponent<Renderer>().material.color = Color.black;

        if (currentNode == thisNode && PlayerUI.open)
        {
            locked = false;
        }
        else
        {
            locked = true;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.white;
        }

        if (currentNode == thisNode)
        {
            node.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            node.GetComponent<Renderer>().material.color = Color.black;
        }
    }


    private void OnMouseDown()
    {
        if (!locked || (currentNode == 11 && !Node11.locked) || (currentNode == 12 && !Node12.locked) || (currentNode == 13 && !Node13.locked) || (currentNode == 21 && !Node21.locked) || (currentNode == 22 && !Node22.locked) || (currentNode == 23 && !Node23.locked))
        //if (!locked || !Node11.locked || !Node12.locked || !Node13.locked || !Node21.locked || !Node22.locked || !Node23.locked)
        {
            currentNode = thisNode;
            PlayerUI.open = false;
        }
    }
}
