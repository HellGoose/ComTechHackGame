﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Newscene : MonoBehaviour {
    public int scene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
