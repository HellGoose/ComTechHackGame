using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waiting : MonoBehaviour {
    public Text text;
    private int numofletters;
    private string theText;

	// Use this for initialization
	void Start () {
        updatenumofletters();
        StartCoroutine("animateText");

    }
	
	// Update is called once per frame
	void Update () {

        

    }
    IEnumerator animateText()
    {

        if (text.text.Length < numofletters + 4)
        {
           
            text.text += ".";
            yield return new WaitForSeconds(1);
        }
        else
        {
            text.text = theText;
        }

        StartCoroutine("animateText");
    }
    private void updatenumofletters()
    {
        theText = text.text;
        numofletters = text.text.Length;
    }
}
