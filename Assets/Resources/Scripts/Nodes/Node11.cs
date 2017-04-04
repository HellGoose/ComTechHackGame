﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node11 : Node
{

    public static bool locked;
    private int thisNode = 11;

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
        if (!locked || (currentNode == 06 && !Node06.locked) || (currentNode == 12 && !Node12.locked) || (currentNode == 17 && !Node17.locked))
        //if (!locked || !Node06.locked || !Node12.locked || !Node17.locked)
        {
            currentNode = thisNode;
            PlayerUI.open = false;
        }
    }
}
