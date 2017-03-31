﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node12 : MonoBehaviour
{

    public static bool locked;
    private GameObject nodeLock;
    private GameObject node;

    // Use this for initialization
    void Start()
    {
        nodeLock = GameObject.FindGameObjectWithTag("Lock12");
        node = GameObject.FindGameObjectWithTag("Node12");

        node.GetComponent<Renderer>().material.color = Color.black;
        nodeLock.GetComponent<Renderer>().material.color = Color.white;
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 12 && PlayerUI.open)
        {
            locked = false;
        }

        if (locked == false)
        {
            nodeLock.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (PlayerUI.currentNode == 12)
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
        // if (!locked || (PlayerUI.currentNode == 02 && !Node02.locked) || (PlayerUI.currentNode == 06 && !Node06.locked) || (PlayerUI.currentNode == 08 && !Node08.locked) || (PlayerUI.currentNode == 11 && !Node11.locked) || (PlayerUI.currentNode == 17 && !Node17.locked))
        if (!locked || !Node02.locked || !Node06.locked || !Node08.locked || !Node11.locked || !Node17.locked)
        {
            PlayerUI.currentNode = 12;
            PlayerUI.open = false;
        }
    }
}