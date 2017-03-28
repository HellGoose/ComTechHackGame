using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    public static int currentNode;
    public static int currentModule;
    public static bool open = false;
    public static Color color;
    public int player;

    // Use this for initialization
    void Start () {

        if (player == 1)
        {
            currentNode = 01;
            color = Color.red;
        }
        else if (player == 2)
        {
            currentNode = 05;
            color = Color.blue;
        }
        else if (player == 3)
        {
            currentNode = 21;
            color = Color.green;
        }
        else if (player == 4)
        {
            currentNode = 25;
            color = Color.yellow;
        }

        open = false;


    }
	
	// Update is called once per frame
	void Update () {

        if (currentNode < 10)
        {
            currentModule = 1;
        }
        else if (currentNode < 20)
        {
            currentModule = 2;
        }
        else
        {
            currentModule = 3;
        }


    }



}
