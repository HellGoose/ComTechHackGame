using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node24 : Node
{

    public static bool locked;
    private int thisNode = 24;

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
        if (!locked || (currentNode == 19 && !Node19.locked) || (currentNode == 23 && !Node23.locked) || (currentNode == 25 && !Node25.locked))
        //if (!locked || !Node19.locked || !Node23.locked ||!Node25.locked)
        {
            currentNode = thisNode;
            PlayerUI.open = false;
        }
    }
}
