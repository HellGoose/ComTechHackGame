using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node13 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerUI.currentNode == 13)
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
        if (PlayerUI.currentNode == 08 || PlayerUI.currentNode == 09 || PlayerUI.currentNode == 15 || PlayerUI.currentNode == 17 || PlayerUI.currentNode == 19)
        {
            PlayerUI.currentNode = 13;
        }
    }
}
