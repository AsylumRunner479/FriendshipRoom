using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class ConnectionMenu : MonoBehaviour
{
    [SerializeField]
    private InputField ipInput;
    public NetworkManager network;
    public void OnClickHost()
    {
        network.StartHost();
    }
    public void OnClickConnect()
    {
       
        network.networkAddress = string.IsNullOrEmpty(ipInput.text) ? "localhost" : ipInput.text;
        
        network.StartClient();
        //Destroy(network);
        //network = FindObjectOfType<NetworkManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
