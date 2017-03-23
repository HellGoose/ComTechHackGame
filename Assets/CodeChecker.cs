using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Jurassic;
using Jurassic.Library;

public class CodeChecker : MonoBehaviour {
    public TextAsset defaultText;
    public Text text;
    public InputField input;
    public string[] textLines;
    private char[] stringTochar;
    private int leftCurly;
    private int rightCurly;
    private int leftParentc;
    private int rightParentc;
    private List<string> Errors;
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
        stringTochar = input.text.ToCharArray();
    }
    public bool chechMainSyntaxt()
    {
        checkLeftCurly();
        checkRightCurly();
        checkLeftParentc();
        checkRightParentc();
        if (rightParentc != leftParentc || rightCurly != leftCurly)
        {
            Debug.Log("Compiler issue");
            resetValues();
            return false;
        }
        Debug.Log(leftCurly);
        resetValues();
        return true;

    }
    public void setErrors()
    {
        if (rightCurly != leftCurly)
        {
            Errors.Add("Mismatched Brackets");
        }
        if (rightParentc != leftParentc)
        {
            Errors.Add("Mismatched Parentheses");
        }
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
    public void checkLeftCurly()
    {
        for(int i = 0; i < stringTochar.Length; i++)
        {
            if (stringTochar[i]=='{')
            {
                leftCurly++;
            }
        }
       
    }
    public void checkRightCurly()
    {
        for (int i = 0; i < stringTochar.Length; i++)
        {
            if (stringTochar[i] == '}')
            {
                rightCurly++;
            }
        }

    }
    public void checkLeftParentc()
    {
        for (int i = 0; i < stringTochar.Length; i++)
        {
            if (stringTochar[i] == '(')
            {
                leftParentc++;
            }
        }

    }
    public void checkRightParentc()
    {
        for (int i = 0; i < stringTochar.Length; i++)
        {
            if (stringTochar[i] == ')')
            {
                rightParentc++;
            }
        }

    }
    public void resetValues()
    {
        leftCurly = 0;
        rightCurly = 0;
        leftParentc = 0;
        rightParentc = 0;
    }
    
}
