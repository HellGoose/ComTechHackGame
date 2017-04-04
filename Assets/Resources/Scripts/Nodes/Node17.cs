﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node17 : Node
{

    private int thisNode = 17;
    private bool thisLock;

    // Use this for initialization
    void Start()
    {
        nodeRen = "Node" + thisNode.ToString();
        lockRen = "Lock" + thisNode.ToString();

        if (!Locks.ContainsKey(thisNode))
        {
            Locks.Add(thisNode, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        thisLock = Locks[thisNode];

        nodeLock = GameObject.FindGameObjectWithTag(lockRen);
        node = GameObject.FindGameObjectWithTag(nodeRen);

        node.GetComponent<Renderer>().material.color = Color.black;

        if (thisLock == false)
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
        if (!thisLock || (currentNode == 11 && !Locks[11]) || (currentNode == 12 && !Locks[12]) || (currentNode == 13 && !Locks[13]) || (currentNode == 21 && !Locks[21]) || (currentNode == 22 && !Locks[22]) || (currentNode == 23 && !Locks[23]))
        {
            currentNode = thisNode;
        }
    }
}
