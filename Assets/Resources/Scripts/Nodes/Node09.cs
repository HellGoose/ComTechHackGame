using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node09 : Node
{
    private int thisNode = 9;
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
        if (!thisLock || (currentNode == 4 && !Locks[4]) || (currentNode == 5 && !Locks[5]) || (currentNode == 8 && !Locks[8]) || (currentNode == 13 && !Locks[13]) || (currentNode == 15 && !Locks[15]))
        {
            currentNode = thisNode;
        }
    }

    public void OnMouseOver()
    {
        currentModule = thisNode;
        currentLevel = thisLevel;
    }
}
