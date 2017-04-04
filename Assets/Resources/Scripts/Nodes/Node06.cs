using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node06 : Node
{
    private int thisNode = 6;
    private bool thisLock;
    private int thisLevel = 2;


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
        if (!thisLock || (currentNode == 1 && !Locks[1]) || (currentNode == 11 && !Locks[11]) || (currentNode == 12 && !Locks[12]))
        {
            currentNode = thisNode;
            currentLevel = thisLevel;
        }
    }
}
