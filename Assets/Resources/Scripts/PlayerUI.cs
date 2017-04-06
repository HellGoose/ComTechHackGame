using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

//    public static int currentNode;
    public static int currentModule;
    public static Color color;
    public static int player;
    private string playerNode;
    private GameObject node;


    // Use this for initialization
    void Start () {

        if (player == 1)
        {
            Node.currentNode = 1;
            color = Color.red;
        }
        else if (player == 2)
        {
            Node.currentNode = 5;
            color = Color.blue;
        }
        else if (player == 3)
        {
            Node.currentNode = 21;
            color = Color.green;
        }
        else if (player == 4)
        {
            Node.currentNode = 25;
            color = Color.yellow;
        }

        

    }
	
	// Update is called once per frame
	void Update () {

        playerNode = "Node" + Node.currentNode.ToString();

        node = GameObject.FindGameObjectWithTag(playerNode);

        node.GetComponent<Renderer>().material.color = color;

    }



}
