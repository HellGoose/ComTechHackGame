﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node17 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 17)
        {
            gameObject.GetComponent<Renderer>().material.color = PlayerUI.color;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }


    }

    private void OnMouseDown()
    {
        if (PlayerUI.currentNode == 11 || PlayerUI.currentNode == 12 || PlayerUI.currentNode == 13 || PlayerUI.currentNode == 21 || PlayerUI.currentNode == 22 || PlayerUI.currentNode == 23)
        {
            PlayerUI.currentNode = 17;
        }
    }
}
