using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node08 : Node
{
    private int thisNode = 8;
    private bool thisLock;
    private bool thisHack;
    private int thisLevel = 3;

    // Use this for initialization
    void Start()
    {
        nodeRen = "Node" + thisNode.ToString();
        lockRen = "Lock" + thisNode.ToString();

        if (!Locks.ContainsKey(thisNode))
        {
            Locks.Add(thisNode, true);
        }

        if (!Hacks.ContainsKey(thisNode))
        {
            Hacks.Add(thisNode, false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        thisLock = Locks[thisNode];
        thisHack = Hacks[thisNode];

        nodeLock = GameObject.FindGameObjectWithTag(lockRen);
        node = GameObject.FindGameObjectWithTag(nodeRen);



        if (thisLock)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (!thisLock && !thisHack)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (!thisLock && thisHack)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.grey;
        }

        if (currentNode != thisNode)
        {
            node.GetComponent<Renderer>().material.color = Color.black;
        }
    }


    private void OnMouseDown()
    {
        //if (!thisLock || (currentNode == 2 && !Locks[2]) || (currentNode == 4 && !Locks[4]) || (currentNode == 9 && !Locks[9]) || (currentNode == 12 && !Locks[12]) || (currentNode == 13 && !Locks[13]))
        if ((currentNode == 2 && (!thisLock || !Locks[2])) || (currentNode == 4 && (!thisLock || !Locks[4])) || (currentNode == 9 && (!thisLock || !Locks[9])) || (currentNode == 12 && (!thisLock || !Locks[12])) || (currentNode == 13 && (!thisLock || !Locks[13])))
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
