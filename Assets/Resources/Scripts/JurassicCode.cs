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
    public TextAsset [] helpText;
    public Text helperText;
    public GameObject helpBox;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void Awake()
    {
        helpBox.SetActive(false);
        engine = new ScriptEngine();
        engine.EnableExposedClrTypes = true;
        engine.SetGlobalFunction("consoleLog", new System.Action<System.Object>(consoleLog));
        engine.SetGlobalFunction("helpUsObi1", new System.Action(help));
    }
   
    public void help()
    {
        int index=new System.Random().Next(0, helpText.Length);
        displayhelp(index);
    }
    public void displayhelp(int index)
    {
        helperText.text = helpText[index].text;
        helpBox.SetActive(true);

    }
    public void dismissHelp()
    {
        helpBox.SetActive(false);
    }

    private void doStuff()
    {
        Debug.Log("IT IS working");


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
    private void consoleLog(System.Object obj)
    {
      
        tempConsole(obj.ToString());
        writeToConsole();
    }
    public  void tempConsole(string log)
    {
        tempConsoleText = log+"\n";
    }
    public void writeToConsole()
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

