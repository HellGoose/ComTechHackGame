﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node09 : Node
{

    public static bool locked;
    private int thisNode = 9;

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
        if (!locked || (currentNode == 04 && !Node04.locked) || (currentNode == 05 && !Node05.locked) || (currentNode == 08 && !Node08.locked) || (currentNode == 13 && !Node13.locked) || (currentNode == 15 && !Node15.locked))
        //if (!locked || !Node04.locked || !Node05.locked || !Node08.locked || !Node13.locked || !Node15.locked)
        {
            currentNode = thisNode;
            PlayerUI.open = false;
        }
    }
}
