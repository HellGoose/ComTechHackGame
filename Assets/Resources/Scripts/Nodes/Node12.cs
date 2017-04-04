using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node12 : Node
{

    private int thisNode = 12;
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
        //if (!thisLock || (currentNode == 2 && !Locks[2]) || (currentNode == 6 && !Locks[6]) || (currentNode == 8 && !Locks[8]) || (currentNode == 11 && !Locks[11]) || (currentNode == 17 && !Locks[17]))
        if ((currentNode == 2 && (!thisLock || !Locks[2])) || (currentNode == 6 && (!thisLock || !Locks[6])) || (currentNode == 8 && (!thisLock || !Locks[8])) || (currentNode == 11 && (!thisLock || !Locks[11])) || (currentNode == 17 && (!thisLock || !Locks[17])))
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
