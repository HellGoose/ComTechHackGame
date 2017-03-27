using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkGUIscript : NetworkBehaviour
{
    NetworkIdentity id;
    Text nameText;
    Text secretText;

	// Use this for initialization
	void Start () {
        id = gameObject.GetComponent<NetworkIdentity>();

        Text[] text = GetComponentsInChildren<Text>();

        for(int i = 0; i < text.Length; i++)
        {
            if (text[i].name == "SecretText")
            {
                secretText = text[i];
            }
            if (text[i].name == "PlayerName")
            {
                nameText = text[i];
            }
        }

        if(isLocalPlayer)
        {
            nameText.text = "eyy lamo" + id.name.ToString();
            Debug.Log(id.name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
