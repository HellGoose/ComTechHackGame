using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeChecker : MonoBehaviour {
    public TextAsset defaultText;
    public Text text;
    public InputField input;
    public string[] textLines;
	// Use this for initialization
	void Start () {
        Debug.Log("start");
        if (defaultText != null)
        {
            Debug.Log("Text is not null");
            input.text = defaultText.text;
        }
	}
	
	// Update is called once per frame
	void Update () {
        updateStringArray();
	}
    public void updateStringArray()
    {
        textLines = input.text.Split('\n');
    }
    public bool chechMainSyntaxt()
    {
        for (int i = 0; i < textLines.Length; i++)
        {
            textLines[i].Trim();
            textLines[i].ToLower();
        }
        if (textLines[0] == "Function createModule(){".Trim().ToLower() && textLines[textLines.Length - 1] == "}".Trim().ToLower())
        {
            Debug.Log("Syntax True");
            return true;
        }
        Debug.Log("syntax False");
        Debug.Log(textLines[0] + "\n" + textLines[textLines.Length - 1]);
        return false;

    }
    public void resetText()
    {
        input.text = defaultText.text;
    }
    public void moduleCreator()
    {
        if (chechMainSyntaxt() == true)
        {
            Debug.Log("It worked");
        }
    }
}
