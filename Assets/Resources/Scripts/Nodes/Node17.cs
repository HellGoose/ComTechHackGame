using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node17 : Node
{

    private int thisNode = 17;
    private bool thisLock;
    private bool thisHack;
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
        //if (!thisLock || (currentNode == 11 && !Locks[11]) || (currentNode == 12 && !Locks[12]) || (currentNode == 13 && !Locks[13]) || (currentNode == 21 && !Locks[21]) || (currentNode == 22 && !Locks[22]) || (currentNode == 23 && !Locks[23]))
        if ((currentNode == 11 && (!thisLock || !Locks[11])) || (currentNode == 12 && (!thisLock || !Locks[12])) || (currentNode == 13 && (!thisLock || !Locks[13])) || (currentNode == 21 && (!thisLock || !Locks[21])) || (currentNode == 22 && (!thisLock || !Locks[22])) || (currentNode == 23 && (!thisLock || !Locks[23])))
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
