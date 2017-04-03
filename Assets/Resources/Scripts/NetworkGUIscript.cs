using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkGUIscript : MonoBehaviour
{
    private HacManNetworkManager networkManager;
    private Button Host;
    private Button Join;
    private InputField playerName;
    private InputField hostIP;

	// Use this for initialization
	void Start () {
        networkManager = GameObject.FindObjectOfType<HacManNetworkManager>();
        Host = GameObject.Find("HostButton").GetComponent<Button>();
        Join = GameObject.Find("JoinButton").GetComponent<Button>();
        playerName = GameObject.Find("NameInputField").GetComponent<InputField>();
        hostIP = GameObject.Find("JoinInputField").GetComponent<InputField>();

        Host.onClick.AddListener(hostOnClick);
        Join.onClick.AddListener(joinOnClick);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void hostOnClick() {
        if(playerName.text != string.Empty)
        {
            networkManager.StartHost();   
        }
    }

    void joinOnClick() {
        if (playerName.text != string.Empty && hostIP.text != string.Empty)
        {
            
            string[] ipAndPort = hostIP.text.Split(':');
            
            if( ipAndPort.Length == 2)
            {
                networkManager.networkAddress = ipAndPort[0];
                networkManager.networkPort = int.Parse(ipAndPort[1]);
                networkManager.StartClient();
            } 
        }
    }

    
    
}
