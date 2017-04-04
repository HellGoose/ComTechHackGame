﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node01 : Node {

    private int thisNode = 1;
    private bool thisLock;
    private int thisLevel = 1;

    // Use this for initialization
    void Start ()
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

        

        if (thisLock == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.white;
        }

        if (currentNode != thisNode)
        {
            node.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    private void OnMouseDown()
    {
        if (!thisLock || (currentNode == 2 && !Locks[2]) || (currentNode == 6 && !Locks[6]))
        {
            currentNode = thisNode;
            currentLevel = thisLevel;

        }
    }

}
