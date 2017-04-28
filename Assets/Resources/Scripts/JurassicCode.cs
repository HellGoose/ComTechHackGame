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
    private Inventory inventory;
    // Use this for initialization
    void Start () {
       // inventory = GameObject.Find("CodeWriter/Canvas/inventory").GetComponent<Inventory>();
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
        engine.SetGlobalFunction("help", new System.Action(help));
        engine.SetGlobalFunction("decrypt", new System.Action<int>(addDecrypt));
        engine.SetGlobalFunction("encrypt", new System.Action<int>(addEncrypt));
        engine.SetGlobalFunction("stopTrace", new System.Action<int>(addStopTrace));
        engine.SetGlobalFunction("proxy", new System.Action<int>(addProxy));
        engine.SetGlobalFunction("node1", new System.Action<System.Object>(node1));
        engine.SetGlobalFunction("node2", new System.Action<System.Object>(node2));
        engine.SetGlobalFunction("node3", new System.Action<System.Object>(node3));
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
    public void resetInputfield()
    {
        input.text = "";
    }

    public void addDecrypt(int lvl)
    {
       
        inventory.addItem(new Decrypt(lvl));
    }
    public void addEncrypt(int lvl)
    {

        inventory.addItem(new Encrypt(lvl));
    }
    public void addStopTrace(int lvl)
    {

        inventory.addItem(new stopTrace(lvl));
    }
    public void addProxy(int lvl)
    {

        inventory.addItem(new Proxy(lvl));
    }
    public void node1(System.Object obj)
    {
        if (obj != null && obj is string &&(string)obj!="")
        {
            consoleLog("Task Successfully completed");
            consoleLog("Welcome to HAC-Man : " + obj);
        }else { 
        consoleLog("Task Failed try again.");
        }
    }
    public void node2(System.Object obj)
    {
        if (obj != null&& Convert.ToInt32(obj)==12)
        {
            consoleLog("Task Successfully completed");
        }
        else
        {
            consoleLog("Task Failed try again.");
            consoleLog("The number you submitted was : "+obj);
        }
      

    }
    public void node3(System.Object obj)
    {
        if ((bool)obj == true)
        {
            consoleLog("Task Successfully completed");
        }else
        {
            consoleLog("Task Failed try again.");
        }
    }
}

