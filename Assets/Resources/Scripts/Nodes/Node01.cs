using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node01 : Node {

    public static bool locked;
    private int thisNode = 1;

    // Use this for initialization
    void Start ()
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
            node.GetComponent<Renderer>().material.color = PlayerUI.color;
        }
        else
        {
            node.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    private void OnMouseDown()
    {
        if (!locked || (currentNode == 02 && !Node02.locked) || (currentNode == 06 && !Node06.locked))
        //if (!locked || !Node02.locked || !Node06.locked)
        {
            currentNode = thisNode;
            PlayerUI.open = false;

        }
    }

}
