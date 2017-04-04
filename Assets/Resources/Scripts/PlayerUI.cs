using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

//    public static int currentNode;
    public static int currentModule;
    public static bool open;
    public static Color color;
    public static int player;

    // Use this for initialization
    void Start () {

        player = 1;

        if (player == 1)
        {
            Node.currentNode = 1;
            color = Color.red;
        }
        else if (player == 2)
        {
            Node.currentNode = 0;
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

        open = false;


    }
	
	// Update is called once per frame
	void Update () {

        if (Node.currentNode < 10)
        {
            currentModule = 1;
        }
        else if (Node.currentNode < 20)
        {
            currentModule = 2;
        }
        else
        {
            currentModule = 3;
        }


    }



}
