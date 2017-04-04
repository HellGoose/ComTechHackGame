using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node13 : Node
{

    private int thisNode = 13;
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
        //if (!thisLock || (currentNode == 8 && !Locks[8]) || (currentNode == 9 && !Locks[9]) || (currentNode == 15 && !Locks[15]) || (currentNode == 17 && !Locks[17]) || (currentNode == 19 && !Locks[19]))
        if ((currentNode == 8 && (!thisLock || !Locks[8])) || (currentNode == 9 && (!thisLock || !Locks[9])) || (currentNode == 15 && (!thisLock || !Locks[15])) || (currentNode == 17 && (!thisLock || !Locks[17])) || (currentNode == 19 && (!thisLock || !Locks[19])))
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
