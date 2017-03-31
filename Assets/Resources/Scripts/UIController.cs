using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIController : MonoBehaviour {

    public bool key1;
    public bool key2;
    public bool key3;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Unlock()
    {
        if ((PlayerUI.currentModule == 1 && key1) || (PlayerUI.currentModule == 2 && key2) || (PlayerUI.currentModule == 3 && key3))
        {
            PlayerUI.open = true;
        }
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
