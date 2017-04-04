using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour {

    public GameObject nodeLock;
    public GameObject node;
    public string nodeRen;
    public string lockRen;
    public static int currentNode;
    public static int currentLevel;
    public static Dictionary<int, bool> Locks = new Dictionary<int, bool>();



    // Use this for initialization
    void Start () {
        currentLevel = 1;


    }
	
	// Update is called once per frame
	void Update () {



    }


}
