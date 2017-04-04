using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIController : MonoBehaviour {

    private int currentLock;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        currentLock = Node.currentNode;
    }

    public void Unlock()
    {
        
        Node.Locks[currentLock] = false;
    }

    public void Lock()
    {
        Node.Locks[currentLock] = true;
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
