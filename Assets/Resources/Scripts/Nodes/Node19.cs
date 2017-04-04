using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node19 : Node
{

    private int thisNode = 19;
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
        //if (!thisLock || (currentNode == 13 && !Locks[13]) || (currentNode == 20 && !Locks[20]) || (currentNode == 23 && !Locks[23]) || (currentNode == 24 && !Locks[24]) || (currentNode == 25 && !Locks[25]))
        if ((currentNode == 13 && (!thisLock || !Locks[13])) || (currentNode == 20 && (!thisLock || !Locks[20])) || (currentNode == 23 && (!thisLock || !Locks[23])) || (currentNode == 24 && (!thisLock || !Locks[24])) || (currentNode == 25 && (!thisLock || !Locks[25])))
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
