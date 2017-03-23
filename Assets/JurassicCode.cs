using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Jurassic;
using Jurassic.Library;
using UnityEngine.UI;

public class JurassicCode : MonoBehaviour {
    ScriptEngine engine;
    string codetext;
    string tempConsoleText;
    string fullConsoleText;
    public InputField input;
    public Text console;
    public RectTransform ConsoleContent;
    public RectTransform InputContent;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void Awake()
    {
        engine = new ScriptEngine();
        engine.EnableExposedClrTypes = true;
        engine.SetGlobalValue("console", new Jurassic.Library.FirebugConsole(engine));
        engine.SetGlobalFunction("test", new System.Func<string>(jsTest));
        //engine.SetGlobalFunction("console", new System.Action<string>(doStuff));
    }
   
    public string jsTest()
    {
        doStuff();
        return "";
    }
  
    
    public void runJS()
    {
        codetext = input.text;
        try{
            engine.Execute(codetext);
        }catch(Exception e)
        {
            tempConsole(e.Message);
            writeToConsole();
        }
        
    }
    private void doStuff()
    {
        Debug.Log("IT IS working");
       
      
    }


    private void tempConsole(string log)
    {
        tempConsoleText = log+"\n";
    }
    private void writeToConsole()
    {
        fullConsoleText += tempConsoleText;
        console.text = fullConsoleText;
        float heightAdjustment = console.preferredHeight;
        ConsoleContent.sizeDelta = new Vector2(ConsoleContent.sizeDelta.x, ConsoleContent.sizeDelta.y+heightAdjustment);
    }
    public void clearConsole()
    {
        tempConsoleText = "";
        fullConsoleText = "";
        console.text = "";
        ConsoleContent.sizeDelta = new Vector2(458, 250);
    }
}
